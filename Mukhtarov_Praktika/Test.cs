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
    public partial class Test : Form
    {
        int count = 0;
        // 
        static string pathTest = "..\\..\\test.txt";
        string pathAnswer = "..\\..\\answer.txt";
        string pathTrueAnswer = "..\\..\\answertrue.txt";
        //
        static int n = File.ReadAllLines(pathTest).Length;
        static string[] TestArr = new string[n];
        static string[] TrueAnswerArr = new string[n];
        static string[,] AnswerArr;
        static string[] StudentAnswerArr = new string[n];

        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // Заполняем массив правильными ответамим
            StreamReader trueanswerReader = new StreamReader(pathTrueAnswer);
            int cc = 0;
            string str;
            while ((str = trueanswerReader.ReadLine()) != null)
            {
                TrueAnswerArr[cc] = str;
                cc++;
            }
            trueanswerReader.Close();
            // Открываем файл для чтения вопросов
            StreamReader testReader = new StreamReader(pathTest);
            int j = 0;
            string line;
            // заполняем масив вопросов из файла
            while ((line = testReader.ReadLine()) != null) 
            {
                TestArr[j] = line;
                j++;
            }
            testReader.Close();
            // Заполняем массив возможными ответами
            string[] lines = File.ReadAllLines(pathAnswer);
            AnswerArr = new string[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int w = 0; w < temp.Length; w++)
                    AnswerArr[i, w] = temp[w];
            }
            // Выводим вопрос 
            label1.Text = TestArr[count];
            // Выводим овтеты
            radioButton1.Text = AnswerArr[0, 0];
            radioButton2.Text = AnswerArr[0, 1];
            radioButton3.Text = AnswerArr[0, 2];
        }
        // при нажатии на кнопку ответить переходим к следущему вопросу
        private void button1_Click(object sender, EventArgs e)
        {  
            // Переходим к след вопросу(ячейке массива)ы
            count++;
            if (count < n)
            {
                // СОХРАНЯЕМ ОТВЕТ
                if (radioButton1.Checked == true)
                {
                    StudentAnswerArr[count] = radioButton1.Text;
                    
                }
                if (radioButton2.Checked == true)
                {
                    StudentAnswerArr[count] = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    StudentAnswerArr[count] = radioButton3.Text;
                }
                // Выводим следующие вопросы 
                radioButton1.Text = AnswerArr[count, 0];
                radioButton2.Text = AnswerArr[count, 1];
                radioButton3.Text = AnswerArr[count, 2];
                // Выводим следующие вопросы 
                label1.Text = TestArr[count];
                int[] a = new int[n];// массив для подсчета баллов
                int truecount = 0; // переменная для подсчета верных ответов
                for (int i = 0; i < n; i++)
                {
                    if (StudentAnswerArr[i] == TrueAnswerArr[i])
                        a[i] = 1;
                    else a[i] = 0;
                    if (a[i] == 1) truecount++;
                }

            }
            
            // Если дошли до последнего вопроса 
            if (count == n - 1)
            {
                button1.Text = "Завершить";
                StreamWriter WriteResult = new StreamWriter("..\\..\\result.txt", true);
                int[] a=new int[n];// массив для подсчета баллов
                int truecount=0; // переменная для подсчета верных ответов
                WriteResult.WriteLine(DateTime.Now);
                for (int i = 0; i < n; i++)
                {
                    if (StudentAnswerArr[i] == TrueAnswerArr[i])
                    a[i] = 1;
                    else a[i] = 0;
                    WriteResult.Write(a[i] + " # ");
                    if (a[i] == 1) truecount++;
                }
                WriteResult.WriteLine("Правильных ответов: " + truecount);
                WriteResult.Close();
                MessageBox.Show("Поздравляю, вы завершили тест\nВаш результат: " + truecount + "/" + n);
                this.Close();
                return;
                
                
            } 
            
        }
    }
}
