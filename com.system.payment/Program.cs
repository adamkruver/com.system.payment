using System;
using System.Windows.Forms;
using com.system.payment.Infrastructure.Factories.App;

namespace com.system.payment
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new AppCoreFactory()
                .Create()
                .Run();
        }
    }
}