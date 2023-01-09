using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA_2022_23_Battleship.Model {
    public class Game {
        private Board boardPlayer1 = new Board(10);
        private Board boardPlayer2 = new Board(10);

        public void StartNewGame() {

            var ships = this.GenerateShips();

            // TODO: Add Ships to Board
            foreach (var ship in ships) {
                boardPlayer1.AddShip(ship);
            }

        }

        private List<Ship> GenerateShips() {
            var ships = new List<Ship>();

            for(var i = 0; i<4; i++) {
                ships.Add(new Ship(2));
            }
            for (var i = 0; i < 3; i++) {
                ships.Add(new Ship(3));
            }
            for (var i = 0; i < 2; i++) {
                ships.Add(new Ship(4));
            }
            ships.Add(new Ship(5));

            return ships;
        }
    }
}
