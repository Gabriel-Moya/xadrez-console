using System;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('a', 1);
            Console.WriteLine(posicao);
            Console.WriteLine(posicao.ToPosition());

            Console.ReadLine();
        }
    }
}
