
using PizzaBilling.BasePizza;
using PizzaBilling.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBilling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePizzaClass basePizza = new Farmhouse();

            Topping extraCheese = new ExtraCheese(basePizza);

            Topping mushroomAndExtraCheese = new Mushrooms(extraCheese);

            Console.WriteLine("extraCheese : " + extraCheese.cost());
            Console.WriteLine("mushroomAndExtraCheese : " + mushroomAndExtraCheese.cost());
            Console.ReadKey();
        }
    }
}
