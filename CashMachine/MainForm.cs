﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int amount;
            String n100, n50, n20, n10;

            if(int.TryParse(tbxAmountWithdraw.Text, out amount))
            {
                if (amount == 0)
                    MessageBox.Show("Entrada inválida"
                                  +  Environment.NewLine + Environment.NewLine
                                  + "Insira um valor maior que zero", "Erro");
                else
                {
                    Atm withdraw = new Atm();

                    if (withdraw.CalcWithdraw(amount))
                    {
                        if (withdraw.N100notes > 0)
                            n100 = "Notas de 100 reais: " + withdraw.N100notes.ToString() + Environment.NewLine;
                        else
                            n100 = "";

                        if (withdraw.N50notes > 0)
                            n50 = "Notas de 50 reais: " + withdraw.N50notes.ToString() + Environment.NewLine;
                        else
                            n50 = "";

                        if (withdraw.N20notes > 0)
                            n20 = "Notas de 20 reais: " + withdraw.N20notes.ToString() + Environment.NewLine;
                        else
                            n20 = "";

                        if (withdraw.N10notes > 0)
                            n10 = "Notas de 10 reais: " + withdraw.N10notes.ToString() + Environment.NewLine;
                        else
                            n10 = "";

                        MessageBox.Show("R$ " + amount.ToString() + " sacados"
                                       + Environment.NewLine + Environment.NewLine
                                       + n100 + n50 + n20 + n10,
                                        "Dinheiro sacado");
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel Sacar"
                                      +  Environment.NewLine + Environment.NewLine
                                      + "Não é possível sacar o valor desejado "
                                      + "apenas com notas de 100, 50, 20 ou 10 reais",  "Erro");
                    }
                }
            }
            else
            {
                MessageBox.Show(  "Entrada inválida"
                                +  Environment.NewLine + Environment.NewLine
                                + "Insira apenas números", "Erro");
            }

            tbxAmountWithdraw.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "1";
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "2";
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "3";
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "4";
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "5";
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "6";
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "7";
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "8";
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "9";
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            tbxAmountWithdraw.Text += "0";
        }
    }
}
