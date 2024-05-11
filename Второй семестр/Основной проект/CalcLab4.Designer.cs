namespace Лабораторная_работа__2
{
    partial class CalcLab4
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
            this.Input_a_lab4 = new System.Windows.Forms.TextBox();
            this.Input_x_lab4 = new System.Windows.Forms.TextBox();
            this.Input_y_lab4 = new System.Windows.Forms.TextBox();
            this.Text_Input_a_lab4 = new System.Windows.Forms.Label();
            this.Text_Input_x_lab4 = new System.Windows.Forms.Label();
            this.Text_Input_y_lab4 = new System.Windows.Forms.Label();
            this.Text_res_d_lab4 = new System.Windows.Forms.Label();
            this.lab4_result_d = new System.Windows.Forms.TextBox();
            this.Lab4_exit = new System.Windows.Forms.Button();
            this.make_result_lab4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_a_lab4
            // 
            this.Input_a_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_a_lab4.Location = new System.Drawing.Point(567, 321);
            this.Input_a_lab4.Name = "Input_a_lab4";
            this.Input_a_lab4.Size = new System.Drawing.Size(100, 20);
            this.Input_a_lab4.TabIndex = 0;
            this.Input_a_lab4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_a_lab4_KeyPress);
            // 
            // Input_x_lab4
            // 
            this.Input_x_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_x_lab4.Location = new System.Drawing.Point(566, 347);
            this.Input_x_lab4.Name = "Input_x_lab4";
            this.Input_x_lab4.Size = new System.Drawing.Size(100, 20);
            this.Input_x_lab4.TabIndex = 1;
            this.Input_x_lab4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_x_lab4_KeyPress);
            // 
            // Input_y_lab4
            // 
            this.Input_y_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_y_lab4.Location = new System.Drawing.Point(566, 373);
            this.Input_y_lab4.Name = "Input_y_lab4";
            this.Input_y_lab4.Size = new System.Drawing.Size(100, 20);
            this.Input_y_lab4.TabIndex = 2;
            this.Input_y_lab4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_y_lab4_KeyPress);
            // 
            // Text_Input_a_lab4
            // 
            this.Text_Input_a_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_a_lab4.AutoSize = true;
            this.Text_Input_a_lab4.Location = new System.Drawing.Point(500, 324);
            this.Text_Input_a_lab4.Name = "Text_Input_a_lab4";
            this.Text_Input_a_lab4.Size = new System.Drawing.Size(61, 13);
            this.Text_Input_a_lab4.TabIndex = 3;
            this.Text_Input_a_lab4.Text = "Введите a:";
            // 
            // Text_Input_x_lab4
            // 
            this.Text_Input_x_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_x_lab4.AutoSize = true;
            this.Text_Input_x_lab4.Location = new System.Drawing.Point(500, 350);
            this.Text_Input_x_lab4.Name = "Text_Input_x_lab4";
            this.Text_Input_x_lab4.Size = new System.Drawing.Size(60, 13);
            this.Text_Input_x_lab4.TabIndex = 4;
            this.Text_Input_x_lab4.Text = "Введите x:";
            // 
            // Text_Input_y_lab4
            // 
            this.Text_Input_y_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_y_lab4.AutoSize = true;
            this.Text_Input_y_lab4.Location = new System.Drawing.Point(500, 376);
            this.Text_Input_y_lab4.Name = "Text_Input_y_lab4";
            this.Text_Input_y_lab4.Size = new System.Drawing.Size(60, 13);
            this.Text_Input_y_lab4.TabIndex = 5;
            this.Text_Input_y_lab4.Text = "Введите y:";
            // 
            // Text_res_d_lab4
            // 
            this.Text_res_d_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_res_d_lab4.AutoSize = true;
            this.Text_res_d_lab4.Location = new System.Drawing.Point(430, 534);
            this.Text_res_d_lab4.Name = "Text_res_d_lab4";
            this.Text_res_d_lab4.Size = new System.Drawing.Size(67, 13);
            this.Text_res_d_lab4.TabIndex = 6;
            this.Text_res_d_lab4.Text = "Значение d:";
            // 
            // lab4_result_d
            // 
            this.lab4_result_d.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab4_result_d.Location = new System.Drawing.Point(503, 531);
            this.lab4_result_d.Name = "lab4_result_d";
            this.lab4_result_d.ReadOnly = true;
            this.lab4_result_d.Size = new System.Drawing.Size(220, 20);
            this.lab4_result_d.TabIndex = 7;
            // 
            // Lab4_exit
            // 
            this.Lab4_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab4_exit.Location = new System.Drawing.Point(484, 674);
            this.Lab4_exit.Name = "Lab4_exit";
            this.Lab4_exit.Size = new System.Drawing.Size(225, 75);
            this.Lab4_exit.TabIndex = 8;
            this.Lab4_exit.Text = "Выход";
            this.Lab4_exit.UseVisualStyleBackColor = true;
            this.Lab4_exit.Click += new System.EventHandler(this.Lab4_exit_Click);
            // 
            // make_result_lab4
            // 
            this.make_result_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.make_result_lab4.Location = new System.Drawing.Point(460, 443);
            this.make_result_lab4.Name = "make_result_lab4";
            this.make_result_lab4.Size = new System.Drawing.Size(263, 30);
            this.make_result_lab4.TabIndex = 9;
            this.make_result_lab4.Text = "Рассчитать";
            this.make_result_lab4.UseVisualStyleBackColor = true;
            this.make_result_lab4.Click += new System.EventHandler(this.Make_result_lab4_Click);
            // 
            // CalcLab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.make_result_lab4);
            this.Controls.Add(this.Lab4_exit);
            this.Controls.Add(this.lab4_result_d);
            this.Controls.Add(this.Text_res_d_lab4);
            this.Controls.Add(this.Text_Input_y_lab4);
            this.Controls.Add(this.Text_Input_x_lab4);
            this.Controls.Add(this.Text_Input_a_lab4);
            this.Controls.Add(this.Input_y_lab4);
            this.Controls.Add(this.Input_x_lab4);
            this.Controls.Add(this.Input_a_lab4);
            this.Name = "CalcLab4";
            this.Text = "Лабораторная работа №4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_a_lab4;
        private System.Windows.Forms.TextBox Input_x_lab4;
        private System.Windows.Forms.TextBox Input_y_lab4;
        private System.Windows.Forms.Label Text_Input_a_lab4;
        private System.Windows.Forms.Label Text_Input_x_lab4;
        private System.Windows.Forms.Label Text_Input_y_lab4;
        private System.Windows.Forms.Label Text_res_d_lab4;
        private System.Windows.Forms.TextBox lab4_result_d;
        private System.Windows.Forms.Button Lab4_exit;
        private System.Windows.Forms.Button make_result_lab4;
    }
}