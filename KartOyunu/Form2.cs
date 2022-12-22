using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartOyunu
{
    public partial class Form2 : Form
    {
        Random random = new Random();

        public static string[] suits = new string[] { "R", "G", "B", "O" };
        public static string[] value = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public List<string> deck;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PlayCard();
            Card51.Image = Image.FromFile("C:\\Users\\HalaycıKedi\\source\\repos\\KartOyunu\\KartOyunu\\Deck\\" + deck[0] + ".jpg");
            Card52.Image = Image.FromFile("C:\\Users\\HalaycıKedi\\source\\repos\\KartOyunu\\KartOyunu\\Deck\\" + deck[1] + ".jpg");
            Card53.Image = Image.FromFile("C:\\Users\\HalaycıKedi\\source\\repos\\KartOyunu\\KartOyunu\\Deck\\" + deck[2] + ".jpg");
            Card54.Image = Image.FromFile("C:\\Users\\HalaycıKedi\\source\\repos\\KartOyunu\\KartOyunu\\Deck\\" + deck[3] + ".jpg");
            target_card.Image = Image.FromFile("C:\\Users\\HalaycıKedi\\source\\repos\\KartOyunu\\KartOyunu\\Deck\\" + deck[20] + ".jpg");
        }

        private int selectRandomCard()
        {
            int randomCard;
            randomCard = random.Next(0, deck.Count);
            return randomCard;
        }

        //Oyun kartlarının oluşturmasını başlatır:
        public void PlayCard()
        {
            deck = GenerateDeck();
            Shuffle(deck);

            //Bu kısım test amaçlıdır. GenerateDeck() ve Shuffle() çalışıyor mu diye kontrol edilir (Çıktı olarak verir):
            foreach (string card in deck)
            {
                Console.WriteLine(card);
            }
        }
        
        //suits ve value listelerini kullanarak bir deste kart oluşurulur:
        public static List<string> GenerateDeck()
        {
            List<string> newDeck = new List<string>();
            foreach (string s in suits)
            {
                foreach (string v in value)
                {
                    newDeck.Add(s + v);
                }
            }
            return newDeck;
        }

        //GenerateDeck()'de oluşturulan desteyi karmak için:
        void Shuffle<T>(List<T> list)
        {
            System.Random random = new System.Random();
            int n = list.Count;
            while (n > 1)
            {
                int k = random.Next(n);
                n--;
                T temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
        }


    }
}
