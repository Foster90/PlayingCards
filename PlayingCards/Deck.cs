using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCards
{
    public class Deck
    {
       
            public List<Card> Cards = new List<Card>();
           
            
                public static void FillDeck(List<Card> Cards)
                {
                    //Can use a single loop utilising the mod operator % and Math.Floor
                    //Using divition based on 13 cards in a suited
                    for (int i = 0; i < 52; i++)
                    {
                        Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                        //Add 2 to value as a cards start a 2
                        int val = i % 13 + 2;
                        Cards.Add(new Card(val, suite));
                    }
                }
            

            public static void PrintDeck(List<Card> Cards)
            {
                foreach (Card card in Cards)
                {                  
                 
                    MessageBox.Show(card.Name);
                    
                }
            }
    }



    
}
