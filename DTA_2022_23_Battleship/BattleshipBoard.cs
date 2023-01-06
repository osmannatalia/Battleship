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

        public BattleshipBoard() : this(10) {

        }
        public BattleshipBoard(int size) {
            InitializeComponent();

            // TODO:
            // Create tableLayoutPanel based on size (rows and columns).
            // Insert a panel into each cell - this can then be colored.
            // In addition, the click event can be handled in the panel (for the shot by the human player)

        }
    }
}
