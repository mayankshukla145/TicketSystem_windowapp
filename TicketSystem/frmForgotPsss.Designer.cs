namespace TicketSystem
{
    partial class frmForgotPsss
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
            txtforgotusername = new TextBox();
            btnGetPass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(244, 36);
            label1.TabIndex = 0;
            label1.Text = "Enter Username :";
            // 
            // txtforgotusername
            // 
            txtforgotusername.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtforgotusername.Location = new Point(277, 53);
            txtforgotusername.Name = "txtforgotusername";
            txtforgotusername.PlaceholderText = "Username";
            txtforgotusername.Size = new Size(218, 39);
            txtforgotusername.TabIndex = 1;
            // 
            // btnGetPass
            // 
            btnGetPass.Location = new Point(216, 145);
            btnGetPass.Name = "btnGetPass";
            btnGetPass.Size = new Size(255, 56);
            btnGetPass.TabIndex = 2;
            btnGetPass.Text = "Get Password";
            btnGetPass.UseVisualStyleBackColor = true;
            btnGetPass.Click += btnGetPass_Click;
            // 
            // frmForgotPsss
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._12;
            ClientSize = new Size(565, 213);
            Controls.Add(btnGetPass);
            Controls.Add(txtforgotusername);
            Controls.Add(label1);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmForgotPsss";
            Text = "frmForgotPsss";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtforgotusername;
        private Button btnGetPass;
    }
}