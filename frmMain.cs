//*******************************************
//*******************************************
//Programmer: James Flippin
//Course: INEW 2332.xxxx (Final Project)
//Program purpose: To demonstrate using the FormClosing Event
//Form Purpose: To demonstrate the FormClosing Even
//              in conjunction with exiting the program
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
    public partial class frmMain : Form
    {
        bool bolNotOkToExit = true; //A variable to track if we are closing from the menu or the 'X' (Form close button)
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bolNotOkToExit) //Check to see if it's OK to exit based on the value in this flag variable
            {
                //Based on the value in bolNotOkToExit, we Cancel the FormClosing Event 
                e.Cancel = true;    //Cancel the FormClosing event
                //Now we give the user some feedback on what they should do instead of clicking the 'X' (Form Close button)
                MessageBox.Show("Sorry, you must choose 'File' and 'Exit' from the menu to exit this program"
                           , "Please don't click the 'X' to close this screen"
                           , MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //Handle Exiting the program correctly from the menu choice
            bolNotOkToExit = false; //Indicate to the FormClosing event that it is OK to exit the application
            Application.Exit(); //Properly exit the program
        }

        private void mnuOrders_Click(object sender, EventArgs e)
        {
            frmOrders frmCustomerOrders = new frmOrders(); //Create an instance named frmCustomersOrders based on the frmOrder object 
            frmCustomerOrders.ShowDialog(); //Display the frmCustomerOrders form object
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not implemented yet.",
                            "Help", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not implemented yet.",
                "Help",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
