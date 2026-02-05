namespace TicketSystem
{
    partial class FrmTicketList
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
            dgvTickets = new DataGridView();
            btnRefresh = new Button();
            btnViewDetails = new Button();
            lblUser = new Label();
            btnback = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(19, 37);
            dgvTickets.Margin = new Padding(4, 3, 4, 3);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(703, 178);
            dgvTickets.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(604, 85);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(118, 33);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(334, 85);
            btnViewDetails.Margin = new Padding(4, 3, 4, 3);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(118, 33);
            btnViewDetails.TabIndex = 2;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.LightGreen;
            lblUser.Location = new Point(501, 26);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(260, 50);
            lblUser.TabIndex = 3;
            lblUser.Text = "Logged in as:";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnback
            // 
            btnback.Location = new Point(67, 85);
            btnback.Margin = new Padding(4, 3, 4, 3);
            btnback.Name = "btnback";
            btnback.Size = new Size(118, 33);
            btnback.TabIndex = 5;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnback);
            groupBox1.Controls.Add(btnViewDetails);
            groupBox1.Location = new Point(28, 79);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(753, 167);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ticket Info";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(dgvTickets);
            groupBox2.Location = new Point(28, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 235);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Details";
            // 
            // FrmTicketList
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cr;
            ClientSize = new Size(823, 523);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblUser);
            Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTicketList";
            Text = "FrmTicketList";
            Load += FrmTicketList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTickets;
        private Button btnRefresh;
        private Button btnViewDetails;
        private Label lblUser;
        private Button btnback;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}