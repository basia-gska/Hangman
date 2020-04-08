﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Player
    {
        public string Name { get; private set; }
        
        public Player(string name)
        {
            this.Name = name;
        }
        
        
        public List<char> GuessedLetters { get; } = new List<char>();


        private int score;
        public int Score
        {
            get { return score; }
            set 
            {
                if (value > 0)
                    score = value; 
            }
        }

    }
}
