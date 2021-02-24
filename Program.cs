using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Card21
{
    //Summary: Class for player info
    class Player
    {
        public string playerName;
    }
    class Deck
    {
        public enum Suits
        {
            Heart,
            Diamond,
            Spade,
            Clubs
        }
        public enum Value
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
        //static void CardSort()
        //{
        //    List<Card>cardlist = new List<Card>();
        //    foreach (Suits s in Enum.GetValues(typeof(Suits)))
        //    {
        //        foreach (Value v in Enum.GetValues(typeof(Value)))
        //        {
        //            cardlist.Add(new Card(s, v));
        //        }
        //    }
}
class Dealer
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Player!");
            Console.Write("What's your name?: ");
            Player player = new Player();
            player.playerName = Console.ReadLine();
            Console.WriteLine($"Welcome {player.playerName}!");
            Deck deck = new Deck();
            // Console.WriteLine(Deck.Suits.Clubs);
            var values = Enum.GetValues(typeof(Deck.Suits));
            Console.WriteLine(values);
        }
    }
}