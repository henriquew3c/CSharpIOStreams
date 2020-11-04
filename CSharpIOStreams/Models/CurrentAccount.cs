using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIOStreams.Models
{
    class CurrentAccount
    {
        public int Number { get; }

        public int Agency { get; }

        public double Balance { get; private set; }
        
        public Client Holder { get; set; }

        public CurrentAccount(int number, int agency)
        {
            this.Number = number;
            this.Agency = agency;
        }

        public void Deposit(double value)
        {
            Balance += value;

        }
    }
}
