using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Atm
    {
        private int n100notes;
        private int n50notes;
        private int n20notes;
        private int n10notes;


        public Atm()
        {
            N100notes = 0;
            N50notes = 0;
            N20notes = 0;
            N10notes = 0;
        }

        public Boolean CalcWithdraw(int amount)
        {
            if(amount > 0)
            {
                n100notes = amount / 100;
                amount = amount % 100;

                if(amount > 0)
                {
                    n50notes = amount / 50;
                    amount = amount % 50;

                    if(amount > 0)
                    {
                        n20notes = amount / 20;
                        amount = amount % 20;

                        if(amount > 0)
                        {
                            n10notes = amount / 10;
                            amount = amount % 10;
                        }
                    }
                }
            }

            if (amount > 0)
                return false;
            else
                return true;
        }

        public int N100notes { get => n100notes; set => n100notes = value; }
        public int N50notes { get => n50notes; set => n50notes = value; }
        public int N20notes { get => n20notes; set => n20notes = value; }
        public int N10notes { get => n10notes; set => n10notes = value; }
    }
}
