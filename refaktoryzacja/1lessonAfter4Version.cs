
namespace refaktoryzacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zmiana pętli na foreach

            string[] names =  { "Katarzyna", "Franciszek", "Jan" };
            var users = new Dictionary<int, string>();

            int index = 1;
            foreach(var name in names)
            {
                users.Add(index++, name);
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
