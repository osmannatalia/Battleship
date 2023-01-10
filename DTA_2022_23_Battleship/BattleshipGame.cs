using DTA_2022_23_Battleship.Model;

namespace DTA_2022_23_Battleship {
    public partial class BattleshipGame : Form {
        private Game game;   // Model
        public BattleshipGame(Game game) {
            this.game = game;

            InitializeComponent();
            game.StartNewGame();

            this.battleshipBoardPlayer1.SetBoard(game.BoardPlayer1, true);
            this.battleshipBoardPlayer2.SetBoard(game.BoardPlayer2, true);

            game.BoardPlayer1.AfterShot += BoardPlayer1_AfterShot;
            game.BoardPlayer2.AfterShot += BoardPlayer2_AfterShot;
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

        private void BoardPlayer1_AfterShot(object? sender, AfterShotEventArgs e) {
            this.battleshipBoardPlayer1.EvaluateShipState(e.Coordinate);
        }

        private void BoardPlayer2_AfterShot(object? sender, AfterShotEventArgs e) {
            this.battleshipBoardPlayer2.EvaluateShipState(e.Coordinate);
        }

        private void button2_Click(object sender, EventArgs e) {
            this.battleshipBoardPlayer1.ShowShips = !this.battleshipBoardPlayer1.ShowShips;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.battleshipBoardPlayer2.ShowShips = !this.battleshipBoardPlayer2.ShowShips;
        }
    }
}