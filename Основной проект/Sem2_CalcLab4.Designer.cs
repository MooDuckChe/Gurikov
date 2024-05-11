namespace Лабораторная_работа
{
    partial class Sem2_CalcLab4_first_question_page
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
            this.Sem2_Lab4_First_question_button_exit = new System.Windows.Forms.Button();
            this.Sem2_Lab4_first_question_button_choose_answer = new System.Windows.Forms.ComboBox();
            this.Sem2_Lab4_first_question_text = new System.Windows.Forms.Label();
            this.Sem2_Lab4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sem2_Lab4_First_question_button_exit
            // 
            this.Sem2_Lab4_First_question_button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab4_First_question_button_exit.Location = new System.Drawing.Point(488, 669);
            this.Sem2_Lab4_First_question_button_exit.Name = "Sem2_Lab4_First_question_button_exit";
            this.Sem2_Lab4_First_question_button_exit.Size = new System.Drawing.Size(225, 75);
            this.Sem2_Lab4_First_question_button_exit.TabIndex = 18;
            this.Sem2_Lab4_First_question_button_exit.Text = "Выход";
            this.Sem2_Lab4_First_question_button_exit.UseVisualStyleBackColor = true;
            this.Sem2_Lab4_First_question_button_exit.Click += new System.EventHandler(this.Sem2_Lab4_exit_Click);
            // 
            // Sem2_Lab4_first_question_button_choose_answer
            // 
            this.Sem2_Lab4_first_question_button_choose_answer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab4_first_question_button_choose_answer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sem2_Lab4_first_question_button_choose_answer.FormattingEnabled = true;
            this.Sem2_Lab4_first_question_button_choose_answer.IntegralHeight = false;
            this.Sem2_Lab4_first_question_button_choose_answer.Items.AddRange(new object[] {
            "Архитектурная Система Управления Пространством",
            "Авиационная Система Управления Полетами",
            "Автоматизированная Система Учета Продукции",
            "Автоматическая Система Управления Персоналом",
            "Автоматизированная Система Управления Производством"});
            this.Sem2_Lab4_first_question_button_choose_answer.Location = new System.Drawing.Point(420, 407);
            this.Sem2_Lab4_first_question_button_choose_answer.Name = "Sem2_Lab4_first_question_button_choose_answer";
            this.Sem2_Lab4_first_question_button_choose_answer.Size = new System.Drawing.Size(360, 21);
            this.Sem2_Lab4_first_question_button_choose_answer.TabIndex = 19;
            // 
            // Sem2_Lab4_first_question_text
            // 
            this.Sem2_Lab4_first_question_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab4_first_question_text.AutoSize = true;
            this.Sem2_Lab4_first_question_text.Location = new System.Drawing.Point(521, 378);
            this.Sem2_Lab4_first_question_text.Name = "Sem2_Lab4_first_question_text";
            this.Sem2_Lab4_first_question_text.Size = new System.Drawing.Size(157, 13);
            this.Sem2_Lab4_first_question_text.TabIndex = 25;
            this.Sem2_Lab4_first_question_text.Text = "Как расшифровыватся АСУП";
            // 
            // Sem2_Lab4
            // 
            this.Sem2_Lab4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sem2_Lab4.Location = new System.Drawing.Point(488, 452);
            this.Sem2_Lab4.Name = "Sem2_Lab4";
            this.Sem2_Lab4.Size = new System.Drawing.Size(225, 47);
            this.Sem2_Lab4.TabIndex = 26;
            this.Sem2_Lab4.Text = "Ответ";
            this.Sem2_Lab4.UseVisualStyleBackColor = true;
            this.Sem2_Lab4.Click += new System.EventHandler(this.Sem2_Lab4_fIrst_question_button_answer_Click);
            // 
            // Sem2_CalcLab4_first_question_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.Sem2_Lab4);
            this.Controls.Add(this.Sem2_Lab4_first_question_text);
            this.Controls.Add(this.Sem2_Lab4_first_question_button_choose_answer);
            this.Controls.Add(this.Sem2_Lab4_First_question_button_exit);
            this.Name = "Sem2_CalcLab4_first_question_page";
            this.Text = "Второой семестр | Лабораторная работа №4 | Первый вопрос";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sem2_Lab4_First_question_button_exit;
        private System.Windows.Forms.ComboBox Sem2_Lab4_first_question_button_choose_answer;
        private System.Windows.Forms.Label Sem2_Lab4_first_question_text;
        private System.Windows.Forms.Button Sem2_Lab4;
    }
}