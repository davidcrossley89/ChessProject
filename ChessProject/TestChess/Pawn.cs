using System;

public class Pawn : GamePiece

{
    //pawns can only move 2 spaces on their first turn
    Boolean firstMove = true;

    //Constructor:  Starting Position, color, name
    public Pawn(int [] startingPos, Boolean white, string n)
	{
        int[] position;
        int[,] possibleMoves;
        Boolean isWhite;
        string name;

        this.setPosition(startingPos);
        if (white)
        {//white pawns only move up
            this.setPossibleMoves(new int[,] { { 0, 1 }, { 0, 2 }, { 1, 1 },{-1,1 }); //can move up 1 or two, or 1 diagonal to capture a piece
        }
        else
        {//black pawns can only move down
            this.setPossibleMoves(new int[,] { { 0, -1 }, { 0, -2 }, { 1, -1 }, { -1, -1 } }); //can move down 1 or two, or 1 diagonal to capture a piece
        }
        this.setIsWhite(white);
        this.setName(n);

    }
    public void move(int[] newPos)
    {
        if ((firstMove)&(checkMove(newPos))) 
        { 
            this.setPosition(newPos);
            this.setFirstMove(false);
            possibleMoves.remove(1); //no longer able to move 2 spaces
        }
        else if (checkMove(newPos)) { this.setPosition(newPos); }
        else { Console.WriteLine("Invalid Move"); }
    }

    //Getters and Setters
    public Boolean getFirstMove() { return firstMove; }
    public void setFirstMove(Boolean move) { this.getFirstMove = move; }

}
