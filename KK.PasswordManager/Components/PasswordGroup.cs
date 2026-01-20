using KK.PasswordManager.Constants;
using KK.PasswordManager.Models;

namespace KK.PasswordManager.Components
{
    public class PasswordGroup : GroupBox
    {
        private readonly PasswordModel _password;
        private readonly TextBox _userNameTextBox;
        private readonly TextBox _passwordTextBox;

        public PasswordGroup(PasswordModel password)
        {
            _password = password;

            SetStyle(password.Name);

            _userNameTextBox = GetTextBox();
            _passwordTextBox = GetTextBox();

            SetPanels();
        }

        private void SetStyle(string text)
        {
            Font = new Font("Unispace", 11F, FontStyle.Bold);
            ForeColor = Color.White;
            Text = text;
            Width = 400;
            Height = 180;
        }

        private void SetPanels()
        {
            var panel = GetMainPanel();

            panel.Controls.Add(GetLabel(FieldConstants.SITE), 0, 0);
            panel.Controls.Add(GetLabel(FieldConstants.USER_NAME), 0, 1);
            panel.Controls.Add(GetLabel(FieldConstants.PASSWORD), 0, 2);

            panel.Controls.Add(
                GetDataLabel(
                    string.IsNullOrWhiteSpace(_password.Site) ?
                        "None" :
                        _password.Site),
                1,
                0);

            var userNameActionsPanel = GetActionsPanel();
            var userNameChangeViewButton = GetChangeViewButton();
            var userNameCopyToClipboardButton = GetCopyToClipboardButton();

            userNameChangeViewButton.Click += (o, e) => ChangeTextBoxPasswordStyle(_userNameTextBox, _password.UserName, o);
            userNameCopyToClipboardButton.Click += (o, e) => CopyToClipboard(_password.UserName);

            userNameActionsPanel.Controls.Add(_userNameTextBox, 0, 0);
            userNameActionsPanel.Controls.Add(userNameChangeViewButton, 1, 0);
            userNameActionsPanel.Controls.Add(userNameCopyToClipboardButton, 2, 0);

            panel.Controls.Add(userNameActionsPanel, 1, 1);

            var passwordActionsPanel = GetActionsPanel();
            var passwordChangeViewButton = GetChangeViewButton();
            var passwordCopyToClipboardButton = GetCopyToClipboardButton();

            passwordChangeViewButton.Click += (o, e) => ChangeTextBoxPasswordStyle(_passwordTextBox, _password.Password, o);
            passwordCopyToClipboardButton.Click += (o, e) => CopyToClipboard(_password.Password);

            passwordActionsPanel.Controls.Add(_passwordTextBox, 0, 0);
            passwordActionsPanel.Controls.Add(passwordChangeViewButton, 1, 0);
            passwordActionsPanel.Controls.Add(passwordCopyToClipboardButton, 2, 0);

            panel.Controls.Add(passwordActionsPanel, 1, 2);

            Controls.Add(panel);

            Refresh();
        }

        private TableLayoutPanel GetMainPanel() =>
            new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3,
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Absolute, 150F),
                    new ColumnStyle(SizeType.Absolute, 250F)
                },
                RowStyles =
                {
                    new RowStyle(SizeType.Percent, 34F),
                    new RowStyle(SizeType.Percent, 33F),
                    new RowStyle(SizeType.Percent, 33F),
                }
            };

        private TableLayoutPanel GetActionsPanel() =>
            new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                ColumnStyles =
                {
                    new ColumnStyle(SizeType.Percent, 100F),
                    new ColumnStyle(SizeType.Absolute, 50F),
                    new ColumnStyle(SizeType.Absolute, 50F)
                },
                RowStyles =
                {
                    new RowStyle(SizeType.Percent, 100F)
                }
            };

        private Label GetLabel(string text) =>
            GetDefauleLabel(text, 16F, ContentAlignment.MiddleRight);

        private Label GetDataLabel(string text) =>
            GetDefauleLabel(text, 14F, ContentAlignment.MiddleLeft);

        private Label GetDefauleLabel(string text, float fontSize, ContentAlignment contentAlignment) =>
            new Label()
            {
                Font = new Font("Exo 2", fontSize, FontStyle.Bold),
                Text = text,
                ForeColor = Color.Black,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = contentAlignment,
                FlatStyle = FlatStyle.Flat
            };

        private TextBox GetTextBox() =>
            new TextBox()
            {
                Font = new Font("Exo 2", 14F, FontStyle.Bold),
                Text = GetTextBoxPasswordText(),
                Width = 200,
                ReadOnly = true,
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Left,
                WordWrap = false,
                PasswordChar = '*',
                UseSystemPasswordChar = false
            };

        private Button GetChangeViewButton() =>
            GetButton(Properties.Resources.View);

        private Button GetCopyToClipboardButton() =>
            GetButton(Properties.Resources.Copy);

        private Button GetButton(Bitmap image) =>
            new Button()
            {
                Text = string.Empty,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(124, 204, 180),
                FlatStyle = FlatStyle.Flat,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                ImageAlign = ContentAlignment.MiddleCenter,
                BackgroundImageLayout = ImageLayout.Zoom,
                Image = image
            };

        private void ChangeTextBoxPasswordStyle(TextBox textBox, string text, object? sender)
        {
            if (sender is not Button button)
            {
                return;
            }

            if (textBox.PasswordChar == '*')
            {
                textBox.PasswordChar = '\0';
                textBox.Text = text;
                button.Image = Properties.Resources.Hide;
            }
            else
            {
                textBox.PasswordChar = '*';
                textBox.Text = GetTextBoxPasswordText();
                button.Image = Properties.Resources.View;
            }

            textBox.Refresh();
        }

        private void CopyToClipboard(string text) => Clipboard.SetText(text);

        private string GetTextBoxPasswordText() => string.Join('*', new int[6]);
    }
}
