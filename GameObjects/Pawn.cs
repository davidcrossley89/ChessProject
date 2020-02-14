using System;
using System.Drawing;

namespace GamePieces
{
    public class Pawn : GamePiece

    {
        //pawns can only move 2 spaces on their first turn
        Boolean firstMove = true;

        //Constructor:  Starting Position, color, name
        public Pawn(int[] startingPos, Boolean white, string n)
        {

            this.setPosition(startingPos);
            if (white)
            {//white pawns only move up
                this.setPossibleMoves(new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 1 }, new int[] { -1, 1 } });//can move up 1 or two, or 1 diagonal to capture a piece
                this.setImage(global::TestChess.Properties.Resources.WhitePawn);
            }
            else
            {//black pawns can only move down
                this.setPossibleMoves(new int[][] { new int[] { 0, -1 }, new int[] { 0, -2 }, new int[] { 1, -1 }, new int[] { -1, -1 } });//can move down 1 or two, or 1 diagonal to capture a piece
                this.setImage(global::TestChess.Properties.Resources.BlackPawn);
            }
            this.setWhite(white);
            this.setName(n);
            Console.WriteLine("Pawn {0} Created", this.getName());


        }
        public override void move(int[] newPos)
        {
            if ((firstMove) & (checkMove(newPos)))
            {
                this.setPosition(newPos);
                this.setFirstMove(false);
                if (this.getWhite())
                {//white pawns only move up
                    this.setPossibleMoves(new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 }, new int[] { -1, 1 } }); //can move up 1 or two, or 1 diagonal to capture a piece
                }
                else
                {//black pawns can only move down
                    this.setPossibleMoves(new int[][] { new int[] { 0, -1 }, new int[] { 1, -1 }, new int[] { -1, -1 } }); //can move down 1 or two, or 1 diagonal to capture a piece
                }
            }
            else if (checkMove(newPos)) { this.setPosition(newPos); }
            else { Console.WriteLine("Invalid Move"); }
        }

        //Getters and Setters
        public Boolean getFirstMove() { return firstMove; }
        public void setFirstMove(Boolean move) { this.firstMove = move; }
    }
}
