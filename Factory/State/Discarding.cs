using PizzaBuilding.Abstractions;
using PizzaBuilding.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBuilding.State
{
    public class Discarding : Discard
    {
        
        public override string DiscardCheese(Context context, Order order)
        {

            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 1);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(1);
            return "\nRemoving Cheese!\n";
        }
        public override string DiscardChicken(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 2);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(2);
            return "\nRemoving Chicken!\n";
        }
        public override string DiscardCorn(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 3);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(3);
            return "\nRemoving Corn!\n";
        }
        public override string DiscardKetchup(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 7);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(5);
            return "\nRemoving Ketchup!\n";
        }
        public override string DiscardMayo(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 4);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(4);
            return "\nRemoving Mayo!\n";
        }
        public override string DiscardMushrooms(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 5);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(5);
            return "\nRemoving Mushrooms!\n";
        }   
        public override string DiscardMustard(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 6);
            if (rawProduct == null)
            {
                return "\nThat topping hasn't been selected!";
            }
            order.DiscardToppingFromOrder(5);
            return "\nRemoving Mustard!\n";
        }
    }
}

