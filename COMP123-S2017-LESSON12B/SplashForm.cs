using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Bishnu Khanal
 * Student Id: 300924228
 * Date: August 08, 2017
 * Description: This is SplashForm class
 * Version: 0.3 - Created SplashFormTimer_Tick() event handler
 */
namespace COMP123_S2017_LESSON12B
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the "Tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // To remove SplashForm in three seconds replaced by CalculatorForm created new object
            CalculatorForm calculatorForm = new CalculatorForm();

            calculatorForm.Show(); //method that shows CalculatorForm
            this.Hide(); //method hides SplashForm when timer triggers in three seconds.
            SplashFormTimer.Enabled = false;//it triggers only once in three seconds (turns timer off as soon as timer triggers)
        }
    }
}
