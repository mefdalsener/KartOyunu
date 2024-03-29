﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// OYUNCUNUN BİTİREBİLECEĞİ BİR OYUN YAPMAK ÜZERİNE HAZIRLANMIŞ BİR DENEME TAHTASIDIR.

namespace KartOyunu
{
    public partial class Form3 : Form
    {
        Random random = new Random();
        //deck_ad kartların bulunduğu klasörün adresidir...
        public string deck_ad = @"C:\Users\HalaycıKedi\OneDrive\Masaüstü\Deck\";
        public int sec_deck_remaining = 19;

        public static string[] suits = new string[] { "R", "G", "B", "O" };
        public static string[] value = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public List<string> deck;

        int sec_deck_loc = 20;

        Boolean cardSwitch = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            PlayCard();
            visible_table();
            Left_cards.Text = ("Kalan Kart:" + sec_deck_remaining);
        }

        public void visible_table()
        {
            //0-19 arası kartlar eşleştirilmesi gereken 20 adet kart
            //20-39 arası kartlar ikincil destede bulunan kartlar
            target_card.Image = Image.FromFile(deck_ad + deck[0] + ".jpg");
            Card11.Visible = true;
            Card11.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card12.Visible = true;
            Card12.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card13.Visible = true;
            Card13.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card14.Visible = true;
            Card14.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card21.Visible = true;
            Card21.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card22.Visible = true;
            Card22.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card23.Visible = true;
            Card23.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card24.Visible = true;
            Card24.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card31.Visible = true;
            Card31.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card32.Visible = true;
            Card32.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card33.Visible = true;
            Card33.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card34.Visible = true;
            Card34.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card41.Visible = true;
            Card41.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card42.Visible = true;
            Card42.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card43.Visible = true;
            Card43.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card44.Visible = true;
            Card44.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card51.Visible = true;
            Card44.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card52.Visible = true;
            Card44.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card53.Visible = true;
            Card44.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            Card54.Visible = true;
            Card44.Image = Image.FromFile(deck_ad + "DeckBack.jpg");
            second_deck.Visible = true;
            target_card.Visible = true;
        }

        //Switch-Case yapısı seçilen kart ile eşlenmesi gereken kartın değerlerini kontrol ediyor.
        public void controlCard(int cardVal, string cardName)
        {
            
            int targetVal = Convert.ToInt32(deck[sec_deck_loc].Substring(1));
            switch (cardVal)
            {
                case 1:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 2:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 3:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 4:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 5:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 6:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 7:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 8:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 9:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
                case 10:
                    if (cardVal - 1 == targetVal || cardVal + 1 == targetVal)
                    {
                        target_card.Image = Image.FromFile(cardName);
                        cardSwitch = true;
                    }
                    break;
            }
        }


        //Oyun kartlarının oluşturmasını başlatır:
        public void PlayCard()
        {
            deck = GenerateDeck();
            Shuffle(deck);

            //Bu kısım test amaçlıdır. GenerateDeck() ve Shuffle() çalışıyor mu diye kontrol edilir (Çıktı olarak verir):
            Console.WriteLine("Elinizdeki deste : ");
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

        private void second_deck_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                sec_deck_loc++;
                target_card.Image = Image.FromFile(deck_ad + deck[sec_deck_loc] + ".jpg");
                sec_deck_remaining--;
                Left_cards.Text = ("Kalan Kart:" + sec_deck_remaining);
            }
        }
        int Left_click = 2;
        private void Reset_Click(object sender, EventArgs e)
        {
            if (Left_click != 0)
            {
                Left_click--;
                Reset.Visible = false;
                sec_deck_remaining = 19;
                sec_deck_loc = 20;
                PlayCard();
                visible_table();
                Left_cards.Text = ("Kalan Kart:" + sec_deck_remaining);
            }


        }

        private void drawCard()
        {
            int cardValue = Convert.ToInt32(deck[0].Substring(1));
        }
        private void Card54_Click(object sender, EventArgs e)
        {
            int cardVal = Convert.ToInt32(deck[3].Substring(1));
            controlCard(cardVal, (deck_ad + deck[3] + ".jpg"));
            if (cardSwitch == true)
            {
                Card54.Visible = false;
                cardSwitch = false;
                Card44.Image = Image.FromFile(deck_ad + deck[7] + ".jpg");
            }

        }

        private void Card44_Click(object sender, EventArgs e)
        {

        }

        private void Card34_Click(object sender, EventArgs e)
        {

        }

        private void Card24_Click(object sender, EventArgs e)
        {

        }

        private void Card14_Click(object sender, EventArgs e)
        {

        }

        private void Card53_Click(object sender, EventArgs e)
        {

        }

        private void Card43_Click(object sender, EventArgs e)
        {

        }

        private void Card33_Click(object sender, EventArgs e)
        {

        }

        private void Card23_Click(object sender, EventArgs e)
        {

        }

        private void Card13_Click(object sender, EventArgs e)
        {

        }

        private void Card52_Click(object sender, EventArgs e)
        {

        }

        private void Card42_Click(object sender, EventArgs e)
        {

        }

        private void Card32_Click(object sender, EventArgs e)
        {

        }

        private void Card22_Click(object sender, EventArgs e)
        {

        }

        private void Card12_Click(object sender, EventArgs e)
        {

        }

        private void Card51_Click(object sender, EventArgs e)
        {

        }

        private void Card41_Click(object sender, EventArgs e)
        {

        }

        private void Card31_Click(object sender, EventArgs e)
        {

        }

        private void Card21_Click(object sender, EventArgs e)
        {

        }

        private void Card11_Click(object sender, EventArgs e)
        {

        }

        //Kontrol için yazılmış hızlı tahta reset tuşu
        private void button1_Click(object sender, EventArgs e)
        {
            sec_deck_remaining = 19;
            sec_deck_loc = 20;
            PlayCard();
            visible_table();
        }
    }
}
