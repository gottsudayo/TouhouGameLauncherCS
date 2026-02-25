namespace TouhouGameLauncher
{
    partial class SearchDireForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDireForm));
            DireListBox = new ListBox();
            AddButton = new Button();
            DeleteButton = new Button();
            CancelButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // DireListBox
            // 
            DireListBox.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DireListBox.FormattingEnabled = true;
            DireListBox.ItemHeight = 20;
            DireListBox.Location = new Point(12, 12);
            DireListBox.Name = "DireListBox";
            DireListBox.Size = new Size(342, 224);
            DireListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(12, 246);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 40);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(93, 246);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(87, 40);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(267, 333);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(87, 40);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("ＭＳ ゴシック", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(174, 333);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(87, 40);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SearchDireForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 385);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(DireListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchDireForm";
            Text = "SearchDireSetting";
            Load += SearchDireForm_Load;
            Shown += SearchDireForm_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ListBox DireListBox;
        private Button AddButton;
        private Button DeleteButton;
        private Button CancelButton;
        private Button SaveButton;
    }
}