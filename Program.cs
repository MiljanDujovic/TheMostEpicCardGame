using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading.Tasks;

namespace Sevens
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public void print()
        {
            foreach (var card in cards)
            {
                card.print();
            }

        }
        public void PrintSymbols()
        {
            foreach (var card in cards)
            {
                card.printSymbol();
            }

        }
        public void addCard(string name, int symbol)
        {
            Card card = new Card(name, symbol);
            this.cards.Add(card);
        }
        public bool addUnique(string name, int symbol, bool unique = false)
        {
            if (!contains(name, symbol))
            {
                Card card = new Card(name, symbol);
                this.cards.Add(card);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool addUnique(Card card)
        {
            if (!contains(card))
            {
                this.cards.Add(card);
                return true;
            }
            else
            {
                return false;
            }

        }
        public Deck addCard(Card card)
        {
            //Console.WriteLine("Card added " + card);
            this.cards.Add(card);
            return this;
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
        public bool contains(string name, int symbol)
        {
            foreach (Card c in cards)
            {
                if ((c.name == name) & (c.symbol == symbol))
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
        public Card removeAt(int index)
        {
            Card card = this.cards[index];
            this.cards.RemoveAt(index);
            return card;
        }
        public Card Get(int index)
        {
            Card card = cards[index];
            return card;
        }

    }
    public class Card
    {
        static public Random rnd = new Random();
        static public int getRandomSymbolIndex()
        {
            return rnd.Next(3, 7);
        }
        static public string getRandomName()
        {
            string[] newName = { "7", "8", "9", "10", "A", "J", "Q", "K" };

            return newName[rnd.Next(0, newName.Length)];
        }

        public string name;
        public char symbol;
        public Card(string name, int symbol, int color = 0)
        {
            this.name = name;

            this.symbol = Convert.ToChar(symbol);
        }
        public override string ToString()
        {
            return name + symbol;
        }
        public void print()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("{0}", this.name);
            Console.ForegroundColor = getColor() == CardColor.Red ? ConsoleColor.Red : ConsoleColor.Black;
            Console.Write("{0} ", this.symbol.ToString());
        }
        public void printSymbol()
        {
            Console.ForegroundColor = getColor() == CardColor.Red ? ConsoleColor.Red : ConsoleColor.Black;
            Console.Write("{0} ", this.symbol.ToString());
        }
        public CardColor getColor()
        {

            return (this.symbol == 3 || this.symbol == 4) ? CardColor.Red : CardColor.Black;


        }
        static public Card Random()
        {

            Card card = new Card(getRandomName(), getRandomSymbolIndex());
            return card;
        }
    }
    public enum CardColor
    {
        Red,
        Black
    }
    class Program
    {
        static void onKeyPressed(ConsoleKeyInfo keyInfo)
        {
            bool b = keyInfo.Key == ConsoleKey.Enter;
            Console.WriteLine(keyInfo.Key.ToString());
        }
        static void Main(String[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Deck deck = new Deck();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                Program.onKeyPressed(keyInfo);
                keyInfo = Console.ReadKey(true);
            }
        }
    }
}
