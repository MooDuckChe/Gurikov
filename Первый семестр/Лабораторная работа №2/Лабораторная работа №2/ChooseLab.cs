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
    }
}
