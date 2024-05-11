namespace Лабораторная_работа__2
{
    partial class Info_Lab_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Lab_2));
            this.InfoLab2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_goto_calcLab2 = new System.Windows.Forms.Button();
            this.Lab2_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoLab2
            // 
            this.InfoLab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoLab2.AutoSize = true;
            this.InfoLab2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLab2.Location = new System.Drawing.Point(261, 25);
            this.InfoLab2.Name = "InfoLab2";
            this.InfoLab2.Size = new System.Drawing.Size(707, 42);
            this.InfoLab2.TabIndex = 0;
            this.InfoLab2.Text = "Лабораторная работа №2\r\nЗадание: Выполнить расчет арифмитического выражения на ос" +
    "нове исходных данных\r\n";
            this.InfoLab2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_goto_calcLab2
            // 
            this.Btn_goto_calcLab2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_calcLab2.Location = new System.Drawing.Point(488, 675);
            this.Btn_goto_calcLab2.Name = "Btn_goto_calcLab2";
            this.Btn_goto_calcLab2.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_calcLab2.TabIndex = 2;
            this.Btn_goto_calcLab2.Text = "ОК";
            this.Btn_goto_calcLab2.UseVisualStyleBackColor = true;
            this.Btn_goto_calcLab2.Click += new System.EventHandler(this.Btn_list2_Click);
            // 
            // Lab2_Info
            // 
            this.Lab2_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab2_Info.AutoSize = true;
            this.Lab2_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab2_Info.Location = new System.Drawing.Point(59, 120);
            this.Lab2_Info.Name = "Lab2_Info";
            this.Lab2_Info.Size = new System.Drawing.Size(1085, 96);
            this.Lab2_Info.TabIndex = 3;
            this.Lab2_Info.Text = resources.GetString("Lab2_Info.Text");
            this.Lab2_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info_Lab_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Lab2_Info);
            this.Controls.Add(this.Btn_goto_calcLab2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoLab2);
            this.Name = "Info_Lab_2";
            this.Text = "Формула Лабораторной Работы №2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLab2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_goto_calcLab2;
        private System.Windows.Forms.Label Lab2_Info;
    }
}