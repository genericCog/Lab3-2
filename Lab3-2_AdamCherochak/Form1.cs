/*
 *  201507201601
 *  Adam Cherochak
 *  Assignment 3.2
 *  A program (C# Windows Forms Application) that will 
 *      1. accept an integer as input and 
 *      2. determine if it is a prime number (i.e., divisible only by itself and 1).  
 *      3. Use the modulo operator (%) which determines the remainder of division of two integers.
 *  Reference Material: http://stackoverflow.com/questions/15743192/check-if-number-is-prime-number 
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

namespace Lab3_2_AdamCherochak
{
    public partial class Form1 : Form
    {
        //global variables
        bool primeResult = true; // assign flag to true

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            int primeNumber = Convert.ToInt32(txtBox_UserInput.Text); //assign user input
            TestIfPrime(primeNumber, primeResult); // test user input
        }//END Calculate button

        private void TestIfPrime(int primeNumber, bool primeResult){
            if (primeNumber == 0 || primeNumber == 1) // if 0 or 1, number is not prime
            {
                primeResult = false;
                DisplayConfiguration(primeNumber, primeResult);
            }
            else
            {
                for (int i = 2; i <= (primeNumber / 2); i++) // how to use Math.Sqrt(primeNumber) here??
                {
                    if (primeNumber % i == 0)
                    {
                        primeResult = false;
                        DisplayConfiguration(primeNumber, primeResult);
                        return;
                    }
                }
                primeResult = true; // the number is prime
                DisplayConfiguration(primeNumber, primeResult);
            }            
        }//END TestIfPrime method

        private void DisplayConfiguration(int primeNumber, bool primeResult)
        {
            if (primeResult == true)
            {
                lbl_DisplayResult.Visible = true;
                lbl_DisplayResult.Text = "The number, " + primeNumber + ", IS Prime.";
                picBox_PrimeOrNot.BackColor = Color.Green;
                picBox_PrimeOrNot.Visible = true;
            }
            else
            {
                lbl_DisplayResult.Visible = true;
                lbl_DisplayResult.Text = "The number, " + primeNumber + ", is NOT Prime.";
                picBox_PrimeOrNot.BackColor = Color.Red;
                picBox_PrimeOrNot.Visible = true;
            }
        }//END DisplayConfigurations

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox_UserInput.Clear(); //reset contents of textbox 1
            picBox_PrimeOrNot.Visible = false;
            txtBox_UserInput.Text = "Enter a number";
            lbl_DisplayResult.Text = "Waiting for input...";
            txtBox_UserInput.Focus(); //rest focus to textbox 1
        }//END Clear button

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); //exit the program
        }//END Exit button
    }//END Class
}//END Namespace

