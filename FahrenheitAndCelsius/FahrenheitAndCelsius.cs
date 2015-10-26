/*
Created by Matthew Ho
Created on 10-26-15
Created for ICS3U
Daily 4-01
This program calculates fahrenheit from celsius using a procedure
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

namespace FahrenheitAndCelsius
{
    public partial class frmFahrenheitAndCelsius : Form
    {
        public void Fahrenheit(int celsius)
        {
            //This procedure calculates celsius to fahrenheit
            int fahrenheit;

            fahrenheit = celsius * 9 / 5 + 32;
            MessageBox.Show("The degrees in fahrenheit is " + fahrenheit + ".", "Fahrenheit Answer");
        }
        
        public frmFahrenheitAndCelsius()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int celsius;

            celsius = Convert.ToInt32(this.txtCelsius.Text);

            Fahrenheit(celsius);

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
