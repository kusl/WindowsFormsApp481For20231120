using System;
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
            textBox1.Text = System.Configuration.ConfigurationManager.AppSettings["HandoffMessage"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x = (TextBox)sender;
            var y = e;
            System.Configuration.ConfigurationManager.AppSettings["HandoffMessage"] = x.ToString();
        }
    }
}
