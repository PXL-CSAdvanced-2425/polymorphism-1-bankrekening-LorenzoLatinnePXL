using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening.Entities
{
    class Zichtrekening : Bankrekening
    {
        public Zichtrekening(double opening, string name, string address) : base(opening, name, address)
        {

        }

        public override double BerekenRente()
        {
            return HuidigSaldo * 0.005;
        }

        public override void CreditSaldo(double amount)
        {
            if (HuidigSaldo + amount < 0)
            {
                throw new BankException("Your balance is insufficient.");
            }
            else
            {
                base.CreditSaldo(amount);
            }
        }
    }
}
