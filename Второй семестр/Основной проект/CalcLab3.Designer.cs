namespace Лабораторная_работа__2
{
    partial class CalcLab3
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
            this.Lab3_exit = new System.Windows.Forms.Button();
            this.lab3_result_y = new System.Windows.Forms.TextBox();
            this.lab3_result_x = new System.Windows.Forms.TextBox();
            this.Text_res_y_lab3 = new System.Windows.Forms.Label();
            this.Text_res_x_lab3 = new System.Windows.Forms.Label();
            this.make_result_lab3 = new System.Windows.Forms.Button();
            this.Input_c1_lab3 = new System.Windows.Forms.TextBox();
            this.Input_b2_lab3 = new System.Windows.Forms.TextBox();
            this.Input_a2_lab3 = new System.Windows.Forms.TextBox();
            this.Input_b1_lab3 = new System.Windows.Forms.TextBox();
            this.Input_a1_lab3 = new System.Windows.Forms.TextBox();
            this.Text_Input_b2_lab3 = new System.Windows.Forms.Label();
            this.Text_Input_c1_lab3 = new System.Windows.Forms.Label();
            this.Text_Input_b1_lab3 = new System.Windows.Forms.Label();
            this.Text_Input_a2_lab3 = new System.Windows.Forms.Label();
            this.Text_Input_a1_lab3 = new System.Windows.Forms.Label();
            this.Input_c2_lab3 = new System.Windows.Forms.TextBox();
            this.Text_Input_c2_lab3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab3_exit
            // 
            this.Lab3_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab3_exit.Location = new System.Drawing.Point(488, 675);
            this.Lab3_exit.Name = "Lab3_exit";
            this.Lab3_exit.Size = new System.Drawing.Size(225, 75);
            this.Lab3_exit.TabIndex = 29;
            this.Lab3_exit.Text = "Выход";
            this.Lab3_exit.UseVisualStyleBackColor = true;
            this.Lab3_exit.Click += new System.EventHandler(this.Lab3_exit_Click);
            // 
            // lab3_result_y
            // 
            this.lab3_result_y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab3_result_y.Location = new System.Drawing.Point(530, 546);
            this.lab3_result_y.Name = "lab3_result_y";
            this.lab3_result_y.ReadOnly = true;
            this.lab3_result_y.Size = new System.Drawing.Size(220, 20);
            this.lab3_result_y.TabIndex = 31;
            this.lab3_result_y.TabStop = false;
            this.lab3_result_y.TextChanged += new System.EventHandler(this.lab3_result_y_TextChanged);
            // 
            // lab3_result_x
            // 
            this.lab3_result_x.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab3_result_x.Location = new System.Drawing.Point(530, 520);
            this.lab3_result_x.Name = "lab3_result_x";
            this.lab3_result_x.ReadOnly = true;
            this.lab3_result_x.Size = new System.Drawing.Size(220, 20);
            this.lab3_result_x.TabIndex = 30;
            this.lab3_result_x.TabStop = false;
            this.lab3_result_x.TextChanged += new System.EventHandler(this.lab3_result_x_TextChanged);
            // 
            // Text_res_y_lab3
            // 
            this.Text_res_y_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_res_y_lab3.AutoSize = true;
            this.Text_res_y_lab3.Location = new System.Drawing.Point(403, 549);
            this.Text_res_y_lab3.Name = "Text_res_y_lab3";
            this.Text_res_y_lab3.Size = new System.Drawing.Size(121, 13);
            this.Text_res_y_lab3.TabIndex = 29;
            this.Text_res_y_lab3.Text = "Точка пересечения Y: ";
            this.Text_res_y_lab3.Click += new System.EventHandler(this.Text_res_y_lab3_Click);
            // 
            // Text_res_x_lab3
            // 
            this.Text_res_x_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_res_x_lab3.AutoSize = true;
            this.Text_res_x_lab3.Location = new System.Drawing.Point(403, 523);
            this.Text_res_x_lab3.Name = "Text_res_x_lab3";
            this.Text_res_x_lab3.Size = new System.Drawing.Size(121, 13);
            this.Text_res_x_lab3.TabIndex = 28;
            this.Text_res_x_lab3.Text = "Точка пересечения X: ";
            this.Text_res_x_lab3.Click += new System.EventHandler(this.Text_res_x_lab3_Click);
            // 
            // make_result_lab3
            // 
            this.make_result_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.make_result_lab3.Location = new System.Drawing.Point(466, 439);
            this.make_result_lab3.Name = "make_result_lab3";
            this.make_result_lab3.Size = new System.Drawing.Size(263, 30);
            this.make_result_lab3.TabIndex = 28;
            this.make_result_lab3.Text = "Рассчитать";
            this.make_result_lab3.UseVisualStyleBackColor = true;
            this.make_result_lab3.Click += new System.EventHandler(this.Make_result_lab3_Click);
            // 
            // Input_c1_lab3
            // 
            this.Input_c1_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_c1_lab3.Location = new System.Drawing.Point(778, 301);
            this.Input_c1_lab3.Name = "Input_c1_lab3";
            this.Input_c1_lab3.Size = new System.Drawing.Size(200, 20);
            this.Input_c1_lab3.TabIndex = 24;
            this.Input_c1_lab3.TextChanged += new System.EventHandler(this.Input_c1_lab3_TextChanged);
            this.Input_c1_lab3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_c1_lab3_KeyPress);
            // 
            // Input_b2_lab3
            // 
            this.Input_b2_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_b2_lab3.Location = new System.Drawing.Point(500, 327);
            this.Input_b2_lab3.Name = "Input_b2_lab3";
            this.Input_b2_lab3.Size = new System.Drawing.Size(200, 20);
            this.Input_b2_lab3.TabIndex = 26;
            this.Input_b2_lab3.TextChanged += new System.EventHandler(this.Input_b2_lab3_TextChanged);
            this.Input_b2_lab3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_b2_lab3_KeyPress);
            // 
            // Input_a2_lab3
            // 
            this.Input_a2_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_a2_lab3.Location = new System.Drawing.Point(221, 326);
            this.Input_a2_lab3.Name = "Input_a2_lab3";
            this.Input_a2_lab3.Size = new System.Drawing.Size(200, 20);
            this.Input_a2_lab3.TabIndex = 25;
            this.Input_a2_lab3.TextChanged += new System.EventHandler(this.Input_a2_lab3_TextChanged);
            this.Input_a2_lab3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_a2_lab3_KeyPress);
            // 
            // Input_b1_lab3
            // 
            this.Input_b1_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_b1_lab3.Location = new System.Drawing.Point(500, 301);
            this.Input_b1_lab3.Name = "Input_b1_lab3";
            this.Input_b1_lab3.Size = new System.Drawing.Size(200, 20);
            this.Input_b1_lab3.TabIndex = 23;
            this.Input_b1_lab3.TextChanged += new System.EventHandler(this.Input_b1_lab3_TextChanged);
            this.Input_b1_lab3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_b1_lab3_KeyPress);
            // 
            // Input_a1_lab3
            // 
            this.Input_a1_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_a1_lab3.Location = new System.Drawing.Point(221, 300);
            this.Input_a1_lab3.Name = "Input_a1_lab3";
            this.Input_a1_lab3.Size = new System.Drawing.Size(200, 20);
            this.Input_a1_lab3.TabIndex = 22;
            this.Input_a1_lab3.TextChanged += new System.EventHandler(this.Input_a1_lab3_TextChanged);
            this.Input_a1_lab3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_a1_lab3_KeyPress);
            // 
            // Text_Input_b2_lab3
            // 
            this.Text_Input_b2_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_b2_lab3.AutoSize = true;
            this.Text_Input_b2_lab3.Location = new System.Drawing.Point(427, 330);
            this.Text_Input_b2_lab3.Name = "Text_Input_b2_lab3";
            this.Text_Input_b2_lab3.Size = new System.Drawing.Size(70, 13);
            this.Text_Input_b2_lab3.TabIndex = 21;
            this.Text_Input_b2_lab3.Text = "Введите b2: ";
            this.Text_Input_b2_lab3.Click += new System.EventHandler(this.Text_Input_b2_lab3_Click);
            // 
            // Text_Input_c1_lab3
            // 
            this.Text_Input_c1_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_c1_lab3.AutoSize = true;
            this.Text_Input_c1_lab3.Location = new System.Drawing.Point(705, 304);
            this.Text_Input_c1_lab3.Name = "Text_Input_c1_lab3";
            this.Text_Input_c1_lab3.Size = new System.Drawing.Size(67, 13);
            this.Text_Input_c1_lab3.TabIndex = 20;
            this.Text_Input_c1_lab3.Text = "Введите c1:";
            this.Text_Input_c1_lab3.Click += new System.EventHandler(this.Text_Input_c1_lab3_Click);
            // 
            // Text_Input_b1_lab3
            // 
            this.Text_Input_b1_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_b1_lab3.AutoSize = true;
            this.Text_Input_b1_lab3.Location = new System.Drawing.Point(427, 304);
            this.Text_Input_b1_lab3.Name = "Text_Input_b1_lab3";
            this.Text_Input_b1_lab3.Size = new System.Drawing.Size(67, 13);
            this.Text_Input_b1_lab3.TabIndex = 19;
            this.Text_Input_b1_lab3.Text = "Введите b1:";
            this.Text_Input_b1_lab3.Click += new System.EventHandler(this.Text_Input_b1_lab3_Click);
            // 
            // Text_Input_a2_lab3
            // 
            this.Text_Input_a2_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_a2_lab3.AutoSize = true;
            this.Text_Input_a2_lab3.Location = new System.Drawing.Point(145, 329);
            this.Text_Input_a2_lab3.Name = "Text_Input_a2_lab3";
            this.Text_Input_a2_lab3.Size = new System.Drawing.Size(70, 13);
            this.Text_Input_a2_lab3.TabIndex = 18;
            this.Text_Input_a2_lab3.Text = "Введите a2: ";
            this.Text_Input_a2_lab3.Click += new System.EventHandler(this.Text_Input_a2_lab3_Click);
            // 
            // Text_Input_a1_lab3
            // 
            this.Text_Input_a1_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_a1_lab3.AutoSize = true;
            this.Text_Input_a1_lab3.Location = new System.Drawing.Point(145, 303);
            this.Text_Input_a1_lab3.Name = "Text_Input_a1_lab3";
            this.Text_Input_a1_lab3.Size = new System.Drawing.Size(70, 13);
            this.Text_Input_a1_lab3.TabIndex = 17;
            this.Text_Input_a1_lab3.Text = "Введите a1: ";
            this.Text_Input_a1_lab3.Click += new System.EventHandler(this.Text_Input_a1_lab3_Click);
            // 
            // Input_c2_lab3
            // 
            this.Input_c2_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Input_c2_lab3.Location = new System.Drawing.Point(778, 327);
            this.Input_c2_lab3.Name = "Input_c2_lab3";
            this.Input_c2_lab3.Size = new System.Drawing.Size(200, 20);
            this.Input_c2_lab3.TabIndex = 27;
            this.Input_c2_lab3.TextChanged += new System.EventHandler(this.Input_c2_lab3_TextChanged);
            this.Input_c2_lab3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_c2_lab3_KeyPress);
            // 
            // Text_Input_c2_lab3
            // 
            this.Text_Input_c2_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Text_Input_c2_lab3.AutoSize = true;
            this.Text_Input_c2_lab3.Location = new System.Drawing.Point(705, 330);
            this.Text_Input_c2_lab3.Name = "Text_Input_c2_lab3";
            this.Text_Input_c2_lab3.Size = new System.Drawing.Size(67, 13);
            this.Text_Input_c2_lab3.TabIndex = 33;
            this.Text_Input_c2_lab3.Text = "Введите c2:";
            this.Text_Input_c2_lab3.Click += new System.EventHandler(this.Text_Input_c2_lab3_Click);
            // 
            // CalcLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Input_c2_lab3);
            this.Controls.Add(this.Text_Input_c2_lab3);
            this.Controls.Add(this.Lab3_exit);
            this.Controls.Add(this.lab3_result_y);
            this.Controls.Add(this.lab3_result_x);
            this.Controls.Add(this.Text_res_y_lab3);
            this.Controls.Add(this.Text_res_x_lab3);
            this.Controls.Add(this.make_result_lab3);
            this.Controls.Add(this.Input_c1_lab3);
            this.Controls.Add(this.Input_b2_lab3);
            this.Controls.Add(this.Input_a2_lab3);
            this.Controls.Add(this.Input_b1_lab3);
            this.Controls.Add(this.Input_a1_lab3);
            this.Controls.Add(this.Text_Input_b2_lab3);
            this.Controls.Add(this.Text_Input_c1_lab3);
            this.Controls.Add(this.Text_Input_b1_lab3);
            this.Controls.Add(this.Text_Input_a2_lab3);
            this.Controls.Add(this.Text_Input_a1_lab3);
            this.Name = "CalcLab3";
            this.Text = "Лабораторная работа №3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lab3_exit;
        private System.Windows.Forms.TextBox lab3_result_y;
        private System.Windows.Forms.TextBox lab3_result_x;
        private System.Windows.Forms.Label Text_res_y_lab3;
        private System.Windows.Forms.Label Text_res_x_lab3;
        private System.Windows.Forms.Button make_result_lab3;
        private System.Windows.Forms.TextBox Input_c1_lab3;
        private System.Windows.Forms.TextBox Input_b2_lab3;
        private System.Windows.Forms.TextBox Input_a2_lab3;
        private System.Windows.Forms.TextBox Input_b1_lab3;
        private System.Windows.Forms.TextBox Input_a1_lab3;
        private System.Windows.Forms.Label Text_Input_b2_lab3;
        private System.Windows.Forms.Label Text_Input_c1_lab3;
        private System.Windows.Forms.Label Text_Input_b1_lab3;
        private System.Windows.Forms.Label Text_Input_a2_lab3;
        private System.Windows.Forms.Label Text_Input_a1_lab3;
        private System.Windows.Forms.TextBox Input_c2_lab3;
        private System.Windows.Forms.Label Text_Input_c2_lab3;
    }
}