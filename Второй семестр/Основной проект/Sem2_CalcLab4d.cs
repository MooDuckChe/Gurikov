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
    public partial class Sem2_CalcLab4d : Form
    {
        public Sem2_CalcLab4d()
        {
            InitializeComponent();
        }

        private void Sem2_Lab4_five_question_button_answer_Click(object sender, EventArgs e)
        {
            
            
            // First question
            bool btn1 = Sem2_Lab4_five_question_button_answer1.Checked;
            bool btn2 = Sem2_Lab4_five_question_button_answer2.Checked;
            bool btn3 = Sem2_Lab4_five_question_button_answer3.Checked;
            bool btn4 = Sem2_Lab4_five_question_button_answer4.Checked;
            bool first_question_get_correct_answer;
            
            if (btn1 && btn2 && !btn3 && !btn4)
                first_question_get_correct_answer = true;
            else
                first_question_get_correct_answer = false;


            // Second question
            bool second_question_get_correct_answer;
            string second_answer = Sem2_Lab4_six_question_button_choose_answer.Text;

            string second_question_first_correct_answer = "Надежность, гибкость и масштабируемость";
            string second_question_second_correct_answer = "Поддержка различных операционных систем и устройств ввода-вывода";

            if (second_question_first_correct_answer == second_answer || second_question_second_correct_answer == second_answer)
                second_question_get_correct_answer = true;
            else
                second_question_get_correct_answer = false;

            // Three question
            // In single-choose make two correct answer for user
            bool three_question_get_correct_answer = Sem2_Lab4_seven_question_button_answer3.Checked;

            if (first_question_get_correct_answer && second_question_get_correct_answer && three_question_get_correct_answer)
                Answer_Base.True_False[Answer_Base.k++] = true;
            else
                Answer_Base.True_False[Answer_Base.k++] = false;

        }
    }
}