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
    public partial class Info_Lab_4 : Form
    {
        public Info_Lab_4()
        {
            InitializeComponent();
        }

        private void Btn_goto_calcLab4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var CalcLab4 = new CalcLab4();
            CalcLab4.ShowDialog();

            this.Close();
        }
    }
}
