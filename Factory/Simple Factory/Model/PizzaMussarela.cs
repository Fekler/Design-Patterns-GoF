using DesignPatternsGoF.Factory.Simple_Factory.Model._Base;

namespace DesignPatternsGoF.Factory.Simple_Factory.Model
{
    public class PizzaMussarela : Pizza
    {
        private readonly string _name = "Pizza de Mussarela";

        public PizzaMussarela()
        {
            Name = _name;
        }

        public override void Bake(int time)
        {
            Console.WriteLine($"{Name} Will be beaking for {time} min.");
        }

        public override void Packing()
        {
            Console.WriteLine($"Packing {Name}.");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing  {Name}.");
        }
    }
}
