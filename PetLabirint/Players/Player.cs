using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLabirint
{
    class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
            this.livesLeft = 3;
            
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            this.score = 0;
            this.livesLeft = startingLives;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetScore()
        {
            return this.score;
        }

        public int GetLivesLeft()
        {
            return this.livesLeft;
        }

        public void Kill()
        {
            if (this.livesLeft > 0)
            {
                this.livesLeft--;
            }
        }

    }
}
