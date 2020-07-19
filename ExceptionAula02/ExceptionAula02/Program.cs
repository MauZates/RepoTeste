using System;
using ExceptionAula02.Entities;
using ExceptionAula02.Entities.Exceptions;

namespace ExceptionAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException exp)
            {
                Console.WriteLine("Format Error " + exp.Message);
            }
            catch (DomainException exp)
            {
                Console.WriteLine("Error in reservation: " + exp.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Unexpected error: " + exp.Message);
            }
        }
    }
}
