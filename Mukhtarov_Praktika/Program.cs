﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mukhtarov_Praktika
{
    static class Program
    {
        // Главная точка входа для приложения.

        [STAThread]
        static void Main()
        {
            string ResultPath = "..\\..\\result.txt";
            string TestPath= "..\\..\\test.txt";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}