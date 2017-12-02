namespace Bridge
{
    public class UsualSnowboardRental : SkiMuneris
    {
        public UsualSnowboardRental()
        {
            Direction = Direction.Left;
        }
        public override int GetBoardPrice()
        {
            var price = 0;
            if (Direction == Direction.Left)
            {
                price += 20;
            }
            return 50;
        }

        public override int GetBoardSetupPrice()
        {
            return 30;
        }
    }
}
