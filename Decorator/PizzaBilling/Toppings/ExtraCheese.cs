using PizzaBilling.BasePizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBilling.Toppings
{
    public class ExtraCheese : Topping
    {
        BasePizzaClass basePizza;
        public ExtraCheese(BasePizzaClass basePizza)
        {
            this.basePizza = basePizza;
        }
        public override int cost()
        {
            return this.basePizza.cost() + 100;
        }
    }
}
