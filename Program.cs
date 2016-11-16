﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variável
            int i;
            int resultado;

            //Pós-Incremento
            i = 1;
            resultado = i++;
            Console.WriteLine("Pós-Incremento: " + resultado);

            //Pré-Incremento
            i = 1;
            resultado = ++i;
            Console.WriteLine("Pré-Incremento: " + resultado);

            //Pós-Incremento
            i = 1;
            Console.WriteLine("Pós-Incremento IF");
            if (i++ == 2)
                Console.WriteLine("É igual");
            else
                Console.WriteLine("Não é igual");

            //Pré-Incremento
            i = 1;
            Console.WriteLine("Pré-Incremento IF");
            if (++i == 2)
                Console.WriteLine("É igual");
            else
                Console.WriteLine("Não é igual");

            //Imprime mensagem na tela e aguarda que alguma tecla seja precionada
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
