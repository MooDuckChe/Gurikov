using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Лабораторная_работа;

namespace Лабораторная_работа
{
    public partial class Sem2_CalcLab4 : Form
    {
        public Sem2_CalcLab4()
        {
            InitializeComponent();

            Sem2_Lab4_first_question_button_answer.DialogResult = DialogResult.OK;
            Sem2_Lab4_first_question_button_exit.DialogResult = DialogResult.Cancel;
        }

        private void Sem2_Lab4_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sem2_Lab4_fIrst_question_button_answer_Click(object sender, EventArgs e)
        {
            if (Sem2_Lab4_first_question_button_choose_answer.SelectedItem != null && Sem2_Lab4_first_question_button_choose_answer.SelectedItem.ToString() == "Автоматизированная Система Управления Производством")
                Answer_Base.True_False[Answer_Base.k++] = true;
            else
                Answer_Base.True_False[Answer_Base.k++] = false;

            this.Close();
        }
    }
}
