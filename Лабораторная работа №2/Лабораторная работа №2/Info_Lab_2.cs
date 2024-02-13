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
    public partial class Info_Lab_2 : Form
    {
        public Info_Lab_2()
        {
            InitializeComponent();
        }

        private void Btn_list2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var CalcLab2 = new CalcLab2();
            CalcLab2.ShowDialog();

            this.Close();
        }
    }
}
