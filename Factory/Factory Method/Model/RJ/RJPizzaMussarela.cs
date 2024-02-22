using DesignPatternsGoF.Factory.Factory_Method.Model._Base;

namespace DesignPatternsGoF.Factory.Factory_Method.Model.RJ
{
    public class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {
            Name = "Pizza de mussarela Carioca";
            Dough = "Massa tradicional carioca";
            Sauce = "Molho de tomate italiano carioca";
            Ingredients.Add("Queijo parmessão ralado");
            Ingredients.Add("Azeitonas pretas");
        }
    }
}
