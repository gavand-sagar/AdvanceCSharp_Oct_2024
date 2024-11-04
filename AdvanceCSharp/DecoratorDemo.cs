using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    // coffie  --> RS. 100/-

    // Extra Creame --> +30

    // Large Size   --> +50

    // No Sugar    --> -10 

    public interface ICoffee {
        int getCoffeeCost();
    }


    public class Coffee : ICoffee
    {
        public int getCoffeeCost()
        {
            return 100;
        }

    }
    public class NoSugerDecorator : ICoffee
    {
        ICoffee baseObj;
        public NoSugerDecorator(ICoffee baseObj)
        {
            this.baseObj= baseObj;
        }
        public int getCoffeeCost()
        {
            return this.baseObj.getCoffeeCost() - 10;
        }
    }

    public class LargeSizeDecorator : ICoffee
    {
        ICoffee baseObj;
        public LargeSizeDecorator(ICoffee baseObj)
        {
            this.baseObj = baseObj;
        }
        public int getCoffeeCost()
        {
            return this.baseObj.getCoffeeCost() + 50;
        }
    }
    public class DecoratorDemo : IExecutableClass
    {
        public void Execute()
        {

            ICoffee coffee = new Coffee();
            Console.WriteLine(coffee.getCoffeeCost());

            ICoffee customeCoffee = new LargeSizeDecorator(new NoSugerDecorator(coffee));
            Console.WriteLine(customeCoffee.getCoffeeCost()); 
        }
    }
}
