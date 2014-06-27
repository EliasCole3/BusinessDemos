using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


//I changed the standard cards to the mario cards from the super mario 3 matching game:
//  http://www.youtube.com/watch?v=r-jckUWLBdk#t=0m11s



namespace Concentration
{
    public partial class boardForm : Form
    {
        public boardForm()
        {
            InitializeComponent();
        }

        #region Instance Variables

        private string[] cards;
        private int index1 = -1, index2 = -1;
        private int matches = 0;
        int seconds = 0;
        int userChoice = 1;

        #endregion

        #region Methods

        private void FillCards()
        {
            cards = new string[21];
            int index = 1;
			
            string[] suits = { "1", "2" };  //all the cards in pairs
			
			string[] values = { "1", "2", "3", "4", "5", "6" };  //first 12 cards
            foreach (string value in values)
            {
                foreach (string suit in suits)
                {
                    cards[index] = "Mario" + value + ".jpg";
                    index++;
                }
            }
			
            string[] values2 = { "1", "2", "3", "4" }; //last 8 cards
            foreach (string value in values2)
            {
                foreach (string suit in suits)
                {
                    cards[index] = "Mario" + value + ".jpg";
                    index++;
                }
            }
            //In total, 20 cards, [4,4,4,4,2,2]
        }

        // determines if the 2 cards are a match.  The "value" of the card is in the filename.
        private bool IsMatch(int index1, int index2)
        {
            string test1 = cards[index1];
            string test2 = cards[index2];
            int match1 = int.Parse(test1.Substring(5,1));
            int match2 = int.Parse(test2.Substring(5,1));
            if (match1 == match2)
                return true;
            else
                return false;
        }

        private void ShuffleCards()
        {
            Random random = new Random();

            for (int i = 1; i <= 20; i++)
            {
                int randomNumber = random.Next(1, 20);
                string temp1 = cards[i];
                cards[i] = cards[randomNumber];
                cards[randomNumber] = temp1;
            }
        }
        
        private void LoadCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["card" + i];
            card.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + cards[i]);
        }

        private void LoadCardBack(int i)
        {
             PictureBox card = (PictureBox)this.Controls["card" + i];
             card.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\Cards\\" + "MarioBack2.jpg");
        }

        private void HideCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["card" + i];
            card.Visible = false;
            card.Enabled = false;
        }

        private void HideAllCards()
        {
            for (int i = 1; i <= 20; i++)
            {
                HideCard(i);
            }
        }

        private void DisableCard(int i)
        {
            PictureBox card = (PictureBox)this.Controls["card" + i];
            card.Enabled = false;
        }

        private void DisableAllCards()
        {
            for (int i = 1; i <= 20; i++)
            {
                DisableCard(i);
            }
        }

        private void ShowAllCards()
        {
            for (int i = 1; i <= 20; i++)
            {
                PictureBox card = (PictureBox)this.Controls["card" + i];
                card.Visible = true;
                card.Enabled = true;
            }
        }

        private void EnableAllVisibleCards()
        {
            for (int i = 1; i <= 20; i++)
            {
                PictureBox card = (PictureBox)this.Controls["card" + i];
                if (card.Visible == true)
                {
                    card.Enabled = true;
                }
            }
        }

        #endregion


        private void frmBoard_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            lblElapsedTime.Text = seconds.ToString();
            FillCards();
            ShuffleCards();

            for (int i = 1; i <= 20; i++)
            {
                LoadCardBack(i);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblElapsedTime.Text = seconds.ToString();
        }

        private void card_Click(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            int cardIndex = int.Parse(card.Name.Substring(4));

            if (index1 == -1)
            {
                index1 = cardIndex;
                LoadCard(index1);
                DisableCard(index1);
            }
            else
            {
                index2 = cardIndex;
                LoadCard(index2);
                DisableAllCards();
                flipTimer.Enabled = true;
            }

        }

        private void flipTimer_Tick(object sender, EventArgs e)
        {

            flipTimer.Enabled = false;

            if (IsMatch(index1, index2))
            {
                HideCard(index1);
                HideCard(index2);
                index1 = -1;
                index2 = -1;
                matches++;
                if (matches == 10)
                {
                    if (userChoice == 1)
                    {
                        MessageBox.Show("Congrats!");
                        ShuffleCards();
                        for (int i = 1; i <= 20; i++)
                        {
                            LoadCardBack(i);
                        }
                        ShowAllCards();
                        EnableAllVisibleCards();
                    }
                    else
                    {
                        //close application
                    }
                }
                else
                {
                    EnableAllVisibleCards();
                }

            }
            else
            {
                LoadCardBack(index1);
                LoadCardBack(index2);
                index1 = -1;
                index2 = -1;
                EnableAllVisibleCards();
            }
          
        }
    }
}
