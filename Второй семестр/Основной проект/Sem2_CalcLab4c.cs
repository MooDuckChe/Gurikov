using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа
{
    public partial class Sem2_CalcLab4c : Form
    {
        public Sem2_CalcLab4c()
        {
            InitializeComponent();
        }

        private void Sem2_Lab4_four_question_button_answer_Click(object sender, EventArgs e)
        {
            string correct_answer = "Оптимизация производственных процессов и улучшение качества продукции";
            if (Sem2_Lab4_four_question_button_choose_answer.Text == correct_answer)
                Answer_Base.True_False[Answer_Base.k++] = true;
            else
                Answer_Base.True_False[Answer_Base.k++] = false;
        }
    }
}
