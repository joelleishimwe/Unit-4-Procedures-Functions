/*
 * Created by: Joelle Ishimwe
 * Created on: 21-May-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Clicked picture
 * This program displays a picture box, when the 
 * user clicks on the picture box a random number 
 * is generated and a random picture is displayed 
 * using a function that passes the picture by reference.
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

namespace PictureClicked
{
    public partial class frmPictureClicked : Form
    {
        Random randNumberGenerator = new Random();
        public frmPictureClicked()
        {
            InitializeComponent();
        }

        //Function: Calculate Hypotenuse
        //Input: double aValue, double bValue
        //Output: void
        //Description: takes a picture box passed bt reference and a card number. 
        //      It assigns the image in the picture box to a card with the given number
        private void ChangedCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }

            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.AD;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.AH;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.AC;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.AS;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.KD;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.KH;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.QC;
            }
            else
            {
                aPictureBox.Image = Properties.Resources.QD;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //declare local variable
            int aRandomNumber;

            //get a random numbers generated
            aRandomNumber = randNumberGenerator.Next(1, 13 + 1);

            //call the ChangedCard proceedure
            ChangedCard(ref this.picCard, aRandomNumber);
        }
    }
}
