namespace Refaktoryzacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unikanie NullReferenceException poprzez ?? w bardziej nowoczesny sposób
            string name = null;
            name = name ?? "Domyślna wartość"; // Użycie null-coalescing operatora

            string[] names = { "Katarzyna", "Franciszek", "Jan" };
            var users = new Dictionary<int, string>();

            // Dodanie użytkowników do słownika
            int index = 1;
            foreach (var userName in names)
            {
                users.Add(index++, userName);
            }

            Console.Write("Podaj ID użytkownika (1-3): ");
            if (int.TryParse(Console.ReadLine(), out int userId) && users.ContainsKey(userId))
            {
                string userName = users[userId];
                string role = GetUserRole(userId);
                Console.WriteLine($"Użytkownik: {userName}, rola użytkownika: {role}");
            }
            else
            {
                Console.WriteLine("Niepoprawny numer ID użytkownika. Podaj wartość z zakresu 1-3.");
            }
        }

        // Nowoczesny sposób switch
        private static string GetUserRole(int userId) => userId switch
        {
            1 => "Administrator",
            2 => "Moderator",
            3 => "Użytkownik",
            _ => "Nieznana rola",
        };
    }
}
