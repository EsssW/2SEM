using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_funt_kg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
            double funt = Convert.ToDouble(textBox1.Text);
            textBox2.Text = funt * 0.4535923745 + " kg";

        }

        
    }
}
