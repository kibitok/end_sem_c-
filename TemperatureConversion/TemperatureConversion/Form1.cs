﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int degrees = Convert.ToInt32(textBox1.Text);
            int celcius = (degrees - 32)*5;
            double fCelcius = (celcius) / 9;
            label4.Text = fCelcius.ToString();
        
        }

    }
}
