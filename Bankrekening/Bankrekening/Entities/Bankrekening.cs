using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening.Entities
{
    abstract class Bankrekening
    {
        private double _saldo;

        public string Adres { get; set; }
        public double HuidigSaldo { get { return _saldo; } }
        public string Naam { get; set; }

        protected Bankrekening(double opening, string name, string address)
        {
            _saldo = opening;
            Naam = name;
            Adres = address;
        }

        public abstract double BerekenRente();

        public virtual void CreditSaldo(double amount)
        {
            if (amount < 0)
            {
                _saldo += amount;
            }
        }

        public void DebetSaldo(double amount)
        {
            if (amount > 0)
            {
                _saldo += amount;
            }
        }

        public override string ToString()
        {
            return $"{Naam} | {Adres}";
        }
    }
}
