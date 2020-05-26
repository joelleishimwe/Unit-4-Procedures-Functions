/*
 * Created by: Joelle Ishimwe
 * Created on: 26-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program that checks if 2 strings are the same 
 * (if you ignore capitals and smalls), and returns a 
 * boolean "bool" value. It accepts 2 strings (the 
 * parameters of the function), declares the local variables 
 * and it compares the length of each string. If they are 
 * the same length then, it converts each string to uppercase 
 * (or lower case) and assigns them to the local variables 
 * declared above and return the boolean variable.
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

namespace StringEquality
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        private bool IsEqual (string stringA, string stringB)
        {
            //declare variables
            bool stringsAreEqual = false;

            //compare the length of each string
            if (stringA.Length == stringB.Length)
            {
                //convert both strings into upper case letters
                string stringAUpperCase = stringA.ToUpper();
                string stringBUpperCase = stringB.ToUpper();

                //if both string are equal
                if (stringAUpperCase == stringBUpperCase)
                {
                    //set the bool to true
                    stringsAreEqual = true;
                    
                    //display their equality in a message box
                    MessageBox.Show("They are the same", "STRING EQUALITY");
                }

                //if strings do not equal
                else
                {
                    //display their equality in a message box
                    MessageBox.Show("They are NOT the same", "STRING EQUALITY");
                }
            }

            //if they are not the same size they do not equal
            else
            {
                //display their equality in a message box
                MessageBox.Show("They are NOT the same", "STRING EQUALITY");
            }

            //return the boolean
            return stringsAreEqual;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            //declare variables
            string userString1, userString2;
            bool stringsAreEqual;

            //assign the txtboxes to their variables
            userString1 = txtString1.Text;
            userString2 = txtString2.Text;

            //call the function
            stringsAreEqual = IsEqual(userString1, userString2);
        }
    }
}
