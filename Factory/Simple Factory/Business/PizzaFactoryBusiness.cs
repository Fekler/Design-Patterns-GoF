using DesignPatternsGoF.Factory.Simple_Factory.Model._Base;
using static DesignPatternsGoF.Factory.Simple_Factory.Util.Constants;

namespace DesignPatternsGoF.Factory.Simple_Factory.Business
{
    public class PizzaFactoryBusiness
    {
        bool ordered = false;
        int orderNumber;
        Pizza pizza;


        public void DoWork()
        {
            try
            {
                Console.WriteLine("Hello, make your order");
                MakeOrder();

                while (!ordered)
                {
                    MakeOrder();
                }

                pizza = PizzaSimpleFactory.CreatePizza((PizzaFlavor)orderNumber);
                pizza.Prepare();
                pizza.Bake(30);
                pizza.Packing();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating or processing pizza: {ex.Message}");
            }
        }

        void MakeOrder()
        {
            Console.WriteLine("Select your pizza, 1 for Calabreza or 2 for Mussarela");
            string orderString = Console.ReadLine();
            if (int.TryParse(orderString, out orderNumber))
            {
                ordered = Enum.IsDefined(typeof(PizzaFlavor), orderNumber);
                if (!ordered)
                    Console.WriteLine("Please select between 1 or 2");

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
