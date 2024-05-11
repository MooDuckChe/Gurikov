namespace Лабораторная_работа
{
    partial class Sem2_Info_Lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sem2_Info_Lab_3));
            this.Btn_goto_Sem_CalcLab3 = new System.Windows.Forms.Button();
            this.Sem2_Lab3_Task = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab3_Task)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_goto_Sem_CalcLab3
            // 
            this.Btn_goto_Sem_CalcLab3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_Sem_CalcLab3.Location = new System.Drawing.Point(479, 662);
            this.Btn_goto_Sem_CalcLab3.Name = "Btn_goto_Sem_CalcLab3";
            this.Btn_goto_Sem_CalcLab3.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_Sem_CalcLab3.TabIndex = 11;
            this.Btn_goto_Sem_CalcLab3.Text = "ОК";
            this.Btn_goto_Sem_CalcLab3.UseVisualStyleBackColor = true;
            this.Btn_goto_Sem_CalcLab3.Click += new System.EventHandler(this.Btn_goto_Sem_CalcLab2_Click);
            // 
            // Sem2_Lab3_Task
            // 
            this.Sem2_Lab3_Task.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab3_Task.Image = ((System.Drawing.Image)(resources.GetObject("Sem2_Lab3_Task.Image")));
            this.Sem2_Lab3_Task.Location = new System.Drawing.Point(12, 280);
            this.Sem2_Lab3_Task.Name = "Sem2_Lab3_Task";
            this.Sem2_Lab3_Task.Size = new System.Drawing.Size(1160, 205);
            this.Sem2_Lab3_Task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sem2_Lab3_Task.TabIndex = 12;
            this.Sem2_Lab3_Task.TabStop = false;
            // 
            // Sem2_Info_Lab_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.Sem2_Lab3_Task);
            this.Controls.Add(this.Btn_goto_Sem_CalcLab3);
            this.Name = "Sem2_Info_Lab_3";
            this.Text = "Sem2_Info_Lab_3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Sem2_Lab3_Task)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_goto_Sem_CalcLab3;
        private System.Windows.Forms.PictureBox Sem2_Lab3_Task;
    }
}