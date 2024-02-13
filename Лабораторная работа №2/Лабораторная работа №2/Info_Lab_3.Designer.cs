namespace Лабораторная_работа__2
{
    partial class Info_Lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Lab_3));
            this.Lab3_Info = new System.Windows.Forms.Label();
            this.Btn_goto_calcLab3 = new System.Windows.Forms.Button();
            this.NameLab3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab3_Info
            // 
            this.Lab3_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab3_Info.AutoSize = true;
            this.Lab3_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab3_Info.Location = new System.Drawing.Point(318, 134);
            this.Lab3_Info.Name = "Lab3_Info";
            this.Lab3_Info.Size = new System.Drawing.Size(551, 32);
            this.Lab3_Info.TabIndex = 7;
            this.Lab3_Info.Text = "Вычислить координаты точки пересечения двух прямых и пошаговой детализации,\r\nс ис" +
    "пользованием DLL библиотеки и созданием отдельного класса.\r\n";
            this.Lab3_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_goto_calcLab3
            // 
            this.Btn_goto_calcLab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_calcLab3.Location = new System.Drawing.Point(479, 668);
            this.Btn_goto_calcLab3.Name = "Btn_goto_calcLab3";
            this.Btn_goto_calcLab3.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_calcLab3.TabIndex = 6;
            this.Btn_goto_calcLab3.Text = "ОК";
            this.Btn_goto_calcLab3.UseVisualStyleBackColor = true;
            this.Btn_goto_calcLab3.Click += new System.EventHandler(this.Btn_goto_calcLab3_Click);
            // 
            // NameLab3
            // 
            this.NameLab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLab3.AutoSize = true;
            this.NameLab3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLab3.Location = new System.Drawing.Point(252, 18);
            this.NameLab3.Name = "NameLab3";
            this.NameLab3.Size = new System.Drawing.Size(765, 42);
            this.NameLab3.TabIndex = 4;
            this.NameLab3.Text = "Лабораторная работа №3\r\nЗадание: Вычисление значений выражений с использованием м" +
    "етода пошаговой детализации\r\n";
            this.NameLab3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 467);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 166);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Info_Lab_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lab3_Info);
            this.Controls.Add(this.Btn_goto_calcLab3);
            this.Controls.Add(this.NameLab3);
            this.Name = "Info_Lab_3";
            this.Text = "Лабораторная работа №3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab3_Info;
        private System.Windows.Forms.Button Btn_goto_calcLab3;
        private System.Windows.Forms.Label NameLab3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}