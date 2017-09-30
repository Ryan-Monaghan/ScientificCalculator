using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class scientificCalculatorForm : Form
    {
        public scientificCalculatorForm()
        {
            InitializeComponent();
        }
        //Declaring variable operator to be used in switch statements.
        string theOperator;
        //Declaring variables to store values of user input.
        double total1 = 0;
        double total2 = 0;
        double sqrt = 0;
        double power = 0;
        bool equal = false;
        private void btnOne_Click(object sender, EventArgs e)
        {
            //If equal bool is true, clear the txtDisplay for users next input.
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "1" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "2" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "3" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "4" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "5" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "6" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "7" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "8" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "9" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
            
            //Sends the input from the "0" key onto the display.
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears the display once the "Clear button is clicked.
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Stores the user input and prepares it to be added.
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "+";
        }

        
          private void btnPoint_Click(object sender, EventArgs e)
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }
              
              //Stops the user from inputting multiple decimal points.
              if (txtDisplay.Text.Contains("."))
            {
                return;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //Stores the user input and prepares it to be Subtracted.
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Stores the user input and prepares it to be Multiplied.
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Stores the user input and prepares it to be Divided.
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "/";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //Stores the user input and prepares it to be Modded.
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            theOperator = "Mod";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            //Displays the sqrt of the users onput
            sqrt = sqrt + double.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(Math.Sqrt(sqrt));
           
            theOperator = "√";
        }


        private void btnPower_Click(object sender, EventArgs e)
        {
            //Displays the users input to the power of itself (eg. User input = 2, the calc will raise 2^2 and display the answer as 4
            power = power + double.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(power), Convert.ToDouble(txtDisplay.Text))); 
            
            theOperator = "x^x";
        }       
        
        
        private void btnEquals_Click(object sender, EventArgs e)
        {
            equal = true;
            
            
            //When the "Equals" button is clicked, the switch statement locates the chosen operator, and applies the respective function.
            switch (theOperator)
            {
                //Identifies the user input as "+" and adds the user input(s) together, then displays the result via the text box.
                case "+":
                    total1 = total1 + double.Parse(txtDisplay.Text);
                //The break command then stops the switch operator.
                    break;
                
                //Identifies the user input as "-" and subtracts the user input(s) together, then displays the result via the text box.
                case "-":
                    total1 = total1 - double.Parse(txtDisplay.Text);
                    break;
                //Identifies the user input as "*" and multiplies the user input(s) together, then displays the result via the text box.
                case "*":
                    total1 = total1 * double.Parse(txtDisplay.Text);
                    break;
                //Identifies the user input as "/" and divides the user input(s) together, then displays the result via the text box.
                case "/":
                    //total1 = total1 / double.Parse(txtDisplay.Text);
                    if (total2 != 0)
                    {
                        total1 = total1 / double.Parse(txtDisplay.Text);
                    }
                    else
                    {
                        MessageBox.Show("Tried to Divide by Zero");
                    }

                    break;

                case "Mod":
                    total1 = total1 % double.Parse(txtDisplay.Text);
                    break;

                case "x^x":
                    txtDisplay.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(power), Convert.ToDouble(txtDisplay.Text)));
                    break;
            }
            total2 = total1;
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        { //Displays confirmation message, and displays buttons
            if (MessageBox.Show("Are you sure you would like to close the application?","Exit",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Closes application
                Application.Exit();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cuts the text insie txtDisplay
            txtDisplay.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copyies the text in txtDisplay
            txtDisplay.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Allows paste functionality
            txtDisplay.Paste();
        }

      
    }
    
}
