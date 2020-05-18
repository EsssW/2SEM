using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix_class_28._04._2020
{
    class Matrix
    {
        int m, n;
        double[,] a;
        
        public Matrix() { a = null; m = 0; n = 0; }
        public Matrix(int mm, int nn)
        {
            m = mm; n = nn;
            a = new double[m, n];
        }

        public int M { get { return m; } }
        public int N { get { return n; } }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= m || j < 0 || j >= n) throw new Exception("Bad index!");
                return a[i, j];
            }
            set
            {
                if (i < 0 || i >= m || j < 0 || j >= n) throw new Exception("Bad index!");
                a[i, j] = value;
            }

        }

        public static Matrix operator ! (Matrix x)
        {
            Matrix res = new Matrix(x.n, x.m);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[j, i]= x.a[i, j];
                }
            }
            return res;
        }

        public static Matrix operator * (Matrix x, double k) 
        {
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[i, j] = x.a[i, j] * k;
                }
            }
            return res;
        }

        public static Matrix operator *(double k, Matrix x) 
        {
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[i, j] = x.a[i, j] * k;
                }
            }
            return res;
        }

        public static Matrix operator +(Matrix x, Matrix y)
        {
            if ( x.m!=y.m || x.n!=y.n) throw new Exception("размеры матриц не совпадают");
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[i, j] = x.a[i, j] + y.a[i,j];
                }
            }
            return res;
        }

        public static Matrix operator -(Matrix x, Matrix y)
        {
            if (x.m != y.m || x.n != y.n) throw new Exception("размеры матриц не совпадают");
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[i, j] = x.a[i, j] - y.a[i, j];
                }
            }
            return res;
        }

        public static Matrix operator -(Matrix x) 
        {
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[i, j] = x.a[i, j] * -1;
                }
            }
            return res;
        }

        public static Matrix operator *(Matrix x, Matrix y) 
        {
            if (x.n != y.m) throw new Exception("Матрицы нельзя перемножить");
            Matrix res = new Matrix(x.m, y.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < y.n; j++)
                {
                   res[i, j] += x.a[i, j] * y.a[i, j];            
                }
            }
            return res;
        }

        public static Matrix operator ++(Matrix x)
        {
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    res[i, j] = x.a[i, j] + 1;
                    
                }
            }
            return res;
        }

        public static Matrix operator --(Matrix x) 
        {
            Matrix res = new Matrix(x.m, x.n);
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                  res[i, j] = x.a[i, j] - 1;
                }
            }
            return res;
        }
        /*
        public static bool operator == (Matrix x, Matrix y)
        {
            bool f = true ;
            if (x.m != y.m || x.n != y.n) { return false; }
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    if (x.a[i, j] != y.a[i, j]) f = false;
                }
            }
            return f;
        }

        public static bool operator != (Matrix x, Matrix y)
        {
            bool f = false;
            if (x.m != y.m || x.n != y.n) { return true; }
            for (int i = 0; i < x.m; i++)
            {
                for (int j = 0; j < x.n; j++)
                {
                    if (x.a[i, j] != y.a[i, j]) f = true;
                }
            }
            return f;
        }
        */

        public static explicit operator double[,](Matrix x)

        {

            double[,] res = new double[x.m, x.n];

            for (int i = 0; i < x.m; i++)

                for (int j = 0; j < x.n; j++)

                    res[i, j] = x.a[i, j];

            return res;
        }

        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < m; i++, Console.WriteLine())
                for (int j = 0; j < n; j++)
                    Console.Write("{0, 6}", a[i, j]);
            Console.WriteLine();

        }

        public void WriteMat()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    a[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        public bool OneMatrix()
        {
            int count = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] == 1 && i == j) { count++; }

            if (count == n) { return true; }
            else { return false; }
        }
    }




}
