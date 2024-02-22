using DesignPatternsGoF.Factory.Factory_Method.Business._Base;
using DesignPatternsGoF.Factory.Factory_Method.Business.RJ;
using DesignPatternsGoF.Factory.Factory_Method.Business.SP;
using static DesignPatternsGoF.Factory.Factory_Method.Util.Constants;

namespace DesignPatternsGoF.Factory.Factory_Method.Business
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CreatePizzaria(Places place)
        {
            PizzaFactoryMethod pizzaria = place switch
            {
                Places.SãoPaulo => new SPPizzaFactory(),
                Places.RioDeJaneiro => new RJPizzaFactory(),
                _ => throw new ApplicationException($"A pizzaria {place} não foi criada"),
            };
            return pizzaria;
        }
    }
}
