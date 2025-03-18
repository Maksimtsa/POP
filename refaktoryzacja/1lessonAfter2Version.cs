
namespace refaktoryzacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zmiana długich instrukcji warunkowych na wyrażenie switch
            Console.Write("Podaj numer roli(1-3)");
            if (int.TryParse(Console.ReadLine(), out int roleId))
            {
                string role = GetUserRole(roleId);
                Console.WriteLine("Rola użytkownika: " + role);
            }
            else
            {
                Console.WriteLine("Nieporawny numer roli");
            }
        }

        // nowoczensy sposób switch
        private static string GetUserRole(int roleId) => roleId switch
        {
            1 => "Administrator",
            2 => "Moderator",
            3 => "Użytkownik",
            _ => "Nieznana rola",
        };
    }
}
