using System;

namespace GamePieces
{
    public class Rook : GamePiece
    {
        //first move matters for castling
        Boolean firstMove = true;

        //Constructor:  Starting Position, color, name
        public Rook(int[] startingPos, Boolean white, string n)
        {
            setPosition(startingPos);
            setPossibleMoves(makeMoves());
            setWhite(white);
            setName(n);
            if (white) { setImage(global::TestChess.Properties.Resources.WhiteRook); }
            else { setImage(global::TestChess.Properties.Resources.BlackRook); }
        }

        private int[][] makeMoves() //only used to instantiate possibleMoves
        {
            int[][] allMoves = new int[32][];
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
            if (checkMove(newPos)) { setPosition(newPos); setFirstMove(false); }
            else { Console.WriteLine("Invalid Move"); }
        }

        //Getters and Setters
        public Boolean getFirstMove() { return firstMove; }
        public void setFirstMove(Boolean move) { firstMove = move; }

    }
}

