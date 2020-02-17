using System;

using System.Drawing;


namespace GamePieces
{
    public class Empty : GamePiece
    {
        public Empty(int[] startPos)
        {
            setPosition(startPos);
            int[][] possibleMoves = null;
            Boolean isWhite = true;
            string name = "X";
            Image image = null;
        }
    }
}
