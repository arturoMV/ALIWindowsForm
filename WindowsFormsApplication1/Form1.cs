﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int numClicks = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text += ""+numClicks; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numClicks++;
            label1.Text = "Numero de clicks: " + numClicks;
        }
    }
}
