using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA_2022_23_Battleship.Model {
    public class ShipSquare {
        public ShipSquare(Ship ship) {
            this.Ship = ship;
        }
        public Coordinate? Coordinate { get; set; }
        public bool IsHit { get; set; }
        public Ship Ship { get; }
    }
}
