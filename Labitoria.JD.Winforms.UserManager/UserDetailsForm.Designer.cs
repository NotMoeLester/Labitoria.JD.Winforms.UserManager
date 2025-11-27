namespace Labitoria.JD.Winforms.UserManager
{
    partial class UserDetailsForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(430, 57);
            label4.TabIndex = 10;
            label4.Text = "Details";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.Location = new Point(24, 213);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.Location = new Point(24, 150);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 12;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(24, 87);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 11;
            label1.Text = "Full Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.Location = new Point(138, 214);
            label5.Name = "label5";
            label5.Size = new Size(136, 22);
            label5.TabIndex = 16;
            label5.Text = "**************";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F);
            label6.Location = new Point(138, 151);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 15;
            label6.Text = "markLester";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F);
            label7.Location = new Point(138, 88);
            label7.Name = "label7";
            label7.Size = new Size(185, 22);
            label7.TabIndex = 14;
            label7.Text = "Mark Lester Agaser";
            label7.Click += label7_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(430, 41);
            btnSave.TabIndex = 17;
            btnSave.Text = "Close";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // UserDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 322);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "UserDetailsForm";
            Text = "UserDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSave;
    }
}