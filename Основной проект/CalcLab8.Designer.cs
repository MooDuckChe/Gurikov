namespace Лабораторная_работа
{
    partial class CalcLab8
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
            this.Lab8_exit = new System.Windows.Forms.Button();
            this.Text_Input_x_lab8 = new System.Windows.Forms.Label();
            this.Text_Input_eps_lab8 = new System.Windows.Forms.Label();
            this.Text_Input_NMax_lab8 = new System.Windows.Forms.Label();
            this.Input_x_lab8 = new System.Windows.Forms.TextBox();
            this.Input_MaxIter_lab8 = new System.Windows.Forms.TextBox();
            this.Input_eps_lab8 = new System.Windows.Forms.TextBox();
            this.Lab8_dataGridView = new System.Windows.Forms.DataGridView();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make_result_lab8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lab8_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab8_exit
            // 
            this.Lab8_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab8_exit.Location = new System.Drawing.Point(490, 674);
            this.Lab8_exit.Name = "Lab8_exit";
            this.Lab8_exit.Size = new System.Drawing.Size(225, 75);
            this.Lab8_exit.TabIndex = 17;
            this.Lab8_exit.Text = "Выход";
            this.Lab8_exit.UseVisualStyleBackColor = true;
            this.Lab8_exit.Click += new System.EventHandler(this.Lab8_exit_Click);
            // 
            // Text_Input_x_lab8
            // 
            this.Text_Input_x_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_x_lab8.AutoSize = true;
            this.Text_Input_x_lab8.Location = new System.Drawing.Point(113, 71);
            this.Text_Input_x_lab8.Name = "Text_Input_x_lab8";
            this.Text_Input_x_lab8.Size = new System.Drawing.Size(112, 13);
            this.Text_Input_x_lab8.TabIndex = 10;
            this.Text_Input_x_lab8.Text = "Введите значение X:";
            // 
            // Text_Input_eps_lab8
            // 
            this.Text_Input_eps_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_eps_lab8.AutoSize = true;
            this.Text_Input_eps_lab8.Location = new System.Drawing.Point(125, 97);
            this.Text_Input_eps_lab8.Name = "Text_Input_eps_lab8";
            this.Text_Input_eps_lab8.Size = new System.Drawing.Size(100, 13);
            this.Text_Input_eps_lab8.TabIndex = 11;
            this.Text_Input_eps_lab8.Text = "Введите точность:";
            // 
            // Text_Input_NMax_lab8
            // 
            this.Text_Input_NMax_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_NMax_lab8.AutoSize = true;
            this.Text_Input_NMax_lab8.Location = new System.Drawing.Point(113, 123);
            this.Text_Input_NMax_lab8.Name = "Text_Input_NMax_lab8";
            this.Text_Input_NMax_lab8.Size = new System.Drawing.Size(117, 13);
            this.Text_Input_NMax_lab8.TabIndex = 12;
            this.Text_Input_NMax_lab8.Text = "Максимум итераций: ";
            // 
            // Input_x_lab8
            // 
            this.Input_x_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_x_lab8.Location = new System.Drawing.Point(231, 68);
            this.Input_x_lab8.Name = "Input_x_lab8";
            this.Input_x_lab8.Size = new System.Drawing.Size(100, 20);
            this.Input_x_lab8.TabIndex = 13;
            this.Input_x_lab8.Text = "5";
            this.Input_x_lab8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_x_lab8_KeyPress);
            // 
            // Input_MaxIter_lab8
            // 
            this.Input_MaxIter_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_MaxIter_lab8.Location = new System.Drawing.Point(231, 120);
            this.Input_MaxIter_lab8.Name = "Input_MaxIter_lab8";
            this.Input_MaxIter_lab8.Size = new System.Drawing.Size(100, 20);
            this.Input_MaxIter_lab8.TabIndex = 15;
            this.Input_MaxIter_lab8.Text = "20";
            this.Input_MaxIter_lab8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_MaxIter_lab8_KeyPress);
            // 
            // Input_eps_lab8
            // 
            this.Input_eps_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_eps_lab8.Location = new System.Drawing.Point(231, 94);
            this.Input_eps_lab8.Name = "Input_eps_lab8";
            this.Input_eps_lab8.Size = new System.Drawing.Size(100, 20);
            this.Input_eps_lab8.TabIndex = 14;
            this.Input_eps_lab8.Text = "0,000001";
            this.Input_eps_lab8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_eps_lab8_KeyPress);
            // 
            // Lab8_dataGridView
            // 
            this.Lab8_dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab8_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lab8_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iter,
            this.value_x});
            this.Lab8_dataGridView.Location = new System.Drawing.Point(611, 12);
            this.Lab8_dataGridView.Name = "Lab8_dataGridView";
            this.Lab8_dataGridView.Size = new System.Drawing.Size(561, 656);
            this.Lab8_dataGridView.TabIndex = 17;
            // 
            // iter
            // 
            this.iter.HeaderText = "i";
            this.iter.Name = "iter";
            this.iter.Width = 259;
            // 
            // value_x
            // 
            this.value_x.HeaderText = "x";
            this.value_x.Name = "value_x";
            this.value_x.ReadOnly = true;
            this.value_x.Width = 259;
            // 
            // Make_result_lab8
            // 
            this.Make_result_lab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Make_result_lab8.Location = new System.Drawing.Point(128, 342);
            this.Make_result_lab8.Name = "Make_result_lab8";
            this.Make_result_lab8.Size = new System.Drawing.Size(263, 90);
            this.Make_result_lab8.TabIndex = 16;
            this.Make_result_lab8.Text = "Рассчитать";
            this.Make_result_lab8.UseVisualStyleBackColor = true;
            this.Make_result_lab8.Click += new System.EventHandler(this.Make_result_lab8_Click);
            // 
            // CalcLab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Make_result_lab8);
            this.Controls.Add(this.Lab8_dataGridView);
            this.Controls.Add(this.Input_eps_lab8);
            this.Controls.Add(this.Input_MaxIter_lab8);
            this.Controls.Add(this.Input_x_lab8);
            this.Controls.Add(this.Text_Input_NMax_lab8);
            this.Controls.Add(this.Text_Input_eps_lab8);
            this.Controls.Add(this.Text_Input_x_lab8);
            this.Controls.Add(this.Lab8_exit);
            this.Name = "CalcLab8";
            this.Text = "Лабораторная работа №8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Lab8_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lab8_exit;
        private System.Windows.Forms.Label Text_Input_x_lab8;
        private System.Windows.Forms.Label Text_Input_eps_lab8;
        private System.Windows.Forms.Label Text_Input_NMax_lab8;
        private System.Windows.Forms.TextBox Input_x_lab8;
        private System.Windows.Forms.TextBox Input_MaxIter_lab8;
        private System.Windows.Forms.TextBox Input_eps_lab8;
        private System.Windows.Forms.DataGridView Lab8_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_x;
        private System.Windows.Forms.Button Make_result_lab8;
    }
}