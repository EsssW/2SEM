﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public static BindingSource bns { get; set; }

        public Result(DataGridView dg, String nresult)
        {
            InitializeComponent();
            int n = dg.ColumnCount;
            int m = dg.RowCount;
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    dataGridView1.Rows[j].Cells[i].Value = dg.Rows[j].Cells[i].Value;

            groupBox1.Text = "Результат " + nresult;
        }
    }
}
