using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

using System.Security.Cryptography.X509Certificates;
using Microsoft.Office.Interop.Word;


namespace Second_Semestr_Dll
{
    public class SecSem_Dll
    {
        public static void Enter_massiv(int[] mas, int length, int min, int max)
        {
            // Убрать length так как легко крашнуть
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                mas[i] = rnd.Next(min, max);
        }
        public static void Output_massiv(int[] mas, int length, DataGridView Table)
        {
            Table.ColumnCount = length;
            Table.RowCount = 2;
            for (int i = 0; i < length; i++)
            {
                Table.Rows[0].Cells[i].Value = "[" + i + "]";
                Table.Rows[1].Cells[i].Value = mas[i];
            }
        }
        public static void Sem2_Lab3_Calc_Geometric(int[] mas, out double result)
        {
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
            result = Math.Pow(geometric, (1 / count));
        }
        public static void Sem2_Lab3_Count_Condition(int[] mas, double result, out int index)
        {
            // Вывести четные числа которые больше геометрического
            index = 0;
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] > result)
                    index++;
        }
        public static void Sem2_Lab3_Calculate(int[] mas, double result, int index, out int[] output)
        {
            
            output = new int[index];
            int k = 0;
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] > result)
                    output[k++] = mas[i];

        }
        public static void Sem2_Lab3_Save_Txt(int[] array, int[] array2)
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
        public static void Sem2_Lab3_Save_Excel(int[] array, int[] array2)
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
        public static void Sem2_Lab3_Save_Word(int[] array, int[] array2)
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Range range = doc.Range();


            range.Text = "Исходный массив:";
            for (int i = 0; i < array.Length; i++)
            {
                range.Text += "[" + i + "] " + array[i].ToString();
            }

            range.Text += "\nКонечный массив:";
            for (int i = 0; i < array2.Length; i++)
            {
                range.Text += "[" + i + "] " + array2[i].ToString() + "";
            }

            word.Visible = true;
        }

        public static void SelectMainDiagonal(DataGridView Table, int length)
        {
            for (int i = 0; i < length + 1; i++)
                Table.Rows[i].Cells[i].Selected = true;
        }
        public static void Sem2_Lab5_Select_Replaced_Nums(int[,] main, int num, DataGridView Table)
        {
            int lenght_arr = Get_Length(main);

            for (int i = 0; i < lenght_arr; i++)
                for (int j = 0; j < lenght_arr; j++)
                    if (main[i, j] > num)    
                        Table.Rows[i + 1].Cells[j + 1].Selected = true;
        }
        public static void Sem2_Lab5_Off_selected_cells(int length, DataGridView TableMain, int length2, DataGridView TableTwink)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    TableMain.Rows[i].Cells[j].Selected = false;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < length2; j++)
                    TableTwink.Rows[i].Cells[j].Selected = false;
        }

        public static void Sem2_Lab5_Fill_Array_RND_Num(int[,] mas, int min, int max)
        {
            int length = Get_Length(mas);
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    mas[i, j] = rnd.Next(min, max);
        }
        public static void Sem2_Lab5_Fill_corner_DGV(int length, DataGridView Table)
        {
            length += 1;
            Table.ColumnCount = length;
            Table.RowCount = length;

            Table.Rows[0].Cells[0].Value = $"[{length - 1}][{length - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[0].Cells[i].Value = $"[{i - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[i].Cells[0].Value = $"[{i - 1}]";
        }
        public static void Sem2_Lab5_Enter_Mas_in_DGV(int[,] mas, DataGridView Table)
        {
            int length_for_table = Get_Length(mas) + 1;

            for (int i = 1; i < length_for_table; i++)
                for (int j = 1; j < length_for_table; j++)
                    Table.Rows[i].Cells[j].Value = mas[i - 1, j - 1];

            Table.Rows[0].Cells[0].Selected = false;
        }
        public static void Sem2_Lab5_Enter_Mas_in_DGV(int[] mas, DataGridView Table)
        {
            Table.RowCount = 2;
            Table.ColumnCount = mas.Length;
            for (int i = 0; i < mas.Length; i++) 
                Table.Rows[0].Cells[i].Value = "[" + i.ToString() + "]";

            for (int i = 0; i < mas.Length; i++)
                    Table.Rows[1].Cells[i].Value = mas[i];

            Table.Rows[0].Cells[0].Selected = false;
        }
        public static int[] Sem2_Lab5_Count_Condition(int[,] main)
        {
            int[] ret = new int[2]; 
            int lenght = Get_Length(main);
            int count_condition = 0;
            for (int i = 0; i < lenght; i++)
                for (int j = 0 + i;j < lenght; j++)
                    if (main[i,j] % 3 == 0 && i != j)
                        count_condition++;

            int array_size = 0;
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                    if (main[i, j] > count_condition)
                        array_size++;
            // Чисел которые делятся на 3
            ret[0] = count_condition;

            ret[1] = array_size;

            return ret;
        }
        public static int[] Sem2_Lab5_Usually(int arr_size, int[,] main, int compare)
        {
            int[] returns = new int[arr_size];
            int lenght = Get_Length(main);
            int k = 0;
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                    if (main[i, j] > compare)
                        returns[k++] = main[i, j];

            return returns;
        }
        public static int Get_Length(int[,] mas)
        {
            int result = (int)Math.Sqrt(mas.Length);
            return result;
        }
        public static void Sem2_Lab5_Save_TXT(int[,] array, int[] array2)
        {
            
            int length = (int)Math.Sqrt(array.Length);
            StreamWriter streamWriter = File.CreateText("Массивы.txt");
            streamWriter.WriteLine("Исходный массив:");
            for (int i = 0; i < length; i++)
            {
                string strAdd = "";
                for (int j = 0; j < length; j++)
                    strAdd += "[" + array[i, j].ToString() + "]" + ' ';

                streamWriter.WriteLine(strAdd);
            }
            streamWriter.WriteLine("Конечный массив:");
            string strAdd2 = "";
            for (int i = 0; i < array2.Length; i++)
            {
                strAdd2 += "[" + array2[i].ToString() + "]" + ' ';
            }
            streamWriter.WriteLine(strAdd2);
            streamWriter.Close();
            Process.Start("Массивы.txt");
        }
        public static void Sem2_Lab5_Save_Word(int[,] main, int[] twin)
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Range range = doc.Range();

            Word.Table table = doc.Tables.Add(range, main.GetLength(0), main.GetLength(1));
            for (int i = 0; i < main.GetLength(0); i++)
            {
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    table.Cell(i + 1, j + 1).Range.Text = main[i, j].ToString();
                }
            }
            word.Visible = true;
        }
        public static void Sem2_Lab5_Save_Excel(int[,] main, int[] twin)
        {
            int lenght = Get_Length(main);
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet1, workSheet2;
            workBook = excelApp.Workbooks.Add();
            workSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.get_Item(1);
            workSheet1.Name = "Исходный массив";
            excelApp.Cells[1, 1] = "Исходный массив";
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    excelApp.Cells[i + 3, 2] = $"[{i}]";
                    excelApp.Cells[2, j + 3] = $"[{j}]";
                    excelApp.Cells[i + 3, j + 3] = main[i, j];
                }

            workSheet2 = workBook.Worksheets.Add();
            int k = 0;
            workSheet2.Name = "Результирующий массив";
            excelApp.Cells[1, 1] = "Результирующий массив";
            for (int i = 0; i < twin.Length; i++)
            {
                workSheet2.Cells[3, i+2] = "[" + (i+1) + "]";
                workSheet2.Cells[4, i+2] = twin[i];
            }
                

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}

/*
 
        public static void Sem2_Lab5_Enter_Mas_in_DGV(int[,] mas, int length, DataGridView Table)
        {
            for (int i = 1; i < length; i++)
                for (int j = 1; j < length; j++)
                    Table.Rows[i].Cells[j].Value = mas[i-1, j-1];
            Table.Rows[0].Cells[0].Selected = false;
        }
        public static void Sem2_Lab5_Fill_corner_DGV(int length, DataGridView Table)
        {
            length += 1;
            Table.ColumnCount = length;
            Table.RowCount = length;

            Table.Rows[0].Cells[0].Value = $"[{length - 1}][{length - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[0].Cells[i].Value = $"[{i - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[i].Cells[0].Value = $"[{i - 1}]";

            // Заполнить 0
            // Заполнить пустым местом
            // Сделать меньше DGV

            //(int x, int y) myPair = (1, 2);
            //Table.Rows[0].Cells[1].Value = myPair.x;
            //Table.Rows[0].Cells[1].Value = myPair.y;
        }
        public static void Sem2_Lab5_Count_Condition(int[,] main, out int count_condition, ref int[] coordinats, DataGridView Table)
        {
            int length = (int)Math.Sqrt(main.Length);
            count_condition = 0;
            int index = 0;
            // Смотрим массив а DGV +1
            for (int i = 0; i < length; i++)
            {
                for (int j = 0 + i; j < length; j++)
                {
                    if (main[i, j] % 3 == 0 && i != j)
                        coordinats[count_condition++] = index;
                    index++; 
                }
            }
            int k = 0;
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    if (main[i, j] > count_condition)
                        k++;

        }
        public static void SelectMainDiagonal(DataGridView Table, int length)
        {
            for (int i = 0; i < length + 1; i++)
                Table.Rows[i].Cells[i].Selected = !Table.Rows[i].Cells[i].Selected;
        }
        public static void Sem2_Lab5_Replace_Nums_Space(int count_nums, int length, int[,] main, int[] coord, DataGridView Table)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0 + i; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != j)
                        Table.Rows[i+1].Cells[j+1].Value = " ";
        }
        public static void Sem2_Lab5_Replace_Nums_Zero(int length, int[,] main, DataGridView Table, DataGridView TableMain)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0 + i; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != j)
                        Table.Rows[i + 1].Cells[j + 1].Value = 0;
        }
        public static void Sem2_Lab5_Reduction_DGV(int[,] main, int count_condition, int[] coordinats, DataGridView Table)
        {
            // Не смог сделать 
            // column = 4
            int lenght = (int)Math.Sqrt(main.Length);
            int new_length = (int)Math.Sqrt(main.Length - count_condition);
            MessageBox.Show("Old: " + lenght.ToString());
            MessageBox.Show("New: " + new_length.ToString() + " " + ((new_length * new_length) + ((main.Length - count_condition) - (new_length * new_length))).ToString());
            int all = (new_length * new_length) + (main.Length - count_condition) - (new_length * new_length);
            int[] new_main = new int[main.Length - count_condition];
            int k_new_main = 0;

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    if (main[i, j] % 3 == 0 && i != j)
                    {
                        continue;
                    }
                    new_main[k_new_main++] = main[i, j];
                }
            }
            int out_k = 0;
            for (int i = 0; i < new_length; i++)
            {
                for (int j = 0; j < new_length; j++)
                {
                    Table.Rows[i+1].Cells[j+1].Value = new_main[out_k++];
                }
            }
            int kpuna = 0;
            for (int i = out_k; i < all; i++, kpuna++)
            {
                Table.Rows[i + 1].Cells[kpuna].Value = new_main[i];
            }
        }
        public static void Sem2_Lab5_Replace_New_Num(int min, int max, int length, int[,] main, DataGridView Table)
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                for (int j = 0 + i; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != j)
                    {
                        int temp = rnd.Next(min, max);
                        while (temp % 3 == 0)
                            temp = rnd.Next(min, max);

                        Table.Rows[i + 1].Cells[j + 1].Value = temp;
                    }
        }
        public static void Sem2_Lab5_Select_Replaced_Nums(int length, int[,] main, DataGridView Table, DataGridView TableMain)
        {
            for (int i = 0; i < length; i++)
                for (int j = 0 + i; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != j)
                    {
                        Table.Rows[i + 1].Cells[j + 1].Selected = !Table.Rows[i + 1].Cells[j + 1].Selected;
                        TableMain.Rows[i + 1].Cells[j + 1].Selected = !TableMain.Rows[i + 1].Cells[j + 1].Selected;
                    }
        }
        public static void Sem2_Lab5_Off_selected_cells(int length, DataGridView Table, DataGridView TableMain)
        {
            for (int i = 0; i < length + 1; i++)
                for (int j = 0; j < length + 1; j++)
                {
                    Table.Rows[i].Cells[j].Selected =     false;
                    TableMain.Rows[i].Cells[j].Selected = false;
                }
        }
 
 */