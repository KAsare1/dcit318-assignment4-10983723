using System;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Button loginButton;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            this.Resize += new EventHandler(LoginForm_Resize);
            CenterControls();
        }

        private void InitializeUI()
        {
            // Initialize labels
            usernameLabel = new Label();
            usernameLabel.Text = "Username:";
            usernameLabel.AutoSize = true;

            passwordLabel = new Label();
            passwordLabel.Text = "Password:";
            passwordLabel.AutoSize = true;

            // Initialize textboxes
            usernameTextBox = new TextBox();
            usernameTextBox.Size = new System.Drawing.Size(150, 20);

            passwordTextBox = new TextBox();
            passwordTextBox.Size = new System.Drawing.Size(150, 20);
            passwordTextBox.PasswordChar = '*';

            // Initialize button
            loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.Click += LoginButton_Click;

            // Add controls to form
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);

            // Center controls initially
            CenterControls();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            usernameLabel.Location = new System.Drawing.Point(centerX - usernameTextBox.Width / 2 - usernameLabel.Width - 5, centerY - 60);
            usernameTextBox.Location = new System.Drawing.Point(centerX - usernameTextBox.Width / 2, centerY - 60);

            passwordLabel.Location = new System.Drawing.Point(centerX - passwordTextBox.Width / 2 - passwordLabel.Width - 5, centerY - 30);
            passwordTextBox.Location = new System.Drawing.Point(centerX - passwordTextBox.Width / 2, centerY - 30);

            loginButton.Location = new System.Drawing.Point(centerX - loginButton.Width / 2, centerY);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Information");
        }
    }
}
