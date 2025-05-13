using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening.Entities
{
    abstract class Bankrekening
    {
        public double saldo;

        public string Adres { get; set; }
        public double HuidigSaldo { get; set; }
        public string Naam { get; set; }

        protected Bankrekening(double opening, string name, string address)
        {
            HuidigSaldo = opening;
            Naam = name;
            Adres = address;
        }

        public abstract double BerekenRente();

        public virtual void CreditSaldo(double amount)
        {
            if (amount < 0)
            {
                HuidigSaldo += amount;
            }
        }

        public void DebetSaldo(double amount)
        {
            if (amount > 0)
            {
                HuidigSaldo += amount;
            }
        }

        public override string ToString()
        {
            return $"{Naam} | {Adres}";
        }
    }
}
