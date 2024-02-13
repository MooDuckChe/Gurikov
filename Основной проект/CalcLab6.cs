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
    public partial class CalcLab6 : Form
    {
        public CalcLab6()
        {
            InitializeComponent();
        }


        private void Make_result_lab6_Click(object sender, EventArgs e)
        {
            if (Input_a_lab6.Text.Length == 0)
                return;
            if (Input_x_lab6.Text.Length == 0)
                return;
            if (Input_y_lab6.Text.Length == 0)
                return;
            if (Input_step_lab6.Text.Length == 0)
                return;
            if (Input_end_cycle_lab6.Text.Length == 0)
                return;
            
            double a = Lab_dll.Input_user(Input_a_lab6);
            double x = Lab_dll.Input_user(Input_x_lab6);
            double y = Lab_dll.Input_user(Input_y_lab6);
            double step = Lab_dll.Input_user(Input_step_lab6);
            double end_cycle = Lab_dll.Input_user(Input_end_cycle_lab6);

            Lab_dll.Lab6_tabulation(Lab6_Table_Values, a, x, y, step, end_cycle, out double result_min_lab6, out double result_average_under_zero_lab6);

            Lab_dll.Out_info(Output_result_min_lab6, result_min_lab6);
            Lab_dll.Out_info(Output_result_average_under_zero_lab6, result_average_under_zero_lab6);

        }

        private void Input_a_lab6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_a_lab6.Text);
        }
        private void Input_x_lab6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_x_lab6.Text);
        }

        private void Input_y_lab6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_y_lab6.Text);
        }

        private void Input_step_lab6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_step_lab6.Text);
        }

        private void Input_end_cycle_lab6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Lab_dll.Input_lab3_KeyPress(e, Input_end_cycle_lab6.Text);
        }
    }
}
