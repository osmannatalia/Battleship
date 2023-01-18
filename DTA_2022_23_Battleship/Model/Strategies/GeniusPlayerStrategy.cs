﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA_2022_23_Battleship.Model.Strategies {
    public class GeniusPlayerStrategy : PlayerStrategyBase {
        private ShootingStateSquare[,] internalBoard;
#if TESTING
        private Random random = new Random(10);
#else
        private Random random = new Random();
#endif
        public GeniusPlayerStrategy(Board board) : base(board) {
            this.internalBoard = new ShootingStateSquare[board.Size, board.Size];

            for (var r = 0; r < board.Size; r++)
            {
                for (var c = 0; c < board.Size; c++)
                {
                    this.internalBoard[r, c] = new ShootingStateSquare();
                }
            }

            board.AfterShot += Board_AfterShot;
        }
        private void Board_AfterShot(object? sender, AfterShotEventArgs e)
        {
            var shootingStateSquare = this.internalBoard[e.Coordinate.Y, e.Coordinate.X];
            shootingStateSquare.IsShot = true;
            if (e.ShotResponse == ShotResponse.IsHit)
            {
                shootingStateSquare.HasShipSquare = true;

                this.RemoveCoordinateForShooting(e.Coordinate.X - 1, e.Coordinate.Y - 1);
                this.RemoveCoordinateForShooting(e.Coordinate.X + 1, e.Coordinate.Y - 1);
                this.RemoveCoordinateForShooting(e.Coordinate.X - 1, e.Coordinate.Y + 1);
                this.RemoveCoordinateForShooting(e.Coordinate.X + 1, e.Coordinate.Y + 1);

                var ship = this.board.GetShipFromCoordinate(e.Coordinate);

                if (ship != null && ship.IsSunk)
                {
                    this.RemoveCoordinateForShooting(e.Coordinate.X - 1, e.Coordinate.Y);
                    this.RemoveCoordinateForShooting(e.Coordinate.X + 1, e.Coordinate.Y);
                    this.RemoveCoordinateForShooting(e.Coordinate.X, e.Coordinate.Y - 1);
                    this.RemoveCoordinateForShooting(e.Coordinate.X, e.Coordinate.Y + 1);
                    foreach (var coordinate in this.nextShootingCoordinates)
                    {
                        this.RemoveCoordinateForShooting(coordinate.X, coordinate.Y);
                    }
                    this.nextShootingCoordinates.Clear();
                }
                else
                {
                    this.AddCoordinateForNextShot(e.Coordinate.X - 1, e.Coordinate.Y);
                    this.AddCoordinateForNextShot(e.Coordinate.X + 1, e.Coordinate.Y);
                    this.AddCoordinateForNextShot(e.Coordinate.X, e.Coordinate.Y - 1);
                    this.AddCoordinateForNextShot(e.Coordinate.X, e.Coordinate.Y + 1);

                    foreach (var coordinate in this.nextShootingCoordinates.ToList())
                    {
                        if (!this.internalBoard[coordinate.Y, coordinate.X].CanShot)
                        {
                            this.nextShootingCoordinates.Remove(coordinate);
                        }
                    }
                }
            }
            else
            {
                this.nextShootingCoordinates.Remove(e.Coordinate);
            }
        }

        private void RemoveCoordinateForShooting(int x, int y)
        {
            if (x < 0 || x >= this.board.Size) { return; }
            if (y < 0 || y >= this.board.Size) { return; }
            this.internalBoard[y, x].RemoveForShooting = true;
        }

        private void AddCoordinateForNextShot(int x, int y)
        {
            if (x < 0 || x >= this.board.Size) { return; }
            if (y < 0 || y >= this.board.Size) { return; }

            var coord = new Coordinate(x, y);
            if (this.internalBoard[coord.Y, coord.X].CanShot)
            {
                this.nextShootingCoordinates.Add(coord);
            }
        }

        private List<Coordinate> nextShootingCoordinates = new List<Coordinate>();


        public async override void Shot() {
            // Player is thinking ...
            await Task.Delay(TimeSpan.FromSeconds(1.5));

            if (this.nextShootingCoordinates.Any())
            {
                var nextIndex = this.random.Next(0, this.nextShootingCoordinates.Count - 1);
                this.board.Shot(this.nextShootingCoordinates[nextIndex]);
            }
            else
            {
                var coordinate = this.GetRandomCoordinate();
                this.board.Shot(coordinate);
            }
        }
        private Coordinate GetRandomCoordinate()
        {
            var cnt = 0;
            var optCnt = 0;
            var shortest = board.ShortestShipLength;
            for (var r = 0; r < board.Size; r++)
            {
                for (var c = 0; c < board.Size; c++)
                {
                    if (this.internalBoard[r, c].CanShot)
                    {
                        cnt++;
                    }
                    if (this.internalBoard[r, c].Optimal)
                    {
                        bool opt = true;
                        for (int i = r - shortest + 1; i < r + shortest; i++)
                        {
                            if (i > board.Size - 1 || i < 0)
                            {
                                opt = false; 
                                break;
                            } else
                            {
                                if (!this.internalBoard[i, c].CanShot)
                                {
                                    opt = false;
                                    break;
                                }
                                else
                                {
                                    for (int j = c - shortest + 1; j < c + shortest; j++)
                                    {
                                        if (j > board.Size - 1 || j < 0)
                                        {
                                            opt = false;
                                            break;
                                        }
                                        else
                                        {
                                            if (!this.internalBoard[r, j].CanShot)
                                            {
                                                opt = false;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            
                        }
                        if (opt)
                        {
                            optCnt++;
                        }
                        else
                        {
                            this.internalBoard[r, c].Optimal = false;
                            Debug.WriteLine("Suboptimal");
                            Debug.WriteLine(r);
                            Debug.WriteLine(c);
                        }
                    }
                    
                }
            }
            if (optCnt > 0)
            {
                var nextSquare = this.random.Next(1, optCnt);
                optCnt= 0;
                for (var r = 0; r < board.Size; r++)
                {
                    for (var c = 0; c < board.Size; c++)
                    {
                        if (this.internalBoard[r,c].Optimal)
                        {
                            optCnt++;
                        }
                        if (optCnt == nextSquare)
                        {
                            return new Coordinate(c, r);
                        }
                    }
                }
                return new Coordinate(0, 0);
            } else
            {
                var nextSquare = this.random.Next(1, cnt);
                cnt = 0;
                for (var r = 0; r < board.Size; r++)
                {
                    for (var c = 0; c < board.Size; c++)
                    {
                        if (this.internalBoard[r, c].CanShot)
                        {
                            cnt++;
                        }
                        if (cnt == nextSquare)
                        {

                            return new Coordinate(c, r);
                        }
                    }
                }
                return new Coordinate(0, 0);
            }
            
        }

        private class ShootingStateSquare
        {
            public bool IsShot { get; set; }
            public bool HasShipSquare { get; set; }
            public bool RemoveForShooting { get; set; }

            public bool CanShot
            {
                get
                {
                    return !this.IsShot && !this.HasShipSquare && !this.RemoveForShooting;
                }
            }
            public bool Optimal { get; set; } = true;
        }
    }
}
