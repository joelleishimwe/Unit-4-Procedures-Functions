/*
 * Created by: Joelle Ishimwe
 * Created on: 3-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Volume of a Cylinder
 * This program that accepts 2 inputs and calculates the 
 * volume of a cylinder. I will need to create a function 
 * with 2 parameters as doubles and returns a double.
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

namespace VolumeOfACylinder
{
    public partial class frmVolumeOfACylinder : Form
    {
        public frmVolumeOfACylinder()
        {
            InitializeComponent();
        }

        private void CalculateCylinder(double radius, double height)
        {
            //declare local variables 
            double volume;

            //declare local constants
            const double PI = 3.14;

            //calculate the volume of a cylinder using the formula
            volume = PI * (Math.Pow(radius, 2)) * height;

            //display the volume in a message box
            MessageBox.Show("the volume is  " + Math.Round(volume, 2) + "cm", "VOLUME OF A CYLINDER");
        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables 
            double usersRadius, usersHeight;

            //assigne the variables to the correct textbox
            usersRadius = Double.Parse(this.txtRadius.Text);
            usersHeight = Double.Parse(this.txtHeight.Text);

            //the function that calculates the volume of the cylinder
            this.CalculateCylinder(usersRadius, usersHeight);
        }
    }
}
