namespace Bridge
{
    public abstract class SkiMuneris
    {
        public string Firma { get; set; }

        public int Id { get; set; }

        public int ShooSize { get; set; }

        public Direction Direction{get;set;}

        public abstract int GetBoardPrice();
        public abstract int GetBoardSetupPrice();
    }

    public enum Direction
    {
        Left,
        Right
    }
}
