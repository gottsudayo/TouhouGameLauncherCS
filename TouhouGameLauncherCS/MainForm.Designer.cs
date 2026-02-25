namespace TouhouGameLauncher
{
    partial class MainForm
    {
        private static string UIDisp(int MSGID)
        {
            return LanguageControll.Json[LanguageControll.LanguageID]["Ui"][MSGID];
        }

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private ToolStripMenuItem[] LTSMIList = new ToolStripMenuItem[LanguageControll.Json.Keys.Count];
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MemoAndInfo = new TabControl();
            Memo = new TabPage();
            MemoBox = new TextBox();
            Info = new TabPage();
            DescriptionBox = new TextBox();
            GameList = new ListBox();
            LaunchButton = new Button();
            CustomLaunchButton = new Button();
            ListUpdateButton = new Button();
            MainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            searchDireSeToolStripMenuItem = new ToolStripMenuItem();
            isDisplayInfoFToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            MemoAndInfo.SuspendLayout();
            Memo.SuspendLayout();
            Info.SuspendLayout();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MemoAndInfo
            // 
            MemoAndInfo.Controls.Add(Memo);
            MemoAndInfo.Controls.Add(Info);
            MemoAndInfo.Location = new Point(437, 27);
            MemoAndInfo.Name = "MemoAndInfo";
            MemoAndInfo.SelectedIndex = 0;
            MemoAndInfo.Size = new Size(335, 422);
            MemoAndInfo.TabIndex = 0;
            // 
            // Memo
            // 
            Memo.Controls.Add(MemoBox);
            Memo.Location = new Point(4, 24);
            Memo.Name = "Memo";
            Memo.Padding = new Padding(3);
            Memo.Size = new Size(327, 394);
            Memo.TabIndex = 0;
            Memo.UseVisualStyleBackColor = true;
            // 
            // MemoBox
            // 
            MemoBox.AcceptsReturn = true;
            MemoBox.Location = new Point(6, 6);
            MemoBox.Multiline = true;
            MemoBox.Name = "MemoBox";
            MemoBox.Size = new Size(315, 397);
            MemoBox.TabIndex = 0;
            MemoBox.TextChanged += MemoBox_TextChanged;
            // 
            // Info
            // 
            Info.Controls.Add(DescriptionBox);
            Info.Location = new Point(4, 24);
            Info.Name = "Info";
            Info.Padding = new Padding(3);
            Info.Size = new Size(327, 394);
            Info.TabIndex = 1;
            Info.UseVisualStyleBackColor = true;
            // 
            // DescriptionBox
            // 
            DescriptionBox.AcceptsReturn = true;
            DescriptionBox.Location = new Point(6, 6);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.ReadOnly = true;
            DescriptionBox.Size = new Size(315, 397);
            DescriptionBox.TabIndex = 0;
            // 
            // GameList
            // 
            GameList.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            GameList.FormattingEnabled = true;
            GameList.ItemHeight = 20;
            GameList.Location = new Point(12, 27);
            GameList.Name = "GameList";
            GameList.Size = new Size(419, 324);
            GameList.TabIndex = 1;
            GameList.SelectedIndexChanged += GameList_SelectedIndexChanged;
            GameList.MouseDoubleClick += GameList_MouseDoubleClick;
            GameList.MouseDown += GameList_MouseDown;
            // 
            // LaunchButton
            // 
            LaunchButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LaunchButton.Location = new Point(12, 382);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(124, 63);
            LaunchButton.TabIndex = 2;
            LaunchButton.UseVisualStyleBackColor = true;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // CustomLaunchButton
            // 
            CustomLaunchButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CustomLaunchButton.Location = new Point(142, 382);
            CustomLaunchButton.Name = "CustomLaunchButton";
            CustomLaunchButton.Size = new Size(150, 63);
            CustomLaunchButton.TabIndex = 3;
            CustomLaunchButton.UseVisualStyleBackColor = true;
            CustomLaunchButton.Click += CustomLaunchButton_Click;
            // 
            // ListUpdateButton
            // 
            ListUpdateButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListUpdateButton.Location = new Point(298, 382);
            ListUpdateButton.Name = "ListUpdateButton";
            ListUpdateButton.Size = new Size(133, 63);
            ListUpdateButton.TabIndex = 4;
            ListUpdateButton.UseVisualStyleBackColor = true;
            ListUpdateButton.Click += ListUpdateButton_Click;
            // 
            // MainMenu
            // 
            MainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, languageToolStripMenuItem, helpToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(784, 24);
            MainMenu.TabIndex = 5;
            MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(12, 20);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchDireSeToolStripMenuItem, isDisplayInfoFToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(67, 22);
            // 
            // searchDireSeToolStripMenuItem
            // 
            searchDireSeToolStripMenuItem.Name = "searchDireSeToolStripMenuItem";
            searchDireSeToolStripMenuItem.Size = new Size(147, 22);
            searchDireSeToolStripMenuItem.Text = "SearchDireSe";
            searchDireSeToolStripMenuItem.Click += searchDireSeToolStripMenuItem_Click;
            // 
            // isDisplayInfoFToolStripMenuItem
            // 
            isDisplayInfoFToolStripMenuItem.Name = "isDisplayInfoFToolStripMenuItem";
            isDisplayInfoFToolStripMenuItem.Size = new Size(147, 22);
            isDisplayInfoFToolStripMenuItem.Text = "IsDisplayInfoF";
            isDisplayInfoFToolStripMenuItem.Click += isDisplayInfoFToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(67, 22);
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(71, 20);
            languageToolStripMenuItem.Text = "Language";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, githubToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(12, 20);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(180, 22);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(ListUpdateButton);
            Controls.Add(CustomLaunchButton);
            Controls.Add(LaunchButton);
            Controls.Add(GameList);
            Controls.Add(MemoAndInfo);
            Controls.Add(MainMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TouhouGameLauncher";
            Shown += MainForm_Shown;
            MemoAndInfo.ResumeLayout(false);
            Memo.ResumeLayout(false);
            Memo.PerformLayout();
            Info.ResumeLayout(false);
            Info.PerformLayout();
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl MemoAndInfo;
        private TabPage Memo;
        private TextBox MemoBox;
        private TabPage Info;
        private TextBox DescriptionBox;
        private ListBox GameList;
        private Button LaunchButton;
        private Button CustomLaunchButton;
        private Button ListUpdateButton;
        private MenuStrip MainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem searchDireSeToolStripMenuItem;
        private ToolStripMenuItem isDisplayInfoFToolStripMenuItem;
    }
}
