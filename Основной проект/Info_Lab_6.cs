using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа
{
    public partial class Info_Lab_6 : Form
    {
        public Info_Lab_6()
        {
            InitializeComponent();
        }

        private void Btn_goto_calcLab6_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var CalcLab6 = new CalcLab6();
            CalcLab6.ShowDialog();

            this.Close();
        }
    }
}
