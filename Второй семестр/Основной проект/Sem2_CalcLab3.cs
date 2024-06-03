using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_lab;
using Second_Semestr_Dll;
using Microsoft.VisualBasic;

namespace Лабораторная_работа
{
    public partial class Sem2_CalcLab3 : Form
    {
        public Sem2_CalcLab3()
        {
            InitializeComponent();
        }
        public int[] array;
        public int[] array2;
        private void Make_result_Sem2_lab3_Click(object sender, EventArgs e)
        {
            
            string length_text = Interaction.InputBox("Введите количество элементов массива для генерации", "Размер массива", "15"); // Количество
            if (length_text == "") return;
            if (!int.TryParse(length_text, out int length)) { MessageBox.Show("Неверный формат данных. Ошибка."); return; }

            string min_text = Interaction.InputBox("Нижняя граница генерации", "Минимальное значение", "-10");
            if (min_text == "") return;
            if (!int.TryParse(min_text, out int min)) { MessageBox.Show("Неверный формат данных. Ошибка."); return; }

            string max_text = Interaction.InputBox("Верхняя граница генерации", "Максимальное значение", "60");
            if (max_text == "") return;
            if (!int.TryParse(max_text, out int max)) { MessageBox.Show("Неверный формат данных. Ошибка."); return; }
            
            // Если ввели максимальное число меньше чем меньшее
            if (max < min) { MessageBox.Show("Верхняя граница генерации чисел должна быть больше нижней. Программа остановлена"); return; }

            int[] mas = new int[length];

            // Заполняем массив
            SecSem_Dll.Enter_massiv(mas, length, min, max);
            // Вывод исходного массива
            SecSem_Dll.Output_massiv(mas, length, Lab2_Sem3_Main_DGV);

            //Вычисление среднего геометрического
            SecSem_Dll.Sem2_Lab3_Calc_Geometric(mas, out double result);
            //Посчитать сколько чисел подходят под условие
            SecSem_Dll.Sem2_Lab3_Count_Condition(mas, result, out int index);
            // Расчет и вывод массива под условие
            SecSem_Dll.Sem2_Lab3_Calculate(mas, result, index, out int[] output);
            // Вывод для пользователя
            MessageBox.Show("Найдено: " + index.ToString() + " элементов", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Вывод результата на вторую таблицу
            SecSem_Dll.Output_massiv(output, index, Lab2_Sem3_Resh_DGV);

            array = mas; // Открываем массив для других функций
            array2 = output;
        }
        private void Sem2_Lab3_Save_Txt_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab3_Save_Txt(array, array2);
        }
        private void Sem2_Lab3_Save_Excel_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab3_Save_Excel(array, array2);
        }
        private void Sem2_Lab3_Save_Word_Click(object sender, EventArgs e)
        {
            SecSem_Dll.Sem2_Lab3_Save_Word(array, array2);
        }
        private void Sem2_Lab3_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
