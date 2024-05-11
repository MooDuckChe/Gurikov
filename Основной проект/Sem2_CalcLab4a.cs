using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лабораторная_работа;

namespace Лабораторная_работа
{
    public partial class Sem2_CalcLab4a : Form
    {
        public Sem2_CalcLab4a()
        {
            InitializeComponent();
        }

        private void Sem2_Lab4_second_question_button_answer_Click(object sender, EventArgs e)
        {
            bool d = Second_question_answer4.Checked;

            if (d)
            {
                MessageBox.Show("True");
                Answer_Base.rigth_answer++;
            }
            else
                MessageBox.Show("False");
        }

        private void Sem2_Lab4_second_question_button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
