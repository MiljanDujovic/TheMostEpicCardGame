using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sevens
{
    public class Deck {
        public List<Card> cards = new List<Card>();
        public void print()
        {
            foreach (var card in cards)
            {
                Console.Write("\n {0}  ", card.ToString());
            }
            
        }
        public bool isContains(Card card)
        {
            foreach (Card c in cards)
            {
                if ((c.name == card.name) & (c.symbol == card.symbol))
                {
                    return true;
                }
 
            }
            return false;
        }
        public void create4Cards(string name)
        {
            this.cards.Add(new Card(name, 3));
            this.cards.Add(new Card(name, 4));
            this.cards.Add(new Card(name, 5));
            this.cards.Add(new Card(name, 6));
        }
        public Card REMOVEat(int index)
        {
            Card card = this.cards[index];
            this.cards.RemoveAt(index);
            return card;
        }
        public void addCard(Card card)
        {
            Console.WriteLine("Card added " + card);
            this.cards.Add(card);
        }
    }
     public class Card
    {
        static public Random rnd = new Random();
        static public int getRandomSymbolIndex()
        {
            return rnd.Next(3, 7);
        }

        public string name;
        public char symbol;
        public Card(string name, int symbol)
        {
            this.name = name;
            this.symbol = Convert.ToChar(symbol);
        }
        public override string ToString()
        {
            return name+symbol;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Deck deck = new Deck();
            //deck.addCard(new Card("7", 4));
            //deck.addCard(new Card("8", 5));
            
            //if (deck.isContains(new Card("7", 4)))
            //{
            //    Console.WriteLine("Sadrzi");
            //}
            //Deck deck = new Deck();
            //char input = Console.ReadKey().KeyChar;
            //while (input != 'e')
            //{
            //    Card card = new Card(input.ToString(), rnd.Next(3, 7));
            //    deck.cards.Add(card);

            //    Console.Clear();
            //    deck.print();

            //    input = Console.ReadKey().KeyChar;
            //}


            string[] a = { "7", "8", "9", "10", "A", "J", "Q", "K" };
            Random r = new Random();
            for (int i = 0; i < 32; i++)
            {
                deck.addCard(new Card(a[r.Next(0, a.Length)], r.Next(3, 7)));
                if (deck.isContains(card))
                {
                    Console.WriteLine("Duplikat");
                }
            }



            //deck.create4Cards("7");
            //deck.create4Cards("8");
            //deck.create4Cards("9");
            //deck.create4Cards("10");
            //deck.create4Cards("A");
            //deck.create4Cards("J");
            //deck.create4Cards("Q");
            //deck.create4Cards("K");
            //deck.REMOVEat(0);
            //Console.Write("{0} ",deck.REMOVEat(0));


            Console.WriteLine();
            Console.WriteLine("Ja sam Mećava i volim da mećavam");
            
            Console.ReadLine();

        }



            
        
    }
}
