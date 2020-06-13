using Factory;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaBuilding.Abstractions;
using System.Linq;
using PizzaBuilding.Models;

namespace PizzaBuilding.Implementations
{
    public class Order : BaseOrder
    {
        public override List<Topping> _order { get; set; } = new List<Topping>();
        public Pizza pizza;
        public string AddToppingToOrder(Topping topping)
        {
            this._order.Add(topping);
            if (topping == null)
            {
                return "Failed to add product to cart";
            }
            return "Product has been succesfully added";
        }        
        public string AddPizzaToOrder(Pizza pizza)
        {
            this.pizza = pizza;
            if (pizza == null)
            {
                return "Failed to add product to cart";
            }
            return "Product has been succesfully added";
        }
        public string DiscardToppingFromOrder(int id)
        {
            var rawProduct = this._order.FirstOrDefault(i => i.ToppingID == id);
            this._order.Remove(rawProduct);
            if (rawProduct == null)
            {
                return "Failed to remove product from cart";
            }
            return "Product has been removed successfully";
        }

    }
}
