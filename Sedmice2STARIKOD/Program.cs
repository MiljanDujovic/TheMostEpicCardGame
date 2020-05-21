using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sevens
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public void print()
        {
            foreach (var card in cards)
            {
                Console.Write("{0} ", card.ToString());
            }

        }
        public Deck addCard(string name, int symbol)
        {
            Card card = new Card(name, symbol);
            this.cards.Add(card);
            return this;
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
        public Card(string name, int symbol, int color = 0)
        {
            this.name = name;

            this.symbol = Convert.ToChar(symbol);
        }
        public override string ToString()
        {
            return name + symbol;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Deck deck = new Deck();


            string[] newCard = { "A", "J", "Q", "K" };
            Random r = new Random();
            //for (int i = 0; i < 32; i++)
            //{
            //    Card card = new Card(newCard[r.Next(0, newCard.Length)], r.Next(3, 7));

            //    if (!deck.contains(card))
            //    {
            //        deck.addCard(card);
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            //if (deck.contains(new Card("7",3)))
            //{

            //}

            //Console.WriteLine("nova karta createCard metoda {0}", deck.createCard("8",4));
            //do
            //{
            //    string name = newCard[r.Next(0, newCard.Length)];
            //    int symbol = r.Next(3, 7);
            //    //if (!deck.contains(name, symbol))
            //    //{
            //    //    deck.addCard(name, symbol);
            //    //    deck.addCard(new Card(name, symbol)); //isto braleouu deck.createCard(name,symbol);
            //    //}
            //    deck.addUnique(name, symbol);
            //} while (deck.cards.Count < 8);

            //deck.addCard(new Card("8", 2)).addCard("8", 1).addCard("8", 2).addCard(new Card("8", 1));
            //deck.addCard("8", 3);
            //deck.addCard("8", 3);
            //deck.addUnique("8", 3);
            Deck first = new Deck();
            Deck second = new Deck();
            for (int i = 0; i < 16; i++)
            {
                string name = newCard[r.Next(0, newCard.Length)];
                int symbol = r.Next(3, 7);
                if (!first.contains(name, symbol))
                {
                    first.addCard(name, symbol);
                }
                else
                {
                    if (!second.contains(name,symbol))
                    {
                        second.addCard(name, symbol);
                    }
                    else
                    {
                        Console.WriteLine("duplikat papane {0}{1}",name, Convert.ToChar(symbol));
                        i--;
                    }
                    
                }
            }
            first.print();
            Console.WriteLine();
            second.print();

            //string[] cardNames = { "7", "8", "9", "10", "A", "J", "Q", "K" };
            //Random r = new Random();
            //for (int i = 0; i < 32; i++)
            //{
            //    Card card = new Card(cardNames[r.Next(0, cardNames.Length)], r.Next(3, 7));

            //    if (!deck.contains(card))
            //    {
            //        deck.addCard(card);

            //    }
            //}


            Console.WriteLine();
              Console.WriteLine("Ja sam Mećava i volim da mećavam");

              Console.ReadLine();

                
            
        }
    }
}
