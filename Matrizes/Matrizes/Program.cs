using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{

    class program
    {

        static void Main ( string [] args )
        {

            Console.WriteLine(" \n\n\n\n \t\t\t\t\t\t =====WELCOME TO YOUR LIST===== ");

            Console.WriteLine(" Digite o seu Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine(" \n\n \t\t\t\t\t\t Bem-vindo " + nome + " A Sua Lista \n\n " );

            string[,] Person = new string [3, 3];
            Person[0, 0] = "Orleans";
            Person[0, 1] = "Olhos Castanhos";
            Person[0, 2] = " 1,81 M ";

            Person[1, 0] = "Lucas";
            Person[1, 1] = "Olhos Castanhos";
            Person[1, 2] = "1,79 M";

            Person[2, 0] = "Sandro";
            Person[2, 1] = "Olhos Castanhos";
            Person[2, 2] = "1, 80 M";

            Console.WriteLine(Person[0, 0] + " - " + Person[0, 1] + " - " + Person[0, 2]);
            Console.WriteLine(Person[1, 0] + " - " + Person[1, 1] + " - " + Person[1, 2]);
            Console.WriteLine(Person[2, 0] + " - " + Person[2, 1] + " - " + Person[2, 2]);

            

            Console.ReadLine();

        }
       
    }

}