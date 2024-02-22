using DesignPatternsGoF.Factory.Factory_Method.Model._Base;

namespace DesignPatternsGoF.Factory.Factory_Method.Model.SP
{
    public class SPPizzaCalabresa : Pizza
    {
        public SPPizzaCalabresa()
        {
            Name = "Pizza de calabreza Paulista com muita calabreza";
            Dough = "Massa fina crocante";
            Sauce = "Molho de tomate italiano";
            Ingredients.Add("Fatias de calabreza defumada especial");
            Ingredients.Add("Queijo parmessão italiano tradicional");
        }
    }
}
