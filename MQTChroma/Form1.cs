using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Corale.Colore.Core;
using Corale.Colore.WinForms;
using Corale.Colore.Razer.ChromaLink;
using Corale.Colore.Razer.Keyboard;
using Corale.Colore.Razer.Keypad;
using Corale.Colore.Razer.Mouse;
using Corale.Colore.Razer.Mousepad;
using ColoreColor = Corale.Colore.Core.Color;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json;

namespace MQTChroma
{
    public partial class MQTChroma : Form
    {
        static MqttClient client;
        string MQTChroma_Topic = "MQTChroma/"+ Environment.MachineName;
        bool connected = false;
        public MQTChroma()
        {
            Chroma.Instance.Initialize();
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            MQTT_Status.ForeColor = System.Drawing.Color.Red;
            MQTT_Status.Text = "Disconnected";
            MQTT_Topic.Text = "Topic: "+ MQTChroma_Topic;

            // get MQTT server
            MQTT_Server.Text   = Properties.Settings.Default.MQTT_Broker;
            MQTT_Port.Text     = Properties.Settings.Default.MQTT_Port ;
            MQTT_Username.Text = Properties.Settings.Default.MQTT_UserName;
            MQTT_Password.Text = Properties.Settings.Default.MQTT_Password;
        }

        // Move Form

        private bool mouseDown;
        private Point lastLocation;

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            editMQTTToolStripMenuItem.PerformClick();
        }
        
        private void BTN_Hide_Click(object sender, EventArgs e)
        {
            Hide();
            this.ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                client.Publish(MQTChroma_Topic + "/status", Encoding.UTF8.GetBytes("OFF"));
            }
            notifyIcon.Visible = false;
            Environment.Exit(0);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MQTChroma_Broker = MQTT_Server.Text;
            int MQTChroma_port = int.Parse(MQTT_Port.Text);
            string MQTChroma_Username = MQTT_Username.Text;
            string MQTChroma_Password = MQTT_Password.Text;
            Topic_LAB.Text = "Topic: " + MQTChroma_Topic;
            connected = true;
            try
            {
                client = new MqttClient(MQTChroma_Broker, MQTChroma_port, false, MqttSslProtocols.None, null, null);
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte code = client.Connect(Guid.NewGuid().ToString(), MQTChroma_Username, MQTChroma_Password);
                if (code == 0)
                {
                    MQTT_Status.ForeColor = System.Drawing.Color.Green;
                    MQTT_Status.Text = "Connected";
                    //Subcribe Topic
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    client.Subscribe(new string[] { MQTChroma_Topic + "/Chroma", MQTChroma_Topic + "/switch", MQTChroma_Topic + "/status" }, new byte[] { 0, 0, 0 });
                    client.Publish(MQTChroma_Topic + "/status", Encoding.UTF8.GetBytes("ON"));
                    client.Publish(MQTChroma_Topic + "/Chroma", Encoding.UTF8.GetBytes("255,255,255"));
                }

                else MessageBox.Show(this, "Connect Fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            catch (Exception)
            {
                MessageBox.Show(this, "Wrong Format", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void editMQTTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void BTN_MQTT_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MQTT_Broker   = MQTT_Server.Text;
            Properties.Settings.Default.MQTT_Port     = MQTT_Port.Text;
            Properties.Settings.Default.MQTT_UserName = MQTT_Username.Text;
            Properties.Settings.Default.MQTT_Password = MQTT_Password.Text;
            Properties.Settings.Default.Save();
        }

        // Razer SDK

        public void RazerSet_All(int R, int G, int B)
        {
            var color = new ColoreColor((byte)R, (byte)G, (byte)B);
            Chroma.Instance.SetAll(color);
            Chroma.Instance.ChromaLink.SetAll(color);
        }

        //#########

        // MQTT Client

        void Receive(string message, string topic)
        {

            if (topic == MQTChroma_Topic+ "/Chroma")
            {
                //MessageBox.Show(message);
                string[] words = message.Split(',');
                int R = int.Parse((words[0]));
                int G = int.Parse((words[1]));
                int B = int.Parse((words[2]));
                ColorR.Value = int.Parse((words[0]));
                ColorG.Value = int.Parse((words[1]));
                ColorB.Value = int.Parse((words[2]));
                RazerSet_All(R, G, B);
                return;
            }
            if (topic == MQTChroma_Topic + "/switch")
            {
                client.Publish(MQTChroma_Topic + "/status", Encoding.UTF8.GetBytes(message));
                return;
            }
            if (topic == MQTChroma_Topic + "/status")
            {
                if (message == "OFF")
                {
                    RazerSet_All(0, 0, 0);
                }
                else {
                    RazerSet_All(Convert.ToInt32(ColorR.Value), Convert.ToInt32(ColorG.Value), Convert.ToInt32(ColorB.Value));
                }

                return;
            }
        }

        Action<string, string> ReceiveAction;
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                this.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }
        //############
    }
}
