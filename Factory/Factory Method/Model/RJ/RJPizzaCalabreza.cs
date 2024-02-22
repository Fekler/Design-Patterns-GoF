using DesignPatternsGoF.Factory.Factory_Method.Model._Base;

namespace DesignPatternsGoF.Factory.Factory_Method.Model.RJ
{
    public class RJPizzaCalabresa : Pizza
    {
        public RJPizzaCalabresa()
        {
            Name = "Pizza de calabreza Carioca com cebola";
            Dough = "Massa tradicional carioca";
            Sauce = "Molho de tomate italiano carioca";
            Ingredients.Add("Fatias de calabreza especial");
            Ingredients.Add("Queijo parmessão italiano tradicional");
        }
    }
}
