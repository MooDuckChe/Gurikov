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
    public partial class Sem2_Info_Lab_4 : Form
    {
        public Sem2_Info_Lab_4()
        {
            InitializeComponent();
        }

        private void Btn_goto_Sem_CalcLab4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Sem2_CalcLab4 = new Sem2_CalcLab4();
            Sem2_CalcLab4.ShowDialog();

            this.Close();
        }
    }
}
