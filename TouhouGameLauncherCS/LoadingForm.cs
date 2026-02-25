using System.Diagnostics;

namespace TouhouGameLauncher
{
    public partial class LoadingForm : Form
    {
        private static string[] MessageList = new string[4];
        private static bool CanClose = false;
        public LoadingForm()
        {
            InitializeComponent();
        }
        private void LoadingForm_Shown_Vpatch(string exe)
        {
            // Vpatchの検査
            if (Directory.GetFiles(Path.GetDirectoryName(exe), "vpatch.exe", SearchOption.TopDirectoryOnly).Length != 0)
            {
                SettingControll.Json["SearchedIsVpatch"].Add("true");
            }
            else
            {
                SettingControll.Json["SearchedIsVpatch"].Add("false");
            }
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("起動中...");
            Console.WriteLine("LanguageC100.jsonを読み込み中...");
            // Languageファイル読み込み
            LanguageControll.LoadJson();
            StatusLabel.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][16];

            // Dataファイル読み込み
            SettingControll.LoadJson();

            // 意味のないメッセージ
            StatusLabel.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][17];
            
            // ゲーム検索
            StatusLabel.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][18];

            if (SettingControll.Json["Searched"].Count == 0)    // まだ検索されていない場合のみ検索を行う
            {
                foreach (var dire in SettingControll.Json["SearchDire"])
                {
                    StatusLabel.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][18] + "\n" + LanguageControll.Json[LanguageControll.LanguageID]["Ui"][24] + dire;
                    Debug.WriteLine(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][24] + dire);
                    string[] foundexe = Directory.GetFiles(dire, "*.exe", SearchOption.AllDirectories); // まずexeを全部探す
                    foreach (var exe in foundexe)
                    {
                        StatusLabel.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][18] + "\n" + LanguageControll.Json[LanguageControll.LanguageID]["Ui"][25] + exe;
                        Debug.WriteLine(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][25] + exe);
                        if (!SettingControll.Json["Searched"].Contains(exe))    // ここで東方ゲームを選別する
                        {
                            Debug.WriteLine($"第二関門突破：{exe}");
                            if (exe.Contains("東方紅魔郷.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("0");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th07.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("1");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th075.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("2");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th08.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("3");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th09.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("4");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th095.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("5");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th10.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("6");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th105.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("7");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th11.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("8");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th12.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("9");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th123.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("10");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th125.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("11");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th128.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("12");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th13.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("13");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th135.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("14");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th14.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("15");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th143.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("16");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th145.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("17");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th15.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("18");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th155.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("19");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th16.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("20");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th165.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("21");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th17.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("22");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th175.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("23");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th18.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("24");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th185.exe"))  // Python版で忘れてたところ
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("25");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th19.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("26");
								LoadingForm_Shown_Vpatch(exe);
                            }
                            if (exe.Contains("th20.exe"))
                            {
                                SettingControll.Json["Searched"].Add(exe);
                                SettingControll.Json["SearchedTouhouIndex"].Add("27");
								LoadingForm_Shown_Vpatch(exe);
                            }
                        }
                    }
                }
            }
            StatusLabel.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][19];

            // GUI起動へ
            CanClose = true;
            this.Close();
            return;
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanClose)  // 普通にユーザーがxを押すことはできない
            {
                Application.Exit();
            }
        }
    }
}
