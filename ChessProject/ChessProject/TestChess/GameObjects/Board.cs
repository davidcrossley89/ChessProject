using System;

namespace GamePieces
{
	public class Board
	{
		GamePiece[] whitePieces;
		GamePiece[] blackPieces;
		string[][] displayBoard;

		public Board()
		{
			whitePieces = new GamePiece[] {
				new Pawn(new int[]{ 0, 1 }, true, "wp1"),
				new Pawn(new int[]{ 1, 1 }, true, "wp2"),
				new Pawn(new int[]{ 2, 1 }, true, "wp3"),
				new Pawn(new int[]{ 3, 1 }, true, "wp4"),
				new Pawn(new int[]{ 4, 1 }, true, "wp5"),
				new Pawn(new int[]{ 5, 1 }, true, "wp6"),
				new Pawn(new int[]{ 6, 1 }, true, "wp7"),
				new Pawn(new int[]{ 7, 1 }, true, "wp8"),
				new Rook(new int[]{ 0, 0 }, true, "wr1"),
				new Knight(new int[]{ 1, 0 }, true, "wk1"),
				new Bishop(new int[]{ 2, 0 }, true, "wb1"),
				new Queen(new int[]{ 3, 0 }, true, "wQ"),
				new King(new int[]{ 4, 0 }, true, "wK"),
				new Bishop(new int[]{ 5, 0 }, true, "wb2"),
				new Knight(new int[]{ 6, 0 }, true, "wk2"),
				new Rook(new int[]{ 7, 0 }, true, "wr2")
			};
			blackPieces = new GamePiece[] {
				new Pawn(new int[]{ 0, 6 }, false, "bp1"),
				new Pawn(new int[]{ 1, 6 }, false, "bp2"),
				new Pawn(new int[]{ 2, 6 },false, "bp3"),
				new Pawn(new int[]{ 3, 6 }, false, "bp4"),
				new Pawn(new int[]{ 4, 6 }, false, "bp5"),
				new Pawn(new int[]{ 5, 6 },false, "bp6"),
				new Pawn(new int[]{ 6, 6 }, false, "bp7"),
				new Pawn(new int[]{ 7, 6 }, false, "bp8"),
				new Rook(new int[]{ 0, 7 },false, "br1"),
				new Knight(new int[]{ 1, 7 },false, "bk1"),
				new Bishop(new int[]{ 2, 7 }, false, "bb1"),
				new Queen(new int[]{ 3, 7 }, false, "bQ"),
				new King(new int[]{ 4, 7 }, false, "bK"),
				new Bishop(new int[]{ 5, 7 },false, "bb2"),
				new Knight(new int[]{ 6, 7 }, false, "bk2"),
				new Rook(new int[]{ 7, 7 }, false, "br2")
			};
			displayBoard = new string[8][];
			for (int i = 0; i < 8; i++) { displayBoard[i] = new string[8]; }
			populateBoard();
			printBoard();
		}
		public void populateBoard()
		{
			int x = 0;
			int y = 0;
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++) { displayBoard[i][j] = "X"; }
			}
			foreach (GamePiece piece in whitePieces)
			{
				x = piece.getPosition()[0];
				y = piece.getPosition()[1];
				displayBoard[x][y] = piece.getName();
			}
			foreach (GamePiece piece in blackPieces)
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
					Console.Write(" {0} ", displayBoard[i][j]);
				}
				Console.WriteLine("");
			}
		}
	}
}