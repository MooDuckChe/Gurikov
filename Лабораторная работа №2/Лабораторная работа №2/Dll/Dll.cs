using System;
using System.Collections.Generic;
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
            {
                return;
            }

            // Разрешить ввод цифр
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Разрешить ввод одного знака минус
            if (e.KeyChar == '-' && !inputText.Contains("-") && !inputText.EndsWith(","))
            {
                return;
            }

            // Разрешить ввод одного знака запятой
            if (e.KeyChar == ',' && !inputText.Contains(",") && !inputText.EndsWith("-"))
            {
                return;
            }

            // Запретить ввод, если символ является минусом или запятой и в поле уже присутствует соответствующий символ
            if ((e.KeyChar == '-' && (inputText.Contains("-") || inputText.EndsWith(","))) ||
                (e.KeyChar == ',' && (inputText.Contains(",") || inputText.EndsWith("-"))))
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
        public static double Delta(double a1, double a2, double b1, double b2)
        {
            double result_delta = (a1 * b2) - (a2 * b1);
            return result_delta;
        }
        public static double Res_Delta_X(double c1, double c2, double b1, double b2)
        {
            double result_del_x = (c1 * b2) - (c2 * b1);
            return result_del_x;
        }
        public static double Res_Delta_Y(double a1, double a2, double c1, double c2)
        {
            double result_del_y = (a1 * c2) - (a2 * c1);
            return result_del_y;
        }
        public static double Min(double a, double b)
        {
            if (a < b) { return a; }
            else return b;
        }
        public static double Max(double a, double b)
        {
            if (a > b) { return a; }
            else return b;
        }
        public static double Lab4_Make_result(double a, double x, double y)
        {
            double d;
            if (x < 0)
            {
                double temp_x = Math.Pow(x, a);
                double temp_e = Math.Exp(x * a);
                double var_res;
                double temp_ax = (a * x) + 1;
                // Min
                if (a < temp_x && a < temp_e)
                    var_res = a;
                else if (temp_x < a && temp_x < temp_e)
                    var_res = temp_x;
                else
                    var_res = temp_e;

                // Max
                if (var_res > temp_ax)
                    d = var_res;
                else
                    d = temp_ax;
            }
            else if (0 <= x && x < 7)
            {
                if (x > y)
                    d = (Math.Pow(Math.Cos(x), 2) + Math.Sin(Math.Pow(x, 2)) * x);
                else
                    d = (Math.Pow(Math.Cos(x), 2) + Math.Sin(Math.Pow(x, 2)) * y);
            }
            else
                d = (1 + 3 * Math.Cos(Math.Abs(x + y)));
            return d;
        }
    }
}


