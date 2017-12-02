namespace Bridge
{
    public class SnowBoardRentService
    {
        private ISnowboardRental _snowboardRental;
        private int _boardsToRentCount;

        public SnowBoardRentService()
        {
            _snowboardRental = new UsualSnowboardRental();
        }

        public ISnowboardRental SnowboardRental
        {
            set => _snowboardRental = value;
        }

        public void AddSnowboardCount(int count)
        {
            _boardsToRentCount += count;
        }

        public int GetTotalPrice()
        {
            var boardPrice = _snowboardRental.GetSnowboardRentPrice();
            var setupPrice = _snowboardRental.GetSnowboardSetupPrice();

            return _boardsToRentCount * (boardPrice + setupPrice);
        }
    }
}
