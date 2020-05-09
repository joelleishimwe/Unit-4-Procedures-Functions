/*
 * Created by: Joelle Ishimwe
 * Created on: 9-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Caluculate the Hypotenuse
 * This program that accepts 2 inputs and calculates the 
 * hypotenuse of a right-angle triangle. I will need to create 
 * a function with 2 parameters as doubles and returns a double.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateHypotenuse
{
    public partial class frmCalculateHypotenuse : Form
    {
        public frmCalculateHypotenuse()
        {
            InitializeComponent();
        }

        private void CalculateHypotenuse(double aValue, double bValue)
        {
            //declare variables
            double hypotenuse;

            //calculate the hyposenuse
            hypotenuse = Math.Sqrt((Math.Pow(aValue, 2)) * (Math.Pow(bValue,2)));
            hypotenuse = Math.Round(hypotenuse, 1);

            //display the answer in a message box
            MessageBox.Show("the hypotenuse is  " + hypotenuse + "  cm", "HYPOTENUSE OF A TRIANGLE");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //decalre variables
            double usersAValue, usersBValue;

            //assign the appropriate textboxes to their values
            usersAValue = double.Parse(txtA.Text);
            usersBValue = double.Parse(txtB.Text);

            //call the CalculateHypotenuse function
            CalculateHypotenuse(usersAValue, usersBValue);
        }
    }
}
