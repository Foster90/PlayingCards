using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace PlayingCards
{

    


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
    
        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Card> Cards = new List<Card>();


            Deck.FillDeck(Cards);
            //Deck.PrintDeck(Cards);

            var query = from card in Cards
                        select card.Name;
            
            listBox1.DataSource = query.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string path = Directory.GetCurrentDirectory();
            //string path1 = path + @"\CardPics\JPEG\10C.jpg";
            List<Card> Cards = new List<Card>();
            Deck.FillDeck(Cards);
            var query = from card in Cards
                        select card.Name;

            listBox1.DataSource = query.ToList();


            
        }



        private void button2_Click(object sender, EventArgs e)
        {

            List<Card> Cards = new List<Card>();
            Deck.FillDeck(Cards);
            //Deck.PrintDeck(Cards);

            Cards.ShuffleDeck();

            var query = from card in Cards
                        select card.Name;


            listBox1.DataSource = query.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
                       
            //string selcd = "";
            string selcd = curItem.Substring(0, 1);
            string selcd1 = "";


            int spaces1 = 0;
            for (int i = 0; i < curItem.Length; i++)
            {
                if (curItem[i] == ' ')
                {
                    spaces1++;
                }
                if (spaces1 == 2)
                {

                    selcd1 = curItem.Substring(i +1 , 1);                  
                    break;
                }


            }

            //selcd = hold.Substring(1,1);
            pictureBox1.Image = Image.FromFile(@"..\..\CardPics\JPEG\" + selcd + selcd1 + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

     
    }
}
