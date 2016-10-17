using System;
using System.Globalization;
using System.Windows.Forms;

namespace DateTimeFormatSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Table of Language Culture Names, Codes, and ISO Values (PIA)
            // https://msdn.microsoft.com/en-us/library/ee796272(v=cs.20).aspx
            this.textBox1.Text = DateTime.Now.ToString("MMM d, yyyy", CultureInfo.GetCultureInfo("en-US"));
        }
    }
}