﻿using System;
using tabuleiro;

namespace Xadrez
{
    public class Program
    {

        public static void Main()
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
        }
    }
}