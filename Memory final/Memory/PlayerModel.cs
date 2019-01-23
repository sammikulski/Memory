/*Project 3 - Matching Game
* CIS 3309 - Component-Based Software Design
* Created by Sam Mikulski and Bianca Tuliao
* This PlayerModel class is used to keep track
* of the player's names and the number of points
* each player has. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class PlayerModel
    {
        private String name;
        private int pointTotal;

        //constructor, takes in the name as a parameter
        //default number of points is 0
        public PlayerModel(String nameArg)
        {
            name = nameArg;
            pointTotal = 0;
        }

        //returns the name of a player
        public String GetName()
        {
            return name;
        }

        //returns the number of points a player has
        public int GetPoints()
        {
            return pointTotal;
        }

        //increments the number of points a player has by 2 (if they get a matching pair of cards)
        public void IncrementScore()
        {
            pointTotal += 2;
        }

        //after the game is over, and 'play again' is clicked, the number of points needs to be reset back to 0
        public void ResetStats()
        {
            pointTotal = 0;
        }
    }
}
