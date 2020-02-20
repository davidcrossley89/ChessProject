using System;
using System.Drawing;

namespace GamePieces
{
    abstract public class GamePiece
    {
        int[] position;
        int[][] possibleMoves;
        Boolean isWhite;
        string name;
        Image image;

        //given a position, check to see if a) the piece can get there, and b) if the piece is on the board
        public virtual bool checkMove(int[] newPos)
        {
            bool ans = false;
            int[][] allMoves = getPossibleMoves();
            int len = allMoves.Length;

            for (int i = 0; i < len; i++)
            {
                if ((allMoves[i][0] + getPosition()[0] <= 7) & (allMoves[i][0] + getPosition()[0] == newPos[0]))
                {
                    if ((allMoves[i][1] + getPosition()[1] <= 7) & (allMoves[i][1] + getPosition()[1] == newPos[1]))
                    { ans = true; }
                }
            }
            return ans;
        }
        public virtual void move(int[] newPos)
        {
            if (checkMove(newPos)) { setPosition(newPos); }
            else { Console.WriteLine("Invalid Move"); }
        }


        //Getters and Setters
        public void setPosition(int[] pos) { position = pos; }
        public int[] getPosition() { return position; }
        protected void setPossibleMoves(int[][] posMoves) { possibleMoves = posMoves; }
        public int[][] getPossibleMoves() { return possibleMoves; }
        protected void setWhite(Boolean color) { isWhite = color; }
        public Boolean getWhite() { return isWhite; }
        protected void setName(string str) { name = str; }
        public string getName() { return name; }
        protected void setImage(Image i) { image = i; }
        public Image getImage() { return image; }

    }
}
