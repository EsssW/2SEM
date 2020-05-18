using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //============================================================//
        // схраняем изменения рамзерности матриц
        private void numCountRows_ValueChanged(object sender, EventArgs e)
        {
            matrixA.RowCount = (int)A_Rows.Value;
        }
        private void numCountCollum_ValueChanged(object sender, EventArgs e)
        {
            matrixA.ColumnCount = (int)A_Collum.Value;
        }
        private void numRowsCountM2_ValueChanged(object sender, EventArgs e)
        {
            matrixB.RowCount = (int)B_Rows.Value;
        }
        private void numCollCountM2_ValueChanged(object sender, EventArgs e)
        {
            matrixB.ColumnCount = (int)B_Collum.Value;
        }
        //============================================================//
        // дефолтные значаения размерностей
        private void Form1_Load(object sender, EventArgs e)
        {
            matrixA.RowCount = 2; 
            matrixA.ColumnCount = 2;
            matrixB.RowCount = 2;
            matrixB.ColumnCount = 2;
        }
        //============================================================//
        
        private void matrixOne_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        //определитель А
        private void button2_Click(object sender, EventArgs e)
        {
            int collCount = matrixA.ColumnCount;
            int rowCount = matrixA.RowCount;
            //проверка на квадратность
            if (collCount != rowCount)
            {
                MessageBox.Show("Определитель существует только для квадратных матриц!");
                return;
            }
            //переносим данные из грида в массив
            double[,] matr = new double[collCount, rowCount];
            matr = ToArr(matrixA);
            //считаем функцией определитель и выводим 
            MessageBox.Show("Определитель равен: " + matrixDet(matr, collCount).ToString());
        }
        // Определитель B
        private void button7_Click(object sender, EventArgs e)
        {
            int collCount = matrixB.ColumnCount;
            int rowCount = matrixB.RowCount;
            //проверка на квадратность
            if (collCount != rowCount)
            {
                MessageBox.Show("Определитель существует только для квадратных матриц!");
                return;
            }
            //переносим данные из грида в массив
            double[,] matr = new double[collCount, rowCount];
            matr = ToArr(matrixB);
            //считаем функцией определитель и выводим 
            MessageBox.Show("Определитель равен: " + matrixDet(matr, collCount).ToString());
        }
        // конопка заполнения случайными цифрами матрицы B
        private void button6_Click(object sender, EventArgs e)
        {
            randomMatrix(matrixB);
        }
        // Кнопка очистки матрицы B
        private void button4_Click(object sender, EventArgs e)
        {
            clearMatrix(matrixB);
        }
        //Кнопка A+B
        private void bPlus_Click(object sender, EventArgs e)
        {
            if (summMatrix(matrixA, matrixB) == null) return;
            Result f = new Result(summMatrix(matrixA, matrixB), "сложения");
            f.ShowDialog();
        }
        //заполняем матрицу A случайными числами
        private void button1_Click(object sender, EventArgs e)
        {
            randomMatrix(matrixA);
        }
        //очищаем матрицу A
        private void button3_Click(object sender, EventArgs e)
        {
            clearMatrix(matrixA);
        }
        //кнопка A*B
        private void bMul_Click(object sender, EventArgs e)
        {
            if (multMatrix(matrixA, matrixB) == null) return;//проверка выполняется ли умножение
            Result f = new Result(multMatrix(matrixA, matrixB), "A*B");//передаем в конструктор новой формы грид и заголовок
            f.ShowDialog();
        }
        //кнопка Вычитание
        private void subBtn_Click_1(object sender, EventArgs e)
        {
            if (subMatrix(matrixA, matrixB) == null) return;
            Result f = new Result(subMatrix(matrixA, matrixB), "A-B");
            f.ShowDialog();
        }
        //кнопка обратной матриы A
        private void Aobr_Click(object sender, EventArgs e)
        {
            Result f = new Result(ObrMatrix(matrixA), "A обратная");//передаем в конструктор новой формы грид и заголовок
            f.ShowDialog();
        }
        //кнопка обратной матриы B
        private void Bobr_Click(object sender, EventArgs e)
        {
            Result f = new Result(ObrMatrix(matrixB), "B обратная");//передаем в конструктор новой формы грид и заголовок
            f.ShowDialog();
        }
        //============================================================//
        //если нажата кнопка проверяем введены ли цифры
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ',')))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                { e.Handled = true; }
            }

        }

        

        /// Заполняет грид случайными числами в диапазоне от 1 до 10
        private void randomMatrix(DataGridView dg)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            //сохраняем количество строк и столбцов грида
            int collCount = dg.ColumnCount;
            int rowCount = dg.RowCount;
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    dg.Rows[j].Cells[i].Value = rand.Next(1, 4);
                }
        }

        // Очистка матрицы
        private void clearMatrix(DataGridView matrix)
        {
            //сохраняем количество строк и столбцов грида
            int collCount = matrix.ColumnCount;
            int rowCount = matrix.RowCount;
            //обнуляем все ячейки таблицы
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                {
                    matrix.Rows[j].Cells[i].Value = 0;
                }
        }


        // Сложение матриц
        private DataGridView summMatrix(DataGridView matr1, DataGridView matr2)
        {
            //проверка размеров
            if (matr1.RowCount != matr2.RowCount)
            {
                MessageBox.Show("Размерность матриц для сложения должна быть одинаковой!");
                return null;
            }

            // сложение матриц
            int m = matr1.ColumnCount;
            int n = matr1.RowCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = n;
            dg.ColumnCount = m;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    dg.Rows[j].Cells[i].Value = Convert.ToDouble(matr1.Rows[j].Cells[i].Value) + Convert.ToDouble(matr2.Rows[j].Cells[i].Value);
            return dg;
        }
        //============================================================//
        //МЕТОД ОБРАТНОЙ МАТРИЦЫ 
        public DataGridView ObrMatrix(DataGridView matr)
        {
            if (matr.ColumnCount != matr.RowCount)
            {
                MessageBox.Show("Матрица не квадртаная!");
                return null;
            }
            
            DataGridView dg = new DataGridView();
            int m = matr.ColumnCount;
            double[,] arr = new double[m, m];
            arr = ToArr(matr);
            double det = matrixDet(arr, m);
            dg.RowCount = m;
            dg.ColumnCount = m;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dg.Rows[j].Cells[i].Value = (matrixDet(Minor(arr, m, i, j),m)/det);
                }
            }
            return dg;
        }
        //============================================================//
        public double[,] ToArr(DataGridView matrA)
        {
            int m = matrA.ColumnCount;
            int n = matrA.RowCount;
            double[,] arr = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToInt32(matrA.Rows[i].Cells[j].Value);
                }
            }
            return arr;
        }
        //============================================================//
        // метод для умножение матриц
        private DataGridView multMatrix(DataGridView matrA, DataGridView matrB)
        {
            //осуществляем проверку
            if (matrA.ColumnCount != matrB.RowCount)
            {
                MessageBox.Show("Размерность матриц A и B не подходят!");
                return null;
            }

            //осуществляем умножение матриц
            int m = matrB.ColumnCount;
            int n= matrA.RowCount;
            int rCount = matrA.ColumnCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = n;
            dg.ColumnCount = m;
            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                {
                    double temp = 0;
                    for (int r = 0; r < rCount; r++)
                        temp += Convert.ToDouble(matrA.Rows[j].Cells[r].Value) * Convert.ToDouble(matrB.Rows[r].Cells[i].Value);
                    dg.Rows[j].Cells[i].Value = temp;
                }
            return dg;
        }
        //============================================================//
        // Вычисляет минор для текущей матрицы
        private double[,] Minor(double[,] matrix, int m, int i, int j)  // m-размерность
        {
            int di = 0;
            double[,] b = new double[m, m];
            for (int ki = 0; ki < m - 1; ki++)
            {
                if (ki == i) di = 1;
                int dj = 0;
                for (int kj = 0; kj < m - 1; kj++)
                {
                    if (kj == j) dj = 1;
                    b[ki, kj] = matrix[ki + di, kj + dj];
                }
            }
            return b;
        }
        //============================================================//
        // определитель для матрицы
        private double matrixDet(double[,] matrix, int m)
        {
            double[,] b = new double[m, m];
            double d = 0, k = 1;
            if (m < 1) return 0;//если размерность матрицы = 0
            if (m == 1) d = matrix[0, 0]; //если размерность матрицы равна 1
            else if (m == 2) //если равна 2 используем стандартную формулу
            {
                d = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            }
            else //n>2 иначе рекурсивно делаем разложение по первой строке
                for (int i = 0; i < m; i++)
                {
                    b = Minor(matrix, m, i, 0);//получаем минор для итого элемента первой строки
                    d += k * matrix[i, 0] * matrixDet(b, m - 1);//вызываем рекурсивно функцию
                    k = -k;
                }
            return d;
        }
        //============================================================//
        // вычитание матриц
        private DataGridView subMatrix(DataGridView matr1, DataGridView matr2)
        {
            if (matr1.RowCount != matr2.RowCount)
            {
                MessageBox.Show("Размерность матриц A и B различны!");
                return null;
            }

            int m = matr1.ColumnCount;
            int n= matr1.RowCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = n;
            dg.ColumnCount = m;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dg.Rows[j].Cells[i].Value = Convert.ToDouble(matr1.Rows[j].Cells[i].Value) - Convert.ToDouble(matr2.Rows[j].Cells[i].Value);
            return dg;
        }
        


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}


