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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindowButton_Click(Object sender, EventArgs e)
        {
            // Скрытие первого окна
            this.Visible = false;

            // Открытие второй формы
            var ChooseLab = new ChooseLab();
            ChooseLab.ShowDialog();
            //var Info_Lab_2 = new Info_Lab_2();
            //Info_Lab_2.ShowDialog();

            //Возвращение главной формы
            this.Visible = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
