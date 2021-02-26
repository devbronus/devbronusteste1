using System;

namespace Terceiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = 5;

            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine(); // isso serve para o programa esperar eu ver os resultados

            // agora vamos ver para calcular uma área de um trapézio

            double b, B, h, area;
            // sempre que for indicar a variável com double, indicar com o .0
            // Caso for indicar a variável tipo float, colocar na fórmula o f no final. Ex: 6f

            b = 6.0; 
            B = 8.0;
            h = 5.0;
            

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area);

            Console.ReadLine();
        }
    }
}
