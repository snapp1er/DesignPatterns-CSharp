using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.IceCreamExample
{
    class IceCream
    {
        public string cone;
        public string flavour;
        public string topping;

        public override string ToString()
        {
            return String.Format("Cone: {0}\nFlavour: {1}\nTopping: {2}", cone, flavour, topping);
        }
    }

   abstract  class Builder
    {
        private IceCream iceCream;
        public abstract void SetCone();
        public abstract void SetFlavour();
        public abstract void SetTopping();
        public Builder()
        {
            iceCream = new IceCream();
        }
        public IceCream GetProduct()
        {
            return iceCream;
        }
        
    }

    class ChocolateBuilder : Builder
    {
        public override void SetCone()
        {
            GetProduct().cone = "Chocolate Cone";
        }

        public override void SetFlavour()
        {
            GetProduct().flavour = "Chocolate flavour";
        }

        public override void SetTopping()
        {
            GetProduct().topping = "Chocolate chips";
        }
    }

    class Director
    {
        Builder builder;
        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            if(builder != null)
            {
                builder.SetCone();
                builder.SetFlavour();
                builder.SetTopping();
            }
        }
    }
    class IceCreamExample
    {
        public static void Main(string[] args)
        {
            var waiter = new Director();
            var chief = new ChocolateBuilder();
            waiter.SetBuilder(chief);
            waiter.Construct();
            var icecream = chief.GetProduct();
            Console.WriteLine(icecream);
            /*
            OUTPUT:
            Cone: Chocolate Cone
            Flavour: Chocolate flavour
            Topping: Chocolate chips
            */
        }
    }
}
