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

namespace MQTChroma
{
    public partial class MQTChroma : Form
    {
        public MQTChroma()
        {
            Chroma.Instance.Initialize();
            InitializeComponent();
            Task t2 = Task.Run(() => { Task.Delay(800).Wait(); RazerSet(0, 0, 0); });
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
    }
}
