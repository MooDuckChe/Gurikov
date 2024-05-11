namespace Лабораторная_работа
{
    partial class CalcLab6
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
            this.Lab6_Table_Values = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text_Input_x_lab6 = new System.Windows.Forms.Label();
            this.Text_Input_a_lab6 = new System.Windows.Forms.Label();
            this.Text_Input_y_lab6 = new System.Windows.Forms.Label();
            this.Text_Input_step_lab6 = new System.Windows.Forms.Label();
            this.Input_x_lab6 = new System.Windows.Forms.TextBox();
            this.Input_y_lab6 = new System.Windows.Forms.TextBox();
            this.Input_a_lab6 = new System.Windows.Forms.TextBox();
            this.Text_Input_end_cycle_lab6 = new System.Windows.Forms.Label();
            this.Input_step_lab6 = new System.Windows.Forms.TextBox();
            this.Input_end_cycle_lab6 = new System.Windows.Forms.TextBox();
            this.make_result_lab6 = new System.Windows.Forms.Button();
            this.Output_result_min_lab6 = new System.Windows.Forms.TextBox();
            this.Output_result_average_under_zero_lab6 = new System.Windows.Forms.TextBox();
            this.Text_Output_min_lab6 = new System.Windows.Forms.Label();
            this.Text_Output_average_under_zero_lab6 = new System.Windows.Forms.Label();
            this.Lab6_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lab6_Table_Values)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab6_Table_Values
            // 
            this.Lab6_Table_Values.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab6_Table_Values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lab6_Table_Values.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.d});
            this.Lab6_Table_Values.Location = new System.Drawing.Point(610, 25);
            this.Lab6_Table_Values.Name = "Lab6_Table_Values";
            this.Lab6_Table_Values.ReadOnly = true;
            this.Lab6_Table_Values.ShowEditingIcon = false;
            this.Lab6_Table_Values.Size = new System.Drawing.Size(550, 757);
            this.Lab6_Table_Values.TabIndex = 0;
            this.Lab6_Table_Values.TabStop = false;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 10;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 255;
            // 
            // d
            // 
            this.d.HeaderText = "d";
            this.d.MinimumWidth = 10;
            this.d.Name = "d";
            this.d.ReadOnly = true;
            this.d.Width = 255;
            // 
            // Text_Input_x_lab6
            // 
            this.Text_Input_x_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_x_lab6.AutoSize = true;
            this.Text_Input_x_lab6.Location = new System.Drawing.Point(89, 117);
            this.Text_Input_x_lab6.Name = "Text_Input_x_lab6";
            this.Text_Input_x_lab6.Size = new System.Drawing.Size(110, 13);
            this.Text_Input_x_lab6.TabIndex = 1;
            this.Text_Input_x_lab6.Text = "Введите значение x:";
            // 
            // Text_Input_a_lab6
            // 
            this.Text_Input_a_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_a_lab6.AutoSize = true;
            this.Text_Input_a_lab6.Location = new System.Drawing.Point(88, 91);
            this.Text_Input_a_lab6.Name = "Text_Input_a_lab6";
            this.Text_Input_a_lab6.Size = new System.Drawing.Size(111, 13);
            this.Text_Input_a_lab6.TabIndex = 2;
            this.Text_Input_a_lab6.Text = "Введите значение a:";
            // 
            // Text_Input_y_lab6
            // 
            this.Text_Input_y_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_y_lab6.AutoSize = true;
            this.Text_Input_y_lab6.Location = new System.Drawing.Point(89, 143);
            this.Text_Input_y_lab6.Name = "Text_Input_y_lab6";
            this.Text_Input_y_lab6.Size = new System.Drawing.Size(110, 13);
            this.Text_Input_y_lab6.TabIndex = 3;
            this.Text_Input_y_lab6.Text = "Введите значение y:";
            // 
            // Text_Input_step_lab6
            // 
            this.Text_Input_step_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_step_lab6.AutoSize = true;
            this.Text_Input_step_lab6.Location = new System.Drawing.Point(89, 217);
            this.Text_Input_step_lab6.Name = "Text_Input_step_lab6";
            this.Text_Input_step_lab6.Size = new System.Drawing.Size(107, 13);
            this.Text_Input_step_lab6.TabIndex = 5;
            this.Text_Input_step_lab6.Text = "Введите шаг цикла:";
            // 
            // Input_x_lab6
            // 
            this.Input_x_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_x_lab6.Location = new System.Drawing.Point(205, 114);
            this.Input_x_lab6.Name = "Input_x_lab6";
            this.Input_x_lab6.Size = new System.Drawing.Size(100, 20);
            this.Input_x_lab6.TabIndex = 2;
            this.Input_x_lab6.Text = "-0,09";
            this.Input_x_lab6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_x_lab6_KeyPress);
            // 
            // Input_y_lab6
            // 
            this.Input_y_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_y_lab6.Location = new System.Drawing.Point(205, 140);
            this.Input_y_lab6.Name = "Input_y_lab6";
            this.Input_y_lab6.Size = new System.Drawing.Size(100, 20);
            this.Input_y_lab6.TabIndex = 3;
            this.Input_y_lab6.Text = "1";
            this.Input_y_lab6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_y_lab6_KeyPress);
            // 
            // Input_a_lab6
            // 
            this.Input_a_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_a_lab6.Location = new System.Drawing.Point(205, 88);
            this.Input_a_lab6.Name = "Input_a_lab6";
            this.Input_a_lab6.Size = new System.Drawing.Size(100, 20);
            this.Input_a_lab6.TabIndex = 1;
            this.Input_a_lab6.Text = "1";
            this.Input_a_lab6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_a_lab6_KeyPress);
            // 
            // Text_Input_end_cycle_lab6
            // 
            this.Text_Input_end_cycle_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_end_cycle_lab6.AutoSize = true;
            this.Text_Input_end_cycle_lab6.Location = new System.Drawing.Point(89, 243);
            this.Text_Input_end_cycle_lab6.Name = "Text_Input_end_cycle_lab6";
            this.Text_Input_end_cycle_lab6.Size = new System.Drawing.Size(118, 13);
            this.Text_Input_end_cycle_lab6.TabIndex = 6;
            this.Text_Input_end_cycle_lab6.Text = "Введите конец цикла:";
            // 
            // Input_step_lab6
            // 
            this.Input_step_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_step_lab6.Location = new System.Drawing.Point(213, 214);
            this.Input_step_lab6.Name = "Input_step_lab6";
            this.Input_step_lab6.Size = new System.Drawing.Size(100, 20);
            this.Input_step_lab6.TabIndex = 4;
            this.Input_step_lab6.Text = "1";
            this.Input_step_lab6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_step_lab6_KeyPress);
            // 
            // Input_end_cycle_lab6
            // 
            this.Input_end_cycle_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_end_cycle_lab6.Location = new System.Drawing.Point(213, 240);
            this.Input_end_cycle_lab6.Name = "Input_end_cycle_lab6";
            this.Input_end_cycle_lab6.Size = new System.Drawing.Size(100, 20);
            this.Input_end_cycle_lab6.TabIndex = 5;
            this.Input_end_cycle_lab6.Text = "19";
            this.Input_end_cycle_lab6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_end_cycle_lab6_KeyPress);
            // 
            // make_result_lab6
            // 
            this.make_result_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.make_result_lab6.Location = new System.Drawing.Point(92, 278);
            this.make_result_lab6.Name = "make_result_lab6";
            this.make_result_lab6.Size = new System.Drawing.Size(225, 75);
            this.make_result_lab6.TabIndex = 6;
            this.make_result_lab6.Text = "Рассчитать";
            this.make_result_lab6.UseVisualStyleBackColor = true;
            this.make_result_lab6.Click += new System.EventHandler(this.Make_result_lab6_Click);
            // 
            // Output_result_min_lab6
            // 
            this.Output_result_min_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Output_result_min_lab6.Location = new System.Drawing.Point(228, 406);
            this.Output_result_min_lab6.Name = "Output_result_min_lab6";
            this.Output_result_min_lab6.ReadOnly = true;
            this.Output_result_min_lab6.Size = new System.Drawing.Size(200, 20);
            this.Output_result_min_lab6.TabIndex = 10;
            // 
            // Output_result_average_under_zero_lab6
            // 
            this.Output_result_average_under_zero_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Output_result_average_under_zero_lab6.Location = new System.Drawing.Point(369, 435);
            this.Output_result_average_under_zero_lab6.Name = "Output_result_average_under_zero_lab6";
            this.Output_result_average_under_zero_lab6.ReadOnly = true;
            this.Output_result_average_under_zero_lab6.Size = new System.Drawing.Size(200, 20);
            this.Output_result_average_under_zero_lab6.TabIndex = 11;
            // 
            // Text_Output_min_lab6
            // 
            this.Text_Output_min_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Output_min_lab6.AutoSize = true;
            this.Text_Output_min_lab6.Location = new System.Drawing.Point(91, 409);
            this.Text_Output_min_lab6.Name = "Text_Output_min_lab6";
            this.Text_Output_min_lab6.Size = new System.Drawing.Size(131, 13);
            this.Text_Output_min_lab6.TabIndex = 12;
            this.Text_Output_min_lab6.Text = "Минимальное значение:";
            // 
            // Text_Output_average_under_zero_lab6
            // 
            this.Text_Output_average_under_zero_lab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Output_average_under_zero_lab6.AutoSize = true;
            this.Text_Output_average_under_zero_lab6.Location = new System.Drawing.Point(91, 438);
            this.Text_Output_average_under_zero_lab6.Name = "Text_Output_average_under_zero_lab6";
            this.Text_Output_average_under_zero_lab6.Size = new System.Drawing.Size(272, 13);
            this.Text_Output_average_under_zero_lab6.TabIndex = 13;
            this.Text_Output_average_under_zero_lab6.Text = "Среднее арифметическое отрацательных значений:\r\n";
            // 
            // Lab6_exit
            // 
            this.Lab6_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab6_exit.Location = new System.Drawing.Point(179, 668);
            this.Lab6_exit.Name = "Lab6_exit";
            this.Lab6_exit.Size = new System.Drawing.Size(225, 75);
            this.Lab6_exit.TabIndex = 14;
            this.Lab6_exit.Text = "Выход";
            this.Lab6_exit.UseVisualStyleBackColor = true;
            this.Lab6_exit.Click += new System.EventHandler(this.Lab6_exit_Click);
            // 
            // CalcLab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Lab6_exit);
            this.Controls.Add(this.Text_Output_average_under_zero_lab6);
            this.Controls.Add(this.Text_Output_min_lab6);
            this.Controls.Add(this.Output_result_average_under_zero_lab6);
            this.Controls.Add(this.Output_result_min_lab6);
            this.Controls.Add(this.make_result_lab6);
            this.Controls.Add(this.Input_end_cycle_lab6);
            this.Controls.Add(this.Input_step_lab6);
            this.Controls.Add(this.Text_Input_end_cycle_lab6);
            this.Controls.Add(this.Input_a_lab6);
            this.Controls.Add(this.Input_y_lab6);
            this.Controls.Add(this.Input_x_lab6);
            this.Controls.Add(this.Text_Input_step_lab6);
            this.Controls.Add(this.Text_Input_y_lab6);
            this.Controls.Add(this.Text_Input_a_lab6);
            this.Controls.Add(this.Text_Input_x_lab6);
            this.Controls.Add(this.Lab6_Table_Values);
            this.Name = "CalcLab6";
            this.Text = "Лабораторная работа №6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Lab6_Table_Values)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Lab6_Table_Values;
        private System.Windows.Forms.Label Text_Input_x_lab6;
        private System.Windows.Forms.Label Text_Input_a_lab6;
        private System.Windows.Forms.Label Text_Input_y_lab6;
        private System.Windows.Forms.Label Text_Input_step_lab6;
        private System.Windows.Forms.TextBox Input_x_lab6;
        private System.Windows.Forms.TextBox Input_y_lab6;
        private System.Windows.Forms.TextBox Input_a_lab6;
        private System.Windows.Forms.Label Text_Input_end_cycle_lab6;
        private System.Windows.Forms.TextBox Input_step_lab6;
        private System.Windows.Forms.TextBox Input_end_cycle_lab6;
        private System.Windows.Forms.Button make_result_lab6;
        private System.Windows.Forms.TextBox Output_result_min_lab6;
        private System.Windows.Forms.TextBox Output_result_average_under_zero_lab6;
        private System.Windows.Forms.Label Text_Output_min_lab6;
        private System.Windows.Forms.Label Text_Output_average_under_zero_lab6;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn d;
        private System.Windows.Forms.Button Lab6_exit;
    }
}