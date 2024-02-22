using DesignPatternsGoF.Factory.Factory_Method.Business._Base;
using DesignPatternsGoF.Factory.Factory_Method.Model._Base;
using DesignPatternsGoF.Factory.Factory_Method.Model.SP;
using System.ComponentModel;
using static DesignPatternsGoF.Factory.Factory_Method.Util.Constants;

namespace DesignPatternsGoF.Factory.Factory_Method.Business.SP
{
    public class SPPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CreatePizza(PizzaFlavor flavor)
        {
            int flavorPosition = (int)flavor;
            Pizza pizza = flavorPosition switch
            {
                1 => new SPPizzaCalabresa(),
                2 => new SPPizzaMussarela(),
                _ => throw new InvalidEnumArgumentException("S"),
            };
            return pizza;
        }
    }
}
