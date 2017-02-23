using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Tool : SaleItem
    {
        public Tool(int id, string name, string desc, double cost, string salesdep, int onhand) : base(id, name, desc, cost, salesdep, onhand)
        {
        }

        public override double CalcMarkup()
        {
            if (Cost >= 80)
            {
                PricePerUnit = Cost * .18;
            }
            else
            {
                PricePerUnit = Cost * .30;
            }
            return PricePerUnit;
        }
    }
}
