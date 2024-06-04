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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sem2_Lab5_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sem2_Lab5_calc_button = new System.Windows.Forms.Button();
            this.Sem2_Lab5_Save_Excel_button = new System.Windows.Forms.Button();
            this.Sem2_Lab5_Save_TXT_button = new System.Windows.Forms.Button();
            this.Sem2_Lab5_Save_Word_button = new System.Windows.Forms.Button();
            this.Sem2_Lab5_dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem2_Lab5_dataGridView_Twink = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main = new System.Windows.Forms.Button();
            this.Sem2_Lab5_Select_Nums = new System.Windows.Forms.Button();
            this.Sem2_Lab5_Off_selected_cells = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab5_dataGridView_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab5_dataGridView_Twink)).BeginInit();
            this.SuspendLayout();
            // 
            // Sem2_Lab5_exit
            // 
            this.Sem2_Lab5_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_exit.Location = new System.Drawing.Point(1090, 668);
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
            this.label1.Location = new System.Drawing.Point(175, 3);
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
            this.label2.Location = new System.Drawing.Point(669, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Массив заполненый по условию задачи";
            // 
            // Sem2_Lab5_calc_button
            // 
            this.Sem2_Lab5_calc_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_calc_button.Location = new System.Drawing.Point(146, 384);
            this.Sem2_Lab5_calc_button.Name = "Sem2_Lab5_calc_button";
            this.Sem2_Lab5_calc_button.Size = new System.Drawing.Size(225, 75);
            this.Sem2_Lab5_calc_button.TabIndex = 1;
            this.Sem2_Lab5_calc_button.Text = "Результат";
            this.Sem2_Lab5_calc_button.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_calc_button.Click += new System.EventHandler(this.Sem2_Lab5_calc_button_Click);
            // 
            // Sem2_Lab5_Save_Excel_button
            // 
            this.Sem2_Lab5_Save_Excel_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_Save_Excel_button.Location = new System.Drawing.Point(945, 77);
            this.Sem2_Lab5_Save_Excel_button.Name = "Sem2_Lab5_Save_Excel_button";
            this.Sem2_Lab5_Save_Excel_button.Size = new System.Drawing.Size(220, 75);
            this.Sem2_Lab5_Save_Excel_button.TabIndex = 25;
            this.Sem2_Lab5_Save_Excel_button.Text = "Вывести массив в Excel";
            this.Sem2_Lab5_Save_Excel_button.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_Save_Excel_button.Click += new System.EventHandler(this.Sem2_Lab5_Save_Excel_button_Click);
            // 
            // Sem2_Lab5_Save_TXT_button
            // 
            this.Sem2_Lab5_Save_TXT_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_Save_TXT_button.Location = new System.Drawing.Point(493, 77);
            this.Sem2_Lab5_Save_TXT_button.Name = "Sem2_Lab5_Save_TXT_button";
            this.Sem2_Lab5_Save_TXT_button.Size = new System.Drawing.Size(220, 75);
            this.Sem2_Lab5_Save_TXT_button.TabIndex = 26;
            this.Sem2_Lab5_Save_TXT_button.Text = "Вывести и сохранить массив в блокнот";
            this.Sem2_Lab5_Save_TXT_button.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_Save_TXT_button.Click += new System.EventHandler(this.Sem2_Lab5_Save_TXT_button_Click);
            // 
            // Sem2_Lab5_Save_Word_button
            // 
            this.Sem2_Lab5_Save_Word_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_Save_Word_button.Location = new System.Drawing.Point(719, 77);
            this.Sem2_Lab5_Save_Word_button.Name = "Sem2_Lab5_Save_Word_button";
            this.Sem2_Lab5_Save_Word_button.Size = new System.Drawing.Size(220, 75);
            this.Sem2_Lab5_Save_Word_button.TabIndex = 27;
            this.Sem2_Lab5_Save_Word_button.Text = "Вывести массив в Word";
            this.Sem2_Lab5_Save_Word_button.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_Save_Word_button.Click += new System.EventHandler(this.Sem2_Lab5_Save_Word_button_Click);
            // 
            // Sem2_Lab5_dataGridView_Main
            // 
            this.Sem2_Lab5_dataGridView_Main.AllowUserToAddRows = false;
            this.Sem2_Lab5_dataGridView_Main.AllowUserToDeleteRows = false;
            this.Sem2_Lab5_dataGridView_Main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_dataGridView_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Sem2_Lab5_dataGridView_Main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersVisible = false;
            this.Sem2_Lab5_dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.value_x});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sem2_Lab5_dataGridView_Main.DefaultCellStyle = dataGridViewCellStyle26;
            this.Sem2_Lab5_dataGridView_Main.Location = new System.Drawing.Point(12, 28);
            this.Sem2_Lab5_dataGridView_Main.Name = "Sem2_Lab5_dataGridView_Main";
            this.Sem2_Lab5_dataGridView_Main.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.Sem2_Lab5_dataGridView_Main.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sem2_Lab5_dataGridView_Main.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.Sem2_Lab5_dataGridView_Main.Size = new System.Drawing.Size(475, 350);
            this.Sem2_Lab5_dataGridView_Main.TabIndex = 28;
            // 
            // iter
            // 
            this.iter.HeaderText = "i";
            this.iter.Name = "iter";
            this.iter.ReadOnly = true;
            this.iter.Width = 5;
            // 
            // value_x
            // 
            this.value_x.HeaderText = "x";
            this.value_x.Name = "value_x";
            this.value_x.ReadOnly = true;
            this.value_x.Width = 5;
            // 
            // Sem2_Lab5_dataGridView_Twink
            // 
            this.Sem2_Lab5_dataGridView_Twink.AllowUserToAddRows = false;
            this.Sem2_Lab5_dataGridView_Twink.AllowUserToDeleteRows = false;
            this.Sem2_Lab5_dataGridView_Twink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_dataGridView_Twink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Sem2_Lab5_dataGridView_Twink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersVisible = false;
            this.Sem2_Lab5_dataGridView_Twink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sem2_Lab5_dataGridView_Twink.DefaultCellStyle = dataGridViewCellStyle30;
            this.Sem2_Lab5_dataGridView_Twink.Location = new System.Drawing.Point(493, 28);
            this.Sem2_Lab5_dataGridView_Twink.Name = "Sem2_Lab5_dataGridView_Twink";
            this.Sem2_Lab5_dataGridView_Twink.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Twink.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.Sem2_Lab5_dataGridView_Twink.RowHeadersVisible = false;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sem2_Lab5_dataGridView_Twink.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.Sem2_Lab5_dataGridView_Twink.Size = new System.Drawing.Size(679, 43);
            this.Sem2_Lab5_dataGridView_Twink.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "i";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "x";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Sem2_Lab5_Select_Main_Diagonal_dgv_main
            // 
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.Location = new System.Drawing.Point(493, 158);
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.Name = "Sem2_Lab5_Select_Main_Diagonal_dgv_main";
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.Size = new System.Drawing.Size(220, 65);
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.TabIndex = 39;
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.Text = "Выделить главную диагональ";
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_Select_Main_Diagonal_dgv_main.Click += new System.EventHandler(this.Sem2_Lab5_Select_Main_Diagonal_dgv_main_Click);
            // 
            // Sem2_Lab5_Select_Nums
            // 
            this.Sem2_Lab5_Select_Nums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_Select_Nums.Location = new System.Drawing.Point(493, 300);
            this.Sem2_Lab5_Select_Nums.Name = "Sem2_Lab5_Select_Nums";
            this.Sem2_Lab5_Select_Nums.Size = new System.Drawing.Size(220, 65);
            this.Sem2_Lab5_Select_Nums.TabIndex = 41;
            this.Sem2_Lab5_Select_Nums.Text = "Выделить подходящие числа";
            this.Sem2_Lab5_Select_Nums.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_Select_Nums.Click += new System.EventHandler(this.Sem2_Lab5_Select_Nums_Click);
            // 
            // Sem2_Lab5_Off_selected_cells
            // 
            this.Sem2_Lab5_Off_selected_cells.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_Off_selected_cells.Location = new System.Drawing.Point(493, 229);
            this.Sem2_Lab5_Off_selected_cells.Name = "Sem2_Lab5_Off_selected_cells";
            this.Sem2_Lab5_Off_selected_cells.Size = new System.Drawing.Size(220, 65);
            this.Sem2_Lab5_Off_selected_cells.TabIndex = 42;
            this.Sem2_Lab5_Off_selected_cells.Text = "Снять выделение";
            this.Sem2_Lab5_Off_selected_cells.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_Off_selected_cells.Click += new System.EventHandler(this.Sem2_Lab5_Off_selected_cells_Click);
            // 
            // Sem2_CalcLab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.Sem2_Lab5_Off_selected_cells);
            this.Controls.Add(this.Sem2_Lab5_Select_Nums);
            this.Controls.Add(this.Sem2_Lab5_Select_Main_Diagonal_dgv_main);
            this.Controls.Add(this.Sem2_Lab5_dataGridView_Twink);
            this.Controls.Add(this.Sem2_Lab5_dataGridView_Main);
            this.Controls.Add(this.Sem2_Lab5_Save_Word_button);
            this.Controls.Add(this.Sem2_Lab5_Save_TXT_button);
            this.Controls.Add(this.Sem2_Lab5_Save_Excel_button);
            this.Controls.Add(this.Sem2_Lab5_calc_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sem2_Lab5_exit);
            this.Name = "Sem2_CalcLab5";
            this.Text = "Второй семестр | Лабораторная работа №5 | Расчёт";
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
        private System.Windows.Forms.Button Sem2_Lab5_calc_button;
        private System.Windows.Forms.Button Sem2_Lab5_Save_Excel_button;
        private System.Windows.Forms.Button Sem2_Lab5_Save_TXT_button;
        private System.Windows.Forms.Button Sem2_Lab5_Save_Word_button;
        private System.Windows.Forms.DataGridView Sem2_Lab5_dataGridView_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_x;
        private System.Windows.Forms.DataGridView Sem2_Lab5_dataGridView_Twink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Sem2_Lab5_Select_Main_Diagonal_dgv_main;
        private System.Windows.Forms.Button Sem2_Lab5_Select_Nums;
        private System.Windows.Forms.Button Sem2_Lab5_Off_selected_cells;
    }
}