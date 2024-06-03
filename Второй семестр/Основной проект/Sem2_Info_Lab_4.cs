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

            Answer_Base.k = 0;
        }

        private void Btn_goto_Sem_CalcLab4_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            var Sem2_CalcLab4 = new Sem2_CalcLab4();

           
            if (Sem2_CalcLab4.ShowDialog() == DialogResult.OK)
            {
                var Sem2_CalcLab4a = new Sem2_CalcLab4a();
                if (Sem2_CalcLab4a.ShowDialog() == DialogResult.OK)
                {
                    var Sem2_CalcLab4b = new Sem2_CalcLab4b();
                    if (Sem2_CalcLab4b.ShowDialog() == DialogResult.OK)
                    {
                        var Sem2_CalcLab4c = new Sem2_CalcLab4c();
                        if (Sem2_CalcLab4c.ShowDialog() == DialogResult.OK)
                        {
                            var Sem2_CalcLab4d = new Sem2_CalcLab4d();
                            if (Sem2_CalcLab4d.ShowDialog() != DialogResult.OK)
                            {
                                MessageBox.Show("Вы вышли досрочно из теста.");
                            }
                        }
                        else
                            MessageBox.Show("Вы вышли досрочно из теста.");
                    }
                    else
                        MessageBox.Show("Вы вышли досрочно из теста.");
                }
                else
                    MessageBox.Show("Вы вышли досрочно из теста.");
            }
            else
                MessageBox.Show("Вы вышли досрочно из теста.");

            var Sem2_CalcLab4result = new Sem2_CalcLab4result();
            Sem2_CalcLab4result.ShowDialog();

            this.Close();
        }
    }
}
