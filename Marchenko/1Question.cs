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
    public partial class SecondTypeQuestion : Form
    {
        public string[] questionarray =
        {
            "1","2","3","4","5"
        };
        public static string[] answersarr =
        {
            "1","2","3","4","5"
        };
        static int n = answersarr.Length;
        public string[] userpick = new string[n];
        public static int count = 0;


        public SecondTypeQuestion()
        {
            InitializeComponent();
        }

        private void SecondTypeQuestion_Load(object sender, EventArgs e)
        {
            textBox1.Text = questionarray[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            if (count< n)
            {
                textBox1.Text = questionarray[count];
                //запись в массив ответов пользотаеля 
                userpick[count]= textBox2.Text;
                count++;
            }
            // дошли до конца 
            if(count==n)
            {
                //сравниваем овтеты пользователя с верными ответами 
                for (int i = 0; i < questionarray.Length; i++)
                {
                    if (userpick[i] == answersarr[i])
                        ANSWERS.true1++;
                }
                MessageBox.Show("резултат= "+ ANSWERS.true1);
            }
        }
    }
}
