using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.Models
{
    public class Topping
    {

        public int ToppingID { get; set; }
        public int Cost { get; set; }
        public ToppingType ToppingTypeSet { get; set; }

        public Topping(int id, int cost, ToppingType type)
        {
            this.ToppingID = id;
            this.Cost = cost;
            this.ToppingTypeSet = type;
        }
    }
}
