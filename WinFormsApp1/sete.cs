using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class calc4 : Form
    {
        public calc4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                //Variaveis 
                double x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0, y5 = 0, y6 = 0, y7 = 0;
                double somaX = 0;
                double logY1 = 0, logY2 = 0, logY3 = 0, logY4 = 0, logY5 = 0, logY6 = 0, logY7 = 0;
                double sxq, sxy, smLogY;
                double d, da, db;
                double n = 7;
                double a = 0, b = 0;
                double beta, alfa;


                //Recuperação de dados das textbox
                x1 = double.Parse(txtX1.Text);
                x2 = double.Parse(txtX2.Text);
                x3 = double.Parse(txtX3.Text);
                x4 = double.Parse(txtX4.Text);
                x5 = double.Parse(txtX5.Text);
                x6 = double.Parse(txtX6.Text);
                x7 = double.Parse(txtX7.Text);
                y1 = double.Parse(txtY1.Text);
                y2 = double.Parse(txtY2.Text);
                y3 = double.Parse(txtY3.Text);
                y4 = double.Parse(txtY4.Text);
                y5 = double.Parse(txtY5.Text);
                y6 = double.Parse(txtY6.Text);
                y7 = double.Parse(txtY7.Text);


                //calculando Log de Y
                logY1 = System.Math.Log10(y1);
                logY2 = System.Math.Log10(y2);
                logY3 = System.Math.Log10(y3);
                logY4 = System.Math.Log10(y4);
                logY5 = System.Math.Log10(y5);
                logY6 = System.Math.Log10(y6);
                logY7 = System.Math.Log10(y7);


                //Soma de X
                somaX = x1 + x2 + x3 + x4 + x5 + x6 + x7;

                //calcula x quadrado e efetua a soma de toda coluna de x quadrado
                sxq = x1 * x1 + x2 * x2 + x3 * x3 + x4 * x4 + x5 * x5 + x6 * x6 + x7 * x7;

                //soma de Log de Y
                smLogY = logY1 + logY2 + logY3 + logY4 + logY5 + logY6 + logY7;

                //soma de X * Y
                sxy = x1 * logY1 + x2 * logY2 + x3 * logY3 + x4 * logY4 + x5 * logY5 + x6 * logY6 + x7 * logY7;


                // Achando a determinante
                d = sxq * n - somaX * somaX;

                //calculando Da
                da = sxy * n - somaX * smLogY;

                //Calculo de Db
                db = sxq * smLogY - somaX * sxy;

                //Calculando A
                a = da / d;

                //Calculando B
                b = db / d;

                //calculando beta
                beta = Math.Pow(10, a);

                //calculando alfa
                alfa = Math.Pow(10, b); ;


                lblBeta.Text = Convert.ToString(beta.ToString("F6"));
                lblAlfa.Text = Convert.ToString(alfa.ToString("F6"));
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se todos valores foram preenchidos", "Teste de calculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtX2.Clear();
            txtX3.Clear();
            txtX4.Clear();
            txtX5.Clear();
            txtX6.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtY3.Clear();
            txtY4.Clear();
            txtY5.Clear();
            txtY6.Clear();
            txtY7.Clear();
            lblBeta.ResetText();
            lblAlfa.ResetText();
        }

        private void btnCalcX_Click(object sender, EventArgs e)
        {
            double x;
            double convB, convA;
            double resultX;
            //captura o que está sendo digitado
            x = double.Parse(txtCalcX.Text);
            //Conversão de variavel Beta
            convB = double.Parse(lblBeta.Text);
            //conversão de variavel Alfa
            convA = double.Parse(lblAlfa.Text);

            resultX = convA * Math.Pow(convB, x);

            lblResultadoY.Text = Convert.ToString(resultX.ToString("F6"));
        }
    }
}
