/*
 * Created by: Joelle Ishimwe
 * Created on: 26-April-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Optional Parameters
 * This program has a procedure (actually 2 procedures 
 * with the exact same name) that accepts an address and 
 * then prints it out in a message box. The procedure will 
 * have 1 optional parameter, the apartment number.
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

namespace OptionalParametersJoelle
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }

        //Procedure: PrintAdresse
        //Input: String apartmentNumber, String street, String city, String province, String postalCode
        //Output: void
        //Description: this proceedure displays a message box with the given parameters; apartmentNumber, street, 
        //city, province, postalCode 
        public void PrintAddress(String apartmentNumber, String street, String city, String province, String postalCode)
        {
            MessageBox.Show(apartmentNumber + street + city + province + postalCode);
        }

        //Procedure: PrintAdresse
        //Input: String street, String city, String province, String postalCode
        //Output: void
        //Description: this proceedure displays a message box with the given parameters; street, city, province, postalCode 
        public void PrintAddress(String street, String city, String province, String postalCode)
        {
            MessageBox.Show(street + city + province + postalCode);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //dclare local variables 
            String usersApartmentNumber, usersStreet, usersCity, usersProvince, usersPostalCode;

            //assign each text box to it's variable
            usersApartmentNumber = this.txtApartmentNumber.Text;
            usersStreet = this.txtStreet.Text;
            usersCity = this.textCity.Text;
            usersProvince = this.txtProvince.Text;
            usersPostalCode = this.txtPostalCode.Text;

            //make the user enter the street
            if (usersStreet == "")
            {
                MessageBox.Show("   Please enter your street name and number.   ", "Optional Parameters ");
            }

            //make user enter the city
            else if (usersCity == "")
            {
                MessageBox.Show("  Please enter your city.   ", "Optional Parameters");
            }

            //make the user enter the province
            else if  (usersProvince == "")
            {
                MessageBox.Show("   Please enter your province.  ", "Optional Parameters");
            }

            //make the user enter the postal code number
            else if (usersPostalCode == "")
            {
                MessageBox.Show("   Please enter your postal code.   ", "Optional Parameters");
            }

            //if the user does not enter the apartment number then print out the other adresse factors
            else if (usersApartmentNumber == "")
            {
                PrintAddress(usersStreet, usersCity, usersProvince, usersPostalCode);
            }

            //if the user enters all 5 adresse factors then print them all out
            else
            {
                PrintAddress(usersApartmentNumber + " - ", usersStreet + " ",
                    usersCity + " ", usersProvince + " ", usersPostalCode);
            }
        }
    } 
}
