using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Capstone_UI
{
    public partial class GameSelection : Page
    {
        public List<Game> GamesList { get; set; }

        public GameSelection()
        {
            InitializeComponent();

            // Attach Loaded event to make sure UI is fully constructed before binding
            this.Loaded += GameSelection_Loaded;
        }

        private void GameSelection_Loaded(object sender, RoutedEventArgs e)
        {
            // 1. Populate sample games
            GamesList = new List<Game>
            {
                new Game
                {
                    Title = "Resident Evil 2",
                    ImagePath = "/Images/re2.jpg",
                    Category = "Survival Horror",
                    Description = "Resident Evil 2 (1998) is a classic survival horror video game developed and published by Capcom for the PlayStation"
                },
                new Game
                {
                    Title = "Mega Man",
                    ImagePath = "/Images/megaman.jpg",
                    Category = "Action-Platformer / Side-Scroller",
                    Description = "The original Mega Man is a 1987 action-platform video game developed and published by Capcom for the Nintendo Entertainment System (NES)."
                },
                new Game
                {
                    Title = "Donkey Kong",
                    ImagePath = "/Images/donkeykong.jpg",
                    Category = "Platformer",
                    Description = "Donkey Kong arcade game is a pioneering platformer created by Shigeru Miyamoto where you control Mario (initially called Jumpman) to rescue his girlfriend Pauline from a giant, barrel-throwing ape."
                },
                new Game
                {
                    Title = "Super Metroid",
                    ImagePath = "/Images/supermetroid.jpg",
                    Category = "2D Action-Adventure / Metroidvania",
                    Description = "Super Metroid is a classic 1994 action-adventure platformer game developed by Nintendo and Intelligent Systems for the Super Nintendo Entertainment System (SNES)"
                }
            };

            // 2. Bind games to ListBox
            GameListBox.ItemsSource = GamesList;

            // 3. Select top item by default
            if (GamesList.Count > 0)
            {
                GameListBox.SelectedIndex = 0;
            }
        }

        private void GameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GameListBox.SelectedItem is Game selectedGame)
            {
                TxtTitle.Text = selectedGame.Title;
                TxtCategory.Text = selectedGame.Category;
                TxtDescription.Text = selectedGame.Description;

                try
                {
                    ImgThumbnail.Source = new BitmapImage(new System.Uri(selectedGame.ImagePath, System.UriKind.RelativeOrAbsolute));
                }
                catch
                {
                    ImgThumbnail.Source = null;
                }
            }
        }


        private void logoExit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Are you sure you want to exit the program?",
                "Exit Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void gameSelectBackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService != null)
            {
                this.NavigationService.Content = null;
            }
        }
    }
}