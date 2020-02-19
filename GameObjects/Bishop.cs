using System;


namespace GamePieces
{
    public class Bishop : GamePiece
    {
        public Bishop(int[] startingPos, Boolean white, string n)
        {

            setPosition(startingPos);
            setPossibleMoves(makeMoves());
            setWhite(white);
            setName(n);
            if (white) { setImage(global::TestChess.Properties.Resources.WhiteBishop); }
            else { setImage(global::TestChess.Properties.Resources.BlackBishop); }

        }

        private int[][] makeMoves() //only used to instantiate possibleMoves
        {
            int[][] allMoves = new int[32][];
            int j = -1;
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { i, i };
            }//any amount of spaces forward
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { -1 * i, i };//any amount of spaces backward
            }
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { i, -1 * i }; //any amount of spaces right
            }
            for (int i = 0; i < 8; i++)
            {
                j = j + 1;
                allMoves[j] = new int[] { -1 * i, -1 * i }; //any amount of spaces left
            }
            return allMoves;

        }

    }
}