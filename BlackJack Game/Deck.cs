using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game
{
    /*/// <summary>
    /// Draw cards faced up on a PictureBox
    /// </summary>
    /// <param name="e">PaintEventArgs instance from drawing method</param>
    /// <param name="playing_card">Which card from Cards enum</param>
    /// <param name="location_x">Where on X-axis</param>
    /// <param name="location_y">Where on Y-axis</param>
    public Card Draw_Front_Card(PictureBox pictureBox, Cards playing_card, int location_x, int location_y)
    {
        // Create rectangle for displaying image.
        Rectangle destRect = new Rectangle(location_x, location_y, 72, 88);

        int card_location_x = 0, card_location_y = 0;
        // Cards are 73x98 px.
        switch (playing_card)
        {
            case Cards.ace_clubs:
                card_location_x = 73 * 0;
                card_location_y = 0;
                break;
            case Cards.two_clubs:
                card_location_x = 73 * 1;
                card_location_y = 0;
                break;
            case Cards.three_clubs:
                card_location_x = 73 * 2;
                card_location_y = 0;
                break;
            case Cards.four_clubs:
                card_location_x = 73 * 3;
                card_location_y = 0;
                break;
            case Cards.five_clubs:
                card_location_x = 73 * 4;
                card_location_y = 0;
                break;
            case Cards.six_clubs:
                card_location_x = 73 * 5;
                card_location_y = 0;
                break;
            case Cards.seven_clubs:
                card_location_x = 73 * 6;
                card_location_y = 0;
                break;
            case Cards.eight_clubs:
                card_location_x = 73 * 7;
                card_location_y = 0;
                break;
            case Cards.nine_clubs:
                card_location_x = 73 * 8;
                card_location_y = 0;
                break;
            case Cards.ten_clubs:
                card_location_x = 73 * 9;
                card_location_y = 0;
                break;
            case Cards.jack_clubs:
                card_location_x = 73 * 10;
                card_location_y = 0;
                break;
            case Cards.queen_clubs:
                card_location_x = 73 * 11;
                card_location_y = 0;
                break;
            case Cards.king_clubs:
                card_location_x = 73 * 12;
                card_location_y = 0;
                break;
            case Cards.ace_spades:
                card_location_x = 73 * 0;
                card_location_y = 98;
                break;
            case Cards.two_spades:
                card_location_x = 73 * 1;
                card_location_y = 98;
                break;
            case Cards.three_spades:
                card_location_x = 73 * 2;
                card_location_y = 98;
                break;
            case Cards.four_spades:
                card_location_x = 73 * 3;
                card_location_y = 98;
                break;
            case Cards.five_spades:
                card_location_x = 73 * 4;
                card_location_y = 98;
                break;
            case Cards.six_spades:
                card_location_x = 73 * 5;
                card_location_y = 98;
                break;
            case Cards.seven_spades:
                card_location_x = 73 * 6;
                card_location_y = 98;
                break;
            case Cards.eight_spades:
                card_location_x = 73 * 7;
                card_location_y = 98;
                break;
            case Cards.nine_spades:
                card_location_x = 73 * 8;
                card_location_y = 98;
                break;
            case Cards.ten_spades:
                card_location_x = 73 * 9;
                card_location_y = 98;
                break;
            case Cards.jack_spades:
                card_location_x = 73 * 10;
                card_location_y = 98;
                break;
            case Cards.queen_spades:
                card_location_x = 73 * 11;
                card_location_y = 98;
                break;
            case Cards.king_spades:
                card_location_x = 73 * 12;
                card_location_y = 98;
                break;
            case Cards.ace_hearts:
                card_location_x = 73 * 0;
                card_location_y = 98 * 2;
                break;
            case Cards.two_hearts:
                card_location_x = 73 * 1;
                card_location_y = 98 * 2;
                break;
            case Cards.three_hearts:
                card_location_x = 73 * 2;
                card_location_y = 98 * 2;
                break;
            case Cards.four_hearts:
                card_location_x = 73 * 3;
                card_location_y = 98 * 2;
                break;
            case Cards.five_hearts:
                card_location_x = 73 * 4;
                card_location_y = 98 * 2;
                break;
            case Cards.six_hearts:
                card_location_x = 73 * 5;
                card_location_y = 98 * 2;
                break;
            case Cards.seven_hearts:
                card_location_x = 73 * 6;
                card_location_y = 98 * 2;
                break;
            case Cards.eight_hearts:
                card_location_x = 73 * 7;
                card_location_y = 98 * 2;
                break;
            case Cards.nine_hearts:
                card_location_x = 73 * 8;
                card_location_y = 98 * 2;
                break;
            case Cards.ten_hearts:
                card_location_x = 73 * 9;
                card_location_y = 98 * 2;
                break;
            case Cards.jack_hearts:
                card_location_x = 73 * 10;
                card_location_y = 98 * 2;
                break;
            case Cards.queen_hearts:
                card_location_x = 73 * 11;
                card_location_y = 98 * 2;
                break;
            case Cards.king_hearts:
                card_location_x = 73 * 12;
                card_location_y = 98 * 2;
                break;
            case Cards.ace_diamonds:
                card_location_x = 73 * 0;
                card_location_y = 98 * 3;
                break;
            case Cards.two_diamonds:
                card_location_x = 73 * 1;
                card_location_y = 98 * 3;
                break;
            case Cards.three_diamonds:
                card_location_x = 73 * 2;
                card_location_y = 98 * 3;
                break;
            case Cards.four_diamonds:
                card_location_x = 73 * 3;
                card_location_y = 98 * 3;
                break;
            case Cards.five_diamonds:
                card_location_x = 73 * 4;
                card_location_y = 98 * 3;
                break;
            case Cards.six_diamonds:
                card_location_x = 73 * 5;
                card_location_y = 98 * 3;
                break;
            case Cards.seven_diamonds:
                card_location_x = 73 * 6;
                card_location_y = 98 * 3;
                break;
            case Cards.eight_diamonds:
                card_location_x = 73 * 7;
                card_location_y = 98 * 3;
                break;
            case Cards.nine_diamonds:
                card_location_x = 73 * 8;
                card_location_y = 98 * 3;
                break;
            case Cards.ten_diamonds:
                card_location_x = 73 * 9;
                card_location_y = 98 * 3;
                break;
            case Cards.jack_diamonds:
                card_location_x = 73 * 10;
                card_location_y = 98 * 3;
                break;
            case Cards.queen_diamonds:
                card_location_x = 73 * 11;
                card_location_y = 98 * 3;
                break;
            case Cards.king_diamonds:
                card_location_x = 73 * 12;
                card_location_y = 98 * 3;
                break;
            default:
                break;
        }

        // Create rectangle for source image.
        Rectangle srcRect = new Rectangle(card_location_x, card_location_y, 72, 98);
        GraphicsUnit units = GraphicsUnit.Pixel;

        // Draw image to screen.
        Graphics gr = pictureBox.CreateGraphics();
        gr.DrawImage(front_card, destRect, srcRect, units);
        gr.Dispose();

        Card card = new Card();
        card.Value = (int)playing_card;
        return card;
    }
}*/

public class Deck
    {
        public class Card
        {
            public int Value { get; set; }
            public Rectangle Image { get; set; }

            public Card(int value, Rectangle image)
            {
                this.Value = value;
                this.Image = image;
            }
        }

        public enum Playing_Cards
        {
            back_card = 0,

            ace_clubs,
            two_clubs,
            three_clubs,
            four_clubs,
            five_clubs,
            six_clubs,
            seven_clubs,
            eight_clubs,
            nine_clubs,
            ten_clubs,
            jack_clubs,
            queen_clubs,
            king_clubs,

            ace_spades,
            two_spades,
            three_spades,
            four_spades,
            five_spades,
            six_spades,
            seven_spades,
            eight_spades,
            nine_spades,
            ten_spades,
            jack_spades,
            queen_spades,
            king_spades,

            ace_hearts,
            two_hearts,
            three_hearts,
            four_hearts,
            five_hearts,
            six_hearts,
            seven_hearts,
            eight_hearts,
            nine_hearts,
            ten_hearts,
            jack_hearts,
            queen_hearts,
            king_hearts,

            ace_diamonds,
            two_diamonds,
            three_diamonds,
            four_diamonds,
            five_diamonds,
            six_diamonds,
            seven_diamonds,
            eight_diamonds,
            nine_diamonds,
            ten_diamonds,
            jack_diamonds,
            queen_diamonds,
            king_diamonds
        }

        private Image back_card;
        private Image front_card;

        public List<Card> cards;

        public Deck()
        {
            back_card = Properties.Resources.deck_back;
            front_card = Properties.Resources.deck_front;

            cards = new List<Card>();

            cards.Add(new Card(0, new Rectangle(73, 0, 72, 98)));
            for (int i = 1, index = 1, increment_rows = 0, increment_columns = 0, rows = 0, columns = 0; i < Enum.GetValues(typeof(Playing_Cards)).Length; i++, index++, rows = 73 * ++increment_rows, columns = 98 * increment_columns)
            {
                cards.Add(new Card((index == 1 ? 11 : (index > 10 ? 10 : index)), new Rectangle(rows, columns, 73, 98)));
                //Debug.WriteLine($"I:{index} | Rows:{rows} | Columns:{columns}");

                if (increment_rows == 12)
                {
                    increment_rows = -1;
                    increment_columns++;
                }
                if (index == 13)
                    index = 0;
            }
        }

        public Card Draw(PictureBox pictureBox, Card card)
        {
            // Create rectangle for displaying image.
            Rectangle destRect = new Rectangle(0, 0, 72, 98);

            // Create rectangle for source image.
            Rectangle srcRect = card.Image;

            // Set graphic unit.
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.

            // Crop the card.
            Bitmap croppedImage = new Bitmap(srcRect.Width, srcRect.Height);

            // Draw the card.
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                if (card.Value == 0)
                    g.DrawImage(back_card, destRect, srcRect, units);
                else
                    g.DrawImage(front_card, destRect, srcRect, units);
            }
            // Set to new Image.
            pictureBox.Image = croppedImage;

            return card;
        }

        public int SumOf(List<Card> cards)
        {
            int sum = 0;
            foreach(Card card in cards)
            {
                sum += card.Value;
            }
            return sum;
        }
    }
}
