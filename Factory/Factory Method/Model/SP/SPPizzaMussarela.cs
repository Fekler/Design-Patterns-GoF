using DesignPatternsGoF.Factory.Factory_Method.Model._Base;

namespace DesignPatternsGoF.Factory.Factory_Method.Model.SP
{
    public class SPPizzaMussarela : Pizza
    {
        public SPPizzaMussarela()
        {
            Name = "Pizza de mussarela Paulista";
            Dough = "Massa fina crocante paulista";
            Sauce = "Molho de tomate italiano paulista";
            Ingredients.Add("Queijo parmessão");
            Ingredients.Add("Azeitonas verdes");
        }
    }
}
