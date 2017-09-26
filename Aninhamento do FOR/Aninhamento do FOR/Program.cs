using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aninhamento_do_FOR
{

    class program
    {

        static void Main ( string [] args )
        {

            //string nome; //Tipo String para COMPATIBILIZAR com A LEITURA
            Console.WriteLine(" \n\n \t\t\t Chroma X - Version 7.89 ");
            Console.WriteLine(" \n\n \t\t\t Digite seu Nome: ");
            //nome = Console.ReadLine();
            //string nome = Console.ReadLine();
            

            for ( int x = 0; x < 5; x++  )
                for ( int y = 0; x < 5; y++ )
                {

                    Console.WriteLine( x + " * " + y + " = " + x * y );

                }
                    Console.ReadKey();
            {

                
            }
        }
        
    }

}