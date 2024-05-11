namespace Лабораторная_работа
{
    partial class Sem2_CalcLab5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sem2_Lab5_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Sem2_Lab5_dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem2_Lab5_dataGridView_Twink = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab5_dataGridView_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab5_dataGridView_Twink)).BeginInit();
            this.SuspendLayout();
            // 
            // Sem2_Lab5_exit
            // 
            this.Sem2_Lab5_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_exit.Location = new System.Drawing.Point(1090, 674);
            this.Sem2_Lab5_exit.Name = "Sem2_Lab5_exit";
            this.Sem2_Lab5_exit.Size = new System.Drawing.Size(82, 75);
            this.Sem2_Lab5_exit.TabIndex = 19;
            this.Sem2_Lab5_exit.Text = "Выход";
            this.Sem2_Lab5_exit.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_exit.Click += new System.EventHandler(this.Sem2_Lab5_exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(498, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Основной массив";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(417, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Массив заполненый по условию задачи";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(458, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 75);
            this.button1.TabIndex = 24;
            this.button1.Text = "Результат";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(12, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 75);
            this.button2.TabIndex = 25;
            this.button2.Text = "Вывести массив в Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(12, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 75);
            this.button3.TabIndex = 26;
            this.button3.Text = "Вывести и сохранить массив в блокнот";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(12, 657);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 75);
            this.button4.TabIndex = 27;
            this.button4.Text = "Вывести массив в Word";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Sem2_Lab5_dataGridView_Main
            // 
            this.Sem2_Lab5_dataGridView_Main.AllowUserToAddRows = false;
            this.Sem2_Lab5_dataGridView_Main.AllowUserToDeleteRows = false;
            this.Sem2_Lab5_dataGridView_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersVisible = false;
            this.Sem2_Lab5_dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.value_x});
            this.Sem2_Lab5_dataGridView_Main.Location = new System.Drawing.Point(12, 34);
            this.Sem2_Lab5_dataGridView_Main.Name = "Sem2_Lab5_dataGridView_Main";
            this.Sem2_Lab5_dataGridView_Main.ReadOnly = true;
            this.Sem2_Lab5_dataGridView_Main.Size = new System.Drawing.Size(1160, 224);
            this.Sem2_Lab5_dataGridView_Main.TabIndex = 28;
            // 
            // iter
            // 
            this.iter.HeaderText = "i";
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            this.iter.Width = 259;
            // 
            // value_x
            // 
            this.value_x.HeaderText = "x";
            this.value_x.Name = "value_x";
            this.value_x.ReadOnly = true;
            this.value_x.Width = 259;
            // 
            // Sem2_Lab5_dataGridView_Twink
            // 
            this.Sem2_Lab5_dataGridView_Twink.AllowUserToAddRows = false;
            this.Sem2_Lab5_dataGridView_Twink.AllowUserToDeleteRows = false;
            this.Sem2_Lab5_dataGridView_Twink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersVisible = false;
            this.Sem2_Lab5_dataGridView_Twink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Sem2_Lab5_dataGridView_Twink.Location = new System.Drawing.Point(12, 286);
            this.Sem2_Lab5_dataGridView_Twink.Name = "Sem2_Lab5_dataGridView_Twink";
            this.Sem2_Lab5_dataGridView_Twink.ReadOnly = true;
            this.Sem2_Lab5_dataGridView_Twink.Size = new System.Drawing.Size(1160, 203);
            this.Sem2_Lab5_dataGridView_Twink.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "i";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 259;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "x";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 259;
            // 
            // Sem2_CalcLab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Sem2_Lab5_dataGridView_Twink);
            this.Controls.Add(this.Sem2_Lab5_dataGridView_Main);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sem2_Lab5_exit);
            this.Name = "Sem2_CalcLab5";
            this.Text = "Sem2_CalcLab5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab5_dataGridView_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab5_dataGridView_Twink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sem2_Lab5_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView Sem2_Lab5_dataGridView_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_x;
        private System.Windows.Forms.DataGridView Sem2_Lab5_dataGridView_Twink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}