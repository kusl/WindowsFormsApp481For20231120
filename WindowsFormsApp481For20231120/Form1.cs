﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp481For20231120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string handoffMessage = Properties.MySettings.Default.HandoffMessage;
            textBox1.Text = handoffMessage;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
