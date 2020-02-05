using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChess
{
    abstract class GamePiece
    {
        int[] position;
        int[,] possibleMoves;
        Boolean isWhite;
        string name;

        //given a position, check to see if a) the piece can get there, and b) if the piece is on the board
        public bool checkMove(int[] newPos)
        {
            bool ans = false;
            int[,] allMoves = getPossibleMoves();
            int len = allMoves.Length;

            for (int i = 0; i < len; i++)
            {
                if ((allMoves[i, 0] + getPosition()[0] <= 7) & (allMoves[i, 0] + getPosition()[0] == newPos[0]))
                {
                    if ((allMoves[i, 1] + getPosition()[1] <= 7) & (allMoves[i, 1] + getPosition()[1] == newPos[1]))
                    { ans = true; }
                }
            }
            return ans;
        }
        public void move(int[] newPos)
        {
            if (checkMove(newPos)) { this.setPosition(newPos); }
            else { Console.WriteLine("Invalid Move"); }
        }

    //Getters and Setters
        public void setPosition(int[] pos) { this.position = pos; }
        public int[] getPosition() { return this.position; }

        private void setPossibleMoves(int[,] posMoves) { this.possibleMoves = posMoves; }
        public int[,] getPossibleMoves() {return this.possibleMoves;}
        private void setWhite(Boolean color) { isWhite = color; }
        public Boolean getWhite() { return isWhite; }
        private void setName(string str) { name = str; }
        public string getName() { return name; }

    }
}
