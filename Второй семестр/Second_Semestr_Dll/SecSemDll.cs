using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Semestr_Dll
{
    public class SecSem_Dll
    {
        public static void Enter_massiv(int[] mas, int length, int a, int b)
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                mas[i] = rnd.Next(a, b);
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

        public static void Sem2_Lab3_DGV_in_Array(int[] array, DataGridView dataGridView)
        {
            int length = array.Length;
            dataGridView.ColumnCount = length;
            dataGridView.RowCount = 2;
            for (int i = 0; i < length; i++)
            {
                dataGridView.Rows[0].Cells[i].Value = "[" + i + "]";
                dataGridView.Rows[1].Cells[i].Value = array[i];
            }
        }
        public static void Sem2_Lab3_Calculate(double result, int[] mas, out int k, out int[] output)
        {
            // Вывести четные числа которые больше геометрического
            int index = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > result)
                    index++;
            }

            output = new int[index];
            k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                //if (mas[i] % 2 == 0 && mas[i] > result) Не понял правильно задание?
                if (mas[i] > result)
                {
                    output[k] = mas[i];
                    k++;
                }
            }

        }


    }
}
