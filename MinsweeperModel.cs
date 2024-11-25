namespace Milestone1.Models
{
    public class MinsweeperModel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public CellModel[,] Cells { get; set; }
    }

    public class CellModel
    {
        public bool IsMine { get; set; }
        public bool IsRevealed { get; set; }
        public int NeighboringMines { get; set; }
    }

}

