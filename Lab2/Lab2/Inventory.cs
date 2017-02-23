using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Inventory
    {
        
        List<SaleItem> saleItems = new List<SaleItem>();

        public void AddItem(SaleItem saleItem)
        {
            saleItems.Add(saleItem);
        }

        public Double GetInvCostTotal()
        {
            Double total = 0;

            foreach (var item in saleItems)
            {
                Double values = (item.QtyOnHand * item.Cost);
                total += values;  
            }
            return total;
        }

        public Double GetInvRetailTotal()
        {
            Double total = 0;

            foreach (var item in saleItems)
            {
                Double values = (item.QtyOnHand * item.PricePerUnit);
                total += values;
            }
            return total;
        }

        public string GetByID(int id)
        {
            SaleItem saleItem = saleItems.Find(x => x.Id == id);

            return saleItem.ToString();
        }

    }
}
