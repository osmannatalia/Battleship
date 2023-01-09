
namespace DTA_2022_23_Battleship.Model {
    public class Board {
        private SeaSquare[,] internalBoard;

        public Board(int size) {
            this.Size = size;
            this.internalBoard = new SeaSquare[size, size];
        }

        private List<Ship> ships = new List<Ship>();
        public void AddShip(Ship ship) {
            this.ships.Add(ship);
        }

        public int Size { get; private set; }

        public bool HasShip(Coordinate coordinate) {
            var seaSquare = this.internalBoard[coordinate.X, coordinate.Y];
            return seaSquare.HasShip;
        }
    }
}
