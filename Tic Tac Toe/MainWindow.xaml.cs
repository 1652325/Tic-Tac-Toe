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
        public MainWindow()
        {
            InitializeComponent();
            Game = new Game();
        }

        private void grdGame1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Game.GameIsStarted)
            {

                if (e.Source is Rectangle)
                {
                    Rectangle currentrct = (Rectangle)e.Source;
                    int iLigne = (int)currentrct.GetValue(Grid.RowProperty);
                    int iColonne = (int)currentrct.GetValue(Grid.ColumnProperty);



                    Game.playersMove(turn, iLigne, iColonne);

                    turn = GameCst.O ? GameCst.X : GameCst.O;

                }
            }

        }

        private void btnCreatePlayers_Click(object sender, RoutedEventArgs e)
        {
            if (txtPlayer1Name.Text == "" || txtPlayer2Name.Text == "")
            {
                MessageBox.Show("veuillez entré le nom des joueurs");
                return;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            
            Game.CreatePlayers(txtPlayer1Name.Text, txtPlayer2Name.Text);
            Game.StartGame();

        }
    }
}
