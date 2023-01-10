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
            this.battleshipBoard5 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.battleshipBoard6 = new DTA_2022_23_Battleship.BattleshipBoard();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // battleshipBoard5
            // 
            this.battleshipBoard5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.battleshipBoard5.Location = new System.Drawing.Point(86, 139);
            this.battleshipBoard5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.battleshipBoard5.Name = "battleshipBoard5";
            this.battleshipBoard5.Size = new System.Drawing.Size(449, 465);
            this.battleshipBoard5.TabIndex = 4;
            this.battleshipBoard5.Load += new System.EventHandler(this.battleshipBoard5_Load);
            // 
            // battleshipBoard6
            // 
            this.battleshipBoard6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.battleshipBoard6.Location = new System.Drawing.Point(657, 139);
            this.battleshipBoard6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.battleshipBoard6.Name = "battleshipBoard6";
            this.battleshipBoard6.Size = new System.Drawing.Size(449, 465);
            this.battleshipBoard6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(510, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "BattleShip ";
            
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(495, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BattleshipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.battleshipBoard5);
            this.Controls.Add(this.battleshipBoard6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BattleshipGame";
            this.Text = "BattleShip";
//            this.Load += new System.EventHandler(this.BattleshipGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BattleshipBoard battleshipBoard5;
        private BattleshipBoard battleshipBoard6;
        private Label label1;
        private Button button1;
    }
}