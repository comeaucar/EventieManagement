using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventieManagement
{
    static class Program
    {

       
        //Name: Carter Comeau
        //Student ID: 101253879
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EventCoordinator eventCoord = FileUtilities.loadFromFilesCoordinator();
            Application.Run(new WelcomeScreen());
        }
    }
}
