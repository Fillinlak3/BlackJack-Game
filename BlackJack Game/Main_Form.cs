using System.Diagnostics;
using System.Windows.Forms;

namespace BlackJack_Game
{
    public partial class Main_Form : Form
    {
        /*
            Application Settings.
        */
        private const int SCREEN_WIDTH = 1160;
        private const int SCREEN_HEIGHT = 540;

        Deck deck;
        Random rand;

        /*
            Game Settings.
        */
        bool isRunning = false;

        // 1 - player(1) , 2 - bot (player 2).
        int player_turn = 0;

        List<Deck.Card> bot_cards;
        List<Deck.Card> player_cards;
        List<PictureBox> added_pictureboxes;
        Point Last_PicBox_Location;

        public Main_Form()
        {
            InitializeComponent();

            deck = new Deck();
            rand = new Random();

            bot_cards = new List<Deck.Card>();
            player_cards = new List<Deck.Card>();
            added_pictureboxes = new List<PictureBox>();
            Last_PicBox_Location = new Point(-1, -1);

            LB_Result.Visible = false;
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (isRunning)
            { LB_Result.Text = "Already Running"; LB_Result.Visible = true; return; }

            if (added_pictureboxes.Count > 0)
                foreach (var picbox in added_pictureboxes) this.Controls.Remove(picbox);
            added_pictureboxes.Clear();

            LB_Result.Visible = false;
            isRunning = true;

            player_cards.Clear();
            bot_cards.Clear();

            deck.Draw(pictureBox_bot_card1, deck.cards[0]);
            bot_cards.Add(deck.Draw(pictureBox_bot_card2, deck.cards[rand.Next(1, 52)]));
            LB_bot_hand_value.Text = $"Bot hand value: {deck.SumOf(bot_cards)}";

            player_cards.Add(deck.Draw(pictureBox_player_card1, deck.cards[rand.Next(1, 52)]));
            player_cards.Add(deck.Draw(pictureBox_player_card2, deck.cards[rand.Next(1, 52)]));
            LB_player_hand_value.Text = $"Your hand value: {deck.SumOf(player_cards)}";
            Last_PicBox_Location = pictureBox_player_card2.Location;

            if (deck.SumOf(player_cards) == 21) GameWin();
        }

        private void HitMe(object sender, EventArgs e)
        {
            if (isRunning == false)
            { LB_Result.Text = "Press Start"; return; }

            // Create a new picturebox to display the new card.
            PictureBox pictureBox = new PictureBox();
            pictureBox.Visible = true;
            pictureBox.Size = new Size(73, 98);
            pictureBox.Location = new Point(Last_PicBox_Location.X + 73 + 6, Last_PicBox_Location.Y);
            Last_PicBox_Location = pictureBox.Location;

            player_cards.Add(deck.Draw(pictureBox, deck.cards[rand.Next(1, 52)]));
            added_pictureboxes.Add(pictureBox);
            this.Controls.Add(pictureBox);

            if (deck.SumOf(player_cards) > 21)
            {
                // Check if player has an ace.
                bool found = false;
                foreach (Deck.Card card in player_cards)
                    if (card.Value == 11) { card.Value = 1; found = true; break; }

                if (found == false) GameOver();
            }
            if (deck.SumOf(player_cards) == 21) GameWin();

            LB_player_hand_value.Text = $"Your hand value: {deck.SumOf(player_cards)}";
        }

        private void Stay(object sender, EventArgs e)
        {
            if (isRunning == false)
            { LB_Result.Text = "Press Start"; return; }

            Last_PicBox_Location = pictureBox_bot_card2.Location;
            bot_cards.Add(deck.Draw(pictureBox_bot_card1, deck.cards[rand.Next(1, 52)]));

            while (deck.SumOf(bot_cards) <= deck.SumOf(player_cards))
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Visible = true;
                pictureBox.Size = new Size(73, 98);
                pictureBox.Location = new Point(Last_PicBox_Location.X + 73 + 6, Last_PicBox_Location.Y);
                Last_PicBox_Location = pictureBox.Location;

                bot_cards.Add(deck.Draw(pictureBox, deck.cards[rand.Next(1, 52)]));
                this.Controls.Add(pictureBox);
                added_pictureboxes.Add(pictureBox);

                if (deck.SumOf(player_cards) > 21)
                {
                    // Check if bot has an ace.
                    foreach (Deck.Card card in bot_cards)
                        if (card.Value == 11) { card.Value = 1; break; }
                }
                if (deck.SumOf(bot_cards) == 21) CheckWin();
            }

            LB_bot_hand_value.Text = $"Bot hand value: {deck.SumOf(bot_cards)}";
            CheckWin();
        }

        void CheckWin()
        {
            if (deck.SumOf(bot_cards) > 21) { GameWin(); return; }
            else if (deck.SumOf(player_cards) > 21) { GameOver(); return; }

            if (deck.SumOf(player_cards) > deck.SumOf(bot_cards)) { GameWin(); return; }
            else { GameOver(); return; }
        }

        void GameWin()
        {
            isRunning = false;
            LB_Result.Visible = true;
            LB_Result.Text = $"You won by {deck.SumOf(bot_cards) - deck.SumOf(player_cards)} points.";
        }

        void GameOver()
        {
            isRunning = false;
            LB_Result.Visible = true;
            LB_Result.Text = "Game Over";
        }
    }
}