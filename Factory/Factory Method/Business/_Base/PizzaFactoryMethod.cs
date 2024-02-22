using DesignPatternsGoF.Factory.Factory_Method.Model._Base;
using static DesignPatternsGoF.Factory.Factory_Method.Util.Constants;

namespace DesignPatternsGoF.Factory.Factory_Method.Business._Base
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza AssemblePizza(PizzaFlavor flavor)
        {
            Pizza pizza;
            pizza = CreatePizza(flavor);
            return pizza;
        }
        protected abstract Pizza CreatePizza(PizzaFlavor flavor);
    }
}
