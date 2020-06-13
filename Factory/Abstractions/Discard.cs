using System;
using System.Collections.Generic;
using System.Text;
using PizzaBuilding.Implementations;
using PizzaBuilding.State;

namespace PizzaBuilding.Abstractions
{
    public abstract class Discard
    {
        public virtual string DiscardCheese(Context context, Order order) { return ""; }
        public virtual string DiscardChicken(Context context, Order order) { return ""; }
        public virtual string DiscardCorn(Context context, Order order) { return ""; }
        public virtual string DiscardKetchup(Context context, Order order) { return ""; }
        public virtual string DiscardMayo(Context context, Order order) { return ""; }
        public virtual string DiscardMushrooms(Context context, Order order) { return ""; }
        public virtual string DiscardMustard(Context context, Order order) { return ""; }
    }
}
