
using System.Diagnostics;
using System.Drawing;

namespace DTA_2022_23_Battleship.Model {
    public class Board {
        private SeaSquare[,] internalBoard;

        public Board(int size) {
            this.Size = size;
            this.internalBoard = new SeaSquare[size, size];
            for (int r = 0; r < size; r++) {
                for (int c = 0; c < size; c++) {
                    this.internalBoard[r, c] = new SeaSquare();
                }
            }
        }

        private List<Ship> ships = new List<Ship>();
        public void AddShip(Ship ship, Coordinate coordinate, Orientation orientation) {
            this.ships.Add(ship);
            
            if(orientation == Orientation.Horizontal) {
                var x = coordinate.X;
                foreach(var shipSquare in ship.ShipSquares) {
                    shipSquare.Coordinate = new Coordinate(x, coordinate.Y);
                    this.internalBoard[x, coordinate.Y].LinkShipSquare(shipSquare);
                    x++;
                }
            } else {
                var y = coordinate.Y;
                foreach (var shipSquare in ship.ShipSquares) {
                    shipSquare.Coordinate = new Coordinate(coordinate.X, y);
                    this.internalBoard[coordinate.X, y].LinkShipSquare(shipSquare);
                    y++;
                }
            }
        }

        public void RemoveShip(Ship ship) {
            foreach (var shipSquare in ship.ShipSquares) {
                this.internalBoard[shipSquare.Coordinate.X, shipSquare.Coordinate.Y].UnlinkShipSquare();

            }
        }
        public int Size { get; private set; }

        public bool HasShip(Coordinate coordinate) {
            var seaSquare = this.internalBoard[coordinate.X, coordinate.Y];
            return seaSquare.HasShip;
        }

        public void PrintBoard() {
            Debug.WriteLine("\n--------------------");
            for (int r = 0; r < this.Size; r++) {
                Debug.Write("|");
                for (int c = 0; c < this.Size; c++) {
                    if (this.internalBoard[r, c].HasShip) {
                        Debug.Write("X");
                    } else {
                        Debug.Write(" ");
                    }
                    Debug.Write("|");
                }
                Debug.WriteLine("\n--------------------");
            }

        }
    }
}
