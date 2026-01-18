using System.Diagnostics;
using System.Text.Json;

namespace TouhouGameLauncher
{
    internal static class LanguageControll
    {
        public static Dictionary<string, Dictionary<string, List<string>>> Json = new Dictionary<string, Dictionary<string, List<string>>>();
        public static string LanguageID = "Japanese";

        public static void LoadJson()
        {
            try
            {
                string StrJson = File.ReadAllText("LanguageC100.json");
                Json = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, List<string>>>>(StrJson);
                Debug.WriteLine($"Jsonの中身（Language）：{ Json}");
            } catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("LanguageC100.json was not found.\nIt's not language.json with Python Edition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }
    }
}
