using System;
using System.Threading;
using System.IO;
// Name of program- Cinema Booking system
// programmer-Sufyaan Shaikh 
// version 2.0
// Date Created- 15/12/2019

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Menu();
            }
        }

        static void Menu()
        {

            BookingFilms Film = new BookingFilms(); 
            Console.WriteLine();
            Console.WriteLine("Cinema Booking System");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine();
            Console.WriteLine("[1] START");
            Console.WriteLine("[2] HELP");
            int user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                // FILM CHOICES
                Film.Films();
            }
            else if (user == 2)
            {
                // HELP
                Console.WriteLine();
                Console.WriteLine("Not Implemented");
                Help();
                Thread.Sleep(2000);
            }
            else
            {
                // BACK TO OPTIONS
                Console.WriteLine();
                Console.WriteLine("Incorrect Option");
                Thread.Sleep(2000);
            }

        }

        static void Help()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Films: You will have 3 films to choose from. To confirm your choice use the following numbers which are displayed on the screen.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Type of Seats: You will have two choices of seating. before the do this, you are required to confirm the type of seat and then the number of seats.  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Ticket: To confirm the booking use the following numbers which are displayed on your screen.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("Please choose the following option:");
            Console.WriteLine();
            Console.WriteLine("[1] BACK");
            int user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                // BACK TO MENU
                Thread.Sleep(1000);
            }
            else
            {
                // BACK TO OPTIONS
                Console.WriteLine();
                Thread.Sleep(2000);
                Help();
            }
        }

    }
}
