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
    public partial class Sem2_Info_Lab_3 : Form
    {
        public Sem2_Info_Lab_3()
        {
            InitializeComponent();
        }

        private void Btn_goto_Sem_CalcLab2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // Открытие третьей формы
            var Sem2_CalcLab3 = new Sem2_CalcLab3();
            Sem2_CalcLab3.ShowDialog();

            this.Close();
        }
    }
}
