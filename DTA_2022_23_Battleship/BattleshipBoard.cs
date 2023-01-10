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

            for (int r = 0; r < this.tableLayoutPanel1.RowCount; r++)
            {
                for (int c = 0; c < this.tableLayoutPanel1.ColumnCount; c++) {

                    var panel = new Panel();
                    panel.Dock = DockStyle.Fill;
                    panel.Click += this.panel1_Click;

                    this.tableLayoutPanel1.Controls.Add(panel, c, r);
                    panel.BackColor = Color.White;

                    
                }
            }
        }

        private void panel1_Click(object? sender, EventArgs e)
        {
            // MessageBox.Show("Hello");
            var panel = (Panel)sender;
            panel.BackColor = Color.DarkGray;
            // panel.BorderStyle = BorderStyle.
        }
    }
}
