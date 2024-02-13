using Dll_lab;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    public partial class CalcLab4 : Form
    {
        public CalcLab4()
        {
            InitializeComponent();
        }

        private void Make_result_lab4_Click(object sender, EventArgs e)
        {
            double a = Lab_dll.Input_user(Input_a_lab4);
            double x = Lab_dll.Input_user(Input_x_lab4);
            double y = Lab_dll.Input_user(Input_y_lab4); // Берем данные
            double return_result = Lab_dll.Lab4_Make_result(a, x, y);
            Lab_dll.Out_info(lab4_result_d, return_result);  
        }

        private void Lab4_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Input_a_lab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_a_lab4.Text);
        }

        private void Input_x_lab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_x_lab4.Text);
        }

        private void Input_y_lab4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_y_lab4.Text);
        }
    }
}
