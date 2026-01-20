namespace KK.PasswordManager
{
    partial class MainForm
    {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainPanel = new TableLayoutPanel();
            HeaderPanel = new TableLayoutPanel();
            SearchPanel = new TableLayoutPanel();
            SearchLabel = new Label();
            SearchTextBox = new TextBox();
            NamePanel = new TableLayoutPanel();
            NameLabel = new Label();
            AddPasswordButton = new Button();
            PasswordsPanel = new FlowLayoutPanel();
            MainPanel.SuspendLayout();
            HeaderPanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainPanel.Controls.Add(HeaderPanel, 0, 0);
            MainPanel.Controls.Add(PasswordsPanel, 0, 1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainPanel.Size = new Size(1004, 611);
            MainPanel.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            HeaderPanel.ColumnCount = 2;
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HeaderPanel.Controls.Add(SearchPanel, 1, 0);
            HeaderPanel.Controls.Add(NamePanel, 0, 0);
            HeaderPanel.Dock = DockStyle.Fill;
            HeaderPanel.Location = new Point(3, 3);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RowCount = 1;
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            HeaderPanel.Size = new Size(998, 64);
            HeaderPanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            SearchPanel.ColumnCount = 2;
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SearchPanel.Controls.Add(SearchLabel, 0, 0);
            SearchPanel.Controls.Add(SearchTextBox, 1, 0);
            SearchPanel.Dock = DockStyle.Fill;
            SearchPanel.Location = new Point(502, 3);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.RowCount = 1;
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SearchPanel.Size = new Size(493, 58);
            SearchPanel.TabIndex = 1;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Dock = DockStyle.Fill;
            SearchLabel.FlatStyle = FlatStyle.Flat;
            SearchLabel.Font = new Font("Exo 2 ExtraBold", 20F, FontStyle.Bold);
            SearchLabel.Location = new Point(3, 0);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(240, 58);
            SearchLabel.TabIndex = 0;
            SearchLabel.Text = "Search:";
            SearchLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Left;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Exo 2", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SearchTextBox.Location = new Point(249, 11);
            SearchTextBox.MaxLength = 255;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(236, 36);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.WordWrap = false;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // NamePanel
            // 
            NamePanel.ColumnCount = 2;
            NamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NamePanel.Controls.Add(NameLabel, 0, 0);
            NamePanel.Controls.Add(AddPasswordButton, 1, 0);
            NamePanel.Dock = DockStyle.Fill;
            NamePanel.Location = new Point(3, 3);
            NamePanel.Name = "NamePanel";
            NamePanel.RowCount = 1;
            NamePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NamePanel.Size = new Size(493, 58);
            NamePanel.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.FlatStyle = FlatStyle.Flat;
            NameLabel.Font = new Font("Exo 2 ExtraBold", 20F, FontStyle.Bold);
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(240, 58);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddPasswordButton
            // 
            AddPasswordButton.BackColor = Color.FromArgb(124, 204, 180);
            AddPasswordButton.Dock = DockStyle.Fill;
            AddPasswordButton.FlatStyle = FlatStyle.Flat;
            AddPasswordButton.Font = new Font("Exo 2", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddPasswordButton.Location = new Point(249, 3);
            AddPasswordButton.Name = "AddPasswordButton";
            AddPasswordButton.Size = new Size(241, 52);
            AddPasswordButton.TabIndex = 1;
            AddPasswordButton.Text = "New Password";
            AddPasswordButton.UseVisualStyleBackColor = false;
            AddPasswordButton.Click += AddPasswordButton_Click;
            // 
            // PasswordsPanel
            // 
            PasswordsPanel.AutoScroll = true;
            PasswordsPanel.Dock = DockStyle.Fill;
            PasswordsPanel.Location = new Point(3, 73);
            PasswordsPanel.Name = "PasswordsPanel";
            PasswordsPanel.Size = new Size(998, 535);
            PasswordsPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 97, 170);
            ClientSize = new Size(1004, 611);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KK.PasswordManager";
            MainPanel.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainPanel;
        private TableLayoutPanel HeaderPanel;
        private Label NameLabel;
        private TableLayoutPanel SearchPanel;
        private Label SearchLabel;
        private TextBox SearchTextBox;
        private TableLayoutPanel NamePanel;
        private Button AddPasswordButton;
        private FlowLayoutPanel PasswordsPanel;
    }
}
