using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{

    class program
    {

        static void Main ( string [] args )
        {

            Console.WriteLine(" \n \t\t\t\t\t Loop - Comando de Código WHILE \n\n ");

            int count = 15;

            while ( count <= 40 )
            {

                Console.WriteLine(" Hello World: " + count);
                count += 4; //Incremento de 4 valores

            }
            Console.ReadKey(); //Leitura do Comando - Motor do Código

        }

    }

}