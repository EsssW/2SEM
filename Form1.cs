using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бегущая_строка_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        // строка для вывода в textBox
        string text = " Продам гараж ДОРОГОГ!!!! +791717171 ";
        // Действия привязанные к таймеру (запуск таймера)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //извлечение подсторки + слово
            text = text.Substring(1) + text[0];
            // вывод строки в textBox
            textBox1.Text = text;
        }
        // если мышь неведена на textBox, останавливаем таймер
        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        // если мышь неведена на textBox, запускаем таймер
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
