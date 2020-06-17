using Factory;
using PizzaBuilding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.Abstractions
{
    public abstract class BaseOrder
    {
        public virtual List<Topping> _order { get; set; }
        public virtual Dictionary<Pizza, Topping> order { get; set; }
    }
}
