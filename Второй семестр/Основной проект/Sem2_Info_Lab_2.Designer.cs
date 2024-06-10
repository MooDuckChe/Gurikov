namespace Лабораторная_работа
{
    partial class Sem2_Info_Lab_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sem2_Info_Lab_2));
            this.Btn_goto_Sem2_CalcLab2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_goto_Sem2_CalcLab2
            // 
            this.Btn_goto_Sem2_CalcLab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_Sem2_CalcLab2.Location = new System.Drawing.Point(479, 668);
            this.Btn_goto_Sem2_CalcLab2.Name = "Btn_goto_Sem2_CalcLab2";
            this.Btn_goto_Sem2_CalcLab2.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_Sem2_CalcLab2.TabIndex = 10;
            this.Btn_goto_Sem2_CalcLab2.Text = "ОК";
            this.Btn_goto_Sem2_CalcLab2.UseVisualStyleBackColor = true;
            this.Btn_goto_Sem2_CalcLab2.Click += new System.EventHandler(this.Btn_goto_Sen_CalcLab2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 166);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1045, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Лабораторная работа №2\r\n«Реализация метода пошаговой детализации на основе исполь" +
    "зования объектно-ориентированного программирования (ООП)»";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sem2_Info_Lab_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_goto_Sem2_CalcLab2);
            this.Name = "Sem2_Info_Lab_2";
            this.Text = "Второй семестр | Лабораторная работа №2 | Задание";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_goto_Sem2_CalcLab2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}