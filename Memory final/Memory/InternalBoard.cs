/*Project 3 - Matching Game 
* CIS 3309 - Component-Based Software Design
* Created by Sam Mikulski and Bianca Tuliao
* This InternalBoard is used to process the state
* of the game, determine if cards are matches,
* and reset the cards selected after each turn
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class InternalBoard
    {
        
        private int totalCards;
        private int cardsAdded; //number of cards in queue, to determine if there is a match.
        private int[] flippedCards = new int[2]; //array of size 2 to store a reference to each card being displayed

        //constructor, no parameters needed
        public InternalBoard()
        {
            cardsAdded = 0;
            totalCards = 16;
        }

        //decrements total cards after a match is made
        public void RemoveCards()
        {
            totalCards -= 2;
        }

        //stores the card in the array
        public void AddCard(int cardArg)
        {
            if (cardsAdded == 0)
            {
                flippedCards[0] = cardArg;

            }
            else if (cardsAdded == 1)
            {
                flippedCards[1] = cardArg;

            }
            cardsAdded++;
        }

        //determines if the cards are a match
        public Boolean IsMatch()
        {
            Boolean match = false;

            if (cardsAdded == 2)
            {
                if (flippedCards[0] == flippedCards[1])
                {
                    match = true;
                }
                else
                {
                    match = false;
                }
            }

            return match;
        }

        //returns the number of cards in queue
        public int GetCardsAdded()
        {
            return cardsAdded;
        }

        //resets the number of cards in queue after each turn
        public void ResetCardsAdded()
        {
            cardsAdded = 0;
        }

        //returns the total number of cards remaining on the board
        public int GetTotalCards()
        {
            return totalCards;
        }

        //resets the board after 'play again' is clicked
        public void ResetBoard()
        {
            totalCards = 16;
            cardsAdded = 0;
        }
    }
}
