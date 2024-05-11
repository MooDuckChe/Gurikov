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
    public partial class Sem2_Info_Lab_2 : Form
    {
        public Sem2_Info_Lab_2()
        {
            InitializeComponent();
        }

        private void Btn_goto_Sen_CalcLab2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var Sem2_CalcLab2 = new Sem2_CalcLab2();
            Sem2_CalcLab2.ShowDialog();

            this.Close();
        }
    }
}
