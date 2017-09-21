using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Test
{

    class program
    {

        static void Main (string [] args )
        {

            Console.WriteLine("Cópia de Nome Digitado - IMPUT");
            Console.WriteLine("Digite o seu nome: ");

            string name = Console.ReadLine();

            Console.WriteLine(" Seu nome é: " + name);

            Console.ReadKey();

        }
        
    }

}