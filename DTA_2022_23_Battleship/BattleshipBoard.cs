using DTA_2022_23_Battleship.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTA_2022_23_Battleship {
    public partial class BattleshipBoard : UserControl {

        public BattleshipBoard()  {
            InitializeComponent();

        }
        private Board board;
        private bool showShips;
        public void SetBoard(Board board, bool showShips) { 
            this.board = board;
            this.showShips = showShips;

            // TODO:
            // Create tableLayoutPanel based on size (rows and columns).
            // Insert a panel into each cell - this can then be colored.
            // In addition, the click event can be handled in the panel (for the shot by the human player)

            for (int r = 0; r < this.tableLayoutPanel1.RowCount; r++) {
                for (int c = 0; c < this.tableLayoutPanel1.ColumnCount; c++) {

                    var panel = new Panel();
                    panel.Dock = DockStyle.Fill;
                    panel.Click += this.panel1_Click;

                    this.tableLayoutPanel1.Controls.Add(panel, c, r);
                }
            }

            this.EvaluateShipStates();
        }

        public bool ShowShips {
            get {
                return this.showShips;
            }
            set {
                if (value != this.showShips) {
                    this.showShips = value;
                    this.EvaluateShipStates();
                }
            }
        }

        private void EvaluateShipStates() {
            for (int r = 0; r < this.tableLayoutPanel1.RowCount; r++) {
                for (int c = 0; c < this.tableLayoutPanel1.ColumnCount; c++) {
                    this.EvaluateShipState(new Coordinate(c, r));
                }
            }
        }

        public void EvaluateShipState(Coordinate coordinate) {
            var seaSquare = board.GetSeaSquare(coordinate);
            var panel = (Panel)tableLayoutPanel1.GetControlFromPosition(coordinate.X, coordinate.Y);

            if (seaSquare.HasShip) {
                if (seaSquare.IsShot) {
                    if(seaSquare.ShipSquare.Ship.IsSunk)
                    {
                        foreach (ShipSquare shipSquare in seaSquare.ShipSquare.Ship.InternalList) {
                            panel = (Panel)tableLayoutPanel1.GetControlFromPosition(shipSquare.Coordinate.X, shipSquare.Coordinate.Y);
                            panel.BackColor = Color.Black;
                        }
                    } else {
                        panel.BackColor = Color.Red;
                    }
                } else {
                    if (showShips) {
                        panel.BackColor = Color.Gray;
                    } else {
                        panel.BackColor = SystemColors.ControlLight;
                    }
                }
            } else {
                if(seaSquare.IsShot) {
                    panel.BackColor = Color.Blue;
                }
            }

        }
        private void panel1_Click(object? sender, EventArgs e) {
            // MessageBox.Show("Hello");
            var panel = (Panel)sender;
            //panel.BackColor = Color.Red;

            var position = this.tableLayoutPanel1.GetPositionFromControl(panel);
            var coordinate = new Coordinate(position.Column, position.Row);
            board.Shot(coordinate);
        }
    }
}
