using System;

namespace GamePieces
{
    public class Knight : GamePiece
    {
        public Knight(int[] startingPos, Boolean white, string n)
        {

            setPosition(startingPos);
            setPossibleMoves(new int[][] { new int[] { -2, -1 }, new int[] { -2, 1 }, new int[] { -1, -2 }, new int[] { -1, 2 }, new int[] { 1, -2 }, new int[] { 1, 2 }, new int[] { 2, -1 }, new int[] { 2, 1 } });
            setWhite(white);
            setName(n);
            if (white) { setImage(global::TestChess.Properties.Resources.WhiteKnight); }
            else { setImage(global::TestChess.Properties.Resources.BlackKnight); }

        }

    }
}