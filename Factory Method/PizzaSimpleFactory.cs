using DesignPatternsGoF.Factory_Method.Model;
using DesignPatternsGoF.Factory_Method.Model._Base;
using System.ComponentModel;
using static DesignPatternsGoF.Factory_Method.Util.Constants;

namespace DesignPatternsGoF.Factory_Method
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
