using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameWar
{
    class Game
    {
        Player player1 = new Player();
        Player player2 = new Player();


        public void Run()
        {
            Player _player1 = new Player() { Name = "player1" };
            Player _player2 = new Player() { Name = "player2" };

            Deck deck = new Deck();
            Console.WriteLine("Dealing the cards..");
            Console.WriteLine(deck.Deal(_player1, _player2));
           
            Console.ReadLine();
            
        }
    }
}
