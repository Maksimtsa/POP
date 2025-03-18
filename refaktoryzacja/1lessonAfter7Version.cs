

namespace refaktoryzacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // konwersja dużych instrukcji if na Dictionary

            string name = null;
            if (name == null) name = "Domyślna wartość";

            string[] names =  { "Katarzyna", "Franciszek", "Jan" };
            var users = new Dictionary<int, string>();

            int index = 1;
            foreach(var userName in names)
            {
                users.Add(index++, userName);
            }

            Console.Write("Podaj ID użytkownika (1-3)");
            if (int.TryParse(Console.ReadLine(), out int userId) && users.ContainsKey(userId))
            {
                string userName = users[userId];
                string role = GetUserRole(userId);
                Console.WriteLine($"Użytkownik: {userName}, rola użytkownika: {role}");
            }
            else
            {
                Console.WriteLine("Nieporawny numer roli");
            }
            Console.WriteLine("Podaj typ klienta (Silver, Gold, Platinum): ");
            string customerType = Console.ReadLine();
            int discount = GetDiscount(customerType);
            Console.WriteLine($"Rabat dla klienta {customerType}: {discount}");
        }

        private static int GetDiscount(string? customerType)
        {
            var discounts = new Dictionary<string, int>
            {
                { "Silver", 5 },
                { "Gold", 10 },
                { "Platinum", 15 }
            };
            return discounts.TryGetValue(customerType, out int discount) ? discount : 0;
            //if (customerType == "Silver") return 5;
            //if (customerType == "Gold") return 10;
            //if (customerType == "Platinum") return 15;
            //return 0;
        }

        // nowoczensy sposób switch
        private static string GetUserRole(int userId) => userId switch
        {
            1 => "Administrator",
            2 => "Moderator",
            3 => "Użytkownik",
            _ => "Nieznana rola",
        };
    }
}
