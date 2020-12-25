using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.DirectoryServices.ActiveDirectory;

namespace MQTChroma
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.Run(new MQTChroma());
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            AppDomain domain = (AppDomain)sender;
            if (args.Name.Contains("Guna.UI2"))
            {
                return domain.Load(Properties.Resources.Guna_UI2);
            }
            if (args.Name.Contains("Corale.Colore"))
            {
                return domain.Load(Properties.Resources.Corale_Colore);
            }
            if (args.Name.Contains("Corale.Colore.WinForms"))
            {
                return domain.Load(Properties.Resources.Corale_Colore_WinForms);
            }
            if (args.Name.Contains("M2Mqtt.Net"))
            {
                return domain.Load(Properties.Resources.M2Mqtt_Net);
            }
            if (args.Name.Contains("Newtonsoft.Json"))
            {
                return domain.Load(Properties.Resources.Newtonsoft_Json);
            }
            return null;
        }

    }
}
