using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone_UI.Models
{
    public class Game
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ExecutablePath { get; set; } // Optional: Path to the game's executable for launching

        public List<string> ImageList { get; set; } = new List<string>(); // Optional: List of image paths for the game
    }
}
