namespace TicketSystem
{
    partial class frmAdduser
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
            label1 = new Label();
            label2 = new Label();
            cmbRole = new ComboBox();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            label1.Location = new Point(136, 93);
            label1.Name = "label1";
            label1.Size = new Size(156, 36);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            label2.Location = new Point(161, 275);
            label2.Name = "label2";
            label2.Size = new Size(90, 36);
            label2.TabIndex = 1;
            label2.Text = "Role :";
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "User" });
            cmbRole.Location = new Point(314, 286);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(222, 43);
            cmbRole.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(314, 93);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(214, 39);
            txtUsername.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 465);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New User";
            // 
            // button2
            // 
            button2.Location = new Point(136, 367);
            button2.Name = "button2";
            button2.Size = new Size(247, 70);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(414, 367);
            button1.Name = "button1";
            button1.Size = new Size(247, 70);
            button1.TabIndex = 6;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(314, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '0';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(214, 39);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            label3.Location = new Point(126, 197);
            label3.Name = "label3";
            label3.Size = new Size(145, 36);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // frmAdduser
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 504);
            Controls.Add(groupBox1);
            Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdduser";
            Text = "frmAdduser";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbRole;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox txtPassword;
        private Label label3;
    }
}