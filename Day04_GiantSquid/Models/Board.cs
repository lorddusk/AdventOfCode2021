using System.Collections.Generic;

namespace Day04_GiantSquid.Models
{
    public class Board
    {
        public List<BoardCell> cells;

        public Board(List<BoardCell> cells)
        {
            this.cells = cells;
        }
    }
}