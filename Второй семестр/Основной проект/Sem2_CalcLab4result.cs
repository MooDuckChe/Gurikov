using Second_Semestr_Dll;
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
    public partial class Sem2_CalcLab4result : Form
    {
        public Sem2_CalcLab4result()
        {
            InitializeComponent();

            string rating = "Ваша оценка - ";

            int count = 0;

            

            Sem2_Lab3_dataGridView_Result.ColumnCount = 5;
            Sem2_Lab3_dataGridView_Result.RowCount = 2;

            for (int i = 0; i < 5; i++)
            {
                Sem2_Lab3_dataGridView_Result.Rows[0].Cells[i].Value = "[" + (i+1) + "]";
                if (Answer_Base.True_False[i] == true)
                {
                    Sem2_Lab3_dataGridView_Result.Rows[1].Cells[i].Value = "Верно";
                    count++;
                }
                else
                    Sem2_Lab3_dataGridView_Result.Rows[1].Cells[i].Value = "Неверно";
            }

            if (count < 2)
                Sem2_Lab3_Result_Label.Text = rating + "2";
            else
                Sem2_Lab3_Result_Label.Text = rating + count.ToString();
        }

        private void Sem2_Lab4_five_question_button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
