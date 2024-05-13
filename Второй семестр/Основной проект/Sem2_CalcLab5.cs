using Microsoft.VisualBasic;
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

        int[,] DGV_MAIN_ARRAY;
        int[,] DGV_TWIN_ARRAY = { { 1 }, { 2 } };

        private void Sem2_Lab5_calc_button_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(Interaction.InputBox(Prompt: "Введите количество элементов массива для генерации", Title: "Размерность массива", DefaultResponse: "21"));
            int min_gen = Convert.ToInt32(Interaction.InputBox(Prompt: "Нижняя граница генерации чисел", Title: "Минимальное значение", DefaultResponse: "-100"));
            int max_gen = Convert.ToInt32(Interaction.InputBox(Prompt: "Верхняя граница генерации чисел", Title: "Максимально значение", DefaultResponse: "100"));


            DGV_MAIN_ARRAY = new int[length, length]; // Определяем двойной массив
            // Заполняем массив
            SecSem_Dll.Sem2_Lab5_Fill_Array(DGV_MAIN_ARRAY, length, min_gen, max_gen);

            // Выводим массив на DGV
            SecSem_Dll.Sem2_Lab5_Output_DGV(DGV_MAIN_ARRAY, length, Sem2_Lab5_dataGridView_Main);

            //Считаем по условию
            SecSem_Dll.Sem2_Lab5_Calculate(DGV_MAIN_ARRAY, length, out int count_div_3);
            MessageBox.Show("Чисел которые делятся на 3: " + count_div_3.ToString(), "Результат");

            SecSem_Dll.Sem2_Lab5_Replace_Num_Var1(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink);

            SecSem_Dll.Sem2_Lab5_Replace_Num_Var2(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink, DGV_TWIN_ARRAY);


            // Сокращение DGV осталось немного допилить
            //SecSem_Dll.Sem2_Lab5_Replace_Num_Var3(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink);



            //Заполняем второй массив по условию


            //SecSem_Dll.Sem2_Lab5_Fill_DGV_from_Array


            //int [,] DGV_MAIN_ARRAY = { {0,1,2}, {3,4,5}, {6,7,8} };
            //int[,] DGV_MAIN_ARRAY = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };


            //Sem2_Lab5_dataGridView_Main = new

        }
    }
}
