using System;
using System.Collections.Generic;

namespace GamePieces
{
	public class Board
	{
		public Dictionary<string, GamePiece> pieces;
		string[][] displayBoard;

		public Board()
		{
			pieces = new Dictionary<string, GamePiece> { };
			pieces.Add("a1", new Rook(this.coordConvertToArray("a1"), true, "wr1"));
			pieces.Add("b1", new Knight(this.coordConvertToArray("b1"), true, "wk1"));
			pieces.Add("c1", new Bishop(this.coordConvertToArray("c1"), true, "wb1"));
			pieces.Add("d1", new Queen(this.coordConvertToArray("d1"), true, "wQ1"));
			pieces.Add("e1", new King(this.coordConvertToArray("e1"), true, "wK"));
			pieces.Add("f1", new Bishop(this.coordConvertToArray("f1"), true, "wb2"));
			pieces.Add("g1", new Knight(this.coordConvertToArray("g1"), true, "wk2"));
			pieces.Add("h1", new Rook(this.coordConvertToArray("h1"), true, "wr2"));
			pieces.Add("a2", new Pawn(this.coordConvertToArray("a2"), true, "wp1"));
			pieces.Add("b2", new Pawn(this.coordConvertToArray("b2"), true, "wp2"));
			pieces.Add("c2", new Pawn(this.coordConvertToArray("c2"), true, "wp3"));
			pieces.Add("d2", new Pawn(this.coordConvertToArray("d2"), true, "wp4"));
			pieces.Add("e2", new Pawn(this.coordConvertToArray("e2"), true, "wp5"));
			pieces.Add("f2", new Pawn(this.coordConvertToArray("f2"), true, "wp6"));
			pieces.Add("g2", new Pawn(this.coordConvertToArray("g2"), true, "wp7"));
			pieces.Add("h2", new Pawn(this.coordConvertToArray("h2"), true, "wp8"));
			pieces.Add("a3", new Empty(this.coordConvertToArray("a3")));
			pieces.Add("b3", new Empty(this.coordConvertToArray("b3")));
			pieces.Add("c3", new Empty(this.coordConvertToArray("c3")));
			pieces.Add("d3", new Empty(this.coordConvertToArray("d3")));
			pieces.Add("e3", new Empty(this.coordConvertToArray("e3")));
			pieces.Add("f3", new Empty(this.coordConvertToArray("f3")));
			pieces.Add("g3", new Empty(this.coordConvertToArray("g3")));
			pieces.Add("h3", new Empty(this.coordConvertToArray("h3")));
			pieces.Add("a4", new Empty(this.coordConvertToArray("a4")));
			pieces.Add("b4", new Empty(this.coordConvertToArray("b4")));
			pieces.Add("c4", new Empty(this.coordConvertToArray("c4")));
			pieces.Add("d4", new Empty(this.coordConvertToArray("d4")));
			pieces.Add("e4", new Empty(this.coordConvertToArray("e4")));
			pieces.Add("f4", new Empty(this.coordConvertToArray("f4")));
			pieces.Add("g4", new Empty(this.coordConvertToArray("g4")));
			pieces.Add("h4", new Empty(this.coordConvertToArray("h4")));
			pieces.Add("a5", new Empty(this.coordConvertToArray("a5")));
			pieces.Add("b5", new Empty(this.coordConvertToArray("b5")));
			pieces.Add("c5", new Empty(this.coordConvertToArray("c5")));
			pieces.Add("d5", new Empty(this.coordConvertToArray("d5")));
			pieces.Add("e5", new Empty(this.coordConvertToArray("e5")));
			pieces.Add("f5", new Empty(this.coordConvertToArray("f5")));
			pieces.Add("g5", new Empty(this.coordConvertToArray("g5")));
			pieces.Add("h5", new Empty(this.coordConvertToArray("h5")));
			pieces.Add("a6", new Empty(this.coordConvertToArray("a6")));
			pieces.Add("b6", new Empty(this.coordConvertToArray("b6")));
			pieces.Add("c6", new Empty(this.coordConvertToArray("c6")));
			pieces.Add("d6", new Empty(this.coordConvertToArray("d6")));
			pieces.Add("e6", new Empty(this.coordConvertToArray("e6")));
			pieces.Add("f6", new Empty(this.coordConvertToArray("f6")));
			pieces.Add("g6", new Empty(this.coordConvertToArray("g6")));
			pieces.Add("h6", new Empty(this.coordConvertToArray("h6")));
			pieces.Add("a7", new Pawn(this.coordConvertToArray("a7"), false, "bp1"));
			pieces.Add("b7", new Pawn(this.coordConvertToArray("b7"), false, "bp2"));
			pieces.Add("c7", new Pawn(this.coordConvertToArray("c7"), false, "bp3"));
			pieces.Add("d7", new Pawn(this.coordConvertToArray("d7"), false, "bp4"));
			pieces.Add("e7", new Pawn(this.coordConvertToArray("e7"), false, "bp5"));
			pieces.Add("f7", new Pawn(this.coordConvertToArray("f7"), false, "bp6"));
			pieces.Add("g7", new Pawn(this.coordConvertToArray("g7"), false, "bp7"));
			pieces.Add("h7", new Pawn(this.coordConvertToArray("h7"), false, "bp8"));
			pieces.Add("a8", new Rook(this.coordConvertToArray("a8"), false, "br1"));
			pieces.Add("b8", new Knight(this.coordConvertToArray("b8"), false, "bk1"));
			pieces.Add("c8", new Bishop(this.coordConvertToArray("c8"), false, "bb1"));
			pieces.Add("d8", new Queen(this.coordConvertToArray("d8"), false, "bQ1"));
			pieces.Add("e8", new King(this.coordConvertToArray("e8"), false, "bK"));
			pieces.Add("f8", new Bishop(this.coordConvertToArray("f8"), false, "bb2"));
			pieces.Add("g8", new Knight(this.coordConvertToArray("g8"), false, "bk2"));
			pieces.Add("h8", new Rook(this.coordConvertToArray("h8"), false, "br2"));
			displayBoard = new string[8][];
			for (int i = 0; i < 8; i++) { displayBoard[i] = new string[8]; }
			populateBoard();
			printBoard();
		}
		public int[] coordConvertToArray(string sCoord)
		{
			char x = sCoord[0];
			char y = sCoord[1];
			int newX = 0;
			int newY = 0;
			switch (x)
			{
				case 'a': newX = 0;
					break;
				case 'b': newX = 1;
					break;
				case 'c': newX = 2;
					break;
				case 'd': newX = 3;
					break;
				case 'e': newX = 4;
					break;
				case 'f': newX = 5;
					break;
				case 'g': newX = 6;
					break;
				case 'h': newX = 7;
					break;
			}
			switch (y)
			{
				case '1':
					newY = 0;
					break;
				case '2':
					newY = 1;
					break;
				case '3':
					newY = 2;
					break;
				case '4':
					newY = 3;
					break;
				case '5':
					newY = 4;
					break;
				case '6':
					newY = 5;
					break;
				case '7':
					newY = 6;
					break;
				case '8':
					newY = 7;
					break;
			}
			return new int[] { newX, newY };
		}
		public string coordConvertToAlg(int[] iCoord)
		{
			int x = iCoord[0];
			int y = iCoord[1];
			char newX = '_';
			char newY = '_';
			switch (x)
			{
				case 0:
					newX = 'a';
					break;
				case 1:
					newX = 'b';
					break;
				case 2:
					newX = 'c';
					break;
				case 3:
					newX = 'd';
					break;
				case 4:
					newX = 'e';
					break;
				case 5:
					newX = 'f';
					break;
				case 6:
					newX = 'g';
					break;
				case 7:
					newX = 'h';
					break;
			}
			newY = Convert.ToChar(Convert.ToString(y + 1));
			string ans = $"{newX}{newY}";
			return ans;
		}

		public void populateBoard()
		{
			int x = 0;
			int y = 0;
			
			foreach (GamePiece piece in pieces.Values)
			{
				x = piece.getPosition()[0];
				y = piece.getPosition()[1];
				displayBoard[x][y] = piece.getName();
			}
		}
		public void printBoard()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j=0; j<8; j++)
				{
					Console.Write(" {0} ", displayBoard[j][i]);
				}
				Console.WriteLine("");
			}
		}
	}
}