namespace Лабораторная_работа__2
{
    partial class ChooseLab
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
            this.Btn_goto_lab2 = new System.Windows.Forms.Button();
            this.Btn_goto_lab3 = new System.Windows.Forms.Button();
            this.Btn_goto_lab4 = new System.Windows.Forms.Button();
            this.Btn_goto_lab5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_goto_lab2
            // 
            this.Btn_goto_lab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_lab2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_goto_lab2.Location = new System.Drawing.Point(250, 300);
            this.Btn_goto_lab2.Name = "Btn_goto_lab2";
            this.Btn_goto_lab2.Size = new System.Drawing.Size(200, 75);
            this.Btn_goto_lab2.TabIndex = 0;
            this.Btn_goto_lab2.Text = "Лабораторная работа №2";
            this.Btn_goto_lab2.UseVisualStyleBackColor = true;
            this.Btn_goto_lab2.Click += new System.EventHandler(this.Btn_goto_lab2_Click);
            // 
            // Btn_goto_lab3
            // 
            this.Btn_goto_lab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_lab3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_goto_lab3.Location = new System.Drawing.Point(700, 300);
            this.Btn_goto_lab3.Name = "Btn_goto_lab3";
            this.Btn_goto_lab3.Size = new System.Drawing.Size(200, 75);
            this.Btn_goto_lab3.TabIndex = 1;
            this.Btn_goto_lab3.Text = "Лабораторная работа №3";
            this.Btn_goto_lab3.UseVisualStyleBackColor = true;
            this.Btn_goto_lab3.Click += new System.EventHandler(this.Btn_goto_lab3_Click);
            // 
            // Btn_goto_lab4
            // 
            this.Btn_goto_lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_lab4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_goto_lab4.Location = new System.Drawing.Point(472, 462);
            this.Btn_goto_lab4.Name = "Btn_goto_lab4";
            this.Btn_goto_lab4.Size = new System.Drawing.Size(200, 75);
            this.Btn_goto_lab4.TabIndex = 4;
            this.Btn_goto_lab4.Text = "Лабораторная работа №4\r\n";
            this.Btn_goto_lab4.UseVisualStyleBackColor = true;
            this.Btn_goto_lab4.Click += new System.EventHandler(this.Btn_goto_lab4_Click);
            // 
            // Btn_goto_lab5
            // 
            this.Btn_goto_lab5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_lab5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_goto_lab5.Location = new System.Drawing.Point(700, 462);
            this.Btn_goto_lab5.Name = "Btn_goto_lab5";
            this.Btn_goto_lab5.Size = new System.Drawing.Size(200, 75);
            this.Btn_goto_lab5.TabIndex = 5;
            this.Btn_goto_lab5.Text = "Лабораторная работа №5\r\n";
            this.Btn_goto_lab5.UseVisualStyleBackColor = true;
            this.Btn_goto_lab5.Visible = false;
            // 
            // ChooseLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Btn_goto_lab5);
            this.Controls.Add(this.Btn_goto_lab4);
            this.Controls.Add(this.Btn_goto_lab3);
            this.Controls.Add(this.Btn_goto_lab2);
            this.Name = "ChooseLab";
            this.Text = "Выбрать лабораторную работу";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_goto_lab2;
        private System.Windows.Forms.Button Btn_goto_lab3;
        private System.Windows.Forms.Button Btn_goto_lab4;
        private System.Windows.Forms.Button Btn_goto_lab5;
    }
}