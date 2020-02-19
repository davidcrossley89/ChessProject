using System;
using System.Drawing;

namespace GamePieces
{
    public class Knight : GamePiece
    {
        public Knight(int[] startingPos, Boolean white, string n)
        {
            
            this.setPosition(startingPos);
            this.setPossibleMoves(new int[][] { new int[]{ -2, -1 }, new int[] { -2, 1 }, new int[] { -1, -2 }, new int[] { -1, 2 }, new int[] { 1, -2 }, new int[] { 1, 2 }, new int[] { 2, -1 }, new int[] { 2, 1 } });
            this.setWhite(white);
            this.setName(n);
            if (white) { this.setImage(global::TestChess.Properties.Resources.WhiteKnight); }
            else { this.setImage(global::TestChess.Properties.Resources.BlackKnight); }

        }

    }
}