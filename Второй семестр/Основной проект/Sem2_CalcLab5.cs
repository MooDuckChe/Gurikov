using Microsoft.VisualBasic;
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
    public partial class Sem2_CalcLab5 : Form
    {
        public Sem2_CalcLab5()
        {
            InitializeComponent();
        }

        private void Sem2_Lab5_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sem2_Lab5_calc_button_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите количество элементов массива для генерации", Title: "Размерность массива", DefaultResponse: "3"));
            int min_gen = Convert.ToInt32(Interaction.InputBox(Prompt: "Нижняя граница генерации чисел", Title: "Минимальное значение", DefaultResponse: "-5"));
            int max_gen = Convert.ToInt32(Interaction.InputBox(Prompt: "Верхняя граница генерации чисел", Title: "Максимально значение", DefaultResponse: "5"));

            //string length_text = Interaction.InputBox("Введите количество элементов массива для генерации", "Заголовок окна", "0", -1, -1); // Количество
            //int length = Convert.ToInt32(length_text);

            //string min_text = Interaction.InputBox("Нижняя граница генерации", "Заголовок окна", "0", -1, -1);
            //int min = Convert.ToInt32(min_text);

            //int max = Convert.ToInt32(max_text);

        }
    }
}
