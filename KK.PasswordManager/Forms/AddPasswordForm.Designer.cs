namespace KK.PasswordManager.Forms
{
    partial class AddPasswordForm
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
            NewPasswordPanel = new TableLayoutPanel();
            ActionsPanel = new TableLayoutPanel();
            CreateButton = new Button();
            CancelButton = new Button();
            NameLabel = new Label();
            SiteLabel = new Label();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            NameTextBox = new TextBox();
            SiteTextBox = new TextBox();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            NewPasswordPanel.SuspendLayout();
            ActionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewPasswordPanel
            // 
            NewPasswordPanel.ColumnCount = 3;
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            NewPasswordPanel.Controls.Add(ActionsPanel, 1, 8);
            NewPasswordPanel.Controls.Add(NameLabel, 1, 0);
            NewPasswordPanel.Controls.Add(SiteLabel, 1, 2);
            NewPasswordPanel.Controls.Add(UserNameLabel, 1, 4);
            NewPasswordPanel.Controls.Add(PasswordLabel, 1, 6);
            NewPasswordPanel.Controls.Add(NameTextBox, 1, 1);
            NewPasswordPanel.Controls.Add(SiteTextBox, 1, 3);
            NewPasswordPanel.Controls.Add(UserNameTextBox, 1, 5);
            NewPasswordPanel.Controls.Add(PasswordTextBox, 1, 7);
            NewPasswordPanel.Dock = DockStyle.Fill;
            NewPasswordPanel.Location = new Point(0, 0);
            NewPasswordPanel.Name = "NewPasswordPanel";
            NewPasswordPanel.RowCount = 9;
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            NewPasswordPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            NewPasswordPanel.Size = new Size(344, 391);
            NewPasswordPanel.TabIndex = 0;
            // 
            // ActionsPanel
            // 
            ActionsPanel.ColumnCount = 2;
            ActionsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActionsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ActionsPanel.Controls.Add(CreateButton, 1, 0);
            ActionsPanel.Controls.Add(CancelButton, 0, 0);
            ActionsPanel.Dock = DockStyle.Fill;
            ActionsPanel.Location = new Point(23, 339);
            ActionsPanel.Name = "ActionsPanel";
            ActionsPanel.RowCount = 1;
            ActionsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ActionsPanel.Size = new Size(298, 49);
            ActionsPanel.TabIndex = 0;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(124, 204, 180);
            CreateButton.Dock = DockStyle.Fill;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Exo 2", 15.7499981F, FontStyle.Bold);
            CreateButton.Location = new Point(152, 3);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(143, 43);
            CreateButton.TabIndex = 4;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(124, 204, 180);
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Exo 2", 15.7499981F, FontStyle.Bold);
            CancelButton.Location = new Point(3, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(143, 43);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.FlatStyle = FlatStyle.Flat;
            NameLabel.Font = new Font("Exo 2", 18F, FontStyle.Bold);
            NameLabel.Location = new Point(23, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(298, 42);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            NameLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // SiteLabel
            // 
            SiteLabel.AutoSize = true;
            SiteLabel.Dock = DockStyle.Fill;
            SiteLabel.FlatStyle = FlatStyle.Flat;
            SiteLabel.Font = new Font("Exo 2", 18F, FontStyle.Bold);
            SiteLabel.Location = new Point(23, 84);
            SiteLabel.Name = "SiteLabel";
            SiteLabel.Size = new Size(298, 42);
            SiteLabel.TabIndex = 2;
            SiteLabel.Text = "Site:";
            SiteLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Dock = DockStyle.Fill;
            UserNameLabel.FlatStyle = FlatStyle.Flat;
            UserNameLabel.Font = new Font("Exo 2", 18F, FontStyle.Bold);
            UserNameLabel.Location = new Point(23, 168);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(298, 42);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "UserName:";
            UserNameLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Dock = DockStyle.Fill;
            PasswordLabel.FlatStyle = FlatStyle.Flat;
            PasswordLabel.Font = new Font("Exo 2", 18F, FontStyle.Bold);
            PasswordLabel.Location = new Point(23, 252);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(298, 42);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            PasswordLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            NameTextBox.Location = new Point(23, 45);
            NameTextBox.MaxLength = 255;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(298, 33);
            NameTextBox.TabIndex = 0;
            // 
            // SiteTextBox
            // 
            SiteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SiteTextBox.BorderStyle = BorderStyle.FixedSingle;
            SiteTextBox.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            SiteTextBox.Location = new Point(23, 129);
            SiteTextBox.MaxLength = 255;
            SiteTextBox.Name = "SiteTextBox";
            SiteTextBox.Size = new Size(298, 33);
            SiteTextBox.TabIndex = 1;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTextBox.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            UserNameTextBox.Location = new Point(23, 213);
            UserNameTextBox.MaxLength = 255;
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(298, 33);
            UserNameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordTextBox.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            PasswordTextBox.Location = new Point(23, 297);
            PasswordTextBox.MaxLength = 255;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(298, 33);
            PasswordTextBox.TabIndex = 3;
            // 
            // AddPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 97, 170);
            ClientSize = new Size(344, 391);
            Controls.Add(NewPasswordPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Password";
            Shown += AddPasswordForm_Shown;
            NewPasswordPanel.ResumeLayout(false);
            NewPasswordPanel.PerformLayout();
            ActionsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel NewPasswordPanel;
        private TableLayoutPanel ActionsPanel;
        private Label NameLabel;
        private Label SiteLabel;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private TextBox NameTextBox;
        private Button CreateButton;
        private Button CancelButton;
        private TextBox SiteTextBox;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
    }
}