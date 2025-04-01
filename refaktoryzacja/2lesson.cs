using System.Text.RegularExpressions;

namespace RefaktoryzacjaZamowien
{
    internal class Program
    {

        class User
        {

            public string FirstName { get; }
            public string LastName { get; }
            public string Email { get; }
            public int Age { get; }

            public string? PhoneNumber { get; }
            internal User(string firstName, string lastName, string email, int age)
            {
                if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                {
                    throw new ArgumentException("Imie i nazwisko nie mogą byćpuste");
                }

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    throw new ArgumentException("niepoprawny adres e-mail");
                }

                if(age <= 0)
                {
                    throw new ArgumentException("wiek musi być większy niż 0");
                }

                if (!string.IsNullOrEmpty(PhoneNumber) && !Regex.IsMatch(PhoneNumber, @"^\+?\d{9,15}$"))
                {
                    throw new ArgumentException("Niepoprawny numer telefonu.");
                }
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                Age = age;
            }

            public override string ToString()
            {
                return $"Utworzono użytkownika: {FirstName} {LastName}, {Email}, wiek:{Age}";
            }
        }

        static void Main(string[] args)
        {
            try
            {
                User user = new User("Janusz", "Nowak", "janusz.nowak@gmail.com", 20);
                Console.WriteLine(user);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }
}
