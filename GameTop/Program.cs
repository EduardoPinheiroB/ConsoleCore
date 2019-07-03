using System;
using GameTOP.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda( 
                new Jogador1("Ronaldo"),
                new Jogador3()
            );
            
            jogo.IniciarJogo();
        }
    }

}
