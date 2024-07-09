using System;
using System.Windows.Forms;

namespace AddressBookApplication
{
    public partial class Form1 : Form
    {
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label phoneLabel;
        private TextBox phoneTextBox;
        private Button saveButton;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            this.Resize += new EventHandler(AddressBookForm_Resize);
            CenterControls();
        }

        private void InitializeUI()
        {
            // Initialize labels
            nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.AutoSize = true;

            emailLabel = new Label();
            emailLabel.Text = "Email:";
            emailLabel.AutoSize = true;

            phoneLabel = new Label();
            phoneLabel.Text = "Phone:";
            phoneLabel.AutoSize = true;

            // Initialize textboxes
            nameTextBox = new TextBox();
            nameTextBox.Size = new System.Drawing.Size(150, 20);

            emailTextBox = new TextBox();
            emailTextBox.Size = new System.Drawing.Size(150, 20);

            phoneTextBox = new TextBox();
            phoneTextBox.Size = new System.Drawing.Size(150, 20);

            // Initialize button
            saveButton = new Button();
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;

            // Add controls to form
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(saveButton);

            // Center controls initially
            CenterControls();
        }

        private void AddressBookForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            nameLabel.Location = new System.Drawing.Point(centerX - nameTextBox.Width / 2 - nameLabel.Width - 5, centerY - 60);
            nameTextBox.Location = new System.Drawing.Point(centerX - nameTextBox.Width / 2, centerY - 60);

            emailLabel.Location = new System.Drawing.Point(centerX - emailTextBox.Width / 2 - emailLabel.Width - 5, centerY - 30);
            emailTextBox.Location = new System.Drawing.Point(centerX - emailTextBox.Width / 2, centerY - 30);

            phoneLabel.Location = new System.Drawing.Point(centerX - phoneTextBox.Width / 2 - phoneLabel.Width - 5, centerY);
            phoneTextBox.Location = new System.Drawing.Point(centerX - phoneTextBox.Width / 2, centerY);

            saveButton.Location = new System.Drawing.Point(centerX - saveButton.Width / 2, centerY + 30);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;

            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Address Book Entry");
        }
    }
}
