using DesignPatternsGoF.Factory.Factory_Method.Business._Base;
using DesignPatternsGoF.Factory.Factory_Method.Model._Base;
using DesignPatternsGoF.Factory.Factory_Method.Model.RJ;
using System.ComponentModel;
using static DesignPatternsGoF.Factory.Factory_Method.Util.Constants;

namespace DesignPatternsGoF.Factory.Factory_Method.Business.RJ
{
    internal class RJPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CreatePizza(PizzaFlavor flavor)
        {
            int flavorPosition = (int)flavor;
            Pizza pizza = flavorPosition switch
            {
                1 => new RJPizzaCalabresa(),
                2 => new RJPizzaMussarela(),
                _ => throw new InvalidEnumArgumentException("S"),
            };
            return pizza;
        }
    }
}
