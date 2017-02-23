using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class SaleItem
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Cost { get; set; }
        public double pricePerUnit;
        public String SalesDepartment { get; set; }
        public int QtyOnHand { get; set; }

        public SaleItem(int id, String name, String desc, double cost, String salesdep, int onhand)
        {
            Id = id;
            Name = name;
            Description = desc;
            Cost = cost;
            SalesDepartment = salesdep;
            QtyOnHand = onhand;
        }

        public double PricePerUnit
        {
            get { return pricePerUnit; }
            set { pricePerUnit = value; }
        }

        public override string ToString()
        {
            return "Name: " + Name + " Department: " + SalesDepartment + " Price per unit: " + PricePerUnit;
        }

        public abstract double CalcMarkup();
    }
}
