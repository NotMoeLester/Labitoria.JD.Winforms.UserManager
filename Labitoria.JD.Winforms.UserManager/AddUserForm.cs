namespace Labitoria.JD.Winforms.UserManager
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName) 
                || string.IsNullOrWhiteSpace(username)
                    || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Saving Failed","Incorrect Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                User userToSave = new User();
                userToSave.FullName = fullName;
                userToSave.Username = username;
                userToSave.Password = password;

                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);

                if (isSaved) 
                {
                    MessageBox.Show("Boy na-saved!","Successful", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtFullName.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
