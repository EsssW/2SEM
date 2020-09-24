using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marchenko
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            NextBTN_Click(null,null);


        }

        public static string[] TestArr =
        {
            "вопр1","вопр2","вопр3","вопр4","вопр5","вопр6","вопр7"
        };
        // массив парвилных оветов для сравнения с ответами пользоваетля 
        static string[] TrueAnswerArr =
        {
            "1","2","3","4","5","6","7"
        };
        // массив варивнтов ответов
        static string[,] AnswerArr =
        {
            {"rrr","rrrr","rrrr","rrr"},

            {"addada","ddada","adadad","adadad"},

            {"55","66","","77"},

            {"88","99","999","1111"},

            {"add","adad","dadddd","dd"},

            {"dd","dd","dd","dd"},

            {"dd","dd","dd","ddd"}
        };
        // массив для записи в него выбранных пользователем овтетов
        static string[] StudentAnswerArr = new string[7]; // количество вопросов


        public int questIndex = 0;

        /*
        // метод для смены вопросов 
        public void NextQuestion(int i)
        {
            
            QuestionTextBox.Text = TestArr[i];
            radioButton1.Text = AnswerArr[i, 0];
            radioButton2.Text = AnswerArr[i, 1];
            radioButton3.Text = AnswerArr[i, 2];
            radioButton4.Text = AnswerArr[i, 3];
        }
        // метод сохранения выбранных отвтеов и записи резульатата в массив 
        public void SaveOtvet(int i)
        {
            if (radioButton1.Checked == true)
                StudentAnswerArr[i] = radioButton1.Text;
            if (radioButton2.Checked == true)
                StudentAnswerArr[i] = radioButton2.Text;
            if (radioButton3.Checked == true)
                StudentAnswerArr[i] = radioButton3.Text;
            if (radioButton4.Checked == true)
                StudentAnswerArr[i] = radioButton4.Text;
        }
        */

        
        

        private void NextBTN_Click(object sender, EventArgs e)
        {
            if (questIndex < 7) // до 7и тк 7вопросв 
            {
                //сохраняем ответ пользовтеля вызвовом метода
                if (radioButton1.Checked == true)
                    StudentAnswerArr[questIndex] = radioButton1.Text;
                if (radioButton2.Checked == true)
                    StudentAnswerArr[questIndex] = radioButton2.Text;
                if (radioButton3.Checked == true)
                    StudentAnswerArr[questIndex] = radioButton3.Text;
                if (radioButton4.Checked == true)
                    StudentAnswerArr[questIndex] = radioButton4.Text;
                // меняем вопрос
                QuestionTextBox.Text = TestArr[questIndex];
                radioButton1.Text = AnswerArr[questIndex, 0];
                radioButton2.Text = AnswerArr[questIndex, 1];
                radioButton3.Text = AnswerArr[questIndex, 2];
                radioButton4.Text = AnswerArr[questIndex, 3];
                questIndex++;
            }
            if (questIndex == 7) //если дошли до последнего вопроса то сохраняем резуьтатаы 
            {
                // идем по массиву выбранных отвоетов 
                // и сравниваем с массивом верных овтетов
                for (int i = 0; i < 7; i++)
                {
                    //если ответ пользовтеля равен верному то 
                    if (StudentAnswerArr[i] == TrueAnswerArr[i])
                    {
                        ANSWERS.true1++;
                    }
                }

                this.Hide();
                SecondTypeQuestion f = new SecondTypeQuestion();
                f.Show();
                
            }

        }

        
    }
}
