<<<<<<< Updated upstream
﻿using Real_estate_managment_system.forms;
=======
﻿
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Real_estate_managment_system
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ulogin());
        }
    }
}
