using PizzaBuilding.Implementations;

using PizzaBuilding.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Abstractions
{     
    public abstract class Add
    {
        public virtual string AddCheese(Context context, Order order) { return ""; }
        public virtual string AddChicken(Context context, Order order) { return ""; }
        public virtual string AddCorn(Context context, Order order) { return ""; }
        public virtual string AddKetchup(Context context, Order order) { return ""; }
        public virtual string AddMayo(Context context, Order order) { return ""; }
        public virtual string AddMushrooms(Context context, Order order) { return ""; }
        public virtual string AddMustard(Context context, Order order) { return ""; }
        public virtual string AddMargherita(Context context, Order order) { return ""; }
        public virtual string AddPepperoni(Context context, Order order) { return ""; }
        public virtual string AddQuattroFormaggio(Context context, Order order) { return ""; }
        public virtual string AddRunningChicken(Context context, Order order) { return ""; }
        public virtual string AddVeggie(Context context, Order order) { return ""; }
    }
}
