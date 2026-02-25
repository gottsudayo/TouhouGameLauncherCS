namespace TouhouGameLauncher
{
    partial class LoadingForm
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
            StatusLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // StatusLabel
            // 
            StatusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatusLabel.Font = new Font("MS Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 128);
            StatusLabel.Location = new Point(12, 9);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(373, 61);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Loading Language Data...";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(393, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 79);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(StatusLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TouhouGameLauncher";
            FormClosing += LoadingForm_FormClosing;
            Shown += LoadingForm_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Label StatusLabel;
        private Button button1;
    }
}