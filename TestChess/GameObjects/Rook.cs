using System;
using System.Drawing;

namespace GamePieces
{
    public class Rook : GamePiece
    {
        //first move matters for castling
        Boolean firstMove = true;

        //Constructor:  Starting Position, color, name
        public Rook(int[] startingPos, Boolean white, string n)
        {
            this.setPosition(startingPos);
            this.setPossibleMoves(makeMoves());
            this.setWhite(white);
            this.setName(n);
            if (white) { this.setImage(global::TestChess.Properties.Resources.WhiteRook); }
            else { this.setImage(global::TestChess.Properties.Resources.BlackRook); }
        }

        private int[][] makeMoves() //only used to instantiate possibleMoves
        { int[][] allMoves = new int[32][];
            int j = -1;
            for (int i = 0; i < 8; i++)
                {
                    j = j + 1;
                    allMoves[j] = new int[] { 0, i };
                }//any amount of spaces forward
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { 0, -1 * i };//any amount of spaces backward
            }
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { i, 0 }; //any amount of spaces right
            }
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { -1 * i, 0 }; //any amount of spaces left
            }
            return allMoves;
        }

        override public void move(int[] newPos)
        {
            if (checkMove(newPos)) { this.setPosition(newPos); this.setFirstMove(false); }
            else { Console.WriteLine("Invalid Move"); }
        }

        //Getters and Setters
        public Boolean getFirstMove() { return firstMove; }
        public void setFirstMove(Boolean move) { this.firstMove = move; }

    }
}

