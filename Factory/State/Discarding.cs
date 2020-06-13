﻿using PizzaBuilding.Abstractions;
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
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(1);
            return "  Removing milk from the cart!";
        }
        public override string DiscardChicken(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 2);
            if (rawProduct == null)
            {
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(2);
            return "  Removing bread from the cart!";
        }
        public override string DiscardCorn(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 3);
            if (rawProduct == null)
            {
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(3);
            return "  Removing eggs from the cart   !";
        }
        public override string DiscardKetchup(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 4);
            if (rawProduct == null)
            {
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(5);
            return "  Removing pepsi from the cart!";
        }
        public override string DiscardMayo(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 5);
            if (rawProduct == null)
            {
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(4);
            return " Removing oranges from the cart!";
        }
        public override string DiscardMushrooms(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 6);
            if (rawProduct == null)
            {
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(5);
            return "  Removing pepsi from the cart!";
        }   
        public override string DiscardMustard(Context context, Order order)
        {
            var rawProduct = order._order.FirstOrDefault(i => i.ToppingID == 7);
            if (rawProduct == null)
            {
                return "  That product isn't in the cart!";
            }
            order.DiscardToppingFromOrder(5);
            return "  Removing pepsi from the cart!";
        }

    }
}

