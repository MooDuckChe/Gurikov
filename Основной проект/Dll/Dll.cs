using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Dll_lab
{
    public class Lab_dll
    {
        // Создать универсальные методы для ввода и вывода

        public static void Input_lab3_KeyPress(KeyPressEventArgs e, string inputText)
        {
            // Разрешить обработку команды Backspace
            if (e.KeyChar == (char)Keys.Back)
                return;

            // Разрешить ввод одной запятой
            if (e.KeyChar == ',' && !inputText.Contains(",") && (inputText.Length != 0))// && !inputText.EndsWith("-"))
                return;

            // Разрешить ввод цифр
            if (char.IsDigit(e.KeyChar))
                return;

            // Разрешить ввод одного знака минус только в начале
            if (e.KeyChar == '-' && (inputText.Length == 0))
                return;
            // Запретить ввод, если символ является минусом или запятой и в поле уже присутствует соответствующий символ
            if ((e.KeyChar == '-' && (inputText.Contains("-") || inputText.EndsWith(","))) || (e.KeyChar == ',' && (inputText.Contains(",") || inputText.EndsWith("-"))))
            {
                e.Handled = true;
                return;
            }

            e.Handled = true;
        }


        public static double Input_user(TextBox textbox)
        {
            return Convert.ToDouble(textbox.Text);
        }

        public static void Out_info(TextBox usr_inp, double test)
        {
            usr_inp.Text = test.ToString();
        }

        public static double Lab3_Matrix(double a1, double a2, double b1, double b2)
        {
            double result_delta = (a1 * b2) - (a2 * b1);
            return result_delta;
        }
        public static void Lab3_All_Out(double a1, double a2, double b1, double b2, double c1, double c2, out double Lab3_Res_X, out double Lab3_Res_Y)
        {
            double delta = Lab3_Matrix(a1, a2, b1, b2);
            double delta_x = Lab3_Matrix(c1, c2, b1, b2);
            double delta_y = Lab3_Matrix(a1, a2, c1, c2);
            Lab3_Res_X = delta_x / delta;
            Lab3_Res_Y = delta_y / delta;
        }

        public static double Lab4_Make_result(double a, double x, double y)
        {
            double d, min;
            if (x < 0)
            {
                MessageBox.Show("Попали в ветку 1", "Проверка", MessageBoxButtons.OK);
                double xa = Math.Pow(x, a);
                double exa = Math.Exp(x * a);
                // Min
                min = a;
                if (min > exa)
                    min = exa;
                if (min > xa)
                    min = xa;

                // Max
                double temp_ax = (a * x) + 1;
                if (min > temp_ax)
                    d = min;
                else
                    d = temp_ax;
            }
            else 
            {
                if (0 <= x && x < 7)
                {
                    MessageBox.Show("Попали в ветку 2", "Проверка", MessageBoxButtons.OK);
                    if (x > y)
                        d = (Math.Pow(Math.Cos(x), 2) + Math.Sin(Math.Pow(x, 2)) * x);
                    else
                        d = (Math.Pow(Math.Cos(x), 2) + Math.Sin(Math.Pow(x, 2)) * y);
                }
                else
                {
                    MessageBox.Show("Попали в ветку 3", "Проверка", MessageBoxButtons.OK);
                    d = (1 + 3 * Math.Cos(Math.Abs(x + y)));
                }
            }
                
            return d;
        }
        public static double La6_Make_result(double a, double x, double y)
        {
            double d, min;
            if (x < 0)
            {
                double xa = Math.Pow(x, a);
                double exa = Math.Exp(x * a);
                // Min
                min = a;
                if (min > exa)
                    min = exa;
                if (min > xa)
                    min = xa;

                // Max
                double temp_ax = (a * x) + 1;
                if (min > temp_ax)
                    d = min;
                else
                    d = temp_ax;
            }
            else
            {
                if (0 <= x && x < 7)
                {
                    if (x > y)
                        d = (Math.Pow(Math.Cos(x), 2) + Math.Sin(Math.Pow(x, 2)) * x);
                    else
                        d = (Math.Pow(Math.Cos(x), 2) + Math.Sin(Math.Pow(x, 2)) * y);
                }
                else
                    d = (1 + 3 * Math.Cos(Math.Abs(x + y)));
            }

            return d;
        }
        public static void Add_Row(double a, double d, DataGridView Lab6_Table_Values)
        {
            Lab6_Table_Values.Rows.Add(a.ToString("F1"), d.ToString("F5"));
        }

        public static void DataGridClear(DataGridView Lab6_Table_Values)
        {
            Lab6_Table_Values.Rows.Clear();
        }

        public static void Lab6_tabulation(DataGridView Lab6_Table_Values, double a, double x, double y, double step, double end_cycle, out double result_min_lab6, out double result_average_under_zero_lab6)
        {
            double min_lab6 = 10000000;
            double average_under_zero_lab6 = 0;

            long end_for = Convert.ToUInt32(Math.Round(((end_cycle - x) / step))+1);
            DataGridClear(Lab6_Table_Values);
            for (int i = 1; i <= end_for; i++)
            {
                double d = La6_Make_result(a, x, y);
                if (d < min_lab6)
                    min_lab6 = d;
                if (d < 0)
                    average_under_zero_lab6 += d;
                Add_Row(x, d, Lab6_Table_Values);
                x += step;
            }
            result_min_lab6 = min_lab6;
            result_average_under_zero_lab6 = average_under_zero_lab6 / end_for;
        }
        public static void Lab8_new_row(int i, double x, DataGridView DGV)
        {
            DGV.Rows.Add(i.ToString("F1"), x.ToString("F9")); // ?
        }
        public static double Lab8_MakeResult(double x, int k)
        {
            double first = (-1) * Math.Pow((x / 3), 4);
            double second = ((2 * k) + 2) * ((2 * k) + 3);

            double sum = first / second;

            return sum;
        }
        public static void Lab8_Result(double x0, double eps, double MaxIter, DataGridView DataGrid)//, out double temp)
        {
            double prev_x;
            int k = 0;
            double temp = x0;
            Lab_dll.DataGridClear(DataGrid);
            do
            {
                prev_x = temp; // Сохраняем прошлое значение
                temp = prev_x * Lab8_MakeResult(prev_x, k); // Рассчитываем
                Lab_dll.Lab8_new_row(k+1, temp, DataGrid);
                k++;
            }
            while (Math.Abs(prev_x - temp) >= eps && k < MaxIter);
        }
    }
}
