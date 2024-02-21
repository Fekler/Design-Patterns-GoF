using DesignPatternsGoF.Factory_Method.Model._Base;

namespace DesignPatternsGoF.Factory_Method.Model
{
    public class PizzaCalabreza : Pizza
    {
        private readonly string _name = "Pizza de Calabreza";

        public PizzaCalabreza()
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
