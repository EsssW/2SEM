using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_class_28._04._2020
{
    class squareMatrix : Matrix
    {
        public squareMatrix(int n) :base(n, n) { }
        public squareMatrix() { }

        // симметричность матрицы 
        public  bool SemetricMatrix()
        {
            bool f = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] != a[j, i])
                    {
                        f= false;
                        break;
                    }
                }
                if (!f) break;
            }
            if (f) return true;
            else return false;
        }
            
        // Определтиьель 
        public double Determinant()
        {
            double det = 0;
            int rows = n;
            if (rows == 1)
                return a[0, 0];
            squareMatrix na = new squareMatrix(rows - 1);
            for (int j = 0; j < rows; j++)
            {
                na = SubMatrix(0, j);
                if (j % 2 == 0)
                    det += na.Determinant() * a[0, j];
                else
                    det -= na.Determinant() * a[0, j];
            }
            return det;
        }
        //обртная матрица
        public squareMatrix Obratnya(squareMatrix m)
        {
            int rows = n;
            squareMatrix res = new squareMatrix(rows);
            squareMatrix na = new squareMatrix(rows - 1);
            double det =m.Determinant();
            if (det == 0)
                throw new Exception("Матрица вырожденная");
            int k;
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0) k = 1;
                else k = -1;
                for (int j = 0; j < rows; j++)
                {
                    na = m.SubMatrix(i, j);
                    res[j, i] = k * na.Determinant() / det;
                    k = -k;
                }
            }
            return res;
        }
        // минор  n-того порядка
        squareMatrix SubMatrix(int i1, int j1)
        {
            int rows = n;
            squareMatrix na = new squareMatrix(rows - 1);
            for (int i = 0; i < i1; i++)
            {
                for (int j = 0; j < j1; j++)
                    na[i, j] = a[i, j];
                for (int j = j1 + 1; j < rows; j++)
                    na[i, j - 1] = a[i, j];
            }
            for (int i = i1 + 1; i < rows; i++)
            {
                for (int j = 0; j < j1; j++)
                    na[i - 1, j] = a[i, j];
                for (int j = j1 + 1; j < rows; j++)
                    na[i - 1, j - 1] = a[i, j];
            }
            return na;
        }



    }
}
