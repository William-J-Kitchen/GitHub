﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //Card card = new Card();
        //card.Face = "King";
        //    card.Suit = "Spades";
        //    Card card = new Card() { Face = "King", Suit = "Spades" };
        //public static deck shuffle(deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = shuffle(deck);
        //    }
        //    return deck;
        }
    }
}
