using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TouhouGameLauncher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void DireKouhoBox_Init()    // ディレクトリ候補（ListBox）の初期化関数
        {
            DireKouhoBox.Items.Clear(); // まず空にする
            foreach (var dire in SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]])  // 対象ゲームのディレクトリリストを表示
            {
                if (SettingControll.DictJson["DisplayName"].ContainsKey(dire))  // 表示名が登録されているかに応じて表示形式を変える
                {
                    DireKouhoBox.Items.Add(SettingControll.DictJson["DisplayName"][dire]);
                }
                else
                {
                    DireKouhoBox.Items.Add(dire);
                }
            }
        }

        private void Form2_Shown(object sender, EventArgs e)    // 初期化作業
        {
            //
            // 複数ディレクトリが見つかった場合のフォーム
            //

            // UIメッセージを設定
            Title.Text = UIDisp(26);
            OpenThisDireButton.Text = UIDisp(3);
            ChangeDispNameButton.Text = UIDisp(27);
            CancelButton.Text = UIDisp(28);

            DireKouhoBox_Init();
        }

        private void OpenThisDireButton_Click(object sender, EventArgs e)   // 起動ボタンが押された場合
        {
            ProcessStartInfo psi = new ProcessStartInfo();  // 起動用設定のクラス宣言
            if (!SettingControll.IsCustomLaunch)    // custom.exeじゃなければ通常起動
            {
                if (SettingControll.Json["SearchedIsVpatch"][SettingControll.Json["Searched"].IndexOf(SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex])] == "true") // Vpatchが入っているか判別
                {
                    psi.FileName = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex].Replace(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex], "vpatch.exe");
                    psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                    psi.UseShellExecute = true;
                }
                else
                {
                    psi.FileName = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex];
                    psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                    psi.UseShellExecute = true;
                }
                Process.Start(psi);
                Application.Exit();
            }
            else   // でなければcustom.exe起動
            {
                psi.FileName = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex].Replace(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex], "custom.exe");
                psi.WorkingDirectory = Path.GetDirectoryName(psi.FileName);
                psi.UseShellExecute = true;
                try
                {
                    Process.Start(psi);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][29], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
            }
        }

        private void ChangeDispNameButton_Click(object sender, EventArgs e) // 名前変更ボタンが押された場合
        {
            if (!File.Exists("dict.json"))  // dict.jsonが存在しない場合は作成する
            {
                SettingControll.InitDictJson();
            }
            string input = Interaction.InputBox(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][30], "TouhouGameLauncher");    // VisualBasicの力を借りて、入力ボックスを出現させる（同時に取得）
            if (!string.IsNullOrEmpty(input))   // nullまたは空ではない場合は登録
            {
                SettingControll.DictJson["DisplayName"][SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex]] = input;
                SettingControll.SaveDict();
            }
            else   // nullまたは空の場合は削除
            {
                if (SettingControll.DictJson["DisplayName"].ContainsKey(SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex]))
                {
                    SettingControll.DictJson.Remove(SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex]);
                }
            }

            DireKouhoBox_Init();
        }

        private void CancelButton_Click(object sender, EventArgs e) // キャンセルボタンが押された場合
        {
            this.Close();   // 普通に閉じろやw
        }

        private void DireKouhoBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenThisDireButton.PerformClick();
        }

        private void DireKouhoBox_MouseDown(object sender, MouseEventArgs e)    // QuickLaunchを設定する
        {
            if (e.Button == MouseButtons.Right)
            {
                if (DireKouhoBox.SelectedIndex != -1)
                {
                    if (string.IsNullOrEmpty(SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex])]))
                    {
                        SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex])] = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex];
                        MessageBox.Show($"{LanguageControll.Json[LanguageControll.LanguageID]["Ui"][35]}{SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex]}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex])] == SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex])
                    {
                        SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex])] = "";
                        MessageBox.Show(LanguageControll.Json[LanguageControll.LanguageID]["Ui"][37], "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show($"{LanguageControll.Json[LanguageControll.LanguageID]["Ui"][36]}{SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex])]}", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            SettingControll.Json["QuickLaunch"][SettingControll.Touhou.IndexOf(SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex])] = SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex];
                            MessageBox.Show($"{LanguageControll.Json[LanguageControll.LanguageID]["Ui"][35]}{SettingControll.DireList[SettingControll.DireList.Keys.ToList()[SettingControll.SelectedGameIndex]][DireKouhoBox.SelectedIndex]}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
