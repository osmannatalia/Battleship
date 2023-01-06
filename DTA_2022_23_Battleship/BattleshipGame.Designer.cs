namespace DTA_2022_23_Battleship {
    partial class BattleshipGame {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.battleshipBoard1 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.battleshipBoard2 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.battleshipBoard3 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.SuspendLayout();
            // 
            // battleshipBoard1
            // 
            this.battleshipBoard1.Location = new System.Drawing.Point(98, 86);
            this.battleshipBoard1.Name = "battleshipBoard1";
            this.battleshipBoard1.Size = new System.Drawing.Size(314, 279);
            this.battleshipBoard1.TabIndex = 0;
            // 
            // battleshipBoard2
            // 
            this.battleshipBoard2.Location = new System.Drawing.Point(531, 102);
            this.battleshipBoard2.Name = "battleshipBoard2";
            this.battleshipBoard2.Size = new System.Drawing.Size(314, 279);
            this.battleshipBoard2.TabIndex = 1;
            // 
            // battleshipBoard3
            // 
            this.battleshipBoard3.Location = new System.Drawing.Point(71, 57);
            this.battleshipBoard3.Name = "battleshipBoard3";
            this.battleshipBoard3.Size = new System.Drawing.Size(314, 279);
            this.battleshipBoard3.TabIndex = 2;
            // 
            // BattleshipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.battleshipBoard3);
            this.Controls.Add(this.battleshipBoard2);
            this.Controls.Add(this.battleshipBoard1);
            this.Name = "BattleshipGame";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BattleshipBoard battleshipBoard1;
        private BattleshipBoard battleshipBoard2;
        private BattleshipBoard battleshipBoard3;
    }
}