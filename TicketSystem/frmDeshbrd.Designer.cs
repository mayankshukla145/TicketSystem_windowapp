namespace TicketSystem
{
    partial class frmDeshbrd
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
            panelMain = new Panel();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            btnCreate = new Button();
            btnassign = new Button();
            btnview = new Button();
            btnallticket = new Button();
            btnClose = new Button();
            btnOpentickt = new Button();
            groupBox1 = new GroupBox();
            lblTotalTickets = new Label();
            lblOpenTickets = new Label();
            lblClosedTickets = new Label();
            panelMain.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Snow;
            panelMain.BackgroundImage = Properties.Resources._12;
            panelMain.BackgroundImageLayout = ImageLayout.Stretch;
            panelMain.Controls.Add(groupBox3);
            panelMain.Controls.Add(groupBox2);
            panelMain.Controls.Add(groupBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1398, 617);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(36, 362);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1028, 125);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "User Info";
            // 
            // button4
            // 
            button4.Location = new Point(595, 49);
            button4.Name = "button4";
            button4.Size = new Size(194, 50);
            button4.TabIndex = 2;
            button4.Text = "Delete User";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(288, 49);
            button3.Name = "button3";
            button3.Size = new Size(194, 50);
            button3.TabIndex = 1;
            button3.Text = "Update Role";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(50, 49);
            button2.Name = "button2";
            button2.Size = new Size(137, 50);
            button2.TabIndex = 0;
            button2.Text = "Add User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnCreate);
            groupBox2.Controls.Add(btnassign);
            groupBox2.Controls.Add(btnview);
            groupBox2.Controls.Add(btnallticket);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnOpentickt);
            groupBox2.Location = new Point(36, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 306);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tickets";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(69, 99);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 49);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Ticket";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnassign
            // 
            btnassign.Location = new Point(242, 99);
            btnassign.Name = "btnassign";
            btnassign.Size = new Size(128, 49);
            btnassign.TabIndex = 1;
            btnassign.Text = "Assign Ticket";
            btnassign.UseVisualStyleBackColor = true;
            btnassign.Click += btnassign_Click;
            // 
            // btnview
            // 
            btnview.Location = new Point(416, 99);
            btnview.Name = "btnview";
            btnview.Size = new Size(128, 49);
            btnview.TabIndex = 2;
            btnview.Text = "View Ticket";
            btnview.UseVisualStyleBackColor = true;
            btnview.Click += btnview_Click;
            // 
            // btnallticket
            // 
            btnallticket.Location = new Point(416, 200);
            btnallticket.Name = "btnallticket";
            btnallticket.Size = new Size(128, 65);
            btnallticket.TabIndex = 5;
            btnallticket.Text = "View All Ticket";
            btnallticket.UseVisualStyleBackColor = true;
            btnallticket.Click += btnallticket_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(69, 200);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(128, 49);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close Ticket";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpentickt
            // 
            btnOpentickt.Location = new Point(242, 200);
            btnOpentickt.Name = "btnOpentickt";
            btnOpentickt.Size = new Size(128, 49);
            btnOpentickt.TabIndex = 3;
            btnOpentickt.Text = "Open Ticket";
            btnOpentickt.UseVisualStyleBackColor = true;
            btnOpentickt.Click += btnOpentickt_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblTotalTickets);
            groupBox1.Controls.Add(lblOpenTickets);
            groupBox1.Controls.Add(lblClosedTickets);
            groupBox1.Location = new Point(1029, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 320);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ticket Info";
            // 
            // lblTotalTickets
            // 
            lblTotalTickets.AutoSize = true;
            lblTotalTickets.Location = new Point(37, 39);
            lblTotalTickets.Name = "lblTotalTickets";
            lblTotalTickets.Size = new Size(116, 23);
            lblTotalTickets.TabIndex = 6;
            lblTotalTickets.Text = "Total Tickets:";
            // 
            // lblOpenTickets
            // 
            lblOpenTickets.AutoSize = true;
            lblOpenTickets.Location = new Point(37, 104);
            lblOpenTickets.Name = "lblOpenTickets";
            lblOpenTickets.Size = new Size(163, 23);
            lblOpenTickets.TabIndex = 7;
            lblOpenTickets.Text = "Total Open Tickets:";
            // 
            // lblClosedTickets
            // 
            lblClosedTickets.AutoSize = true;
            lblClosedTickets.Location = new Point(37, 191);
            lblClosedTickets.Name = "lblClosedTickets";
            lblClosedTickets.Size = new Size(163, 23);
            lblClosedTickets.TabIndex = 8;
            lblClosedTickets.Text = "Total Close Tickets:";
            // 
            // frmDeshbrd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1398, 617);
            Controls.Add(panelMain);
            IsMdiContainer = true;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDeshbrd";
            Text = "frmDeshbrd";
            WindowState = FormWindowState.Maximized;
            Load += frmDeshbrd_Load;
            panelMain.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button btnallticket;
        private Button btnClose;
        private Button btnOpentickt;
        private Button btnview;
        private Button btnassign;
        private Button btnCreate;
        private Label lblClosedTickets;
        private Label lblOpenTickets;
        private Label lblTotalTickets;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}