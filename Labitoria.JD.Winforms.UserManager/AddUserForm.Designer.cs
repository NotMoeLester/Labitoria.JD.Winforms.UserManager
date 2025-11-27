namespace Labitoria.JD.Winforms.UserManager
{
    partial class AddUserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtFullName.Location = new Point(134, 105);
            txtFullName.Margin = new Padding(2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(206, 31);
            txtFullName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtPassword.Location = new Point(134, 225);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(206, 31);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtUsername.Location = new Point(134, 165);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(206, 31);
            txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(20, 106);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 4;
            label1.Text = "Full Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.Location = new Point(20, 169);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.Location = new Point(20, 232);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(364, 41);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 27);
            label4.Name = "label4";
            label4.Size = new Size(263, 41);
            label4.TabIndex = 8;
            label4.Text = "Add User Form";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(364, 339);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Margin = new Padding(2);
            Name = "AddUserForm";
            Text = "Add User";
            Load += AddUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private Label label4;
    }
}
