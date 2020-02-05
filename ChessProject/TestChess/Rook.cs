using System;

public class Rook
{
    //first move matters for castling
    Boolean firstMove = true;

    //Constructor:  Starting Position, color, name
    public Pawn(int[] startingPos, Boolean white, string n)
    {
        int[] position;
        int[,] possibleMoves;
        Boolean isWhite;
        string name;

        this.setPosition(startingPos);
        this.setPossibleMoves(makeMoves()); 
        this.setIsWhite(white);
        this.setName(n);

    }

    private int[,] makeMoves() //only used to instantiate possibleMoves
    { int[,] allMoves = new int[,];
        for(int i=0;i < 8; i++)
        {
            allMoves.append(new int[0, i]); //any amount of spaces forward
            allMoves.append(new int[0, -1*i]);//any amount of spaces backward
            allMoves.append(new int[i,0]); //any amount of spaces right
            allMoves.append(new int[-1*i, 0]); //any amount of spaces left
        }
        return allMoves;
    }

    override public void move(int[] newPos)
    {
        if (checkMove(newPos)) { this.setPosition(newPos); this.setFirstMove(false); }
        else { Console.WriteLine("Invalid Move"); }
    }

    //Getters and Setters
    public Boolean getFirstMove() { return firstMove; }
    public void setFirstMove(Boolean move) { this.getFirstMove = move; }

}

}
