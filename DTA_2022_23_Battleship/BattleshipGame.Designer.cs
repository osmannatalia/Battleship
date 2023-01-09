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
            this.battleshipBoardPlayer1 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.battleshipBoardPlayer2 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battleshipBoardPlayer1
            // 
            this.battleshipBoardPlayer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.battleshipBoardPlayer1.Location = new System.Drawing.Point(60, 83);
            this.battleshipBoardPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.battleshipBoardPlayer1.Name = "battleshipBoardPlayer1";
            this.battleshipBoardPlayer1.Size = new System.Drawing.Size(314, 279);
            this.battleshipBoardPlayer1.TabIndex = 4;
            // 
            // battleshipBoardPlayer2
            // 
            this.battleshipBoardPlayer2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.battleshipBoardPlayer2.Location = new System.Drawing.Point(460, 83);
            this.battleshipBoardPlayer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.battleshipBoardPlayer2.Name = "battleshipBoardPlayer2";
            this.battleshipBoardPlayer2.Size = new System.Drawing.Size(314, 279);
            this.battleshipBoardPlayer2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "BattleShip ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(346, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BattleshipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.battleshipBoardPlayer1);
            this.Controls.Add(this.battleshipBoardPlayer2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BattleshipGame";
            this.Text = "BattleShip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BattleshipBoard battleshipBoardPlayer1;
        private BattleshipBoard battleshipBoardPlayer2;
        private Label label1;
        private Button button1;
    }
}