using System;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rentService = new SnowBoardRentService { SnowboardRental = new UsualSnowboardRental() };
            var boardsToRent = 12;
            rentService.AddSnowboardCount(boardsToRent);
            var totalPrice = rentService.GetTotalPrice();

            Console.WriteLine($"Total price for {boardsToRent} boards = {totalPrice}");
            Console.WriteLine("Let's bridge to professional rental");

            rentService.SnowboardRental = new ProfessionalSnowboardRental();

            totalPrice = rentService.GetTotalPrice();

            Console.WriteLine($"Total price for {boardsToRent} boards = {totalPrice}");
            Console.ReadLine();
        }
    }
}
