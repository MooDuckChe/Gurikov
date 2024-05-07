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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Diagnostics;


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
            
            Lab2_Sem3_Main_DGV.ColumnCount = 0;

            string length_text = Interaction.InputBox("Введите количество элементов массива для генерации", "Заголовок окна", "0", -1, -1); // Количество
            int length = Convert.ToInt32(length_text);

            string min_text = Interaction.InputBox("Нижняя граница генерации", "Заголовок окна", "0", -1, -1);
            int min = Convert.ToInt32(min_text);
            
            string max_text = Interaction.InputBox("Верхняя граница генерации", "Заголовок окна", "0", -1, -1);
            int max = Convert.ToInt32(max_text);

            int[] mas = new int[length];

            SecSem_Dll.Enter_massiv(mas, length, min, max);
            SecSem_Dll.Output_massiv(mas, length, Lab2_Sem3_Main_DGV);

            double geometric = 1.0;
            double count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    geometric *= mas[i];
                    count++;
                }
            }
            // (x1*x2*x3*x4*x5) ^ (1/5);
            double result = Math.Pow(geometric, (1 / count));


            // Четные, среднее геометрическое, вывести числа больше геом четных
            SecSem_Dll.Sem2_Lab3_Calculate(result, mas, out int k, out int[] output);

            MessageBox.Show("Найдено: " + k.ToString() + " элементов", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            SecSem_Dll.Output_massiv(output, k, Lab2_Sem3_Resh_DGV);

            array = mas; // Открываем массив для других функций
            array2 = output;
        }
        private void Sem2_Lab3_Save_Txt_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = File.CreateText("Массивы.txt");
            streamWriter.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                streamWriter.WriteLine(array[i].ToString());
            }
            streamWriter.WriteLine("Конечный массив:");
            for (int i = 0; i < array2.Length; i++)
            {
                streamWriter.WriteLine(array2[i].ToString());
            }

            streamWriter.Close();
            Process.Start("Массивы.txt");
        }

        private void Sem2_Lab3_Save_Word_Click(object sender, EventArgs e)
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Range range = doc.Range();


            range.Text = "Исходный массив:\n";
            for (int i = 0; i < array.Length; i++)
            {
                range.Text += "[" + i + "] " + array[i].ToString() + "\n";
            }

            range.Text += "\nКонечный массив:\n";
            for (int i = 0; i < array2.Length; i++)
            {
                range.Text += "[" + i + "] " + array2[i].ToString() + "\n";
            }

            word.Visible = true;
        }

        private void Sem2_Lab3_Save_Excel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook WB = excel.Workbooks.Add();
            Excel.Worksheet ws = WB.Worksheets[1];
            ws.Name = "Исходный массив";
            for (int i = 0; i < array.Length; i++)
            {
                ws.Cells[2, i + 1] = "[" + i + "]";
                ws.Cells[3, i + 1] = array[i].ToString();
            }
            Excel.Worksheet ws2 = WB.Worksheets.Add();
            ws2.Name = "Конечный массив";
            for (int i = 0; i < array2.Length; i++)
            {
                ws2.Cells[2, i + 1] = "[" + i + "]";
                ws2.Cells[3, i + 1] = array2[i].ToString();
            }
            excel.Visible = true;
            excel.UserControl = true;
        }
    }
}
