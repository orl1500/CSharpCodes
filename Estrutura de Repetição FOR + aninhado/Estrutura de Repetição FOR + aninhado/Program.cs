using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Acima estão as bibliotecas para construir o projeto
 * Version: 1789.56
 * Date: 25/09/2017 */
 
    namespace Estrutura_de_Repetição_FOR___aninhado
    {

        class program
         {

            static void Main ( string [] args )
            {

                Console.WriteLine(" \t\t\t\t\t ===Welcome to MainSpace Version 1789.56=== \n\n\n ");
                //Mensagem de Apresentação na Tela

                    for ( int countdown = 30; countdown >= 5; countdown-=4 )
                    {

                        Console.WriteLine(" \t\t\t\t Contagem: " + countdown);
                        //Mensagem na Tela
                    }
                    Console.ReadKey(); //Faz o programa ser executado
        }

    }

}