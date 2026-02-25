using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouhouGameLauncher
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void SetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SettingControll.SetupCanClose)
            {
                Application.Exit();
            } else
            {
                this.Close();
            }
        }

        private void LanguageSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            if (LanguageSelectBox.SelectedIndex == -1) NextButton.Enabled = false;
        }

        private void SetupForm_Shown(object sender, EventArgs e)
        {
            foreach (var lang in LanguageControll.Json.Keys)
            {
                LanguageSelectBox.Items.Add(LanguageControll.Json[lang]["Ui"][9]);
            }
            SettingControll.SetupCanClose = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Page++;
            if (Page == 1)
            {
                // 言語設定保存
                SettingControll.Json["Language"][0] = LanguageControll.Json.Keys.ElementAt(LanguageSelectBox.SelectedIndex);
                LanguageControll.LanguageID = SettingControll.Json["Language"][0];

                // Backボタン有効化
                BackButton.Enabled = true;

                // Nextボタン無効化
                NextButton.Enabled = false;

                // テキスト更新
                DireSettingTopTitle.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][20];
                NewFileButton.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][21];
                LoadPythonJsonButton.Text = LanguageControll.Json[LanguageControll.LanguageID]["Ui"][22];

                // ページ表示・非表示切り替え
                LanguageWindow.Visible = false;
                DirectorySettingTop.Visible = true;

                // Nextボタンテキスト変更
                NextButton.Text = "Finish";
            }
            if (Page == 2)
            {
                SettingControll.SetupCanClose = true;
                Application.Restart();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (Page > 0)
            {
                Page--;
                if (Page == 0)
                {
                    // Backボタン無効化
                    BackButton.Enabled = false;

                    // Nextボタン有効化
                    NextButton.Enabled = true;

                    // ページ表示・非表示切り替え
                    LanguageWindow.Visible = true;
                    DirectorySettingTop.Visible = false;

                    // Nextボタンテキスト変更
                    NextButton.Text = "Next";
                }
            }
        }

        private void DirectorySettingTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            SearchDireForm sdf = new SearchDireForm();
            sdf.ShowDialog(this);
            if (File.Exists("data.json"))
            {
                NextButton.Enabled = true;
            }
        }

        private void LanguageSelectBox_DropDownClosed(object sender, EventArgs e)
        {
            if (LanguageSelectBox.SelectedIndex != -1)
            {
                NextButton.Enabled = true;
            }
            else
            {
                NextButton.Enabled = false;
            }
        }

        private void LoadPythonJsonButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Python Data.json File|data.json";
            ofd.Title = "Select data.json created by Python Edition";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofd.FileName, "data.json", true);
                SettingControll.LoadJson();
                NextButton.Enabled = true;
            }
        }
    }
}
