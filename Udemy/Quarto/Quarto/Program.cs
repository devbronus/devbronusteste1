using System;

namespace Quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            string s = Console.ReadLine();
            
            string[] v = s.Split(' '); // um outro jeito de se fazer isso é tirar o comando string s = console.readline() e colocar direto nessa string[]
            // neste caso, ficaria assim: string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.Read();

        }
    }
}
