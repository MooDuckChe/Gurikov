using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лабораторная_работа;

namespace Лабораторная_работа__2
{
    public partial class ChooseLab : Form
    {
        public ChooseLab()
        {
            InitializeComponent();
        }

        private void Btn_goto_lab2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var Info_Lab_2 = new Info_Lab_2();
            Info_Lab_2.ShowDialog();

            this.Close();
        }

        private void Btn_goto_lab3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var Info_Lab_3 = new Info_Lab_3();
            Info_Lab_3.ShowDialog();

            this.Close();
        }

        private void Btn_goto_lab4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var Info_Lab_4 = new Info_Lab_4();
            Info_Lab_4.ShowDialog();

            this.Close();
        }

        private void Btn_goto_lab6_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Info_Lab_6 = new Info_Lab_6();
            Info_Lab_6.ShowDialog();

            this.Close();
        }

        private void Btn_goto_lab8_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Info_Lab_8 = new Info_Lab_8();
            Info_Lab_8.ShowDialog();

            this.Close();
        }

        private void Btn_goto_Sem2_Lab2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Sem2_Info_Lab_2 = new Sem2_Info_Lab_2();
            Sem2_Info_Lab_2.ShowDialog();

            this.Close();
        }

        private void Btn_goto_Sem2_Lab3_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Sem2_Info_Lab_3 = new Sem2_Info_Lab_3();
            Sem2_Info_Lab_3.ShowDialog();

            this.Close();
        }

        private void Btn_goto_Sem2_Lab4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Sem2_Info_Lab_4 = new Sem2_Info_Lab_4();
            Sem2_Info_Lab_4.ShowDialog();

            this.Close();
        }
    }
}
