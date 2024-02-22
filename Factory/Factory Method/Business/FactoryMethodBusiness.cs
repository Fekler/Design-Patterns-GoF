using DesignPatternsGoF.Factory.Factory_Method.Business;
using DesignPatternsGoF.Factory.Factory_Method.Business._Base;
using DesignPatternsGoF.Factory.Factory_Method.Model._Base;
using static DesignPatternsGoF.Factory.Factory_Method.Util.Constants;

namespace DesignPatternsGoF.Factory.Factory_Method
{
    public class FactoryMethodBusiness
    {
        int orderNumber;
        bool placeSucess;
        int orderplace;

        bool orderPizzaSucess;
        PizzaFactoryMethod pizzaria;
        Pizza pizza;


        public void DoWork()
        {
            try
            {
                while (!placeSucess)
                {
                    placeSucess = SelectPlace();
                }
                pizzaria = PizzaSimpleFactory.CreatePizzaria((Places)orderplace);


                while (!orderPizzaSucess)
                {
                    orderPizzaSucess = SelectPizza();
                }

                pizza = pizzaria.AssemblePizza((PizzaFlavor)orderNumber);
                Console.WriteLine(pizza.Prepare());
                Console.WriteLine("\nPizza concluida com sucesso");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating or processing pizza: {ex.Message}");
            }
        }

        bool SelectPlace()
        {
            bool placeSucess = false;
            Console.WriteLine("========= Pizzaria ======");
            Console.WriteLine("Informe o local São Paulo(1)  Rio de Janeiro(2)");
            string? selectedPlace = Console.ReadLine();
            if (!string.IsNullOrEmpty(selectedPlace) && int.TryParse(selectedPlace, out orderplace))
            {
                placeSucess = Enum.IsDefined(typeof(Places), orderplace);
                if (!placeSucess)
                    Console.WriteLine("Please select between 1 or 2");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return placeSucess;
        }

        bool SelectPizza()
        {
            bool pizzaSucess = false;

            Console.WriteLine("Select your pizza, 1 for Calabreza or 2 for Mussarela");
            string? orderString = Console.ReadLine();
            if (!string.IsNullOrEmpty(orderString) && int.TryParse(orderString, out orderNumber))
            {
                pizzaSucess = Enum.IsDefined(typeof(PizzaFlavor), orderNumber);
                if (!pizzaSucess)
                    Console.WriteLine("Please select between 1 or 2");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return pizzaSucess;
        }
    }
}


