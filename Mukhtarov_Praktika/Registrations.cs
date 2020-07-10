using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mukhtarov_Praktika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            // проверка на то что все поля заполнены 
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните поля !"); return;
            }
            // записываем в файл фио и номер группы
            StreamWriter sw = new StreamWriter("..\\..\\result.txt",true);
            sw.Write("---------------------------\n"+textBox1.Text+ "  ");
            sw.Write(textBox2.Text + "\n");
            sw.Close();
            //Открываем форму с тестом 
            Test test = new Test();
            test.ShowDialog();
            //Закрываем текущую форму 
            this.Close();
        }
        // Запрет на воод цифр в поле ФИО
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
