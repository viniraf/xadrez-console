﻿using System;
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
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Digite a posição de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Digite a posição de destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);

                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
