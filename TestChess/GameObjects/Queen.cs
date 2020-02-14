using System;
using System.Drawing;

namespace GamePieces
{
    public class Queen : GamePiece
    {
        public Queen(int[] startingPos, Boolean white, string n)
        {

            this.setPosition(startingPos);
            this.setPossibleMoves(makeMoves());
            this.setWhite(white);
            this.setName(n);
            if (white) { this.setImage(global::TestChess.Properties.Resources.WhiteQueen); }
            else { this.setImage(global::TestChess.Properties.Resources.BlackQueen); }

        }

        private int[][] makeMoves() //only used to instantiate possibleMoves
        {
            int[][] allMoves = new int[64][];
            for (int j = 0; j <= 32; j = j + 8)
            {
                for (int i = 0; i < 8; i++)
                {
                    allMoves[j] = new int[] { 0, i }; //any amount of spaces forward
                    allMoves[j+1] = new int[] { 0, -1 * i };//any amount of spaces backward
                    allMoves[j+2] = new int[] { i, 0 }; //any amount of spaces right
                    allMoves[j+3] = new int[] { -1 * i, 0 }; //any amount of spaces left
                    allMoves[j+4] = new int[] { -1 * i, i }; //any amount of diagonal left
                    allMoves[j+5] = new int[] { i, i };//any amount of diagonal right
                    allMoves[j+6] = new int[] { i, -1 * i }; //any amount of diagonal back right
                    allMoves[j+7] = new int[] { -1 * i, -1 * i }; //any amount of spaces diagonal back left
                }
            }

            return allMoves;
        }
    }
}
