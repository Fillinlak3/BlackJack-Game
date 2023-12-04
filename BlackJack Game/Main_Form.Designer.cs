namespace BlackJack_Game
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_StartGame = new Button();
            pictureBox_bot_card1 = new PictureBox();
            pictureBox_player_card1 = new PictureBox();
            pictureBox_player_card2 = new PictureBox();
            pictureBox_bot_card2 = new PictureBox();
            LB_bot_hand_value = new Label();
            LB_player_hand_value = new Label();
            BTN_Hit = new Button();
            BTN_Stay = new Button();
            LB_Result = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bot_card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_player_card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_player_card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bot_card2).BeginInit();
            SuspendLayout();
            // 
            // BTN_StartGame
            // 
            BTN_StartGame.BackColor = Color.FromArgb(0, 66, 37);
            BTN_StartGame.FlatAppearance.BorderSize = 0;
            BTN_StartGame.FlatStyle = FlatStyle.Flat;
            BTN_StartGame.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_StartGame.ForeColor = Color.White;
            BTN_StartGame.Location = new Point(643, 21);
            BTN_StartGame.Name = "BTN_StartGame";
            BTN_StartGame.Size = new Size(144, 33);
            BTN_StartGame.TabIndex = 1;
            BTN_StartGame.TabStop = false;
            BTN_StartGame.Text = "Start Game";
            BTN_StartGame.UseVisualStyleBackColor = false;
            BTN_StartGame.Click += StartGame;
            // 
            // pictureBox_bot_card1
            // 
            pictureBox_bot_card1.BackColor = Color.Transparent;
            pictureBox_bot_card1.Location = new Point(12, 21);
            pictureBox_bot_card1.Name = "pictureBox_bot_card1";
            pictureBox_bot_card1.Size = new Size(73, 98);
            pictureBox_bot_card1.TabIndex = 3;
            pictureBox_bot_card1.TabStop = false;
            // 
            // pictureBox_player_card1
            // 
            pictureBox_player_card1.BackColor = Color.Transparent;
            pictureBox_player_card1.Location = new Point(12, 169);
            pictureBox_player_card1.Name = "pictureBox_player_card1";
            pictureBox_player_card1.Size = new Size(73, 98);
            pictureBox_player_card1.TabIndex = 4;
            pictureBox_player_card1.TabStop = false;
            // 
            // pictureBox_player_card2
            // 
            pictureBox_player_card2.BackColor = Color.Transparent;
            pictureBox_player_card2.Location = new Point(91, 169);
            pictureBox_player_card2.Name = "pictureBox_player_card2";
            pictureBox_player_card2.Size = new Size(73, 98);
            pictureBox_player_card2.TabIndex = 5;
            pictureBox_player_card2.TabStop = false;
            // 
            // pictureBox_bot_card2
            // 
            pictureBox_bot_card2.BackColor = Color.Transparent;
            pictureBox_bot_card2.Location = new Point(91, 21);
            pictureBox_bot_card2.Name = "pictureBox_bot_card2";
            pictureBox_bot_card2.Size = new Size(73, 98);
            pictureBox_bot_card2.TabIndex = 6;
            pictureBox_bot_card2.TabStop = false;
            // 
            // LB_bot_hand_value
            // 
            LB_bot_hand_value.AutoSize = true;
            LB_bot_hand_value.BackColor = Color.FromArgb(0, 66, 37);
            LB_bot_hand_value.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_bot_hand_value.ForeColor = Color.White;
            LB_bot_hand_value.Location = new Point(12, 122);
            LB_bot_hand_value.Name = "LB_bot_hand_value";
            LB_bot_hand_value.Size = new Size(157, 30);
            LB_bot_hand_value.TabIndex = 7;
            LB_bot_hand_value.Text = "Bot hand value:";
            // 
            // LB_player_hand_value
            // 
            LB_player_hand_value.AutoSize = true;
            LB_player_hand_value.BackColor = Color.FromArgb(0, 66, 37);
            LB_player_hand_value.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_player_hand_value.ForeColor = Color.White;
            LB_player_hand_value.Location = new Point(12, 270);
            LB_player_hand_value.Name = "LB_player_hand_value";
            LB_player_hand_value.Size = new Size(167, 30);
            LB_player_hand_value.TabIndex = 8;
            LB_player_hand_value.Text = "Your hand value:";
            // 
            // BTN_Hit
            // 
            BTN_Hit.BackColor = Color.FromArgb(0, 66, 37);
            BTN_Hit.FlatAppearance.BorderSize = 0;
            BTN_Hit.FlatStyle = FlatStyle.Flat;
            BTN_Hit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Hit.ForeColor = Color.White;
            BTN_Hit.Location = new Point(643, 169);
            BTN_Hit.Name = "BTN_Hit";
            BTN_Hit.Size = new Size(144, 33);
            BTN_Hit.TabIndex = 9;
            BTN_Hit.TabStop = false;
            BTN_Hit.Text = "Hit me";
            BTN_Hit.UseVisualStyleBackColor = false;
            BTN_Hit.Click += HitMe;
            // 
            // BTN_Stay
            // 
            BTN_Stay.BackColor = Color.FromArgb(0, 66, 37);
            BTN_Stay.FlatAppearance.BorderSize = 0;
            BTN_Stay.FlatStyle = FlatStyle.Flat;
            BTN_Stay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Stay.ForeColor = Color.White;
            BTN_Stay.Location = new Point(643, 217);
            BTN_Stay.Name = "BTN_Stay";
            BTN_Stay.Size = new Size(144, 33);
            BTN_Stay.TabIndex = 10;
            BTN_Stay.TabStop = false;
            BTN_Stay.Text = "Stay";
            BTN_Stay.UseVisualStyleBackColor = false;
            BTN_Stay.Click += Stay;
            // 
            // LB_Result
            // 
            LB_Result.AutoSize = true;
            LB_Result.BackColor = Color.FromArgb(0, 66, 37);
            LB_Result.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Result.ForeColor = Color.White;
            LB_Result.Location = new Point(253, 122);
            LB_Result.Name = "LB_Result";
            LB_Result.Size = new Size(162, 40);
            LB_Result.TabIndex = 11;
            LB_Result.Text = "Result Here";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.table_felt2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 321);
            Controls.Add(LB_Result);
            Controls.Add(BTN_Stay);
            Controls.Add(BTN_Hit);
            Controls.Add(LB_player_hand_value);
            Controls.Add(LB_bot_hand_value);
            Controls.Add(pictureBox_bot_card2);
            Controls.Add(pictureBox_player_card2);
            Controls.Add(pictureBox_player_card1);
            Controls.Add(pictureBox_bot_card1);
            Controls.Add(BTN_StartGame);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(815, 360);
            MinimumSize = new Size(815, 360);
            Name = "Main_Form";
            Text = "BlackJack - Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox_bot_card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_player_card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_player_card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bot_card2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTN_StartGame;
        private PictureBox pictureBox_bot_card1;
        private PictureBox pictureBox_player_card1;
        private PictureBox pictureBox_player_card2;
        private PictureBox pictureBox_bot_card2;
        private Label LB_bot_hand_value;
        private Label LB_player_hand_value;
        private Button BTN_Hit;
        private Button BTN_Stay;
        private Label LB_Result;
    }
}