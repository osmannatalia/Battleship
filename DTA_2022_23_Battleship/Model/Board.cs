
namespace DTA_2022_23_Battleship.Model {
    public class Board {
        private SeaSquare[,] internalBoard;

        public Board(int size) {
            this.internalBoard = new SeaSquare[size, size];
        }
    }
}
