using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    public class PosicaoXadrez
    {
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public Posicao ToPosition()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}