using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvServiceForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void C2FBtn_Click(object sender, EventArgs e)   // button function for converting Celcius to Fahrenheit
        {
            TempCovService.Service1Client tempService = new TempCovService.Service1Client(); // Initializing a TempCovService Client Object
            int C = Int32.Parse(textBox1.Text);     // converting the Celcius value in "textBox1" text to integer format
            int F = tempService.C2f(C);             // converting the Celcius value to Fahrenheit
            label3.Text = F.ToString();             // displaying the converted value to "label3" label
        }

        private void F2CBtn_Click(object sender, EventArgs e)   // button function for converting Fahrenheit to Celcius
        {
            TempCovService.Service1Client tempService = new TempCovService.Service1Client();    // Initializing a TempCovService Client Object
            int C = Int32.Parse(textBox2.Text);     // converting the Fahrenheit value in "textBox2" text to integer format
            int F = tempService.F2c(C);             // converting the Fahrenheit to Celcius
            label4.Text = F.ToString();             // displaying the converted value to "label4" label
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
