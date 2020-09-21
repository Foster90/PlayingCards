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
            
            var query = from card in Cards
                        select card.Name;
            
            listBox1.DataSource = query.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
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

            Cards.ShuffleDeck();

            var query = from card in Cards
                        select card.Name;
            
            listBox1.DataSource = query.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cardlist = listBox1.SelectedItem.ToString();
            string card = UpdatePic.UpPic(cardlist);                
            pictureBox1.Image = Image.FromFile(@"..\..\CardPics\JPEG\" + card + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var cardlist = listBox1.Items.Cast<String>().ToList();
            string card = cardlist[rnd.Next(cardlist.Count)];
         

            card = UpdatePic.UpPic(card);
            pictureBox1.Image = Image.FromFile(@"..\..\CardPics\JPEG\" + card + ".jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }
    }
}
