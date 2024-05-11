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
    public partial class Sem2_CalcLab4_first_question_page : Form
    {
        public Sem2_CalcLab4_first_question_page()
        {
            InitializeComponent();
        }

        private void Sem2_Lab4_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sem2_Lab4_fIrst_question_button_answer_Click(object sender, EventArgs e)
        {
            if (Sem2_Lab4_first_question_button_choose_answer.SelectedItem != null && Sem2_Lab4_first_question_button_choose_answer.SelectedItem.ToString() == "Автоматизированная Система Управления Производством")
            {
                MessageBox.Show("True");
                Answer_Base.rigth_answer++;
            }
            else
                MessageBox.Show("False");

            //this.ShowDialog();
            Sem2_CalcLab4a Sem2_CalcLab4a = new Sem2_CalcLab4a();
            Sem2_CalcLab4a.Show();

            //this.Visible = false;


            // закрываем текущую форму
            //this.Close();
        }
    }
}
