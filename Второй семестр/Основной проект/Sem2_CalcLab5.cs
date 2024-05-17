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
        int[,] DGV_TWIN_ARRAY;

        private void Sem2_Lab5_calc_button_Click(object sender, EventArgs e)
        {
            string length_str =  Interaction.InputBox(Prompt: "Введите количество элементов массива для генерации", Title: "Размерность массива", DefaultResponse: "21");
            // Если нажали кнопку отмена
            if (length_str ==  "") { return; }
            string min_gen_str = Interaction.InputBox(Prompt: "Нижняя граница генерации чисел", Title: "Минимальное значение", DefaultResponse: "-100");
            if (min_gen_str == "") { return; }
            string max_gen_str = Interaction.InputBox(Prompt: "Верхняя граница генерации чисел", Title: "Максимально значение", DefaultResponse: "100");
            if (max_gen_str == "") { return; }

            int length = Convert.ToInt32(length_str);
            int min_gen = Convert.ToInt32(min_gen_str);
            int max_gen = Convert.ToInt32(max_gen_str);
            if (max_gen < min_gen) { MessageBox.Show("Верхняя граница генерации чисел должна быть больше нижней. Программа остановлена"); return; }

            // Если ввели максимальное число меньше чем меньшее

            DGV_MAIN_ARRAY = new int[length, length]; // Определяем двойной массив
            
            // Заполняем массив
            SecSem_Dll.Sem2_Lab5_Fill_Array_RND_Num(DGV_MAIN_ARRAY, length, min_gen, max_gen);
            // Рисуем края mianDGV
            SecSem_Dll.Sem2_Lab5_Fill_corner_DGV(length, Sem2_Lab5_dataGridView_Main);
            // Выводим массив на mainDGV
            SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length+1, Sem2_Lab5_dataGridView_Main);

            //SecSem_Dll.Sem2_Lab5_Debug_DGV(Sem2_Lab5_dataGridView_Main, DGV_MAIN_ARRAY);

            //Считаем по условию mainDGV
            SecSem_Dll.Sem2_Lab5_Count_Condition(DGV_MAIN_ARRAY, length, out int count_condition);
            // Выводим результат MsgBox
            MessageBox.Show("Чисел которые делятся на 3: " + count_condition.ToString(), "Результат");
            // Рисуем края twinDGV
            SecSem_Dll.Sem2_Lab5_Fill_corner_DGV(length, Sem2_Lab5_dataGridView_Twink);
            // Выводим массив на twinDGV
            SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length+1, Sem2_Lab5_dataGridView_Twink);
            // Замена на пробел
            SecSem_Dll.Sem2_Lab5_Replace_Nums_Space(count_condition, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink);


            // Замена на 0
            //SecSem_Dll.Sem2_Lab5_Replace_Num_Var2(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink, DGV_TWIN_ARRAY);

            // Сокращение DGV осталось немного допилить
            //SecSem_Dll.Sem2_Lab5_Replace_Num_Var3(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink);

            //int [,] DGV_MAIN_ARRAY = { {0,1,2}, {3,4,5}, {6,7,8} };
            //int[,] DGV_MAIN_ARRAY = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
        }
    }
}
