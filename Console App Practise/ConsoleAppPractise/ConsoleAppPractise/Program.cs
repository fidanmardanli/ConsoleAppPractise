using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;

namespace ConsoleAppPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();

            Helper.WriteConsole(ConsoleColor.Yellow, "Select one ooption:");
            Helper.WriteConsole(ConsoleColor.Cyan, "1- Create a library, 2- Get a library by id, 3- Update the library, 4- Delete the library ");


            while (true) ;
            {
                SelectOption: string SelectOption = Console.ReadLine();

                int selectTrueOption;

                bool isSelectedOption = int.TryParse(SelectOption, out selectTrueOption);

                if (isSelectedOption)
                {
                    switch (selectTrueOption)
                    {
                        case 1:
                            Helper.WriteConsole(ConsoleColor.Blue, "Add a library name:");
                            string libraryName = Console.ReadLine();

                            Helper.WriteConsole(ConsoleColor.Blue, "Add a library seat count:");

                            SeatCount:  string librarySeatCount = Console.ReadLine();

                            int seatCount;

                            bool isSeatCount = int.TryParse(librarySeatCount, out seatCount);
                            if (isSeatCount)
                            {
                                Library library = new Library
                                {
                                    Name = libraryName,
                                    SeatCount = seatCount

                                };

                                var result = libraryService.Create(library);
                                Helper.WriteConsole(ConsoleColor.Green, $"Library ID: {result.Id}, Name: {result.Name}, Seat Count: {result.SeatCount}");
                            }
                            else
                            {
                                Helper.WriteConsole(ConsoleColor.Red, "Add the correct seat count:");
                                goto SeatCount;
                            }
                            break;
                            case 2:
                            Console.WriteLine(selectTrueOption);
                       
                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select the correct option number");
                            break;
                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select the correct option");
                    goto SelectOption;
                }
            }
        }
    }
}