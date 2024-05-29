// This Program was developed using C#
// Homework 2 Deck Draw Program
// Teammates are Nicholas/Brett/James/Jeremy/Matthew
// 3/8/24 CS4500
// This Program used Visual Studio
// This Program will allow user to select 4 cards and write selections to a file
// Central Data Structure is Lists
// This Program used MicroSoft's Tutorial on C# Picture viewer apps,StackOverflow.com,and learn.microsoft.com/en-us/dotnet/api.

/* 
 * ==================================
 * HOW TO COMPILE, BUILD, AND EXECUTE
 * ==================================
 *  Launch Visual Studio and open the solution file (.sln) of the project.
 
 **  Build the Solution **
    -- In Visual Studio, go to the menu and select Build > Build Solution.

 ** Configure Debugging Options **
    -- Click F5 on the keyboard or go to Debug > Start Debugging 
    -- This Should Also Run the Project and Compile

 ** Documentation **
    -- Consult the Projects other Documentation for more in-depth details about the project
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckDrawHW1
{
    public partial class ArtDealer : Form
    {
        // Get Title
        string title = "Deck Draw Program";

        // Get path to write data
        string path = @"DrawData/CardsDealt.txt";

        // Get date-only portion of date, without its time. From .net API
        string date = System.DateTime.Now.Date.ToString("d");

        // variables to track user-picked rank and suit of cards
        // set to first options of dropdowns be default
        int userRankCard1 = 2;
        string userSuitCard1 = "_of_hearts";
        int userRankCard2 = 2;
        string userSuitCard2 = "_of_hearts";
        int userRankCard3 = 2;
        string userSuitCard3 = "_of_hearts";
        int userRankCard4 = 2;
        string userSuitCard4 = "_of_hearts";

        // array of locations of cards chosen by user in the deck
        int[] drawIndexes = new int[4];

        // generates a deck of cards
        List<(string, int)> deck = GenerateDeck();

        // Purpose: Initializes application (automatically made by .NET framework)
        public ArtDealer()
        {
            InitializeComponent();
        }

        // Purpose: On Program Start (initial form load), prepares program for user
        private void ArtDealer_Load(object sender, EventArgs e)
        {
            //Hides stop and reset buttons on initial start of program
            StopButton.Visible = false;
            ResetButton.Visible = false;

            //Displays welcome message
            string message = "Purpose of Program: Select 4 cards and write selections to a file";
            MessageBox.Show(message,title);


            // Create File if it does not exist Credit goes to matthew and win API
            if (!File.Exists(path))
            {
                // Create a file to write to
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(date);
                sw.Close();
            }

            //Updates history box with previous sessions choices
            updateHistoryBox();

            //Sets all dropdown menu values to same value, 2 of hearts
            rankBoxCard1.SelectedIndex = 0;
            suitBoxCard1.SelectedIndex = 0;
            rankBoxCard2.SelectedIndex = 0;
            suitBoxCard2.SelectedIndex = 0;
            rankBoxCard3.SelectedIndex = 0;
            suitBoxCard3.SelectedIndex = 0;
            rankBoxCard4.SelectedIndex = 0;
            suitBoxCard4.SelectedIndex = 0;

            //Clears card images
            clearCardImages();
            
            //Shows the pick a card message
            PickACardMesage.Visible = true;
        }

        // Purpose: On Draw Click, confirms user selection
        private void DrawButton_Click(object sender, EventArgs e)
        {
            //verifies all user-selected cards are unique
            bool sameCards = verifyUniqueCards(drawIndexes);
            //verifies all 4 cards have been picked
            bool allCardsPicked = verifyCardsPicked();

           
            //if all cards are selected and all cards are unique
            if (!sameCards && allCardsPicked)
            {
                StopButton.Visible = true;

                // Gets name of cards located at each user-selected draw index and prepares them for writing to file
                string firstCard = shortName(deck[drawIndexes[0]].Item1.ToString());
                string secondCard = shortName(deck[drawIndexes[1]].Item1.ToString());
                string thirdCard = shortName(deck[drawIndexes[2]].Item1.ToString());
                string fourthCard = shortName(deck[drawIndexes[3]].Item1.ToString());

                string rank1 = actualRank(deck[drawIndexes[0]].Item2);
                string rank2 = actualRank(deck[drawIndexes[1]].Item2);
                string rank3 = actualRank(deck[drawIndexes[2]].Item2);
                string rank4 = actualRank(deck[drawIndexes[3]].Item2);

                // Open the file to read from
                using (StreamWriter sw = File.AppendText(path))
                {
                    // Write Draw Data to file
                    sw.WriteLine(rank1 + firstCard + ','
                        + rank2 + secondCard + ','
                        + rank3 + thirdCard + ','
                        + rank4 + fourthCard);
                    sw.Close();
                }
                //Updates history box with new selections
                updateHistoryBox();
                //Replaces draw button with reset button
                DrawButton.Visible = false;
                ResetButton.Visible = true;
            }
            //Reprompts user if not all 4 cards are picked, displays error message
            else if (!allCardsPicked)
            {
                string message = "Please select all 4 cards.";
                MessageBox.Show(message, title);
            }
            //Reprompts user if not all cards are unique, displays error message
            else
            {
                string message = "You have 2 or more of the same card in this draw.\nPlease choose 4 different cards.";
                MessageBox.Show(message, title);
            }
        }

        // Purpose: On Stop Click, exit application
        private void StopButton_Click(object sender, EventArgs e)
        {
            // Configure message box
            string message = "Thank You For Playing";
            // Show message box
            System.Windows.Forms.MessageBox.Show(message,title);
            Application.Exit();
        }

        // Purpose: Generate Deck of Tuple sorted cards
        // Return: Tuple list representing deck of cards
        static List<(string,int)> GenerateDeck()
        {
            string[] suits = { "_of_clubs", "_of_diamonds", "_of_hearts", "_of_spades" };
            int[] ranks = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            List<int> rank = new List<int>(ranks);
            List<string> suit = new List<string>(suits);
            List<(string, int)> deck = CombineLists(suits, ranks);
            //Returns a deck of 52 cards as a list
            return deck;
        }
        // Paramters: Takes in array of strings representing card suits, array of ints representing card ranks
        // Purpose: Combine suits and ranks arrays into tuple deck list
        // Return: deck as tuple list (string suit, int rank) made up of suits and ranks arrays
        // Credit: @StackOverflow method for combining lists
        static List<(string, int)> CombineLists(string[] suits, int[] ranks)
        {
            var deck = new List<(string, int)>();
            for( int i = 0; i < suits.Length; i++ )
            {
                for( int j = 0; j < ranks.Length; j++)
                {
                    deck.Add((suits[i], ranks[j]));
                }
            }
            //Returns a list consisting of a deck of 52 cards after combining lists of ranks and suits
            return deck;
        }
        // Parameters: Takes in card suit as a string
        // Purpose: Get first letter of the suit
        // Return: Returns string of first character of each suit name
        string shortName(string name)
        {
            string shortSuit = name.ToUpper();
            shortSuit = shortSuit.Substring(4, 1);
            return shortSuit;
        }
        // Parameters: Takes in card rank as an int
        // Purpose: Get the rank of the card and convert it to a letter if face card
        // Return: Returns card rank as a string
        string actualRank(int rank)
        {
            string rankSuit = rank.ToString();
            if( rank > 10 )
            {
                //Converts number rank to first letter of face rank
                switch( rank )
                {
                    case 11:
                        rankSuit = "J";
                        break;
                    case 12:
                        rankSuit = "Q";
                        break;
                    case 13:
                        rankSuit = "K";
                        break;
                    case 14:
                        rankSuit = "A";
                        break;
                }
            }
            return rankSuit;
        }
        // Parameters: Takes card suit text from dropdown menu as string
        // Purpose: Translates suit dropdown menu option into card image file formatted string
        // Returns: String of suit formatted into card image file suit
        private string suitBox_Translator(string text)
        {
            string translatedSuit;
            switch (text)
            {
                case "Hearts":
                    translatedSuit = "_of_hearts";
                    break;
                case "Diamonds":
                    translatedSuit = "_of_diamonds";
                    break;
                case "Clubs":
                    translatedSuit = "_of_clubs";
                    break;
                default:
                    translatedSuit = "_of_spades";
                    break;
            }
            return translatedSuit;
        }
        // Paramters: Takes card rank text from dropdown menu as string
        // Translates rank dropdown menu option into file formatted int
        // Return: Returns int of suit formatted into card image file suit
        private int rankBox_Translator(string text)
        {
            int translatedRank;
            switch (text)
            {
                case "Jack":
                    translatedRank = 11;
                    break;
                case "Queen":
                    translatedRank = 12;
                    break;
                case "King":
                    translatedRank = 13;
                    break;
                case "Ace":
                    translatedRank = 14;
                    break;
                default:
                    //https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint16?view=net-8.0
                    translatedRank = Convert.ToInt16(text);
                    break;
            }
            return translatedRank;
        }
        // Parameters: Takes deck of card as a tuple list (string suit, int rank),
        //             rank of user selected card as int, suit of user selected card as string
        // Purpose: Searches deck list for a card that matches user input rank and suit
        // Return: int value of location of selected card from deck
        private int searchDeck(List<(string, int)> deck, int rank, string suit)
        {
            int index = 0;
            for (int i = 0; i < deck.Count; i++)
            {
                if (rank == deck[i].Item2 && suit == deck[i].Item1)
                {
                    index = i;
                    break;
                }
            }
            //Returns int value of location of selected card from deck
            return index;
        }
        // Parameters: Takes in array of user selected cards as integers, representing location in deck list
        // Purpose: Verifies that each card selected is at a different location in deck list
        // Return: Boolean value representing if any integer matches
        private bool verifyUniqueCards(int[] indexes)
        {
            for (int i = 0; i < indexes.Length-1; i++)
            {
                if (indexes[i] == indexes[i + 1])
                {
                    //Returns true if a card selected matches any cards next to it
                    return true;
                }
            }
            for (int i = 0; i < indexes.Length - 2; i++)
            {
                if (indexes[i] == indexes[i + 2])
                {
                    //Returns true if a card selected matches any cards 2 spots away
                    return true;
                }
            }
            if (indexes[0] == indexes[3])
            {
                //Returns true if a card selected matches any cards 3 spots away
                return true;
            }
            //Returns false if all cards are unique
            return false;
        }
        // Purpose: Clears current contents of history box and adds content from text file
        private void updateHistoryBox()
        {
            //https://stackoverflow.com/questions/13505248/how-to-make-autoscroll-multiline-textbox-in-winforms
            textBox1.Text = string.Empty;
            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            while (line != null)
            {
                //https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.appendtext?view=windowsdesktop-8.0
                textBox1.AppendText(line);
                //https://stackoverflow.com/questions/13318561/adding-new-line-of-data-to-textbox
                textBox1.AppendText(Environment.NewLine);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        // Parameters: Takes in card image location in program as Winforms PictureBox,
        //             rank as an integer, suit as a string (both card image file formatted)
        //             and integer representing locaion of card changed in user selected card array (drawIndexes)
        // Purposes: Updates card images with user-selected cards
        private void updateCardImage(PictureBox card, int userRank, string userSuit, int cardNumber)
        {
            int cardIndex = searchDeck(deck, userRank, userSuit);
            drawIndexes[cardNumber] = cardIndex;
            Console.WriteLine(cardIndex);
            card.Load(@"PlayingCards/" + deck[cardIndex].Item2 + deck[cardIndex].Item1 + ".png");
            //Hides pick a card message when user selects a card
            PickACardMesage.Visible = false;
        }

        // Purpose: Clears card images
        private void clearCardImages()
        {
            card1.Image = null;
            card2.Image = null;
            card3.Image = null;
            card4.Image = null;
        }

        // Purpose: Verifies that all 4 cards are chosen
        // Return: Returns boolean representing truth value of if all cards being picked
        private bool verifyCardsPicked()
        {
            if (card1.Image == null || card2.Image == null || card3.Image == null || card4.Image == null)
            {
                //Returns false if any card is not chosen
                return false;
            }
            //Returns true if all cards are chosen
            return true;
        }

        // Purpose: On user selection of first card's rank display dropdown menu, update tracking variable and update associated card image box
        private void rankBoxCard1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard1 = rankBox_Translator(rankBoxCard1.Text);
            updateCardImage(card1, userRankCard1, userSuitCard1, 0);
        }
        // Purpose: On user selection of first card's suit display dropdown menu, update tracking variable and update associated card image box
        private void suitBoxCard1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard1 = suitBox_Translator(suitBoxCard1.Text);
            updateCardImage(card1, userRankCard1, userSuitCard1, 0);
        }

        // Purpose: On user selection of second card's rank display dropdown menu, update tracking variable and update associated card image box
        private void rankBoxCard2_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard2 = rankBox_Translator(rankBoxCard2.Text);
            updateCardImage(card2, userRankCard2, userSuitCard2, 1);
        }

        // Purpose: On user selection of second card's suit display dropdown menu, update tracking variable and update associated card image box
        private void suitBoxCard2_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard2 = suitBox_Translator(suitBoxCard2.Text);
            updateCardImage(card2, userRankCard2, userSuitCard2, 1);
        }

        // Purpose: On user selection of third card's rank display dropdown menu, update tracking variable and update associated card image box
        private void rankBoxCard3_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard3 = rankBox_Translator(rankBoxCard3.Text);
            updateCardImage(card3, userRankCard3, userSuitCard3, 2);
        }

        // Purpose: On user selection of third card's suit display dropdown menu, update tracking variable and update associated card image box
        private void suitBoxCard3_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard3 = suitBox_Translator(suitBoxCard3.Text);
            updateCardImage(card3, userRankCard3, userSuitCard3, 2);
        }

        // Purpose: On user selection of fourth card's rank display dropdown menu, update tracking variable and update associated card image box
        private void rankBoxCard4_SelectedIndexChanged(object sender, EventArgs e)
        {
            userRankCard4 = rankBox_Translator(rankBoxCard4.Text);
            updateCardImage(card4, userRankCard4, userSuitCard4, 3);
        }

        // Purpose: On user selection of fourth card's suit display dropdown menu, update tracking variable and update associatedcard image box
        private void suitBoxCard4_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSuitCard4 = suitBox_Translator(suitBoxCard4.Text);
            updateCardImage(card4, userRankCard4, userSuitCard4, 3);
        }

        // Purpose:  On reset button click clears card images
        private void ResetButton_Click(object sender, EventArgs e)
        {
            clearCardImages();
            ResetButton.Visible = false;
            DrawButton.Visible = true;
        }
    }
}
