
namespace refaktoryzacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zastosowanie var dla przejrzystości kodu

            List<string> names = new List<string> { "Katarzyna", "Franciszek", "Jan" };
            Dictionary<int, string> users = new Dictionary<int, string>();

            for(int i = 0; i < names.Count; i++)
            {
                users.Add(i + 1, names[i]);
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
