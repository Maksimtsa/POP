using System;

namespace ConsoleApp8
{
    internal class Program
    {
        public class Employee
        {
            public string Name { get; }
            public DateOnly DateOfBirth { get; }
            public int Age => CalculateAge();

            public Employee(string name, DateOnly dateOfBirth)
            {
                Name = name;
                DateOfBirth = dateOfBirth;
            }

            private int CalculateAge()
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                int age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) --age;
                return age;
            }
        }

        static void Main(string[] args)
        {
            string name = GetValidName();
            DateOnly dateOfBirth = GetValidDateOfBirth();

            Employee emp = new Employee(name, dateOfBirth);
            Console.WriteLine($"Pracownik: {emp.Name}, wiek: {emp.Age}");
        }

        private static DateOnly GetValidDateOfBirth()
        {
            DateOnly dateOfBirth;
            bool isValidDate = false;
            do
            {
                Console.WriteLine("Podaj datę urodzenia (RRRR - MM - DD): ");
                string input = Console.ReadLine();

                if (DateOnly.TryParse(input, out dateOfBirth) && dateOfBirth <= DateOnly.FromDateTime(DateTime.Now))
                {
                    isValidDate = true;
                }
                else
                {
                    Console.Write("Błędny format! Podaj datę ponownie (RRRR-MM-DD): ");
                }
            }
            while (!isValidDate);
            return dateOfBirth;
            //Console.Write("Podaj datę urodzenia (RRRR-MM-DD): ");
            //DateOnly dateOfBirth;

            //while (!DateOnly.TryParse(Console.ReadLine(), out dateOfBirth))
            //{
            //    Console.Write("Błędny format! Podaj datę ponownie (RRRR-MM-DD): ");
            //}
            //return dateOfBirth;
        }

        private static string GetValidName()
        {
            string name;
            while (true)
            {
                Console.WriteLine("Podaj imie: ");
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Imię nie może być puste. Spróbuj ponownie.");
                }
                else
                {    
                    return name;
                }
            }
        }
    }
}
