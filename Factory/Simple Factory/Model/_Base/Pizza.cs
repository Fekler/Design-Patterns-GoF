namespace DesignPatternsGoF.Factory.Simple_Factory.Model._Base
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public abstract void Prepare();
        public abstract void Bake(int time);
        public abstract void Packing();

    }
}
