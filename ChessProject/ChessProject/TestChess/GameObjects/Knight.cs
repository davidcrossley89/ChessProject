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
            if (white) { this.setImage(Image.FromFile("WhiteKnight.jpg")); }
            else { this.setImage(Image.FromFile("BlackKnight.jpg")); }

        }

    }
}