using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(fahrenheitTextBox.Text);
                double celsius = (fahrenheit - 32.0) * (5.0 / 9.0);
                celsiusTextBox.Text = celsius.ToString("n3");
            }
            catch
            {
                MessageBox.Show("Invalid input for Fahrenheit value");
            }
        }

        private  void fahrenheitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void celsiusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
