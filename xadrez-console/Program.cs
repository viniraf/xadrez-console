﻿using System;
using tabuleiro;

namespace xadrez_console
{
    class Program{
        static void Main(string[] args){

            // Teste criação tabuleiro
            Tabuleiro tab = new Tabuleiro(8, 8);

            // Teste imprimir o tabuleiro
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
          
        }
    }
}
