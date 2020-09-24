using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olkhovikiv_
{
    public partial class Foot_to_Kg : Form
    {
        public Foot_to_Kg()
        {
            InitializeComponent();
        }

        private void RESULTbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните 1 поле!");
                return;
            }
            double kf = 0.45359237;
            //записываем данные
            double inputD = Convert.ToDouble(textBox1.Text);
            // делаем вычесления
            double result = inputD * kf;
            // выводим резаультат
            textBox2.Text = Convert.ToString(result);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // можно вводить только числа
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            // превращаем точку в запятую, для предотвращения ошибок
            if (e.KeyChar == '.') e.KeyChar = ',';
            {
                // заяпятая не может стоятб на 1 месте и длинна не может быть <0
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
        }
    }
}
