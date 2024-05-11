namespace Лабораторная_работа
{
    partial class Info_Lab_8
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
            this.Btn_goto_calcLab8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_goto_calcLab8
            // 
            this.Btn_goto_calcLab8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_calcLab8.Location = new System.Drawing.Point(479, 662);
            this.Btn_goto_calcLab8.Name = "Btn_goto_calcLab8";
            this.Btn_goto_calcLab8.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_calcLab8.TabIndex = 8;
            this.Btn_goto_calcLab8.Text = "ОК";
            this.Btn_goto_calcLab8.UseVisualStyleBackColor = true;
            this.Btn_goto_calcLab8.Click += new System.EventHandler(this.Btn_goto_calcLab8_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(387, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Лабораторная работа №8\r\n\"Итеративный циклический процесс\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Лабораторная_работа.Properties.Resources.Lab8_info;
            this.pictureBox1.Location = new System.Drawing.Point(99, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Info_Lab_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_goto_calcLab8);
            this.Name = "Info_Lab_8";
            this.Text = "Лабораторная работа №8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_goto_calcLab8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}