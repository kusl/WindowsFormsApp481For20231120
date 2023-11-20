using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp481For20231120
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
            textBox1.Text = Properties.Settings.Default.HandoffMessage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender != null && !string.IsNullOrEmpty(textBox1.Text))
            {
                Properties.Settings.Default.HandoffMessage = textBox1.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
