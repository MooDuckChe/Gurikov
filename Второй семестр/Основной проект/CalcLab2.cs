using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    public partial class CalcLab2 : Form
    {
        public CalcLab2()
        {
            InitializeComponent();
        }

        private void Input_m_lab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputText = Input_m_lab2.Text;

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

        private void Input_c_lab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputText = Input_c_lab2.Text;

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

        private void Input_x_lab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputText = Input_x_lab2.Text;

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

        private void Input_a_lab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputText = Input_a_lab2.Text;

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

        private void Input_b_lab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string inputText = Input_b_lab2.Text;

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

        private void Make_result_lab2_Click(object sender, EventArgs e)
        {
            // Получаем значения из полей ввода
            string input_m = Input_m_lab2.Text;
            string input_c = Input_c_lab2.Text;
            string input_x = Input_x_lab2.Text;
            string input_a = Input_a_lab2.Text;
            string input_b = Input_b_lab2.Text;

            // Переменная для проверки успешности ввода

            // Проверка и парсинг значения m
            if (!double.TryParse(input_m, out double m))
            {
                MessageBox.Show("Неверный формат данных для m.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка и парсинг значения c
            if (!double.TryParse(input_c, out double c))
            {
                MessageBox.Show("Неверный формат данных для c.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка и парсинг значения x
            if (!double.TryParse(input_x, out double x))
            {
                MessageBox.Show("Неверный формат данных для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка и парсинг значения a
            if (!double.TryParse(input_a, out double a))
            {
                MessageBox.Show("Неверный формат данных для a.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка и парсинг значения b
            if (!double.TryParse(input_b, out double b))
            {
                MessageBox.Show("Неверный формат данных для b.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result_z = ( Math.Sin(x) / Math.Sqrt(1+Math.Pow(m,2) * Math.Pow(Math.Sin(x),2))) - c * m * Math.Log(m * x);
            lab2_result_z.Text = result_z.ToString();

            double result_s = Math.Exp(-a*x) * Math.Sqrt(x+1) + Math.Exp(-b*x) * Math.Sqrt(x+1.5); // a x b
            lab2_result_s.Text = result_s.ToString();
        }

        private void Lab2_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcLab2_Load(object sender, EventArgs e)
        {

        }
    }
}
