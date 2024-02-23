using DesignPatternsGoF.Prototype.Model;
using static System.Console;


namespace DesignPatternsGoF.Prototype.Business
{
    public class SoldierBusiness
    {


        public void DoWorkSimple()
        {
            //Cria objeto do tipo Soldado
            Soldier soldado = new()
            {
                Name = "Soldado",
                Weapon = "Fuzil"
            };

            Soldier soldado_clone1 = (Soldier)soldado.Clone(true);
            Soldier soldado_clone2 = (Soldier)soldado.Clone(true);
            // atribui valores ao clone1
            soldado_clone1.Name = "Soldado Clone1";
            soldado_clone1.Weapon = "Bazuca";

            // atribui valores ao clone2
            soldado_clone2.Name = "Soldado Clone2";
            soldado_clone2.Weapon = "Metralhadora";

            //exibe valores do objeto original
            WriteLine(">> Objeto Original");
            WriteLine($"{soldado.Name} - {soldado.Weapon}");

            //Valores de objeto clone1
            WriteLine(">> Objeto Clone1");
            WriteLine($"{soldado_clone1.Name} -  {soldado_clone1.Weapon}");

            //Valores de objeto clone2
            WriteLine(">> Objeto Clone2");
            WriteLine($"{soldado_clone2.Name} - {soldado_clone2.Weapon}");


            ReadLine();
        }

        public void DoWorkDeep()
        {
            //Cria objeto do tipo Soldado
            Soldier soldado = new()
            {
                Name = "Soldado",
                Weapon = "Fuzil",
                Acessory = new() { Name = "Capacete" }
            };

            //Clone o objeto original
            Soldier soldado_clone1 = (Soldier)soldado.Clone();
            soldado_clone1.Acessory.Name = "Visor Noturno";

            Soldier soldado_clone2 = (Soldier)soldado.Clone();
            soldado_clone2.Acessory.Name = "Arma Secreta";

            //exibe valores do objeto original
            WriteLine(">> Objeto Original");
            WriteLine($"{soldado.Name} - {soldado.Weapon}");
            WriteLine($"{soldado.Acessory.Name}");

            //Valores de objeto clone1
            WriteLine(">> Objeto Clone1");
            WriteLine($"{soldado_clone1.Name} -  {soldado_clone1.Weapon}");
            WriteLine($"{soldado_clone1.Acessory.Name}");

            //Valores de objeto clone2
            WriteLine(">> Objeto Clone2");
            WriteLine($"{soldado_clone2.Name} - {soldado_clone2.Weapon}");
            WriteLine($"{soldado_clone2.Acessory.Name}");

            ReadLine();
        }

        public void DoWorkWrong()
        {
            //Cria objeto do tipo Soldado
            Soldier soldado = new()
            {
                Name = "Soldado",
                Weapon = "Fuzil",
                Acessory = new() { Name = "Capacete" }
            };

            //Clone o objeto original
            Soldier soldado_clone1 = (Soldier)soldado.Clone(true);
            soldado_clone1.Acessory.Name = "Visor Noturno";

            Soldier soldado_clone2 = (Soldier)soldado.Clone(true);
            soldado_clone2.Acessory.Name = "Arma Secreta";

            //exibe valores do objeto original
            WriteLine(">> Objeto Original");
            WriteLine($"{soldado.Name} - {soldado.Weapon}");
            WriteLine($"{soldado.Acessory.Name}");

            //Valores de objeto clone1
            WriteLine(">> Objeto Clone1");
            WriteLine($"{soldado_clone1.Name} -  {soldado_clone1.Weapon}");
            WriteLine($"{soldado_clone1.Acessory.Name}");

            //Valores de objeto clone2
            WriteLine(">> Objeto Clone2");
            WriteLine($"{soldado_clone2.Name} - {soldado_clone2.Weapon}");
            WriteLine($"{soldado_clone2.Acessory.Name}");

            ReadLine();
        }
    }
}
