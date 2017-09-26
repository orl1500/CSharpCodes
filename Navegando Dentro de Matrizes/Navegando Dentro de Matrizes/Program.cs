using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navegando_Dentro_de_Matrizes
{

    class program
    {

        static void Main ( string [] args )
        {

            Console.WriteLine(" \n\n\n \t\t\t\t\t Hello, This is The XDOUBList ");
            Console.WriteLine(" \n \t\t\t\t\t Digite seu Nome: ");

            string name = Console.ReadLine();

            Console.WriteLine(" \n \t\t\t\t\t Bem-Vindo " + name + " Ao XDOUBlist \n\n ");

            string[] ID = new string[5];
            ID[0] = "Orleans";
            ID[1] = "Sandro";
            ID[2] = "Lucas";
            ID[3] = "Osmir";
            ID[4] = "Lucas";

            Console.WriteLine(ID[0]);
            Console.WriteLine(ID[1]);
            Console.WriteLine(ID[2]);
            Console.WriteLine(ID[3]);
            Console.WriteLine(ID[4]);


            string[,,,] Person = new string[4, 4, 4, 4];
            Person[0, 0, 0, 1] = "Orleans";
            Person[0, 0, 1, 1] = "Olhos Castanhos";
            Person[0, 1, 1, 1] = "1,81 M";
            Person[1, 1, 1, 1] = "Branco";

            Person[0, 0, 0, 2] = "Sandro";
            Person[0, 0, 2, 2] = "Olhos Azuis";
            Person[0, 2, 2, 2] = "1,90 M";
            Person[2, 2, 2, 2] = "Pardo";

            Console.WriteLine(" Digite uma das duas opções abaixo para saber as características: ");
            Console.WriteLine(" A - Orleans ");
            Console.WriteLine(" B - Sandro ");

            string decision = Convert.ToInt16(Console.ReadLine());


            if ( decision = "10" )
            {

                Console.WriteLine(Person[0, 0, 0, 1] + " - " + Person[0, 0, 1, 1] + " - " + Person[0, 1, 1, 1] + " - " + Person[1, 1, 1, 1]);

            } if ( decision = "10" )
            {

                Console.WriteLine(Person[0, 0, 0, 2] + " - " + Person[0, 0, 2, 2] + " - " + Person[0, 2, 2, 2] + " - " + Person[2, 2, 2, 2]);

            }
            

           
            

            Console.ReadKey();
        }
       
    }   

}