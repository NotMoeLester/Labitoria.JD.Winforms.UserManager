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
                User userToSave = new User(fullName,username,password);
                UserRepository repository = new UserRepository();
                bool isSaved = repository.Add(userToSave);

                if (isSaved) 
                {
                    MessageBox.Show("Boy na-saved!","Successful",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
