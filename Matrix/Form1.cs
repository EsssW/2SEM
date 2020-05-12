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

        //если нажата кнопка проверяем введены ли цифры
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ',')))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                { e.Handled = true; }
            }

        }

        //заполняем матрицу 1 случайными числами
        private void button1_Click(object sender, EventArgs e)
        {
            randomMatrix(matrixA);
        }

        //очищаем матрицу 1
        private void button3_Click(object sender, EventArgs e)
        {
            clearMatrix(matrixA);
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

        //заполняем случайными цифрами матрицу B
        private void button6_Click(object sender, EventArgs e)
        {
            randomMatrix(matrixB);
        }

        // очистки матрицы B
        private void button4_Click(object sender, EventArgs e)
        {
            clearMatrix(matrixB);
        }

        //СЛОЖЕНИЕ A+B
        private void bPlus_Click(object sender, EventArgs e)
        {
            if (summMatrix(matrixA, matrixB) == null) return;
            Result f = new Result(summMatrix(matrixA, matrixB), "сложения");
            f.ShowDialog();
        }

        // Сложение матриц
        private DataGridView summMatrix(DataGridView matr1, DataGridView matr2)
        {
            //осуществляем проверку
            if (matr1.RowCount != matr2.RowCount)
            {
                MessageBox.Show("Размерность матриц для сложения должна быть одинаковой!");
                return null;
            }

            //осуществляем сложение матриц
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

        //кнопка нахождения определителя
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
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                    matr[i, j] = Convert.ToDouble(matrixA.Rows[j].Cells[i].Value);
            //считаем функцией определитель и выводим 
            MessageBox.Show("Определитель равен: " + matrixDeterminant(matr, collCount).ToString());
        }

        // Вычисляет минор для текущей матрицы
        private double[,] getMinor(double[,] matrix, int m, int i, int j)  // m-размерность
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

        
        // определитель для матрицы
        private double matrixDeterminant(double[,] matrix, int m)
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
                    b = getMinor(matrix, m, i, 0);//получаем минор для итого элемента первой строки
                    d += k * matrix[i, 0] * matrixDeterminant(b, m - 1);//вызываем рекурсивно функцию
                    k = -k;
                }
            return d;
        }

        //кнопка умножения
        private void bMul_Click(object sender, EventArgs e)
        {
            if (multMatrix(matrixA, matrixB) == null) return;//проверка выполняется ли умножение
            Result f = new Result(multMatrix(matrixA, matrixB), "A*B");//передаем в конструктор новой формы грид и заголовок
            f.ShowDialog();
        }
        //Вычитание
        private void button5_Click(object sender, EventArgs e)
        {
            if (subMatrix(matrixA, matrixB) == null) return;
            Result f = new Result(subMatrix(matrixA, matrixB), "A-B");
            f.ShowDialog();
        }
        
        /// вычитание
        private DataGridView subMatrix(DataGridView matr1, DataGridView matr2)
        {
            //осуществляем проверку
            if (matr1.RowCount != matr2.RowCount)
            {
                MessageBox.Show("Размерность матриц A и B различны!");
                return null;
            }
            //осуществляем вычитание матриц
            int collCount = matr1.ColumnCount;
            int rowCount = matr1.RowCount;
            DataGridView dg = new DataGridView();
            dg.RowCount = rowCount;
            dg.ColumnCount = collCount;
            for (int i = 0; i < collCount; i++)
                for (int j = 0; j < rowCount; j++)
                    dg.Rows[j].Cells[i].Value = Convert.ToDouble(matr1.Rows[j].Cells[i].Value) - Convert.ToDouble(matr2.Rows[j].Cells[i].Value);
            return dg;
        }

        
    }
}


