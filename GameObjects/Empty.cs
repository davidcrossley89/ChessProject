namespace GamePieces
{
    public class Empty : GamePiece
    {
        public Empty(int[] startPos)
        {
            setPosition(startPos);
            setName("X");
        }
        public override bool checkMove(int[] newPos)
        {
            return false;
        }
    }
}
