using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory myInventory = new Inventory();
            

            Tool tool1 = new Tool(1, "Hammer", "Hammers things", 30.00, "Tools", 10);
            tool1.CalcMarkup();
            ComputerPart cPart1 = new ComputerPart(22, "Hard Drive", "Stores Stuff", 100.00, "Hard Drives", 10);
            cPart1.CalcMarkup();
            ElectronicProduct eProd1 = new ElectronicProduct(33, "Camera", "Takes Pictures", 800.00, "Cameras", 10);
            eProd1.CalcMarkup();

            myInventory.AddItem(tool1);
            myInventory.AddItem(cPart1);
            myInventory.AddItem(eProd1);



            Console.WriteLine(myInventory.GetByID(1));
            Console.WriteLine();
            Console.WriteLine(myInventory.GetByID(22));
            Console.WriteLine();
            Console.WriteLine(myInventory.GetByID(33));
            Console.WriteLine();

            Console.WriteLine(myInventory.GetInvCostTotal());
            Console.WriteLine();
            Console.WriteLine(myInventory.GetInvRetailTotal());


            Console.ReadLine();

        }
    }
}
