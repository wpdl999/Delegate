using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question
{
    public static class Program
    {
        public static Notification notification;
        public static Send send;
        public static Subscription subscription;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            send = new Send();
            notification = new Notification(send);
            subscription = new Subscription(send, notification);
            Application.Run(new Notification(send));
        }
    }
}
