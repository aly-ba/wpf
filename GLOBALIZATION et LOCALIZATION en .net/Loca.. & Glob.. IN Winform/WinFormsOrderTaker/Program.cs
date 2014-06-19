using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace OrderTaker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var culture = new CultureInfo("cs-CZ");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            // Use the same culture for any newly created threads
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
