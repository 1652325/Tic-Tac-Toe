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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game Game;
        bool turn = GameCst.O;
        ImageBrush X = new ImageBrush();
        ImageBrush O = new ImageBrush();

        public MainWindow()
        {
            InitializeComponent();
            Game = new Game();
            X.ImageSource = new BitmapImage(new Uri(@"../../Images/X.jpg", UriKind.Relative));
            O.ImageSource = new BitmapImage(new Uri(@"../../Images/O.jpg", UriKind.Relative));
        }

        private void grdGame1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Game.GameIsStarted)
            {

                if (e.Source is Rectangle)
                {
                    if (Game.GameIsStarted)
                    {
                        Rectangle currentrct = (Rectangle)e.Source;
                        int iLigne = (int)currentrct.GetValue(Grid.RowProperty);
                        int iColonne = (int)currentrct.GetValue(Grid.ColumnProperty);

                        Game.playersMove(turn, iLigne, iColonne);
                        currentrct.Fill = turn == GameCst.O ? O : X;
                        if (turn == GameCst.O)
                            turn = GameCst.X;

                        else
                            turn = GameCst.O;
                        Game.CheckWinner();

                    }
                }
            }
        }

        private void btnCreatePlayers_Click(object sender, RoutedEventArgs e)
        {
            if (Game.PlayerAreCreated())
            {
                MessageBox.Show("Les joueurs sont déjà créer...");
                return;
            }
            if (txtPlayer1Name.Text == "" || txtPlayer2Name.Text == "")
            {
                MessageBox.Show("veuillez entré le nom des joueurs");
                return;
            }
            Game.CreatePlayers(txtPlayer1Name.Text, txtPlayer2Name.Text);
            lblBlockJoueur1.Content += txtPlayer1Name.Text + " = O ";
            lblBlockJoueur2.Content += txtPlayer2Name.Text + " = X ";
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (Game.PlayerAreCreated())
                Game.StartGame();


        }
    }
}
