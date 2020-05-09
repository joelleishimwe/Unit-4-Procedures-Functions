/*
 * Created by: Joelle Ishimwe
 * Created on: 9-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Percentage Program
 * This program that has a function that takes the 
 * user's grade level and returns the equivalent 
 * percentage mark. It accept a string type (ex. 4+ or 3-)  
 * as a level and return an integer as the percentage
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

namespace PercentageProgram
{
    public partial class frmPercentageProgram : Form
    {
        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        //Function: ConvertToPercentage
        //Input: String MarkLevel
        //Output: void
        //Description: a fuction that converts the mark level into a percentage mark
        private int ConvertToPercentage(String MarkLevel)
        {
            //variables
            int percentage;

            switch (MarkLevel)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 66;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }
            
            //display the percentage in a label
            lblPercentage.Text = "Your percentage is  " + Convert.ToString(percentage) + " %";

            return percentage;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            //variables
            string usersPercentage;

            //assigne the textbox to the variable
            usersPercentage = Convert.ToString(txtLevel.Text);

            //call the Percentage function
            ConvertToPercentage(usersPercentage);

        }
    }
}
