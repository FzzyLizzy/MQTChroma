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
        public MQTChroma()
        {
            Chroma.Instance.Initialize();
            InitializeComponent();
        }
        public void RazerSet(int R, int G, int B) {
            var color = new ColoreColor((byte)R, (byte)G, (byte)B);
            Chroma.Instance.SetAll(color);
            Chroma.Instance.ChromaLink.SetAll(color);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RazerSet(Convert.ToInt32(ColorR.Value), Convert.ToInt32(ColorG.Value), Convert.ToInt32(ColorB.Value));
            
        }

        private void MQTT_Connect(object sender, EventArgs e)
        {
            string MQTChroma_Broker = MQTT_Server.Text;
            int MQTChroma_port      = int.Parse(MQTT_Port.Text);
            string MQTChroma_Username = MQTT_Username.Text;
            string MQTChroma_Password = MQTT_Password.Text;
            Topic_LAB.Text = "Topic: " + MQTChroma_Topic;
            try
            {
                client = new MqttClient(MQTChroma_Broker, MQTChroma_port, false, MqttSslProtocols.None, null, null);
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte code = client.Connect(Guid.NewGuid().ToString(),MQTChroma_Username, MQTChroma_Password);
                if (code == 0)
                {
                    MessageBox.Show(this, "Connect Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    //Subcribe Topic
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    client.Subscribe(new string[] { MQTChroma_Topic+ "/Chroma", MQTChroma_Topic+ "/switch", MQTChroma_Topic+ "/status" }, new byte[] { 0, 0, 0 });
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
                RazerSet(R, G, B);
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
                    RazerSet(0, 0, 0);
                }
                else {
                    RazerSet(Convert.ToInt32(ColorR.Value), Convert.ToInt32(ColorG.Value), Convert.ToInt32(ColorB.Value));
                }

                return;
            }


        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void BTN_exit_Click(object sender, EventArgs e)
        {
            client.Publish(MQTChroma_Topic + "/status", Encoding.UTF8.GetBytes("OFF"));
            Environment.Exit(0);
        }

        private void BTN_Hide_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
