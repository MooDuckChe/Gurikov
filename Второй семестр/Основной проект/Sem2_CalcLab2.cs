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
    public partial class Sem2_CalcLab2 : Form
    {
        public Sem2_CalcLab2()
        {
            InitializeComponent();
        }

        public class Calc
        {
            public bool OK
            {  get; set; }

            public Calc()
            {
                
            }

            public Calc(double a1, double a2, double b1, double b2, double c1, double c2)
            {
                this.A1 = a1;
                this.A2 = a2; 
                this.B1 = b1;
                this.B2 = b2;
                this.C1 = c1;
                this.C2 = c2;
            }

            private double _a1;
            public double A1
            {
                get => _a1;
                set { _a1 = value; }
            }

            private double _a2;
            public double A2
            {
                get => _a2;
                set { _a2 = value; }
            }

            private double _b1;
            public double B1
            {
                get => _b1;
                set { _b1 = value; }
            }

            private double _b2;
            public double B2
            {
                get => _b2;
                set { _b2 = value; }
            }

            private double _c1;
            public double C1
            {
                get => _c1;
                set { _c1 = value; }
            }

            private double _c2;
            public double C2
            {
                get => _c2;
                set { _c2 = value; }
            }

            private double _Sem2_Lab3_Res_X;

            public double Sem2_Lab3_Res_X
            {
                get => _Sem2_Lab3_Res_X;
                set { _Sem2_Lab3_Res_X = value; }
            }

            private double _Sem2_Lab3_Res_Y;

            public double Sem2_Lab3_Res_Y
            {
                get => _Sem2_Lab3_Res_Y;
                set { _Sem2_Lab3_Res_Y = value; }
            }

            public void Sem2_Lab2_Resh(double a1, double a2, double b1, double b2, double c1, double c2)
            {
                double delta = Lab_dll.Lab3_Matrix(a1, a2, b1, b2);
                double delta_x = Lab_dll.Lab3_Matrix(c1, c2, b1, b2);
                double delta_y = Lab_dll.Lab3_Matrix(a1, a2, c1, c2);
                this.Sem2_Lab3_Res_X = delta_x / delta;
                this.Sem2_Lab3_Res_Y = delta_y / delta;
            }

        }

        private void Sem2_Lab2_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void make_result_lab3_Click(object sender, EventArgs e)
        {
            double a1 = Lab_dll.Input_user(Input_a1_lab3);
            double a2 = Lab_dll.Input_user(Input_a2_lab3);
            double b1 = Lab_dll.Input_user(Input_b1_lab3);
            double b2 = Lab_dll.Input_user(Input_b2_lab3);
            double c1 = Lab_dll.Input_user(Input_c1_lab3);
            double c2 = Lab_dll.Input_user(Input_c2_lab3); // Берем данные
            Calc calc = new Calc(a1, a2, b1, b2, c1, c2);

            calc.Sem2_Lab2_Resh(calc.A1, calc.A2, calc.B1, calc.B2, calc.C1, calc.C2);
            
            Lab_dll.Out_info(lab3_result_x, calc.Sem2_Lab3_Res_X);
            Lab_dll.Out_info(lab3_result_y, calc.Sem2_Lab3_Res_Y);
        }
    }
}
