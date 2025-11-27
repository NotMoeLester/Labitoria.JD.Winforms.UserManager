namespace Labitoria.JD.Winforms.UserManager
{
    partial class ListUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUsersForm));
            label4 = new Label();
            btnSave = new Button();
            button1 = new Button();
            dgvViewUsers = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(547, 57);
            label4.TabIndex = 9;
            label4.Text = "List of users";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(547, 41);
            btnSave.TabIndex = 11;
            btnSave.Text = "View";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(0, 57);
            button1.Name = "button1";
            button1.Size = new Size(547, 42);
            button1.TabIndex = 12;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvViewUsers
            // 
            dgvViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewUsers.Location = new Point(12, 124);
            dgvViewUsers.Name = "dgvViewUsers";
            dgvViewUsers.Size = new Size(423, 323);
            dgvViewUsers.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(449, 124);
            button2.Name = "button2";
            button2.Size = new Size(86, 94);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = true;
            // 
            // ListUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 509);
            Controls.Add(button2);
            Controls.Add(dgvViewUsers);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Name = "ListUsersForm";
            Text = "ListUsersForm";
            Load += ListUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Button btnSave;
        private Button button1;
        private DataGridView dgvViewUsers;
        private Button button2;
    }
}