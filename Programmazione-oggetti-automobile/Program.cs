using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmazione_oggetti_automobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione dell'oggetto
            Automobile a = new Automobile("Fiat", 100, 3, 120, true);

            int choice = 0;
            bool iteration = true;

            while(iteration)
            {
                Console.WriteLine("Scegli un'opzione:");
                Console.WriteLine("1. Accelera");   
                Console.WriteLine("2. Decelera");
                Console.WriteLine("3. Accendi");
                Console.WriteLine("4. Spegni");
                Console.WriteLine("5. Esci\n");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (choice)
                {
                    case 1:
                        a.Accelera();
                        break;
                    case 2:
                        a.Decelera();
                        break;
                    case 3:
                        a.Accendi();
                        break;
                    case 4:
                        a.Spegni();
                        break;
                    case 5:
                        iteration = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.\n");
                        break;
                }

            }


           




           
        }
    }

}