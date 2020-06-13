using Factory.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public int Cost { get; set; }
        public PizzaType PizzaTypeSet { get; set; }
        public Pizza(int id,int cost, PizzaType type) 
        {
            this.PizzaID = id;
            this.Cost = cost;
            this.PizzaTypeSet = type;
        }
    }
}
