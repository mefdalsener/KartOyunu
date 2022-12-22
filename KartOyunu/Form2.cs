﻿using System;
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
        public string deck_ad = @"C:\Users\HalaycıKedi\OneDrive\Masaüstü\Deck\";
        public int sec_deck_loc = 20;
        public int sec_deck_remaining = 19;

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
            visible_table();
            Left_cards.Text = ("Kalan Kart:" + sec_deck_remaining);
        }

        public void visible_table()
        {
            //0-19 arası kartlar eşleştirilmesi gereken 20 adet kart
            //20-39 arası kartlar ikincil destede bulunan kartlar
            Card51.Image = Image.FromFile(deck_ad + deck[0] + ".jpg");
            Card52.Image = Image.FromFile(deck_ad + deck[1] + ".jpg");
            Card53.Image = Image.FromFile(deck_ad + deck[2] + ".jpg");
            Card54.Image = Image.FromFile(deck_ad + deck[3] + ".jpg");
            target_card.Image = Image.FromFile(deck_ad + deck[sec_deck_loc] + ".jpg");
            Card11.Visible = true;
            Card12.Visible = true;
            Card13.Visible = true;
            Card14.Visible = true;
            Card21.Visible = true;
            Card22.Visible = true;
            Card23.Visible = true;
            Card24.Visible = true;
            Card31.Visible = true;
            Card32.Visible = true;
            Card33.Visible = true;
            Card34.Visible = true;
            Card41.Visible = true;
            Card42.Visible = true;
            Card43.Visible = true;
            Card44.Visible = true;
            Card51.Visible = true;
            Card52.Visible = true;
            Card53.Visible = true;
            Card54.Visible = true;
            second_deck.Visible = true;
            target_card.Visible = true;
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

        private void second_deck_Click(object sender, EventArgs e)
        {
            
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;

        }

        private void second_deck_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                
                sec_deck_loc++;
                target_card.Image = Image.FromFile(deck_ad + deck[sec_deck_loc] + ".jpg");
                sec_deck_remaining--;
                Left_cards.Text = ("Kalan Kart:" + sec_deck_remaining);
                if (sec_deck_remaining == 0)
                {
                    second_deck.Visible = false;
                    Reset.Visible = true;
                }
                    

            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Reset.Visible = false;
            sec_deck_remaining = 19;
            sec_deck_loc = 20;
            PlayCard();
            visible_table();
            Left_cards.Text = ("Kalan Kart:" + sec_deck_remaining);

        }
    }
}
