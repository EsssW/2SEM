namespace Gagnutdinov_Praktika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.AttestatnuberBox = new System.Windows.Forms.TextBox();
            this.passportNumberBox = new System.Windows.Forms.TextBox();
            this.passportSBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridDelBtn = new System.Windows.Forms.Button();
            this.GridAddBnt = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "№ аттестата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Серия и номер паспорта ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(4, 44);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(348, 31);
            this.nameBox.TabIndex = 4;
            this.nameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox_KeyPress);
            // 
            // AttestatnuberBox
            // 
            this.AttestatnuberBox.Location = new System.Drawing.Point(8, 210);
            this.AttestatnuberBox.Margin = new System.Windows.Forms.Padding(4);
            this.AttestatnuberBox.Multiline = true;
            this.AttestatnuberBox.Name = "AttestatnuberBox";
            this.AttestatnuberBox.Size = new System.Drawing.Size(188, 31);
            this.AttestatnuberBox.TabIndex = 6;
            this.AttestatnuberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // passportNumberBox
            // 
            this.passportNumberBox.Location = new System.Drawing.Point(8, 292);
            this.passportNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.passportNumberBox.Multiline = true;
            this.passportNumberBox.Name = "passportNumberBox";
            this.passportNumberBox.Size = new System.Drawing.Size(85, 31);
            this.passportNumberBox.TabIndex = 7;
            this.passportNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // passportSBox
            // 
            this.passportSBox.Location = new System.Drawing.Point(101, 292);
            this.passportSBox.Margin = new System.Windows.Forms.Padding(4);
            this.passportSBox.Multiline = true;
            this.passportSBox.Name = "passportSBox";
            this.passportSBox.Size = new System.Drawing.Size(131, 31);
            this.passportSBox.TabIndex = 8;
            this.passportSBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.passportSBox);
            this.panel1.Controls.Add(this.passportNumberBox);
            this.panel1.Controls.Add(this.AttestatnuberBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 408);
            this.panel1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 32);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(18, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(336, 309);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.GridDelBtn);
            this.panel2.Controls.Add(this.GridAddBnt);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(386, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 407);
            this.panel2.TabIndex = 11;
            // 
            // GridDelBtn
            // 
            this.GridDelBtn.Location = new System.Drawing.Point(238, 347);
            this.GridDelBtn.Name = "GridDelBtn";
            this.GridDelBtn.Size = new System.Drawing.Size(116, 37);
            this.GridDelBtn.TabIndex = 12;
            this.GridDelBtn.Text = "Удалить";
            this.GridDelBtn.UseVisualStyleBackColor = true;
            this.GridDelBtn.Click += new System.EventHandler(this.GridDelBtn_Click);
            // 
            // GridAddBnt
            // 
            this.GridAddBnt.Location = new System.Drawing.Point(18, 347);
            this.GridAddBnt.Name = "GridAddBnt";
            this.GridAddBnt.Size = new System.Drawing.Size(116, 37);
            this.GridAddBnt.TabIndex = 11;
            this.GridAddBnt.Text = "Добавить ";
            this.GridAddBnt.UseVisualStyleBackColor = true;
            this.GridAddBnt.Click += new System.EventHandler(this.GridAddBnt_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(551, 436);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(135, 43);
            this.saveBTN.TabIndex = 12;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(761, 491);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Сведения об абитуриенте";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox AttestatnuberBox;
        private System.Windows.Forms.TextBox passportNumberBox;
        private System.Windows.Forms.TextBox passportSBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GridDelBtn;
        private System.Windows.Forms.Button GridAddBnt;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

