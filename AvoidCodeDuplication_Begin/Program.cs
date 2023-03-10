using System;
using AvoidCodeDuplication_Begin.Logic;

namespace AvoidCodeDuplication_Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationBook registrationBook = new RegistrationBook();

            registrationBook.RegisterPerson("Ana", "Popescu", Gender.Female);
            registrationBook.RegisterPerson("Nadia", "Comanici", Gender.Female);
            registrationBook.RegisterPerson("Marian", "Ionescu", Gender.Male);
            registrationBook.RegisterPerson("Vasile", "Pop", Gender.Male);
            registrationBook.RegisterPerson("Ana", "Andreica", Gender.Female);

            Console.WriteLine($"There are {registrationBook.CountFemales()} registered women.");
            Console.WriteLine($"There are {registrationBook.CountMales()} registered men.");
        }
    }
}
