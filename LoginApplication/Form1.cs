using System;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Form1 : Form
    {
        private TextBox usernameTextBox;
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
            // Initialize controls
            usernameTextBox = new TextBox();
            usernameTextBox.Size = new System.Drawing.Size(150, 20);

            passwordTextBox = new TextBox();
            passwordTextBox.Size = new System.Drawing.Size(150, 20);
            passwordTextBox.PasswordChar = '*';

            loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.Click += LoginButton_Click;

            // Add controls to form
            Controls.Add(usernameTextBox);
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

            usernameTextBox.Location = new System.Drawing.Point(centerX - usernameTextBox.Width / 2, centerY - 60);
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
