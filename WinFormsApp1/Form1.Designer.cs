﻿
namespace WinFormsApp1
{
    partial class calc1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX4 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtY4 = new System.Windows.Forms.TextBox();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblResultadoY = new System.Windows.Forms.Label();
            this.btnCalcX = new System.Windows.Forms.Button();
            this.txtCalcX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAlfa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnormal = new System.Windows.Forms.Label();
            this.lblBeta = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre com os valores X e Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(260, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(72, 68);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 23);
            this.txtX1.TabIndex = 1;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(216, 68);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 23);
            this.txtY1.TabIndex = 5;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(72, 107);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 23);
            this.txtX2.TabIndex = 2;
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(72, 183);
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(100, 23);
            this.txtX4.TabIndex = 4;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(72, 145);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(100, 23);
            this.txtX3.TabIndex = 3;
            // 
            // txtY4
            // 
            this.txtY4.Location = new System.Drawing.Point(216, 183);
            this.txtY4.Name = "txtY4";
            this.txtY4.Size = new System.Drawing.Size(100, 23);
            this.txtY4.TabIndex = 8;
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(216, 145);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(100, 23);
            this.txtY3.TabIndex = 7;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(216, 107);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 23);
            this.txtY2.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalcular.Location = new System.Drawing.Point(72, 212);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(244, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Location = new System.Drawing.Point(72, 239);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(244, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Resultado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblResultadoY);
            this.panel2.Controls.Add(this.btnCalcX);
            this.panel2.Controls.Add(this.txtCalcX);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-13, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 128);
            this.panel2.TabIndex = 35;
            // 
            // lblResultadoY
            // 
            this.lblResultadoY.AutoSize = true;
            this.lblResultadoY.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoY.ForeColor = System.Drawing.Color.Magenta;
            this.lblResultadoY.Location = new System.Drawing.Point(151, 52);
            this.lblResultadoY.Name = "lblResultadoY";
            this.lblResultadoY.Size = new System.Drawing.Size(53, 37);
            this.lblResultadoY.TabIndex = 6;
            this.lblResultadoY.Text = "???";
            // 
            // btnCalcX
            // 
            this.btnCalcX.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalcX.Location = new System.Drawing.Point(297, 16);
            this.btnCalcX.Name = "btnCalcX";
            this.btnCalcX.Size = new System.Drawing.Size(75, 23);
            this.btnCalcX.TabIndex = 18;
            this.btnCalcX.Text = "Calcular X";
            this.btnCalcX.UseVisualStyleBackColor = false;
            this.btnCalcX.Click += new System.EventHandler(this.btnCalcX_Click);
            // 
            // txtCalcX
            // 
            this.txtCalcX.Location = new System.Drawing.Point(197, 16);
            this.txtCalcX.Name = "txtCalcX";
            this.txtCalcX.Size = new System.Drawing.Size(100, 23);
            this.txtCalcX.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "O Valor de Y é:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Entre com valor de X:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblAlfa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtnormal);
            this.panel1.Controls.Add(this.lblBeta);
            this.panel1.Location = new System.Drawing.Point(11, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 53);
            this.panel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(321, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "X";
            // 
            // lblAlfa
            // 
            this.lblAlfa.AutoSize = true;
            this.lblAlfa.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlfa.ForeColor = System.Drawing.Color.Magenta;
            this.lblAlfa.Location = new System.Drawing.Point(46, 9);
            this.lblAlfa.Name = "lblAlfa";
            this.lblAlfa.Size = new System.Drawing.Size(53, 37);
            this.lblAlfa.TabIndex = 4;
            this.lblAlfa.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(177, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "*";
            // 
            // txtnormal
            // 
            this.txtnormal.AutoSize = true;
            this.txtnormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnormal.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtnormal.Location = new System.Drawing.Point(14, 22);
            this.txtnormal.Name = "txtnormal";
            this.txtnormal.Size = new System.Drawing.Size(35, 21);
            this.txtnormal.TabIndex = 2;
            this.txtnormal.Text = "Y =";
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBeta.ForeColor = System.Drawing.Color.Magenta;
            this.lblBeta.Location = new System.Drawing.Point(200, 8);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(53, 37);
            this.lblBeta.TabIndex = 0;
            this.lblBeta.Text = "???";
            // 
            // calc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY3);
            this.Controls.Add(this.txtY4);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.txtX4);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "calc1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4 pontos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX4;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.TextBox txtY4;
        private System.Windows.Forms.TextBox txtY3;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResultadoY;
        private System.Windows.Forms.Button btnCalcX;
        private System.Windows.Forms.TextBox txtCalcX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtnormal;
        private System.Windows.Forms.Label lblBeta;
    }
}