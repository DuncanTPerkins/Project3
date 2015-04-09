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
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor for GUI form class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event for Button that converts from Decimal (Base 10) to other bases
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnToBase_Click(object sender, EventArgs e)
        {
            TxtBase.Text = BaseConverter.FromDecimal((int)NumBase.Value, int.Parse(TxtDecimal.Text), (int)NumPlaces.Value);
            LblBase.Text = "Integer Value in Base " + NumBase.Value;
            lblDirection.Text = "--->";
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#101B83");
            TxtBase.ForeColor = col;
            TxtDecimal.ForeColor = SystemColors.WindowText;
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
            TxtDecimal.Text = BaseConverter.toDecimal((int)NumBase.Value, TxtBase.Text).ToString();
            LblBase.Text = "Integer Value in Base " + NumBase.Value;
            lblDirection.Text = "<---";
        }
    }
}
