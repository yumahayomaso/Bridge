namespace Bridge
{
    public class UsualSnowboardRental : ISnowboardRental
    {
        public int GetSnowboardRentPrice()
        {
            return 30;
        }

        public int GetSnowboardSetupPrice()
        {
            return 10;
        }
    }
}
