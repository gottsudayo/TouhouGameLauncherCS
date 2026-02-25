using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TouhouGameLauncher
{
    internal class SettingControll
    {
        public static Dictionary<string,List<string>> Json = new Dictionary<string,List<string>>();
        public static Dictionary<string, Dictionary<string, string>> DictJson = new Dictionary<string, Dictionary<string, string>>();
        private static string RawJson = "";
        public static bool SetupCanClose = true;
        public static Dictionary<string, List<string>> DireList = new Dictionary<string, List<string>>();
        public static int SelectedGameIndex = -1;
        public static bool IsCustomLaunch = false;
        public static List<string> Touhou = new List<string> { 
            "東方紅魔郷.exe",
            "th07.exe",
            "th075.exe",
            "th08.exe",
            "th09.exe",
            "th095.exe",
            "th10.exe",
            "th105.exe",
            "th11.exe",
            "th12.exe",
            "th123.exe",
            "th125.exe",
            "th128.exe",
            "th13.exe",
            "th135.exe",
            "th14.exe",
            "th143.exe",
            "th145.exe",
            "th15.exe",
            "th155.exe",
            "th16.exe",
            "th165.exe",
            "th17.exe",
            "th175.exe",
            "th18.exe",
            "th185.exe",
            "th19.exe",
            "th20.exe"
        };
        public static void LoadJson()
        {
            try
            {
                RawJson = File.ReadAllText("data.json");
            }
            catch (System.IO.FileNotFoundException)
            {
                InitJson();
            }
            if (SetupCanClose)
            {
                Json = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(RawJson);
                try
                {
                    DictJson = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(File.ReadAllText("dict.json"));
                }
                catch (System.IO.FileNotFoundException) 
                {
                    InitDictJson();
                }
            }
            LanguageControll.LanguageID = Json["Language"][0];
        }
        public static void SaveJson()
        {
            RawJson = JsonSerializer.Serialize<Dictionary<string, List<string>>>(Json);
            Debug.WriteLine(RawJson);
            File.WriteAllText("data.json", RawJson);
        }
        public static void InitJson()
        {
            Json["Searched"] = new List<string>();
            Json["SearchedTouhouIndex"] = new List<string>();
            Json["SearchedIsVpatch"] = new List<string>();
            Json["SearchDire"] = new List<string>();
            Json["Language"] = new List<string> { "Japanese" };
            Json["MyMemo"] = new List<string>();
            Json["QuickLaunch"] = new List<string>();
            Json["IsDisplayInfoFirst"] = new List<string> { "false" };
            for (int i = 0; i < 28; i++)
            {
                Json["MyMemo"].Add("");
                Json["QuickLaunch"].Add("");
            }
            SetupForm setup = new SetupForm();
            setup.ShowDialog();
        }
        public static void SaveDict()
        {
            RawJson = JsonSerializer.Serialize<Dictionary<string, Dictionary<string, string>>>(DictJson);
            File.WriteAllText("dict.json", RawJson);
        }
        public static void InitDictJson()
        {
            DictJson["DisplayName"] = new Dictionary<string, string>();
            SaveDict();
        }
    }
}
