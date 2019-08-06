//14.8 (Guess the Number Game) Write a program that plays “guess the number” as follows: 
//Your program chooses the number to be guessed by selecting an int at random in the range 1–1000. The program then displays 
//the following text in a label: I have a number between 1 and 1000--can you guess my number? Please enter your first guess. 
//A TextBox should be used to input the guess. As each guess is input, the background color should change to red or blue. 
//Red indicates that the user is getting “warmer,” blue that the user is getting “colder.” A Label should display either 
//“Too High” or “Too Low,” to help the user zero in on the correct answer. 
//When the user guesses the correct answer, display “Correct!” in a message box, change the Form’s background color to green 
//and disable the TextBox. Recall that a TextBox (like other controls) can be disabled by setting the control’s Enabled 
//property to false. Provide a Button that allows the user to play the game again. When the Button is clicked, 
//generate a new random number, change the background to the default color and enable the TextBox.
//********************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessWord
{
    public partial class frmGuessNumber : Form
    {

        public frmGuessNumber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
    }
}
