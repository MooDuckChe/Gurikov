using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll_lab;

namespace Лабораторная_работа__2
{
    public partial class CalcLab3 : Form
    {
        public CalcLab3()
        {
            InitializeComponent();
        }

        

        private void Make_result_lab3_Click(object sender, EventArgs e)
        {
            double a1 = Lab_dll.Input_user(Input_a1_lab3);
            double a2 = Lab_dll.Input_user(Input_a2_lab3);
            double b1 = Lab_dll.Input_user(Input_b1_lab3);
            double b2 = Lab_dll.Input_user(Input_b2_lab3);
            double c1 = Lab_dll.Input_user(Input_c1_lab3);
            double c2 = Lab_dll.Input_user(Input_c2_lab3); // Берем данные

            double Lab3_Res_X = 0;
            double Lab3_Res_Y = 0;

            Lab_dll.Lab3_All_Out(a1, a1, b1, b2, c1, c2, out Lab3_Res_X, out Lab3_Res_Y);

            Lab_dll.Out_info(lab3_result_x, Lab3_Res_X);
            Lab_dll.Out_info(lab3_result_y, Lab3_Res_Y);
        }

        private void Input_a1_lab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_a1_lab3.Text);
        }

        private void Input_a2_lab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_a2_lab3.Text);
        }

        private void Input_b1_lab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_b1_lab3.Text);
        }

        private void Input_b2_lab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_b2_lab3.Text);
        }

        private void Input_c1_lab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_c1_lab3.Text);
        }

        private void Input_c2_lab3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_c2_lab3.Text);
        }

        private void Lab3_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
