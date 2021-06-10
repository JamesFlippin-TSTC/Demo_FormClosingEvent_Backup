//*******************************************
//*******************************************
//Programmer: James Flippin
//Course: INEW 2332.xxxx (Final Project)
//Program purpose: To demonstrate using the FormClosing Event
//Form Purpose: To demonstrate the FormClosing Even
//              in conjunction with Closing this form and returning to the main form
//*******************************************
//*******************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_FormClosingEvent
{
    public partial class frmOrders : Form
    {
        bool bolNotOkToExit = true; //A variable to track if we are closing from the menu or the 'X' (Form close button)
        public frmOrders()
        {
            InitializeComponent();
        }

        private void mnuReturn_Click(object sender, EventArgs e)
        {
            //Handle Exiting the program correctly from the menu choice
            bolNotOkToExit = false; //Indicate to the FormClosing event that it is OK to exit the application
            this.Close(); //Close this form
        }

        private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bolNotOkToExit) //Check to see if it's OK to exit based on the value in this flag variable
            {
                //Based on the value in bolNotOkToExit, we Cancel the FormClosing Event 
                e.Cancel = true;    //Cancel the FormClosing event
                //Now we give the user some feedback on what they should do instead of clicking the 'X' (Form Close button)
                MessageBox.Show("Sorry, you must choose 'Return' from the menu to close this Screen and Return to the previous one."
                           , "Please don't click the 'X' to close this screen"
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
