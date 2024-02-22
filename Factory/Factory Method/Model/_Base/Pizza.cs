using System.Collections;
using System.Text;

namespace DesignPatternsGoF.Factory.Factory_Method.Model._Base
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected string Dough;
        protected string Sauce;
        protected ArrayList Ingredients = [];

        public string Prepare()
        {
            StringBuilder sb = new();
            sb.AppendLine("Preparando " + Name);
            sb.AppendLine(Dough);
            sb.AppendLine(Sauce);
            sb.AppendLine("Ingredientes :");
            foreach (string ingredient in Ingredients)
            {
                sb.AppendLine("\t" + ingredient);
            }
            sb.AppendLine(Bake());
            sb.AppendLine(Slicing());
            sb.AppendLine(Packing());
            return sb.ToString();
        }

        public virtual string Bake()
        {
            return $"Baking Pizza for 25 min at 350 degress";
        }
        public virtual string Slicing()
        {
            return $"Slicing the Pizza 8 into slices ";
        }
        public virtual string Packing()
        {
            return $"Paking Pizza ";
        }

    }
}
