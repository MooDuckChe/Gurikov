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
    public partial class Sem2_CalcLab4b : Form
    {
        public Sem2_CalcLab4b()
        {
            InitializeComponent();
        }

        private void Sem2_Lab4_three_question_button_answer_Click(object sender, EventArgs e)
        {
            string answer = (Sem2_CalcLab4_three_question_answer.Text).ToLower();
            if (answer == "оптимальное" || answer == "рациональное")
                Answer_Base.True_False[Answer_Base.k++] = true;
            else
                Answer_Base.True_False[Answer_Base.k++] = false;
        }
    }
}
