using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * Student Id: 300924228
 * Description: Calculator Demo Project
 * Version: 0.3 - Created an instance of the CalculatorForm
 */
namespace COMP123_S2017_LESSON12B
{
   public static class Program
    {
        public static CalculatorForm calculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            calculatorForm = new CalculatorForm(); //instantiate a new object of calculator form
            Application.Run(new SplashForm());
        }
    }
}
