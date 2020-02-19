using System;

namespace GamePieces
{
    public class Pawn : GamePiece

    {
        //pawns can only move 2 spaces on their first turn
        Boolean firstMove = true;

        //Constructor:  Starting Position, color, name
        public Pawn(int[] startingPos, Boolean white, string n)
        {

            setPosition(startingPos);
            if (white)
            {//white pawns only move up
                setPossibleMoves(new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 1 }, new int[] { -1, 1 } });//can move up 1 or two, or 1 diagonal to capture a piece
                setImage(global::TestChess.Properties.Resources.WhitePawn);
            }
            else
            {//black pawns can only move down
                setPossibleMoves(new int[][] { new int[] { 0, -1 }, new int[] { 0, -2 }, new int[] { 1, -1 }, new int[] { -1, -1 } });//can move down 1 or two, or 1 diagonal to capture a piece
                setImage(global::TestChess.Properties.Resources.BlackPawn);
            }
            setWhite(white);
            setName(n);
            Console.WriteLine("Pawn {0} Created", getName());


        }
        public override void move(int[] newPos)
        {
            if ((firstMove) & (checkMove(newPos)))
            {
                setPosition(newPos);
                setFirstMove(false);
                if (getWhite())
                {//white pawns only move up
                    setPossibleMoves(new int[][] { new int[] { 0, 1 }, new int[] { 1, 1 }, new int[] { -1, 1 } }); //can move up 1 or two, or 1 diagonal to capture a piece
                }
                else
                {//black pawns can only move down
                    setPossibleMoves(new int[][] { new int[] { 0, -1 }, new int[] { 1, -1 }, new int[] { -1, -1 } }); //can move down 1 or two, or 1 diagonal to capture a piece
                }
            }
            else if (checkMove(newPos)) { setPosition(newPos); }
            else { Console.WriteLine("Invalid Move"); }
        }

        //Getters and Setters
        public Boolean getFirstMove() { return firstMove; }
        public void setFirstMove(Boolean move) { firstMove = move; }
    }
}
