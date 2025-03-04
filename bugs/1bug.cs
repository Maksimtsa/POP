using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        class Employee
        {
            //brak enkapsulacji, niepoprawne użycie pól zamiast właściwości (nie mamy kontroli nad ustawianiem wartości)
            //brak zabiezpieczenia przed pustym imieniem
            public string Name;
            public int Age;//blędny typ danych, powinniśmy zastosować: byte(0-255), ushort(0-65535),
            //DateTime(musimy dodać metodę obliczającą wiek w czasie rzeczywistym
            public double Salary;

            public Employee(string name, int age, double salary)
            {
                Name = name;
                Age = age;
                Salary = salary;
            }

            //brak walidacji w metodzie, nie sprawdzamy czy amount jest dodatnie
            public void IncreaseSalary(double amount)
            {
                Salary += amount;
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee("Janusz Kowalski", 20, 5000);
            emp.Age = -5;//możemy  ustawić błędny wiek
            emp.Salary = -1000;//możemy ustawić niegatywną pensję
            Console.WriteLine($"Pracownik: {emp.Name}, wiek: {emp.Age}, pensja: {emp.Salary}");
        }
    }
}
