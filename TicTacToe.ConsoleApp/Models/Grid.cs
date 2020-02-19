using System.Collections.Generic;

namespace TicTacToe.ConsoleApp.Models
{
    public class Grid
    {
        public int Rows { get; set; }

        public int Columns { get; set; }

        public List<GridCell> Cells { get; set; }
    }
}