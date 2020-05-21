/*
 * Created by: Joelle Ishimwe
 * Created on: 20-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Rounding Program
 * This program will accept a number with decimals 
 * and also tell the program how many decimal places 
 * the user want to round off to. The program then 
 * passes By Reference the variable to be rounded off 
 * and By Value the number of decimal points to remain 
 * to a procedure called "RoundDecimal". Finally a 
 * message box will display the rounded result.
*/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundingDecimals
{
    public partial class frmRoundingDecimals : Form
    {
        public frmRoundingDecimals()
        {
            InitializeComponent();
        }

        //Function: Round Decimal 
        //Input: ref TextBox txtRoundedBy, int numberRoundedTo
        //Output: void
        //Description: a fuction that rounds the decimal to number entered by the user
        private void RoundDecimal(ref double userNumber, int userNumDecimal)
        {
            //multiply number by 10 to power of how many decimal points you want
            userNumber = userNumber * Math.Pow(10, userNumDecimal);

            //add 0.5
            userNumber = userNumber + 0.5;

            //get rid of numbers following the decimal(i.e.Math.Truncate)
            userNumber = Math.Truncate(userNumber);

            //move decimal point back to its original place
            userNumber = userNumber / Math.Pow(10, userNumDecimal);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //declare variables
            double theNumber;
            int numDecimals;

            //convert the values
            theNumber = double.Parse(txtDecimal.Text);
            numDecimals = (int)nudNumRound.Value;

            //call the function
            RoundDecimal(ref theNumber, numDecimals);

            //display the answer in a message box
            MessageBox.Show("The rounded decimal is:  " + theNumber, "FINAL DECIMAL");
        }
    }
}
