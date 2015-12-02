// Kevin Lui
// Box #1705
// CSC 101
// Exam 2

// Tested Close Button
// Tested Tab Order
// Tested Clear Button
// Tested Alt short cut keys
// Tested Available Credit calculation and output
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x2_Lui
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
            Application.Run(new Form1());
        }
    }
}
