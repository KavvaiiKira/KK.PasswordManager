namespace KK.PasswordManager.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            RegistrationPanel = new TableLayoutPanel();
            NameTextBox = new TextBox();
            PINTextBox = new TextBox();
            NameLabel = new Label();
            SubmitButton = new Button();
            label1 = new Label();
            RegistrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationPanel
            // 
            RegistrationPanel.ColumnCount = 3;
            RegistrationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RegistrationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RegistrationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            RegistrationPanel.Controls.Add(NameTextBox, 1, 1);
            RegistrationPanel.Controls.Add(PINTextBox, 1, 3);
            RegistrationPanel.Controls.Add(NameLabel, 1, 0);
            RegistrationPanel.Controls.Add(SubmitButton, 1, 4);
            RegistrationPanel.Controls.Add(label1, 1, 2);
            RegistrationPanel.Dock = DockStyle.Fill;
            RegistrationPanel.Location = new Point(0, 0);
            RegistrationPanel.Name = "RegistrationPanel";
            RegistrationPanel.RowCount = 5;
            RegistrationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            RegistrationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            RegistrationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            RegistrationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            RegistrationPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            RegistrationPanel.Size = new Size(344, 211);
            RegistrationPanel.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Font = new Font("Exo 2", 14F, FontStyle.Bold);
            NameTextBox.Location = new Point(23, 43);
            NameTextBox.MaxLength = 255;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(298, 30);
            NameTextBox.TabIndex = 0;
            NameTextBox.KeyDown += NameTextBox_KeyDown;
            // 
            // PINTextBox
            // 
            PINTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PINTextBox.BorderStyle = BorderStyle.FixedSingle;
            PINTextBox.Font = new Font("Exo 2", 14F, FontStyle.Bold);
            PINTextBox.Location = new Point(23, 123);
            PINTextBox.MaxLength = 255;
            PINTextBox.Name = "PINTextBox";
            PINTextBox.PasswordChar = '*';
            PINTextBox.Size = new Size(298, 30);
            PINTextBox.TabIndex = 1;
            PINTextBox.KeyDown += PINTextBox_KeyDown;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NameLabel.AutoSize = true;
            NameLabel.FlatStyle = FlatStyle.Flat;
            NameLabel.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            NameLabel.Location = new Point(23, 8);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(80, 32);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubmitButton.BackColor = Color.FromArgb(124, 204, 180);
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            SubmitButton.Location = new Point(23, 163);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(298, 45);
            SubmitButton.TabIndex = 2;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Exo 2", 16F, FontStyle.Bold);
            label1.Location = new Point(23, 88);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 3;
            label1.Text = "PIN:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 97, 170);
            ClientSize = new Size(344, 211);
            Controls.Add(RegistrationPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Shown += RegisterForm_Shown;
            RegistrationPanel.ResumeLayout(false);
            RegistrationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel RegistrationPanel;
        private TextBox NameTextBox;
        private TextBox PINTextBox;
        private Label NameLabel;
        private Label label1;
        private Button SubmitButton;
    }
}