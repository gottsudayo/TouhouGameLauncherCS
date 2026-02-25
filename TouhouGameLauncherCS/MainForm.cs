using System.Diagnostics;

namespace TouhouGameLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // 言語選択を並べる
            int j = 0;
            foreach (string Keys in LanguageControll.Json.Keys)
            {
                ToolStripMenuItem i = new ToolStripMenuItem();
                i.Name = Keys;
                i.Size = new Size(120, 22);
                i.Text = LanguageControll.Json[Keys]["Ui"][9];
                i.Click += languageSelectToolStripMenuItem_Click;
                LTSMIList[j] = i;
                j++;
            }
            languageToolStripMenuItem.DropDownItems.AddRange(LTSMIList);


            // UIメッセージを設定
            Memo.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][1];
            Info.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][2];
            LaunchButton.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][3];
            CustomLaunchButton.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][4];
            ListUpdateButton.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][5];
            fileToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][6];
            settingsToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][7];
            searchDireSeToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][31];
            isDisplayInfoFToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][32];
            exitToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][8];
            helpToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][10];
            aboutToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][11];
            githubToolStripMenuItem.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][12];

            // メモタブと解説タブの切り替え
            if (SettingControll.Json["IsDisplayInfoFirst"][0] == "true")
            {
                MemoAndInfo.SelectedIndex = 1;
                isDisplayInfoFToolStripMenuItem.Checked = true;
            }
            else
            {
                MemoAndInfo.SelectedIndex = 0;
                isDisplayInfoFToolStripMenuItem.Checked = false;
            }

            // ゲームリストを構成
            for (int i = 0; i < SettingControll.Touhou.Count; i++)
            {
                if (SettingControll.Json["SearchedTouhouIndex"].Contains(i.ToString()))
                {
                    SettingControll.DireList[SettingControll.Touhou[i]] = new List<string>();
                    for (j = 0; j < SettingControll.Json["Searched"].Count; j++)
                    {
                        if (int.Parse(SettingControll.Json["SearchedTouhouIndex"][j]) == i)
                        {
                            SettingControll.DireList[SettingControll.Touhou[i]].Add(SettingControll.Json["Searched"][j]);
                            Debug.WriteLine($"インデックス追加： {SettingControll.Touhou[i]} <= {SettingControll.Json["Searched"][j]}");
                        }
                    }
                }
            }

            // ゲームリストを表示
            foreach (var games in SettingControll.DireList.Keys)
            {
                GameList.Items.Add(LanguageControll.Json[LanguageControll.LanguageID]["Game"][SettingControll.Touhou.IndexOf(games)]);
            }

            // ディレクトリ情報を保存
            SettingControll.SaveJson();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (GameList.SelectedIndex != -1)
            {
                Debug.WriteLine($"Selected Index: {GameList.SelectedIndex}");
                Debug.WriteLine($"Selected Game Index: {SettingControll.SelectedGameIndex}");
                SettingControll.SelectedGameIndex = GameList.SelectedIndex;
                if (SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]].Count == 1)
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    if (SettingControll.Json["SearchedIsVpatch"][SettingControll.Json["Searched"].IndexOf(SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][0])] == "true") // Vpatchが入っているか判別
                    {
                        psi.FileName = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][0].Replace(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex], "vpatch.exe");
                        psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                    }
                    else
                    {
                        psi.FileName = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][0];
                        psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                    }
                    try
                    {
                        Process.Start(psi);
                        Application.Exit();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    SettingControll.SelectedGameIndex = GameList.SelectedIndex;
                    SettingControll.IsCustomLaunch = false;
                    Form2 mdf = new Form2();
                    mdf.ShowDialog();
                }
            }
        }

        private void CustomLaunchButton_Click(object sender, EventArgs e)
        {
            if (GameList.SelectedIndex != -1)
            {
                SettingControll.SelectedGameIndex = GameList.SelectedIndex;
                if (SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]].Count == 1)
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][0].Replace(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex], "custom.exe");
                    psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                    try
                    {
                        Process.Start(psi);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][29], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    SettingControll.SelectedGameIndex = GameList.SelectedIndex;
                    SettingControll.IsCustomLaunch = true;
                    Form2 mdf = new Form2();
                    mdf.ShowDialog();
                }
            }
        }

        private void ListUpdateButton_Click(object sender, EventArgs e)
        {
            // データのリセット
            SettingControll.Json["Searched"].Clear();
            SettingControll.Json["SearchedTouhouIndex"].Clear();
            SettingControll.Json["SearchedIsVpatch"].Clear();
            SettingControll.SaveJson();

            // 再起動
            Application.Restart();
        }

        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionBox.Text = LanguageControll.Json[LanguageControll.LanguageID]["Info"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])];
            MemoBox.Text = SettingControll.Json["MyMemo"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/gottsudayo/TouhouGameLauncherCS") { UseShellExecute = true });
        }

        private void MemoBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                SettingControll.Json["MyMemo"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])] = MemoBox.Text;
                SettingControll.SaveJson();
            } catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void searchDireSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDireForm sdf = new SearchDireForm();
            sdf.ShowDialog(this);
        }

        private void isDisplayInfoFToolStripMenuItem_Click(object sender, EventArgs e)  // 
        {
            if (SettingControll.Json["IsDisplayInfoFirst"][0] == "true")
            {
                SettingControll.Json["IsDisplayInfoFirst"][0] = "false";
                isDisplayInfoFToolStripMenuItem.Checked = false;
            }
            else
            {
                SettingControll.Json["IsDisplayInfoFirst"][0] = "true";
                isDisplayInfoFToolStripMenuItem.Checked = true;
            }
            SettingControll.SaveJson();
        }

        private void GameList_MouseDoubleClick(object sender, MouseEventArgs e) // QuickLaunchを使用
        {
            LaunchButton.PerformClick();
        }

        private void GameList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (GameList.SelectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])]))
                    {
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])];
                        psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                        psi.UseShellExecute = true;
                        try
                        {
                            Process.Start(psi);
                        }
                        catch (FileNotFoundException)
                        {
                            MessageBox.Show($"{LanguageControll.Json[LanguageControll.LanguageID]["Ui"][33]}{SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])]}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[GameList.SelectedIndex])] = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][34], "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void languageSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            foreach (var Keys in LanguageControll.Json.Keys)
            {
                if (LanguageControll.Json[Keys]["Ui"].Contains(tsmi.Text))
                {
                    // 言語設定を保存して再起動
                    SettingControll.Json["Language"][0] = Keys;
                    LanguageControll.LanguageID = Keys;
                    SettingControll.SaveJson();

                    Application.Restart();
                    break;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TouhouGameLauncher\n\nVersion: 1.0.0 (26Jan18.2)\n\nCopyright (c) 2026 Grylosc Gottsudayo","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
