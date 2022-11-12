using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ViewInterface
    {
        private readonly Presenter presenter;
        private static int player;
        private static char symbol;

        /// <summary>
        /// Displays the main window of the application.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            presenter = new Presenter(this);
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 0, 0);
            }

            Continue();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 0, 1);
            }

            Continue();
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 0, 2);
            }

            Continue();
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 1, 0);
            }

            Continue();
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 1, 1);
            }

            Continue();
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 1, 2);
            }

            Continue();
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 2, 0);
            }

            Continue();
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 2, 1);
            }

            Continue();
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (presenter.ValidGame())
            {
                player = presenter.GetPlayer();
                presenter.ProcessChoice(player, 2, 2);
            }

            Continue();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            presenter.NewGame();
            console.Foreground = Brushes.White;
            Prompt();
        }

        /// <summary>
        /// Determines and prompts the next player for action.
        /// </summary>
        private void Prompt()
        {
            player = presenter.GetPlayer();
            console.Text = $"Player {player}, it is your turn to play";
        }

        /// <summary>
        /// Clears the playing board.
        /// </summary>
        public void Reset()
        {
            one.Content = string.Empty;
            two.Content = string.Empty;
            three.Content = string.Empty;
            four.Content = string.Empty;
            five.Content = string.Empty;
            six.Content = string.Empty;
            seven.Content = string.Empty;
            eight.Content = string.Empty;
            nine.Content = string.Empty;
        }

        /// <summary>
        /// Sets the symbol (X / O) of the player in its position.
        /// </summary>
        /// <param name="player">The current player</param>
        /// <param name="row">The row number</param>
        /// <param name="col">The column number</param>
        public void SetPosition(int player, int row, int col)
        {
            errorConsole.Text = string.Empty;
            
            if (player == 1)
            {
                symbol = 'X';
            }
            else if (player == 2)
            {
                symbol = 'O';
            }

            string panel = $"{row}{col}";

            switch(panel)
            {
                case "00":
                    one.Content = symbol;
                    break;
                case "01":
                    two.Content = symbol;
                    break;
                case "02":
                    three.Content = symbol;
                    break;
                case "10":
                    four.Content = symbol;
                    break;
                case "11":
                    five.Content = symbol;
                    break;
                case "12":
                    six.Content = symbol;
                    break;
                case "20":
                    seven.Content = symbol;
                    break;
                case "21":
                    eight.Content = symbol;
                    break;
                case "22":
                    nine.Content = symbol;
                    break;
            }
        }

        /// <summary>
        /// Displays an error message to the console.
        /// </summary>
        /// <param name="error"></param>
        public void ShowError(string error)
        {
            errorConsole.Foreground = Brushes.Red;
            errorConsole.Text = error;
            Prompt();
        }

        /// <summary>
        /// Displays a message indicating a win.
        /// </summary>
        /// <param name="result"></param>
        public void ShowWin(string result)
        {
            console.Foreground = Brushes.Lime;
            console.Text = result;
        }

        /// <summary>
        /// Displays a message indicating a draw.
        /// </summary>
        /// <param name="result"></param>
        public void ShowDraw(string result)
        {
            console.Foreground = Brushes.Gray;
            console.Text = result;
        }

        /// <summary>
        /// Asks the presenter if the game can continue.
        /// </summary>
        private void Continue()
        {
            if (presenter.ValidGame())
            {
                Prompt();
            }
        }
    }
}
