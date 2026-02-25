namespace TouhouGameLauncher
{
    partial class SetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int Page = 0;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            LanguageWindow = new Panel();
            LanguageSelectBox = new ComboBox();
            LWTitle = new Label();
            NextButton = new Button();
            BackButton = new Button();
            DirectorySettingTop = new Panel();
            LoadPythonJsonButton = new Button();
            NewFileButton = new Button();
            DireSettingTopTitle = new Label();
            LanguageWindow.SuspendLayout();
            DirectorySettingTop.SuspendLayout();
            SuspendLayout();
            // 
            // LanguageWindow
            // 
            LanguageWindow.Controls.Add(LanguageSelectBox);
            LanguageWindow.Controls.Add(LWTitle);
            LanguageWindow.Location = new Point(12, 12);
            LanguageWindow.Name = "LanguageWindow";
            LanguageWindow.Size = new Size(436, 390);
            LanguageWindow.TabIndex = 0;
            // 
            // LanguageSelectBox
            // 
            LanguageSelectBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageSelectBox.FormattingEnabled = true;
            LanguageSelectBox.Location = new Point(152, 213);
            LanguageSelectBox.Name = "LanguageSelectBox";
            LanguageSelectBox.Size = new Size(121, 23);
            LanguageSelectBox.TabIndex = 1;
            LanguageSelectBox.SelectedIndexChanged += LanguageSelectBox_SelectedIndexChanged;
            LanguageSelectBox.DropDownClosed += LanguageSelectBox_DropDownClosed;
            // 
            // LWTitle
            // 
            LWTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LWTitle.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LWTitle.ImageAlign = ContentAlignment.MiddleLeft;
            LWTitle.Location = new Point(0, 12);
            LWTitle.Name = "LWTitle";
            LWTitle.Size = new Size(430, 68);
            LWTitle.TabIndex = 0;
            LWTitle.Text = "TouhouGameLauncher\nSetup";
            LWTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            NextButton.Enabled = false;
            NextButton.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.Location = new Point(358, 408);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(90, 30);
            NextButton.TabIndex = 2;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // BackButton
            // 
            BackButton.Enabled = false;
            BackButton.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 408);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(90, 30);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // DirectorySettingTop
            // 
            DirectorySettingTop.Controls.Add(LoadPythonJsonButton);
            DirectorySettingTop.Controls.Add(NewFileButton);
            DirectorySettingTop.Controls.Add(DireSettingTopTitle);
            DirectorySettingTop.Location = new Point(12, 12);
            DirectorySettingTop.Name = "DirectorySettingTop";
            DirectorySettingTop.Size = new Size(436, 390);
            DirectorySettingTop.TabIndex = 2;
            DirectorySettingTop.Visible = false;
            DirectorySettingTop.Paint += DirectorySettingTop_Paint;
            // 
            // LoadPythonJsonButton
            // 
            LoadPythonJsonButton.Enabled = false;
            LoadPythonJsonButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LoadPythonJsonButton.Location = new Point(96, 166);
            LoadPythonJsonButton.Name = "LoadPythonJsonButton";
            LoadPythonJsonButton.Size = new Size(244, 41);
            LoadPythonJsonButton.TabIndex = 2;
            LoadPythonJsonButton.Text = "button1";
            LoadPythonJsonButton.UseVisualStyleBackColor = true;
            LoadPythonJsonButton.Click += LoadPythonJsonButton_Click;
            // 
            // NewFileButton
            // 
            NewFileButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NewFileButton.Location = new Point(96, 119);
            NewFileButton.Name = "NewFileButton";
            NewFileButton.Size = new Size(244, 41);
            NewFileButton.TabIndex = 1;
            NewFileButton.Text = "button1";
            NewFileButton.UseVisualStyleBackColor = true;
            NewFileButton.Click += NewFileButton_Click;
            // 
            // DireSettingTopTitle
            // 
            DireSettingTopTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DireSettingTopTitle.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DireSettingTopTitle.Location = new Point(3, 12);
            DireSettingTopTitle.Name = "DireSettingTopTitle";
            DireSettingTopTitle.Size = new Size(430, 73);
            DireSettingTopTitle.TabIndex = 0;
            DireSettingTopTitle.Text = "label1";
            DireSettingTopTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 450);
            Controls.Add(DirectorySettingTop);
            Controls.Add(BackButton);
            Controls.Add(NextButton);
            Controls.Add(LanguageWindow);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TouhouGameLauncher Setup";
            FormClosing += SetupForm_FormClosing;
            Shown += SetupForm_Shown;
            LanguageWindow.ResumeLayout(false);
            DirectorySettingTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LanguageWindow;   // Page 0
        private Label LWTitle;
        public ComboBox LanguageSelectBox;
        public Button NextButton;
        public Button BackButton;
        public Panel DirectorySettingTop;
        public Label DireSettingTopTitle;
        public Button NewFileButton;
        public Button LoadPythonJsonButton;
    }
}