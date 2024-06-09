using Microsoft.Office.Interop.Excel;
using Second_Semestr_Dll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Лабораторная_работа
{
    public partial class Sem2_CalcLab4result : Form
    {
        public Sem2_CalcLab4result()
        {
            InitializeComponent();

            string rating = "Ваша оценка - ";

            int count = 0;

            

            Sem2_Lab3_dataGridView_Result.ColumnCount = 5;
            Sem2_Lab3_dataGridView_Result.RowCount = 2;

            for (int i = 0; i < 5; i++)
            {
                Sem2_Lab3_dataGridView_Result.Rows[0].Cells[i].Value = "[" + (i+1) + "]";
                if (Answer_Base.True_False[i] == true)
                {
                    Sem2_Lab3_dataGridView_Result.Rows[1].Cells[i].Value = "Верно";
                    count++;
                }
                else
                    Sem2_Lab3_dataGridView_Result.Rows[1].Cells[i].Value = "Неверно";
            }

            if (count < 2)
                Sem2_Lab3_Result_Label.Text = rating + "2";
            else
                Sem2_Lab3_Result_Label.Text = rating + count.ToString();
        }

        private void Sem2_Lab4_five_question_button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sem2_Lab4_Save_TXT_button_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = File.CreateText("Результаты.txt");
            streamWriter.WriteLine("Номер вопроса:");
            string strAdd = "    ";
            for (int i = 0; i < 5; i++)
                strAdd += "[#" + i.ToString() + "]" + "           ";
            streamWriter.WriteLine(strAdd);
            streamWriter.WriteLine("Результат ответа:");
            strAdd = "";
            for (int i = 0; i < 5; i++)
                strAdd += "[" + (Answer_Base.True_False[i].ToString() == "True" ? "Правильно" : "Неправильно") + "]" + "  ";
            streamWriter.WriteLine(strAdd);
            streamWriter.Close();
            Process.Start("Результаты.txt");
        }

        private void Sem2_Lab4_Save_Excel_button_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook WB = excel.Workbooks.Add();
            Excel.Worksheet ws = WB.Worksheets[1];
            ws.Name = "Результат";
            ws.Cells[2, 1] = "Номер вопроса:";
            ws.Cells[3, 1] = "Результат ответа:";
            for (int i = 1; i < 6; i++)
            {
                ws.Cells[2, i + 1] = "[" + i + "]";
                ws.Cells[3, i + 1] = (Answer_Base.True_False[i-1].ToString() == "True" ? "Правильно" : "Неправильно");
            }
            Excel.Range usedRange = ws.UsedRange;
            usedRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Автоматически подстраиваем ширину столбцов под содержимое
            for (int i = 1; i <= ws.UsedRange.Columns.Count; i++)
            {
                Excel.Range column = ws.Columns[i];
                column.AutoFit();
            }

            excel.Visible = true;
            excel.UserControl = true;
        }

        private void Sem2_Lab4_Save_Word_button_Click(object sender, EventArgs e)
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Range range = doc.Range();


            range.Text = "[Номер вопроса] Результат";
            for (int i = 0; i < 5; i++)
            {
                range.Text += "[" + (i+1).ToString() + "] " + (Answer_Base.True_False[i].ToString() == "True" ? "Правильно" : "Неправильно");
            }

            word.Visible = true;
        }
    }
}
