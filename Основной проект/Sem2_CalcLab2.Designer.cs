﻿namespace Лабораторная_работа
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
            this.SuspendLayout();
            // 
            // Sem2_Lab2_exit
            // 
            this.Sem2_Lab2_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab2_exit.Location = new System.Drawing.Point(488, 669);
            this.Sem2_Lab2_exit.Name = "Sem2_Lab2_exit";
            this.Sem2_Lab2_exit.Size = new System.Drawing.Size(225, 75);
            this.Sem2_Lab2_exit.TabIndex = 18;
            this.Sem2_Lab2_exit.Text = "Выход";
            this.Sem2_Lab2_exit.UseVisualStyleBackColor = true;
            this.Sem2_Lab2_exit.Click += new System.EventHandler(this.Sem2_Lab2_exit_Click);
            // 
            // Sem2_CalcLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.Sem2_Lab2_exit);
            this.Name = "Sem2_CalcLab2";
            this.Text = "Sem2_CalcLab2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sem2_Lab2_exit;
    }
}