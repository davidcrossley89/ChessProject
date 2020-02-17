using System;
using System.Drawing;

namespace GamePieces
{
    public class King : GamePiece
{
    //first move matters for castling
    Boolean firstMove = true;

    //Constructor:  Starting Position, color, name
    public King(int[] startingPos, Boolean white, string n)
    {
        this.setPosition(startingPos);
        this.setPossibleMoves(makeMoves(firstMove));
        this.setWhite(white);
        this.setName(n);
        if (white) { this.setImage(global::TestChess.Properties.Resources.WhiteKing); }
        else { this.setImage(global::TestChess.Properties.Resources.BlackKing); }
        }

    private int[][] makeMoves(Boolean firstMove) //only used to instantiate possibleMoves
    {
            if (firstMove)
            {
                int[][] allMoves = new int[][]  {
                    new int[] { 0, 1 },
                    new int[] { 0, -1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 } ,
                    new int[] { -1, 1 } ,
                    new int[] { 1, 1 },
                    new int[] { 1, -1 },
                    new int[] { -1, -1 },
                    new int[] { 2, 0 }, //move to king's side knight
                    new int[] { -3, 0 } };//move to queen's side knight
                return allMoves;
            }
            else
            {
                int[][] allMoves = new int[][]  {
                    new int[] { 0, 1 },
                    new int[] { 0, -1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 } ,
                    new int[] { -1, 1 } ,
                    new int[] { 1, 1 },
                    new int[] { 1, -1 },
                    new int[] { -1, -1 },
                };
                return allMoves;
            }
       }

    override public void move(int[] newPos)
    {
        if (checkMove(newPos)) { 
            this.setPosition(newPos);
            if (getFirstMove())
            {
                this.setFirstMove(false);
                this.setPossibleMoves(makeMoves(firstMove));
                }
        }
        else { Console.WriteLine("Invalid Move"); }
    }

    //Getters and Setters
    public Boolean getFirstMove() { return firstMove; }
    public void setFirstMove(Boolean move) { this.firstMove = move; }

    }
}
