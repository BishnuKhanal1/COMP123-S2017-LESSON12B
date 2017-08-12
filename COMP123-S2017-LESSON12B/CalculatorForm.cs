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
 * Description: Calculator Demo Project
 * Version: 0. - Created CalculatorBtton_Clicked event
 */
namespace COMP123_S2017_LESSON12B
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //terminates my form
        }
        /// <summary>
        /// This is shared event handler for the calculator Button
        /// Not including the operator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button; //downcasting

            if ((this.IsDecimalClicked) && (calculatorButton.Text == "."))
            {
                return;
            }

            if (calculatorButton.Text == ".")
            {
                this.IsDecimalClicked = true;
            }

            if (ResultTextBox.Text == "0")
            {
                if (calculatorButton.Text == ".")
                {
                    ResultTextBox.Text += calculatorButton.Text;
                }
                else
                {
                    ResultTextBox.Text = calculatorButton.Text;
                }
            }
            else
            {
                if ((OperandList.Count > 0) && (this._isOperandTwo == false))
                {
                    ResultTextBox.Text = calculatorButton.Text;
                    this._isOperandTwo = true;
                }
                else
                {
                    ResultTextBox.Text += calculatorButton.Text;
                }
            }

            //Debug.WriteLine.Text("A calculator button was clicked")
        }
    }
}
