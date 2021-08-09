using System;

namespace CabInvoiceGenerater
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Cab Invoice Generator\n");

            #region Normal Cab Type

            Console.WriteLine("Normal Cab Type :\n");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            RideRepository rideRepository = new RideRepository();

            Console.WriteLine("Single Ride Fare :");
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare -> {fare}\n");

            Console.WriteLine("Multiple Ride Fare");
            InvoiceSummary Summary = new InvoiceSummary(2, 35.0);
            Console.WriteLine($"No. Of Rides -> { Summary.numberOfRides}\nTotal Fare -> {Summary.totalFare}\nAverage Fare -> {Summary.averageFare}\n");

            Console.WriteLine("Using UserId To fetch the summary of rides :");
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
            rideRepository.AddRide("Pawan", rides);
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rideRepository.getRides("Pawan"));
            Console.WriteLine($"No. Of Rides -> { summary.numberOfRides}\nTotal Fare -> {summary.totalFare}\nAverage Fare -> {summary.averageFare}\n");

            #endregion Normal Cab Type

            #region Premium Cab Type 

            Console.WriteLine("Premium Cab Type:\n");

            InvoiceGenerator invoiceGeneratorObj = new InvoiceGenerator(RideType.PREMIUM);
            RideRepository rideRepositoryObj = new RideRepository();

            Console.WriteLine("Single Ride Fare :");
            double Fare = invoiceGeneratorObj.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare -> {Fare}\n");

            Console.WriteLine("Multiple Ride Fare");
            InvoiceSummary Summary1 = new InvoiceSummary(2, 35.0);
            Console.WriteLine($"No. Of Rides -> { Summary1.numberOfRides}\nTotal Fare -> {Summary1.totalFare}\nAverage Fare -> {Summary1.averageFare}\n");

            Console.WriteLine("Using UserId To fetch the summary of rides :");
            Ride[] rides1 = { new Ride(4.0, 10), new Ride(5.1, 15) };
            rideRepositoryObj.AddRide("Sagar", rides1);
            InvoiceSummary summary1 = invoiceGeneratorObj.CalculateFare(rideRepositoryObj.getRides("Sagar"));
            Console.WriteLine($"No. Of Rides -> { summary1.numberOfRides}\nTotal Fare -> {summary1.totalFare}\nAverage Fare -> {summary1.averageFare}\n");

            #endregion Premium Cab Type
        }
    }
}
