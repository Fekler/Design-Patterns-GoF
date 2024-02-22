using DesignPatternsGoF.Factory.Simple_Factory.Model;
using DesignPatternsGoF.Factory.Simple_Factory.Model._Base;
using System.ComponentModel;
using static DesignPatternsGoF.Factory.Simple_Factory.Util.Constants;

namespace DesignPatternsGoF.Factory.Simple_Factory
{
    public class PizzaSimpleFactory
    {
        public static Pizza CreatePizza(PizzaFlavor flavor) 
        {
            int flavorPosition = (int)flavor;
            Pizza pizza = flavorPosition switch
            {
                1 => new PizzaCalabreza(),
                2 => new PizzaMussarela(),
                _ => throw new InvalidEnumArgumentException("S"),
            };
            return pizza;
        }
    }
}
