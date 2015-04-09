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
    }
}
