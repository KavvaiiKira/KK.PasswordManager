namespace KK.PasswordManager.Forms
{
    partial class PINEnterForm
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
            PINPanel = new TableLayoutPanel();
            PINTextBox = new TextBox();
            label1 = new Label();
            PINPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PINPanel
            // 
            PINPanel.ColumnCount = 3;
            PINPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PINPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PINPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PINPanel.Controls.Add(PINTextBox, 1, 1);
            PINPanel.Controls.Add(label1, 1, 0);
            PINPanel.Dock = DockStyle.Fill;
            PINPanel.Location = new Point(0, 0);
            PINPanel.Name = "PINPanel";
            PINPanel.RowCount = 2;
            PINPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PINPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PINPanel.Size = new Size(254, 101);
            PINPanel.TabIndex = 0;
            // 
            // PINTextBox
            // 
            PINTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PINTextBox.BorderStyle = BorderStyle.FixedSingle;
            PINTextBox.Font = new Font("Exo 2", 14.25F, FontStyle.Bold);
            PINTextBox.Location = new Point(23, 53);
            PINTextBox.MaxLength = 255;
            PINTextBox.Name = "PINTextBox";
            PINTextBox.PasswordChar = '*';
            PINTextBox.Size = new Size(208, 30);
            PINTextBox.TabIndex = 0;
            PINTextBox.KeyDown += PINTextBox_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Exo 2", 14.25F, FontStyle.Bold);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 1;
            label1.Text = "PIN:";
            // 
            // PINEnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 97, 170);
            ClientSize = new Size(254, 101);
            Controls.Add(PINPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PINEnterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PIN";
            Shown += PINEnterForm_Shown;
            PINPanel.ResumeLayout(false);
            PINPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PINPanel;
        private TextBox PINTextBox;
        private Label label1;
    }
}