using System;
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
            int amount, i;
            String resultNotes = "";
            List<String> listNotes = new List<String>();

            if (tbxAmountWithdraw.Text == "")
                MessageBox.Show("Valor nulo", "Erro");
            else
            {
                if (int.TryParse(tbxAmountWithdraw.Text, out amount))
                {
                    if (amount <= 0)
                        MessageBox.Show("Erro de valor inválido", "Erro");
                    else
                    {
                        Atm withdraw = new Atm();

                        if (withdraw.CalcWithdraw(amount))
                        {
                            for (i = 0; i < withdraw.N100notes; i++)
                                listNotes.Add("100.00");

                            for (i = 0; i < withdraw.N50notes; i++)
                                listNotes.Add("50.00");

                            for (i = 0; i < withdraw.N20notes; i++)
                                listNotes.Add("20.00");

                            for (i = 0; i < withdraw.N10notes; i++)
                                listNotes.Add("10.00");

                            resultNotes = "[" + listNotes[0];

                            for (i = 1; i < listNotes.Count(); i++)
                            {
                                resultNotes += ", " + listNotes[i];
                            }

                            resultNotes += "]";

                            MessageBox.Show("R$ " + amount.ToString() + " sacados"
                                            + Environment.NewLine + resultNotes, "Saque efetuado");

                            listNotes.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Notas indisponíveis", "Erro");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Entrada inválida, insira apenas números", "Erro");
                }
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
