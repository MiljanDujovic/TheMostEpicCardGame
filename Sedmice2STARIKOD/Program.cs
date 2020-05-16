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
                Console.Write("{0}  ", card.ToString());
              
            }
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
            deck.cards.Add(new Card("8",Card.getRandomSymbolIndex()));
            deck.cards.Add(new Card("7", Card.getRandomSymbolIndex()));
            deck.cards.Add(new Card("9", Card.getRandomSymbolIndex()));

            deck.print();

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

            Console.ReadLine();
        }



            
        
    }
}
