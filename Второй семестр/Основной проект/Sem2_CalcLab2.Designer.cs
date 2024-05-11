namespace Лабораторная_работа
{
    partial class Sem2_CalcLab2
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
            this.Sem2_Lab2_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sem2_Lab2_exit
            // 
            this.Sem2_Lab2_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab2_exit.Location = new System.Drawing.Point(488, 675);
            this.Sem2_Lab2_exit.Name = "Sem2_Lab2_exit";
            this.Sem2_Lab2_exit.Size = new System.Drawing.Size(225, 75);
            this.Sem2_Lab2_exit.TabIndex = 18;
            this.Sem2_Lab2_exit.Text = "Выход";
            this.Sem2_Lab2_exit.UseVisualStyleBackColor = true;
            this.Sem2_Lab2_exit.Click += new System.EventHandler(this.Sem2_Lab2_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 116);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ремонт...\r\n\r\nЧуть позже сделаю.\r\nСейчас упор на новые лабораторные работы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sem2_CalcLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sem2_Lab2_exit);
            this.Name = "Sem2_CalcLab2";
            this.Text = "Второй семестр | Лабораторная работа №2 | Расчёт";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sem2_Lab2_exit;
        private System.Windows.Forms.Label label1;
    }
}