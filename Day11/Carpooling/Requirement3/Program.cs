using System;

using System.Collections.Generic;

namespace Requirement3

{

    public class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Menu:");

            Console.WriteLine("1) Valid Car Registration Number");

            Console.WriteLine("2) Convert Car Registration Number");

            Console.WriteLine("3) Valid Driving Liscence");

            Console.WriteLine("Eneter choice : ");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)

            {

                case 1:

                    Console.WriteLine("Enter car registration number :");

                    string carRegNumber = Console.ReadLine();

                    if (IsValidCarRegistrationNumber(carRegNumber))

                        Console.WriteLine(carRegNumber + " " + "is Valid");

                    else

                        Console.WriteLine(carRegNumber + " " + "is Invalid");

                    break;

                case 2:

                    Console.WriteLine("Enter car registration number :");

                    string carRegNumberToConvert = Console.ReadLine();

                    string convertedCarRegNumber = ConvertCarRegistrationNumber(carRegNumberToConvert);

                    Console.WriteLine(convertedCarRegNumber);

                    break;

                case 3:

                    Console.WriteLine("Enter driving liscence issue date (dd-MM-yyyy)");

                    DateTime issueDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

                    if (IsValidDrivingLiscence(issueDate))

                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + " years old liscence - expired");

                    else

                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + " years old liscence - valid");

                    break;

                default:

                    Console.WriteLine("Invalid Choice");

                    break;

            }

        }

        private static bool IsValidDrivingLiscence(DateTime issueDate)

        {

            DateTime currentDate = DateTime.Now;

            DateTime expiryDate = issueDate.AddYears(10);

            return currentDate > expiryDate;

        }

        private static string ConvertCarRegistrationNumber(string carRegNumber)

        {

            return carRegNumber.Replace('@', '-').Replace('*', '-').ToUpper();

        }

        private static bool IsValidCarRegistrationNumber(string carRegNumber)

        {

            string pattern = @"^[A-Z]{2}-\d{2}-[A-Z]{2}-\d{4}$";

            return System.Text.RegularExpressions.Regex.IsMatch(carRegNumber, pattern);

        }

    }

}





















