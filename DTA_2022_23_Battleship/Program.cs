using DTA_2022_23_Battleship.Model;

namespace DTA_2022_23_Battleship {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var playersBoard = new Board(10);
            var computersBoard = new Board(10);
        }
    }
}