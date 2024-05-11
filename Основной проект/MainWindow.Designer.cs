using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Info_High_Institution = new System.Windows.Forms.Label();
            this.Info_My = new System.Windows.Forms.Label();
            this.MainWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info_High_Institution
            // 
            this.Info_High_Institution.AllowDrop = true;
            this.Info_High_Institution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Info_High_Institution.AutoSize = true;
            this.Info_High_Institution.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_High_Institution.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Info_High_Institution.Location = new System.Drawing.Point(59, 4);
            this.Info_High_Institution.Margin = new System.Windows.Forms.Padding(0);
            this.Info_High_Institution.Name = "Info_High_Institution";
            this.Info_High_Institution.Size = new System.Drawing.Size(1083, 210);
            this.Info_High_Institution.TabIndex = 0;
            this.Info_High_Institution.Text = resources.GetString("Info_High_Institution.Text");
            this.Info_High_Institution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info_My
            // 
            this.Info_My.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Info_My.AutoSize = true;
            this.Info_My.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info_My.Location = new System.Drawing.Point(815, 509);
            this.Info_My.Margin = new System.Windows.Forms.Padding(0);
            this.Info_My.Name = "Info_My";
            this.Info_My.Size = new System.Drawing.Size(360, 84);
            this.Info_My.TabIndex = 1;
            this.Info_My.Text = "Выполнил студент группы ЗРС2304\r\nЗубков И.С.\r\nПроверил доцент кафедры «Информатик" +
    "а»\r\nГуриков С.Р.\r\n";
            this.Info_My.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainWindowButton
            // 
            this.MainWindowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainWindowButton.AutoSize = true;
            this.MainWindowButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainWindowButton.Location = new System.Drawing.Point(488, 669);
            this.MainWindowButton.Name = "MainWindowButton";
            this.MainWindowButton.Size = new System.Drawing.Size(225, 75);
            this.MainWindowButton.TabIndex = 2;
            this.MainWindowButton.Text = "OK";
            this.MainWindowButton.UseVisualStyleBackColor = true;
            this.MainWindowButton.Click += new System.EventHandler(this.MainWindowButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.MainWindowButton);
            this.Controls.Add(this.Info_My);
            this.Controls.Add(this.Info_High_Institution);
            this.Name = "MainWindow";
            this.Text = "Лабораторная работа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info_High_Institution;
        private System.Windows.Forms.Label Info_My;
        private System.Windows.Forms.Button MainWindowButton;
    }
}

