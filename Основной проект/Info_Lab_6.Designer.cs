namespace Лабораторная_работа
{
    partial class Info_Lab_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Lab_6));
            this.Btn_goto_calcLab6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLab3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_goto_calcLab6
            // 
            this.Btn_goto_calcLab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_calcLab6.Location = new System.Drawing.Point(479, 668);
            this.Btn_goto_calcLab6.Name = "Btn_goto_calcLab6";
            this.Btn_goto_calcLab6.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_calcLab6.TabIndex = 7;
            this.Btn_goto_calcLab6.Text = "ОК";
            this.Btn_goto_calcLab6.UseVisualStyleBackColor = true;
            this.Btn_goto_calcLab6.Click += new System.EventHandler(this.Btn_goto_calcLab6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1075, 312);
            this.label1.TabIndex = 9;
            this.label1.Text = "Необходимо создать приложение определяющие значение d при помощи многозначных вет" +
    "влений по данной схеме\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nПользователь вводит: a,x,y\r\nТребуетс" +
    "я: Вычислить и вывести d";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLab3
            // 
            this.NameLab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLab3.AutoSize = true;
            this.NameLab3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLab3.Location = new System.Drawing.Point(460, 9);
            this.NameLab3.Name = "NameLab3";
            this.NameLab3.Size = new System.Drawing.Size(279, 63);
            this.NameLab3.TabIndex = 10;
            this.NameLab3.Text = "Лабораторная работа №6\r\nЗадание: Табулирование функции\r\n\r\n";
            this.NameLab3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Info_Lab_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.NameLab3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_goto_calcLab6);
            this.Name = "Info_Lab_6";
            this.Text = "Лабораторная работа №6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_goto_calcLab6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLab3;
    }
}