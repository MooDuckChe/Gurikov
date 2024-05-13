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
        public static void Enter_massiv(int[] mas, int length, int min, int max)
        {
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
        public static void Sem2_Lab5_Fill_Array(int[,] mas, int length, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    mas[i,j] = rnd.Next(min, max);
        }
        public static void Sem2_Lab5_Output_DGV(int[,] mas, int length, DataGridView Table)
        {
            length+=1;
            Table.ColumnCount = length;
            Table.RowCount = length;

            Table.Rows[0].Cells[0].Value = $"[{length-1}][{length-1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[0].Cells[i].Value = $"[{i - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[i].Cells[0].Value = $"[{i - 1}]";

            for (int i = 1; i < length; i++)
                for (int j = 1; j < length; j++)
                    Table.Rows[i].Cells[j].Value = mas[i-1, j-1];
        }
        public static void Sem2_Lab5_Calculate(int[,] main, int length, out int count_div_3)
        {
            int k = 0;
            count_div_3 = 0;
            for(int i = 0 + k; i < length; i++)
            {
                for (int j = 0 + k; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != 0)
                        count_div_3++;
                k++;
            }
        }

        // Пробел
        public static void Sem2_Lab5_Replace_Num_Var1(int count_nums, int length, int[,] main, DataGridView Table)
        {
            (int i, int j)[] coords = new (int i, int j)[count_nums];
            int count_coords = 0;
            int k = 0;
            for (int i = 0 + k; i < length; i++)
            {
                for (int j = 0 + k; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != 0)
                        coords[count_coords++] = (i, j);
                k++;
            }

            Sem2_Lab5_Output_DGV(main, length, Table);

            MessageBox.Show("1");

            for (int i = 0; i < count_coords; i++)
                Table.Rows[coords[i].i].Cells[coords[i].j].Value = " ";
        }

        // Замена на 0
        public static void Sem2_Lab5_Replace_Num_Var2(int count_nums, int length, int[,] main, DataGridView Table, int[,] DGV_TWIN_ARRAY)
        {
            (int i, int j)[] coords = new (int i, int j)[count_nums];
            int count_coords = 0;
            int k = 0;
            for (int i = 0 + k; i < length; i++)
            {
                for (int j = 0 + k; j < length; j++)
                    if (main[i, j] % 3 == 0 && i != 0)
                        coords[count_coords++] = (i, j);
                k++;
            }
            DGV_TWIN_ARRAY = main;
            for (int i = 0; i < count_coords; i++)
                DGV_TWIN_ARRAY[coords[i].i, coords[i].j] = 0;

            Sem2_Lab5_Output_DGV(DGV_TWIN_ARRAY, length, Table);
        }

        // Сокращение DGV
        public static void Sem2_Lab5_Replace_Num_Var3(int count_nums, int length, int[,] main, DataGridView Table)
        {
            int all_legth = length * length;
            int dgv_count = 0;
            int[] small_dgv = new int[all_legth];

            for(int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    if (!(main[i, j] % 3 == 0 && i != 0))
                    {
                        small_dgv[dgv_count] = main[i, j];
                        dgv_count += 1;
                    }
            // Ошибка берет числа ниже диагонали 

            length += 1;
            Table.ColumnCount = length;
            Table.RowCount = length;

            Table.Rows[0].Cells[0].Value = $"[{length - 1}][{length - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[0].Cells[i].Value = $"[{i - 1}]";

            for (int i = 1; i < length; i++)
                Table.Rows[i].Cells[0].Value = $"[{i - 1}]";

            
            int limit = (int)Math.Sqrt(dgv_count);
            int when_stop = (int)Math.Pow(limit, 2);

            for (int i = 1; i < limit; i++)
            {
                for (int j = 1; j < limit; j++)
                    Table.Rows[i].Cells[j].Value = small_dgv[dgv_count--];
            }

            MessageBox.Show("test");
            //if (all_legth != when_stop)
            //{
            //    for (int i = 0; i < all_legth - when_stop; i++)
            //    {
            //        Table.Rows[limit].Cells[i].Value = small_dgv[dgv_count--];
            //    }
            //}

            //for (int j = 1; j < Math.Sqrt(dgv_count); j++)
            //    Table.Rows[i].Cells[j].Value = small_dgv[i - 1, j - 1]; if (kounter >= limit)
            //kounter = 0;

        }
        public static void Sem2_Lab5_Fill_DGV_with_Array_Filter(int[,] mas, int length, DataGridView Table)
        {
            length += 1;
            Table.ColumnCount = length;
            Table.RowCount = length;

            //Tuple<int, int> myPair = new Tuple<int, int>(1, 2);

            (int x, int y) myPair = (1, 2);


            Table.Rows[0].Cells[0].Value = $"[{length - 1}][{length - 1}]";

            for (int i = 1; i < length; i++)
            {
                myPair = (i, i+2);
                Table.Rows[0].Cells[i].Value = $"[{i - 1}]";
            }

            for (int i = 1; i < length; i++)
                Table.Rows[i].Cells[0].Value = $"[{i - 1}]";
            


            // Заполнить 0
            // Заполнить пустым местом
            // Сделать меньше DGV
            Table.Rows[0].Cells[1].Value = myPair.x;
            Table.Rows[0].Cells[1].Value = myPair.y;
        }
    }
}
