namespace TouhouGameLauncher
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private static string UIDisp(int MSGID)
        {
            return LanguageControll.Json[LanguageControll.LanguageID]["Ui"][MSGID];
        }

        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DireKouhoBox = new ListBox();
            Title = new Label();
            OpenThisDireButton = new Button();
            ChangeDispNameButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // DireKouhoBox
            // 
            DireKouhoBox.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DireKouhoBox.FormattingEnabled = true;
            DireKouhoBox.ItemHeight = 20;
            DireKouhoBox.Location = new Point(12, 42);
            DireKouhoBox.Name = "DireKouhoBox";
            DireKouhoBox.Size = new Size(460, 104);
            DireKouhoBox.TabIndex = 0;
            DireKouhoBox.MouseDoubleClick += DireKouhoBox_MouseDoubleClick;
            DireKouhoBox.MouseDown += DireKouhoBox_MouseDown;
            // 
            // Title
            // 
            Title.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(460, 28);
            Title.TabIndex = 1;
            Title.Text = "Title";
            // 
            // OpenThisDireButton
            // 
            OpenThisDireButton.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OpenThisDireButton.Location = new Point(12, 164);
            OpenThisDireButton.Name = "OpenThisDireButton";
            OpenThisDireButton.Size = new Size(110, 36);
            OpenThisDireButton.TabIndex = 2;
            OpenThisDireButton.UseVisualStyleBackColor = true;
            OpenThisDireButton.Click += OpenThisDireButton_Click;
            // 
            // ChangeDispNameButton
            // 
            ChangeDispNameButton.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeDispNameButton.Location = new Point(128, 164);
            ChangeDispNameButton.Name = "ChangeDispNameButton";
            ChangeDispNameButton.Size = new Size(156, 36);
            ChangeDispNameButton.TabIndex = 3;
            ChangeDispNameButton.UseVisualStyleBackColor = true;
            ChangeDispNameButton.Click += ChangeDispNameButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("ＭＳ ゴシック", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(362, 164);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(110, 36);
            CancelButton.TabIndex = 4;
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(CancelButton);
            Controls.Add(ChangeDispNameButton);
            Controls.Add(OpenThisDireButton);
            Controls.Add(Title);
            Controls.Add(DireKouhoBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "TouhouGameLauncher";
            Shown += Form2_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ListBox DireKouhoBox;
        private Label Title;
        private Button OpenThisDireButton;
        private Button ChangeDispNameButton;
        private Button CancelButton;
    }
}