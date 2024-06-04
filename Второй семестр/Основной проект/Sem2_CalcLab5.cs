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
        }

        private void Sem2_Lab5_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int[,] DGV_MAIN_ARRAY;
        int[] DGV_TWIN_ARRAY;
        int length_select = 0;
        int compare = 0;
        private void Sem2_Lab5_calc_button_Click(object sender, EventArgs e)
        {

            if (length_select != 0)
                SecSem_Dll.Sem2_Lab5_Off_selected_cells(length_select,Sem2_Lab5_dataGridView_Main, DGV_TWIN_ARRAY.Length, Sem2_Lab5_dataGridView_Twink);

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
            SecSem_Dll.Sem2_Lab5_Fill_Array_RND_Num(DGV_MAIN_ARRAY, min_gen, max_gen);
            // Рисуем края mianDGV
            SecSem_Dll.Sem2_Lab5_Fill_corner_DGV(length, Sem2_Lab5_dataGridView_Main);
            // Выводим массив на mainDGV
            SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_MAIN_ARRAY, Sem2_Lab5_dataGridView_Main);

            //Считаем по условию mainDGV
            int[] condition_arr_size = SecSem_Dll.Sem2_Lab5_Count_Condition(DGV_MAIN_ARRAY);

            compare = condition_arr_size[0];
            // Выводим результат MsgBox
            MessageBox.Show("Чисел которые делятся на 3: " + condition_arr_size[0].ToString() + "\n Кол-во чисел которые большего этого числа: " + condition_arr_size[1].ToString(), "Результат");
            DGV_TWIN_ARRAY = SecSem_Dll.Sem2_Lab5_Usually(condition_arr_size[1], DGV_MAIN_ARRAY, condition_arr_size[0]);
            SecSem_Dll.Sem2_Lab5_Enter_Mas_in_DGV(DGV_TWIN_ARRAY, Sem2_Lab5_dataGridView_Twink);
        }


        private void Sem2_Lab5_Select_Main_Diagonal_dgv_main_Click(object sender, EventArgs e)
        {
            SecSem_Dll.SelectMainDiagonal(Sem2_Lab5_dataGridView_Main, length_select);
        }

        private void Sem2_Lab5_Select_Nums_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Select_Replaced_Nums(DGV_MAIN_ARRAY, compare,Sem2_Lab5_dataGridView_Main);
        }

        private void Sem2_Lab5_Off_selected_cells_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Off_selected_cells(length_select+1, Sem2_Lab5_dataGridView_Main, DGV_TWIN_ARRAY.Length, Sem2_Lab5_dataGridView_Twink);
        }

        private void Sem2_Lab5_Save_TXT_button_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Save_TXT(DGV_MAIN_ARRAY, DGV_TWIN_ARRAY);
        }

        private void Sem2_Lab5_Save_Word_button_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Save_Word(DGV_MAIN_ARRAY, DGV_TWIN_ARRAY);
        }

        private void Sem2_Lab5_Save_Excel_button_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab5_Save_Excel(DGV_MAIN_ARRAY, DGV_TWIN_ARRAY);
        }
    }
}
