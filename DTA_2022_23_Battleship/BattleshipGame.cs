using DTA_2022_23_Battleship.Model;

namespace DTA_2022_23_Battleship {
    public partial class BattleshipGame : Form {
        private Game game;   // Model
        public BattleshipGame(Game game) {
            this.game = game;

            InitializeComponent();
            game.StartNewGame();            

            // View:
            // BattleshipGame (=this)
            // this.battleshipBoardPlayer1
            // this.battleshipBoardPlayer2


            // TODO:
            // Hier sind die Boards (=Model) mit den Schiffen erzeugt.
            // game.BoardPlayer1 mit this.battleshipBoardPlayer1 visualisieren
            // D.h. game.BoardPlayer1 an this.battleshipBoardPlayer1 übergeben und
            // in BattleshipBoard die Logik für die Visualisierung umsetzen.
        }
    }
}