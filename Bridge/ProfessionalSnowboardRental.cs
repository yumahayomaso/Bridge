namespace Bridge
{
    public class ProfessionalSnowboardRental : ISnowboardRental
    {
        public int GetSnowboardRentPrice()
        {
            return 50;
        }

        public int GetSnowboardSetupPrice()
        {
            return 30;
        }
    }
}
