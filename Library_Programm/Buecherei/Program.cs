using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buecherei
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmScreenOfBooks());

            //Application.Run(new frmScreenCopies());
            // Application.Run(new frmScreenOfUsers());

            //Application.Run(new frmScreenReturnBookCopy());
            //Application.Run(new frmScreenBorrowing());

            Application.Run(new frmMainScreen());
            //Application.Run(new frmScreenReservations());
           // Application.Run(new frmScreenSettings());
        }
    }
}
