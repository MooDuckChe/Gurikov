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
    public partial class Info_Lab_8 : Form
    {
        public Info_Lab_8()
        {
            InitializeComponent();
        }

        private void Btn_goto_calcLab8_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var CalcLab8 = new CalcLab8();
            CalcLab8.ShowDialog();

            this.Close();
        }
    }
}
