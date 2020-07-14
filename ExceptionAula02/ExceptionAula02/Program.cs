using System;
using ExceptionAula02.Entities;

namespace ExceptionAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in: ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            
            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date mmust be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: "+ reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in: ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                
                string erro = reservation.UpdateDates(checkIn, checkOut);
                if (erro != null)
                {
                    Console.WriteLine("Error in reservation: " + reservation);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
