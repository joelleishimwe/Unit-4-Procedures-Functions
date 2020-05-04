/*
 * Created by: Joelle Ishimwe
 * Created on: 26-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Procedures & Pass by Value
 * This program that when I enter a temperature in degrees Celsius,
 * it passes the Celsius value to a procedure that will convert it 
 * to degrees Fahrenheit and display the answer in a message box 
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

namespace ProceduresAndPassByValueJoelle
{
    public partial class frmProceduresAndPassByValue : Form
    {
        public frmProceduresAndPassByValue()
        {
            InitializeComponent();
        }

        public void CalculateFahrenheit (double tempCelcius)
        {
            //local variables
            double Fahrenheit;

            //convert the temperature to Fahrenheit using the formula
            Fahrenheit = (((double)(9) / (double)(5)) * tempCelcius) + 32;

            //display the converted temperature in a message box
            MessageBox.Show("It's " + Fahrenheit + " °F");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //local variables
            double tempCelsius;

            //assigne the variable to the value entered by the user in the textbox
            tempCelsius = double.Parse(txtCelcius.Text);

            //call the function to calculate the temperature in Fahrenheit 
            this.CalculateFahrenheit(tempCelsius);
        }
    }
}
