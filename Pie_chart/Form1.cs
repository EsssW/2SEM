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
using System.Windows.Forms.DataVisualization.Charting;

namespace Mullinov_Aidar_09_901
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chart1.Series.Clear();
            // настройки диаграммы
            Chart1.BackColor = Color.Gray;
            Chart1.BackSecondaryColor = Color.WhiteSmoke;
            Chart1.BackGradientStyle = GradientStyle.DiagonalRight;
            Chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            Chart1.BorderlineColor = Color.Gray;
            Chart1.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            Chart1.ChartAreas[0].BackColor = Color.Wheat;
            // заголовок
            Chart1.Titles.Add("Диаграмма");
            //стиль и размер заголвка 
            Chart1.Titles[0].Font = new Font("", 16);
            
            Chart1.Series.Add(new Series("Result"){ChartType = SeriesChartType.Pie});
            int[] arr;// массив для записи данных из файла
           // запоняем массив при помощи вызова метода
            arr = ReadFromFile("C:\\Users\\mukht\\Desktop\\ocenki.txt");
            // переменные для подсчета количесвто оценок 
            int a5=0, a4=0, a3=0, a2=0;
            // цикл для подсчета числа оценок
            for (int i = 0; i < arr.Length; i++)
            {
                int casei = arr[i];
                switch (casei)
                {
                    case 5: a5 += 1; break;
                    case 4: a4 += 1; break;
                    case 3: a3 += 1; break;
                    case 2: a2 += 1; break;
                    default: MessageBox.Show("В файле на строке {0} неверная оценка ");  break;
                }
            }
            // задаем данные для диаграммы
            double[] yValues = { a5, a4, a3, a2 };
            string[] xValues = { "Отл", "Хор", "Удов", "НеУдов" };
            Chart1.Series["Result"].Points.DataBindXY(xValues, yValues);
            // 3D стиль для диаграммы
            Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
        // Метод для создания массива из файла
        public int[] ReadFromFile(string FileName)
        {
            // считываем файл
            StreamReader f = new StreamReader (FileName);
            string line; // промежуточная строка
            int count= System.IO.File.ReadAllLines(FileName).Length; // вычиляем кол-во строк файла
            int[] arr = new int[count]; // массив для хранения всех элементов файла 
            int i = 0;
            // в цикле записывем каждую строку в отдельную ячейку массива
            while ((line = f.ReadLine()) != null)
            {
                arr[i++] = Convert.ToInt32(line);
            }
            return arr;
        }
    }
}
