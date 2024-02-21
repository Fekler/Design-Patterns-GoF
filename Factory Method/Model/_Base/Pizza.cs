namespace DesignPatternsGoF.Factory_Method.Model._Base
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public abstract void Prepare();
        public abstract void Bake(int time);
        public abstract void Packing();

    }
}
