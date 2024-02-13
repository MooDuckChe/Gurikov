using Dll_lab;
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
    public partial class CalcLab8 : Form
    {
        public CalcLab8()
        {
            InitializeComponent();
        }

        private void Lab8_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Make_result_lab8_Click(object sender, EventArgs e)
        {
            double x = Lab_dll.Input_user(Input_x_lab8);
            double eps = Lab_dll.Input_user(Input_eps_lab8);
            double MaxIter = Lab_dll.Input_user(Input_MaxIter_lab8);
            Lab_dll.Lab8_Result(x, eps, MaxIter, Lab8_dataGridView);
        }

        private void Input_x_lab8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_x_lab8.Text);
        }

        private void Input_eps_lab8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_eps_lab8.Text);
        }

        private void Input_MaxIter_lab8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_MaxIter_lab8.Text);
        }
    }
}
