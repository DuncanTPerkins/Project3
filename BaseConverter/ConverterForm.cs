//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 3
//	File Name:		Form1.cs
//	Description:    Converts between base numerical systems
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Duncan Perkins, perkinsdt@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    April 7, 2015
//	Copyright:		Duncan Perkins, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseConverter;
namespace BaseConverter
{
    /// <summary>
    /// Form class for GUI of application
    /// </summary>
    public partial class ConverterForm : Form
    {
        //Keypress events for the Base text box
        System.Windows.Forms.KeyEventHandler keyeventDec;
        System.Windows.Forms.KeyEventHandler keyeventBase;
        KeyEventHandler keyeventCurrent;

        //bool for checking against key events
        private bool InvalidKey = false;

        /// <summary>
        /// Constructor for GUI form class
        /// </summary>
        public ConverterForm()
        {
            InitializeComponent();
            keyeventDec = TxtDecimal_KeyDown;
            keyeventBase = TxtBase_KeyDown;
            keyeventCurrent = keyeventDec;
            this.TxtBase.KeyDown += this.keyeventDec;
        }

        /// <summary>
        /// Click event for Button that converts from Decimal (Base 10) to other bases
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnToBase_Click(object sender, EventArgs e)
        {
            try
            {
                TxtBase.Text = BaseConverter.FromDecimal((int)NumBase.Value, int.Parse(TxtDecimal.Text), (int)NumPlaces.Value);
                LblBase.Text = "Integer Value in Base " + NumBase.Value;
                lblDirection.Text = "--->";
            }

            catch
            {
                MessageBox.Show("That Number is too big. The biggest possible number to convert is 2,147,483,647.");
                TxtDecimal.Clear();
            }
        }

        /// <summary>
        /// Close Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Click event for Button that converts from bases between 2 and 16 to Decimal (Base 10) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnToDecimal_Click(object sender, EventArgs e)
        {
            TxtDecimal.Text = BaseConverter.toDecimal((int)NumBase.Value, TxtBase.Text.ToUpper()).ToString();
            LblBase.Text = "Integer Value in Base " + NumBase.Value;
            lblDirection.Text = "<---";
        }

        /// <summary>
        /// Keypress event for Decimal Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (InvalidKey == true)
            {
                e.Handled = true;
                InvalidKey = false;
            }

        }

        /// <summary>
        /// Keydown event for the Decimal Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtDecimal_KeyDown(object sender, KeyEventArgs e)
        {
            //if the key pressed was between 0 and 9, do nothing
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
            }

            //otherwise, don't accept the keypress
            else
            {
                InvalidKey = true;
            }
        }

        /// <summary>
        /// Keydown event for the Decimal Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TxtBase_KeyDown(object sender, KeyEventArgs e)
        {
            //if the key pressed was between 0 and 9, do nothing
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) || (e.KeyCode >= Keys.A && e.KeyCode <= Keys.F))
            {
            }

            //otherwise, don't accept the keypress
            else
            {
                InvalidKey = true;
            }
        }

        /// <summary>
        /// Event for value changing on NumericalUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumBase_ValueChanged(object sender, EventArgs e)
        {
            //set key event listener to Decimal values only
            if ((int)NumBase.Value <= 10)
            {
                TxtBase.KeyDown -= keyeventCurrent;
                TxtBase.KeyDown += keyeventDec;
                keyeventCurrent = keyeventDec;
            }

            //allow for A-F for bases above Decimal
            else
            {
                TxtBase.KeyDown -= keyeventCurrent;
                TxtBase.KeyDown += keyeventBase;
                keyeventCurrent = keyeventBase;

            }
        }

    }
}
