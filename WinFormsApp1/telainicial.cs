using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class telainicial : Form
    {
        public telainicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formaulario 4 pontos
            calc1 novaCalc1 = new calc1();
            novaCalc1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //formaulario 5 pontos
            calc2 novaCalc2 = new calc2();
            novaCalc2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //formaulario 6 pontos
            calc3 novaCalc3 = new calc3();
            novaCalc3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //formaulario 7 pontos
            calc4 novaCalc4 = new calc4();
            novaCalc4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //formaulario 8 pontos
            calc5 novaCalc5 = new calc5();
            novaCalc5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //formaulario 8 pontos
            calc7 novaCalc7 = new calc7();
            novaCalc7.Show();
        }
    }
}
