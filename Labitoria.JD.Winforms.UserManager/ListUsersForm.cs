using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labitoria.JD.Winforms.UserManager
{
    public partial class ListUsersForm : Form
    {
        public ListUsersForm()
        {
            LoadUsersToDataGridView();
            InitializeComponent();
        }

        private void LoadUsersToDataGridView()
        {
           
            UserRepository repository = new UserRepository();
            List<User> users = repository.GetAll();
            dgvViewUsers.DataSource = users;
        }

        private void ListUsersForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to User Manager", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }
    }
}
