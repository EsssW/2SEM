using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Gagnutdinov_Praktika
{
    public partial class Form1 : Form
    {
        string path = "..\\..\\G.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd:MM:yyyy";
            // ограничения для длинны водимых данных
            passportNumberBox.MaxLength = 4;
            passportSBox.MaxLength = 6;
            AttestatnuberBox.MaxLength = 14;
            // создание столбцов таблицы с результатами экзаменов
            dataGridView1.Columns.Add("Exam", "Экзамен");
            dataGridView1.Columns.Add("Result", "Балл");
            dataGridView1.Columns[0].Width = 130; // Задаем высоту первой колник
            // добавление деффолтных строк
            dataGridView1.Rows.Add("Русский");
            dataGridView1.Rows.Add("Математика (П)");
        }
        // Запреты на ввод цифр/букв в textbox-ы
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)) return;
            else e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)) return;
            else e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)) return;
            else e.Handled = true;
        }
        // Кнопки для работы с таблицей
        private void GridAddBnt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
        private void GridDelBtn_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index; // сохраняем индекс выбранной строки
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]); // удаляем строку
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            // проверка на пустые (незаполненные поля)
            if (nameBox.Text == "") { MessageBox.Show("Заполните поле с фио"); return;}
            if (AttestatnuberBox.Text == "") { MessageBox.Show("Заполните поле с номером аттестата"); return; }
            if (dateTimePicker1.Value== DateTime.Now) { MessageBox.Show("Заполните поле с датой рождения"); return; }
            if(passportNumberBox.Text=="" || passportSBox.Text== "") { MessageBox.Show("Заполните поле паспортными данными"); return; }
            //saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(nameBox.Text);
            sw.WriteLine(Convert.ToDateTime(dateTimePicker1.Text));
            sw.WriteLine(AttestatnuberBox.Text);
            sw.WriteLine(passportNumberBox.Text);
            sw.WriteLine(passportSBox.Text);
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                {
                    sw.Write(dataGridView1.Rows[j].Cells[i].Value+"\n");
                }
            }
            sw.Close();
            // ОЧИСТКА ВСЕХ ПОЛЕЙ
            ClearAll();

        }
        void ClearAll()
        {
            nameBox.Text = "";
            AttestatnuberBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            passportNumberBox.Text = "";
            passportSBox.Text = "";
        }
        
    }
}
