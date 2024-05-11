namespace Лабораторная_работа
{
    partial class Sem2_Info_Lab_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sem2_Info_Lab_5));
            this.Btn_goto_Sem2_CalcLab5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_goto_Sem2_CalcLab5
            // 
            this.Btn_goto_Sem2_CalcLab5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_goto_Sem2_CalcLab5.Location = new System.Drawing.Point(479, 662);
            this.Btn_goto_Sem2_CalcLab5.Name = "Btn_goto_Sem2_CalcLab5";
            this.Btn_goto_Sem2_CalcLab5.Size = new System.Drawing.Size(225, 75);
            this.Btn_goto_Sem2_CalcLab5.TabIndex = 13;
            this.Btn_goto_Sem2_CalcLab5.Text = "ОК";
            this.Btn_goto_Sem2_CalcLab5.UseVisualStyleBackColor = true;
            this.Btn_goto_Sem2_CalcLab5.Click += new System.EventHandler(this.Btn_goto_Sem2_CalcLab5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 216);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sem2_Info_Lab_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_goto_Sem2_CalcLab5);
            this.Name = "Sem2_Info_Lab_5";
            this.Text = "Второй семестр | Лабораторная работа №5 | Задание";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_goto_Sem2_CalcLab5;
        private System.Windows.Forms.Label label1;
    }
}