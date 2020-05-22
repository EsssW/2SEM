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


namespace Bilaletdinova_Sabina
{
    public partial class Form1 : Form
    {
        static bool fn_enable = false;
        public Form1()
        {
            InitializeComponent();
        }
        // Метод для создания массива из файла
        public double[,] ReadFromFile(string FileName)
        {
            int rows = 0;
            string tmp;
            char[] sep = { ' ' };
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                rows++;
            }
            double[,] array = new double[rows, 2];
            fs.Seek(0, SeekOrigin.Begin);
            int i = 0;
            while (!sr.EndOfStream)
            {
                tmp = sr.ReadLine();
                string[] s = tmp.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                array[i, 0] = double.Parse(s[0]);
                array[i, 1] = double.Parse(s[1]);
                i++;

            }
            sr.Close();
            fs.Close();
            return array;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear(); //Очистка всех графиков
            chart1.Series.Add(new Series("МАЙ")); //  Создание ноовго графика
            // указываем диапозон 
            chart1.ChartAreas[0].AxisX.Minimum = 1; 
            chart1.ChartAreas[0].AxisX.Maximum = 31;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 33;
            // задаем название осям
            chart1.ChartAreas[0].AxisX.Title = "День";
            chart1.ChartAreas[0].AxisY.Title = "Температура";
            //задаем шаг(интрвал осей)
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            // указываем позицию названий осей для правильного отображения 
            chart1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
            // задаем цвет
            chart1.Series[0].Color = Color.Green;
            // создаем массив для заполнения из файла
            double[,] arr;
            // созданому массиву вызываем метод для читки и заолнения массива из файла
            arr = ReadFromFile("C:\\Users\\mukht\\Desktop\\weather.txt");
            // циклы для вывода наших данных из массива
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    chart1.Series[0].Points.AddXY(i+1, arr[i, j]);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fn_enable == true)
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                fn_enable = false;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                fn_enable = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fn_enable == true)
            {
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                fn_enable = false;
            }
            else
            {
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                fn_enable = true;
            }
        }
    }
}
