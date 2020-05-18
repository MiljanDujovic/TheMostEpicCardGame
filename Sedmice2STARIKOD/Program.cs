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
        public bool contains(Card card)
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
        public void createSuite(string name)
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

            string[] cardNames = { "7", "8", "9", "10", "A", "J", "Q", "K" };
            Random r = new Random();
            for (int i = 0; i < 32; i++)
            {
                Card card = new Card(cardNames[r.Next(0, cardNames.Length)], r.Next(3, 7));
                
                if (!deck.contains(card))
                {
                    deck.addCard(card);
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("Ja sam Mećava i volim da mećavam");
            
            Console.ReadLine();

        }
    }
}
