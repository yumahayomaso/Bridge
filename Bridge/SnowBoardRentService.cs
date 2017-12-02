namespace Bridge
{
    public class SnowBoardRentService
    {
        private SkiMuneris _snowboardRental;
        private int _boardsToRentCount;


        public SnowBoardRentService()
        {
            _snowboardRental = new UsualSnowboardRental();
        }

        public SkiMuneris SnowboardRental
        {
            set => _snowboardRental = value;
        }

        public void AddSnowboardCount(int count)
        {
            _boardsToRentCount += count;
        }

        public int GetTotalPrice()
        {
            var boardPrice = _snowboardRental.GetBoardPrice();
            var setupPrice = _snowboardRental.GetBoardSetupPrice();

            return _boardsToRentCount * (boardPrice + setupPrice);
        }
    }
}
