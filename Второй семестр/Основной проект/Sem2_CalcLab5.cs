using Microsoft.Office.Interop.Word;
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

            bool debug = true;

            if (debug)
            {
                int length = 7;
                length_select = length;
                int min_gen = -10;
                int max_gen = 20;

                DGV_MAIN_ARRAY = new int[length, length]; // Определяем двойной массив

                // Заполняем массив
                SecSem_Dll.Sem2_Lab5_Fill_Array_RND_Num(DGV_MAIN_ARRAY, length, min_gen, max_gen);
                // Рисуем края mianDGV
                SecSem_Dll.Sem2_Lab5_Fill_corner_DGV(length, Sem2_Lab5_dataGridView_Main);
                // Выводим массив на mainDGV
                SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length + 1, Sem2_Lab5_dataGridView_Main);


                int[] coordinats = new int[length * (length / 2) + 1];
                //Считаем по условию mainDGV
                SecSem_Dll.Sem2_Lab5_Count_Condition(DGV_MAIN_ARRAY, out int count_condition, ref coordinats, Sem2_Lab5_dataGridView_Main);

                // Выводим результат MsgBox
                MessageBox.Show("Чисел которые делятся на 3: " + count_condition.ToString(), "Результат");
                // Рисуем края twinDGV
                SecSem_Dll.Sem2_Lab5_Fill_corner_DGV(length, Sem2_Lab5_dataGridView_Twink);

                SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length + 1, Sem2_Lab5_dataGridView_Twink);
                SecSem_Dll.Sem2_Lab5_Replace_Nums_Space(count_condition, length, DGV_MAIN_ARRAY, coordinats, Sem2_Lab5_dataGridView_Twink);
                
                DGV_TWIN_ARRAY = SecSem_Dll.Sem2_Lab5_Usually(count_condition, length, DGV_MAIN_ARRAY);
            }
        }

        private void Sem2_Lab5_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int[,] DGV_MAIN_ARRAY;
        int[] DGV_TWIN_ARRAY;
        int length_select = 0;
        string choose = "replace_space";
        private void Sem2_Lab5_calc_button_Click(object sender, EventArgs e)
        {

            if (length_select != 0) SecSem_Dll.Sem2_Lab5_Off_selected_cells(length_select, Sem2_Lab5_dataGridView_Main, Sem2_Lab5_dataGridView_Twink);
            string length_str =  Interaction.InputBox(Prompt: "Введите количество элементов массива для генерации", Title: "Размерность массива", DefaultResponse: "6");
            // Если нажали кнопку отмена
            if (length_str ==  "") { return; }
            string min_gen_str = Interaction.InputBox(Prompt: "Нижняя граница генерации чисел", Title: "Минимальное значение", DefaultResponse: "-10");
            if (min_gen_str == "") { return; }
            string max_gen_str = Interaction.InputBox(Prompt: "Верхняя граница генерации чисел", Title: "Максимально значение", DefaultResponse: "20");
            if (max_gen_str == "") { return; }

            int length = Convert.ToInt32(length_str);
            length_select = length;
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
            //Sem2_Lab5_dataGridView_Main.Rows[0].Cells[0].Selected = false;

            int[] coordinats = new int[length * (length / 2) + 1];
            //Считаем по условию mainDGV
            SecSem_Dll.Sem2_Lab5_Count_Condition(DGV_MAIN_ARRAY, out int count_condition, ref coordinats, Sem2_Lab5_dataGridView_Main);
            
            // Выводим результат MsgBox
            MessageBox.Show("Чисел которые делятся на 3: " + count_condition.ToString(), "Результат");
            // Рисуем края twinDGV
            SecSem_Dll.Sem2_Lab5_Fill_corner_DGV(length, Sem2_Lab5_dataGridView_Twink);

            DGV_TWIN_ARRAY = SecSem_Dll.Sem2_Lab5_Usually(count_condition, length, DGV_MAIN_ARRAY);

            switch (choose)
            {
                case "reduce":
                    SecSem_Dll.Sem2_Lab5_Reduction_DGV(DGV_MAIN_ARRAY, count_condition, coordinats, Sem2_Lab5_dataGridView_Twink);
                    break;

                case "replace_zero":
                    SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length+1, Sem2_Lab5_dataGridView_Twink);
                    SecSem_Dll.Sem2_Lab5_Replace_Nums_Zero(length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink, Sem2_Lab5_dataGridView_Main);
                    break;

                case "replace_space":
                    // Замена на пробел
                    SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length+1, Sem2_Lab5_dataGridView_Twink);
                    SecSem_Dll.Sem2_Lab5_Replace_Nums_Space(count_condition, length, DGV_MAIN_ARRAY, coordinats, Sem2_Lab5_dataGridView_Twink);
                    break;

                case "replace_new_num":
                    SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length + 1, Sem2_Lab5_dataGridView_Twink);
                    SecSem_Dll.Sem2_Lab5_Replace_New_Num(min_gen, max_gen, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink);
                    break;
            }
            // Выводим массив на twinDGV
            //SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, length + 1, Sem2_Lab5_dataGridView_Twink);

            // Замена на 0
            //SecSem_Dll.Sem2_Lab5_Replace_Num_Var2(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink, DGV_TWIN_ARRAY);

            // Сокращение DGV осталось немного допилить
            //SecSem_Dll.Sem2_Lab5_Replace_Num_Var3(count_div_3, length, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink);

            //int [,] DGV_MAIN_ARRAY = { {0,1,2}, {3,4,5}, {6,7,8} };
            //int[,] DGV_MAIN_ARRAY = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
        }

        private void Sem2_Lab5_button_Replace_Num_Space_Click(object sender, EventArgs e)
        {
            choose = "replace_space";
            MessageBox.Show("Вы выбрали замену чисел на пробел.");
        }
        private void Sem2_Lab5_button_Reduce_DGV_Click(object sender, EventArgs e)
        {
            choose = "reduce";
            MessageBox.Show("Вы выбрали сокращение таблицы.");
        }
        private void Sem2_Lab5_button_Replace_Num_WithZero_Click(object sender, EventArgs e)
        {
            choose = "replace_zero";
            MessageBox.Show("Вы выбрали замену чисел на 0.");
        }
        private void Sem2_Lab5_button_Replace_Num_NewNum_Click(object sender, EventArgs e)
        {
            choose = "replace_new_num";
            MessageBox.Show("Вы выбрали замена на новое число.");
        }


        private void Sem2_Lab5_Select_Main_Diagonal_dgv_main_Click(object sender, EventArgs e)
        {
            SecSem_Dll.SelectMainDiagonal(Sem2_Lab5_dataGridView_Main, length_select);
        }

        private void Sem2_Lab5_Select_Main_Diagonal_dgv_twin_Click(object sender, EventArgs e)
        {
            SecSem_Dll.SelectMainDiagonal(Sem2_Lab5_dataGridView_Twink, length_select);
        }

        private void Sem2_Lab5_Select_Nums_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Select_Replaced_Nums(length_select, DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Twink, Sem2_Lab5_dataGridView_Main);
        }

        private void Sem2_Lab5_Off_selected_cells_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Off_selected_cells(length_select, Sem2_Lab5_dataGridView_Main, Sem2_Lab5_dataGridView_Twink);
        }

        private void Sem2_Lab5_Save_TXT_button_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Save_TXT(DGV_MAIN_ARRAY, DGV_TWIN_ARRAY);
        }

        private void Sem2_Lab5_Save_Word_button_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Save_Word(DGV_TWIN_ARRAY);
        }
    }
}
