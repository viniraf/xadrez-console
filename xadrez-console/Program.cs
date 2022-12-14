using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program{
        static void Main(string[] args){

            try {

                // Teste criação partida de xadrez
                PartidaDeXadrez partida = new PartidaDeXadrez();

                // Teste movimentos de peça informando origem e destino
                while (!partida.termidada) {

                    try {
                        Console.Clear();
                        Tela.imprimirPartida(partida);


                        Console.WriteLine();
                        Console.Write("Digite a posição de origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaodeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Digite a posição de destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Tela.imprimirPartida(partida);

            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
