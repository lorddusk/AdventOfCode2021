namespace Day04_GiantSquid.Models
{
    public class BoardCell
    {
        public int number;
        public int x;
        public int y;
        public bool marked;

        public BoardCell(int number, int x, int y, bool marked = false)
        {
            this.number = number;
            this.x = x;
            this.y = y;
            this.marked = marked;
        }
    }
}