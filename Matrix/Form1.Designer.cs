namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bobr = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.matrixB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Collum = new System.Windows.Forms.NumericUpDown();
            this.B_Rows = new System.Windows.Forms.NumericUpDown();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.A_Rows = new System.Windows.Forms.NumericUpDown();
            this.A_Collum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matrixA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ClearA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Aobr = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Collum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Collum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.Bobr);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.matrixB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.B_Collum);
            this.groupBox2.Controls.Add(this.B_Rows);
            this.groupBox2.Location = new System.Drawing.Point(283, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(251, 499);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B Matrix";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Bobr
            // 
            this.Bobr.Location = new System.Drawing.Point(12, 440);
            this.Bobr.Name = "Bobr";
            this.Bobr.Size = new System.Drawing.Size(194, 26);
            this.Bobr.TabIndex = 9;
            this.Bobr.Text = "Обратнаяматрица";
            this.Bobr.UseVisualStyleBackColor = true;
            this.Bobr.Click += new System.EventHandler(this.Bobr_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 403);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(194, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "Найти detB";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 366);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Занулить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 330);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Заполнить случайно";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // matrixB
            // 
            this.matrixB.AllowUserToAddRows = false;
            this.matrixB.AllowUserToDeleteRows = false;
            this.matrixB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixB.ColumnHeadersVisible = false;
            this.matrixB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixB.DefaultCellStyle = dataGridViewCellStyle9;
            this.matrixB.Location = new System.Drawing.Point(12, 96);
            this.matrixB.Margin = new System.Windows.Forms.Padding(4);
            this.matrixB.Name = "matrixB";
            this.matrixB.RowHeadersVisible = false;
            this.matrixB.RowHeadersWidth = 30;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "0";
            this.matrixB.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.matrixB.RowTemplate.DefaultCellStyle.Format = "N0";
            this.matrixB.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.matrixB.RowTemplate.ErrorText = "Не верный формат цифр";
            this.matrixB.Size = new System.Drawing.Size(225, 226);
            this.matrixB.TabIndex = 4;
            this.matrixB.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixOne_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во столбцов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Кол-во строк:";
            // 
            // B_Collum
            // 
            this.B_Collum.Location = new System.Drawing.Point(139, 53);
            this.B_Collum.Margin = new System.Windows.Forms.Padding(4);
            this.B_Collum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.B_Collum.Name = "B_Collum";
            this.B_Collum.Size = new System.Drawing.Size(85, 22);
            this.B_Collum.TabIndex = 1;
            this.B_Collum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.B_Collum.ValueChanged += new System.EventHandler(this.numCollCountM2_ValueChanged);
            // 
            // B_Rows
            // 
            this.B_Rows.Location = new System.Drawing.Point(139, 21);
            this.B_Rows.Margin = new System.Windows.Forms.Padding(4);
            this.B_Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.B_Rows.Name = "B_Rows";
            this.B_Rows.Size = new System.Drawing.Size(85, 22);
            this.B_Rows.TabIndex = 0;
            this.B_Rows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.B_Rows.ValueChanged += new System.EventHandler(this.numRowsCountM2_ValueChanged);
            // 
            // bPlus
            // 
            this.bPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlus.Location = new System.Drawing.Point(541, 111);
            this.bPlus.Margin = new System.Windows.Forms.Padding(4);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(68, 63);
            this.bPlus.TabIndex = 9;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMul.Location = new System.Drawing.Point(541, 274);
            this.bMul.Margin = new System.Windows.Forms.Padding(4);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(68, 63);
            this.bMul.TabIndex = 11;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(539, 190);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(70, 63);
            this.subBtn.TabIndex = 0;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click_1);
            // 
            // A_Rows
            // 
            this.A_Rows.Location = new System.Drawing.Point(142, 23);
            this.A_Rows.Margin = new System.Windows.Forms.Padding(4);
            this.A_Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.A_Rows.Name = "A_Rows";
            this.A_Rows.Size = new System.Drawing.Size(85, 22);
            this.A_Rows.TabIndex = 0;
            this.A_Rows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.A_Rows.ValueChanged += new System.EventHandler(this.numCountRows_ValueChanged);
            // 
            // A_Collum
            // 
            this.A_Collum.Location = new System.Drawing.Point(142, 53);
            this.A_Collum.Margin = new System.Windows.Forms.Padding(4);
            this.A_Collum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.A_Collum.Name = "A_Collum";
            this.A_Collum.Size = new System.Drawing.Size(85, 22);
            this.A_Collum.TabIndex = 1;
            this.A_Collum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.A_Collum.ValueChanged += new System.EventHandler(this.numCountCollum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во строк:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кол-во столбцов:";
            // 
            // matrixA
            // 
            this.matrixA.AllowUserToAddRows = false;
            this.matrixA.AllowUserToDeleteRows = false;
            this.matrixA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixA.ColumnHeadersVisible = false;
            this.matrixA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "0";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixA.DefaultCellStyle = dataGridViewCellStyle11;
            this.matrixA.Location = new System.Drawing.Point(12, 96);
            this.matrixA.Margin = new System.Windows.Forms.Padding(4);
            this.matrixA.Name = "matrixA";
            this.matrixA.RowHeadersVisible = false;
            this.matrixA.RowHeadersWidth = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "0";
            this.matrixA.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.matrixA.RowTemplate.DefaultCellStyle.Format = "N0";
            this.matrixA.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.matrixA.RowTemplate.ErrorText = "Не верный формат цифр";
            this.matrixA.Size = new System.Drawing.Size(224, 226);
            this.matrixA.TabIndex = 4;
            this.matrixA.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixOne_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Заполнить случайно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Найти detA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearA
            // 
            this.ClearA.Location = new System.Drawing.Point(12, 369);
            this.ClearA.Margin = new System.Windows.Forms.Padding(4);
            this.ClearA.Name = "ClearA";
            this.ClearA.Size = new System.Drawing.Size(191, 28);
            this.ClearA.TabIndex = 7;
            this.ClearA.Text = "Занулить";
            this.ClearA.UseVisualStyleBackColor = true;
            this.ClearA.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.Aobr);
            this.groupBox1.Controls.Add(this.ClearA);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.matrixA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.A_Collum);
            this.groupBox1.Controls.Add(this.A_Rows);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(259, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A matrix";
            // 
            // Aobr
            // 
            this.Aobr.Location = new System.Drawing.Point(9, 440);
            this.Aobr.Name = "Aobr";
            this.Aobr.Size = new System.Drawing.Size(194, 26);
            this.Aobr.TabIndex = 8;
            this.Aobr.Text = "Обратнаяматрица";
            this.Aobr.UseVisualStyleBackColor = true;
            this.Aobr.Click += new System.EventHandler(this.Aobr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(621, 527);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Collum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_Collum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView matrixB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown B_Collum;
        private System.Windows.Forms.NumericUpDown B_Rows;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.NumericUpDown A_Rows;
        private System.Windows.Forms.NumericUpDown A_Collum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView matrixA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ClearA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Bobr;
        private System.Windows.Forms.Button Aobr;
    }
}

