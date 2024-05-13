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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sem2_Lab5_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sem2_Lab5_calc_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Sem2_Lab5_dataGridView_Main = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem2_Lab5_dataGridView_Twink = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(219, 9);
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
            this.label2.Location = new System.Drawing.Point(701, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Массив заполненый по условию задачи";
            // 
            // Sem2_Lab5_calc_button
            // 
            this.Sem2_Lab5_calc_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab5_calc_button.Location = new System.Drawing.Point(474, 490);
            this.Sem2_Lab5_calc_button.Name = "Sem2_Lab5_calc_button";
            this.Sem2_Lab5_calc_button.Size = new System.Drawing.Size(225, 75);
            this.Sem2_Lab5_calc_button.TabIndex = 1;
            this.Sem2_Lab5_calc_button.Text = "Результат";
            this.Sem2_Lab5_calc_button.UseVisualStyleBackColor = true;
            this.Sem2_Lab5_calc_button.Click += new System.EventHandler(this.Sem2_Lab5_calc_button_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(705, 674);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 75);
            this.button2.TabIndex = 25;
            this.button2.Text = "Вывести массив в Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(243, 674);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 75);
            this.button3.TabIndex = 26;
            this.button3.Text = "Вывести и сохранить массив в блокнот";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(474, 674);
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
            this.Sem2_Lab5_dataGridView_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Sem2_Lab5_dataGridView_Main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sem2_Lab5_dataGridView_Main.ColumnHeadersVisible = false;
            this.Sem2_Lab5_dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.value_x});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sem2_Lab5_dataGridView_Main.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sem2_Lab5_dataGridView_Main.Location = new System.Drawing.Point(12, 34);
            this.Sem2_Lab5_dataGridView_Main.Name = "Sem2_Lab5_dataGridView_Main";
            this.Sem2_Lab5_dataGridView_Main.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Sem2_Lab5_dataGridView_Main.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sem2_Lab5_dataGridView_Main.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Sem2_Lab5_dataGridView_Main.Size = new System.Drawing.Size(575, 450);
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
            this.Sem2_Lab5_dataGridView_Twink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Sem2_Lab5_dataGridView_Twink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sem2_Lab5_dataGridView_Twink.ColumnHeadersVisible = false;
            this.Sem2_Lab5_dataGridView_Twink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sem2_Lab5_dataGridView_Twink.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sem2_Lab5_dataGridView_Twink.Location = new System.Drawing.Point(597, 34);
            this.Sem2_Lab5_dataGridView_Twink.Name = "Sem2_Lab5_dataGridView_Twink";
            this.Sem2_Lab5_dataGridView_Twink.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sem2_Lab5_dataGridView_Twink.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Sem2_Lab5_dataGridView_Twink.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sem2_Lab5_dataGridView_Twink.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Sem2_Lab5_dataGridView_Twink.Size = new System.Drawing.Size(575, 450);
            this.Sem2_Lab5_dataGridView_Twink.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "i";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "x";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(12, 490);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 75);
            this.button6.TabIndex = 33;
            this.button6.Text = "Sem2_Lab5_Replace_Num_Var1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(12, 652);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 75);
            this.button1.TabIndex = 34;
            this.button1.Text = "Sem2_Lab5_Replace_Num_Var3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(12, 571);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 75);
            this.button5.TabIndex = 35;
            this.button5.Text = "Sem2_Lab5_Replace_Num_Var2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 65);
            this.label3.TabIndex = 36;
            this.label3.Text = "Я не знал что делать \r\nс числами которые \r\nне подходят под \r\nусловие поэтому \r\nво" +
    "т 3 варианта ";
            this.label3.Visible = false;
            // 
            // Sem2_CalcLab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Sem2_Lab5_dataGridView_Twink);
            this.Controls.Add(this.Sem2_Lab5_dataGridView_Main);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sem2_Lab5_calc_button);
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
        private System.Windows.Forms.Button Sem2_Lab5_calc_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView Sem2_Lab5_dataGridView_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_x;
        private System.Windows.Forms.DataGridView Sem2_Lab5_dataGridView_Twink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}