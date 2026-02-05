namespace TicketSystem
{
    partial class FrmTicketDetails
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
            lblTicketNumber = new Label();
            lblSubject = new Label();
            label3 = new Label();
            lblCreatedDate = new Label();
            lblStatus = new Label();
            lblPriority = new Label();
            txtDescription = new TextBox();
            lblAssignedTo = new Label();
            dgvHistory = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            btnclose = new Button();
            btnSave = new Button();
            label9 = new Label();
            cmbStatus = new ComboBox();
            cmbAssignTo = new ComboBox();
            label8 = new Label();
            btnAddComment = new Button();
            txtComment = new TextBox();
            groupBoxtcktinfo = new GroupBox();
            groupBoxadmin = new GroupBox();
            groupBoxcommtn = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            groupBoxtcktinfo.SuspendLayout();
            groupBoxadmin.SuspendLayout();
            groupBoxcommtn.SuspendLayout();
            SuspendLayout();
            // 
            // lblTicketNumber
            // 
            lblTicketNumber.AutoSize = true;
            lblTicketNumber.Location = new Point(182, 50);
            lblTicketNumber.Margin = new Padding(4, 0, 4, 0);
            lblTicketNumber.Name = "lblTicketNumber";
            lblTicketNumber.Size = new Size(126, 23);
            lblTicketNumber.TabIndex = 0;
            lblTicketNumber.Text = "Ticket Number";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(195, 123);
            lblSubject.Margin = new Padding(4, 0, 4, 0);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(72, 23);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(724, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 2;
            label3.Text = "Description :";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(854, 50);
            lblCreatedDate.Margin = new Padding(4, 0, 4, 0);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(116, 23);
            lblCreatedDate.TabIndex = 5;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(854, 111);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(171, 244);
            lblPriority.Margin = new Padding(4, 0, 4, 0);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(69, 23);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Priority";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(854, 185);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(285, 85);
            txtDescription.TabIndex = 6;
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Location = new Point(195, 185);
            lblAssignedTo.Margin = new Padding(4, 0, 4, 0);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(133, 23);
            lblAssignedTo.TabIndex = 7;
            lblAssignedTo.Text = "Assigned Admin";
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(13, 576);
            dgvHistory.Margin = new Padding(4, 3, 4, 3);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(1224, 170);
            dgvHistory.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 9;
            label1.Text = "Ticket Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 10;
            label2.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 185);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 11;
            label4.Text = "Assigned Admin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 244);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 12;
            label5.Text = "Priority :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(770, 123);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 13;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(713, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 14;
            label7.Text = "Created Date:";
            // 
            // button1
            // 
            button1.Location = new Point(104, 508);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(335, 3);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(55, 29);
            btnclose.TabIndex = 4;
            btnclose.Text = "X";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(421, 46);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 93);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 2;
            label9.Text = "Change Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(204, 88);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 31);
            cmbStatus.TabIndex = 1;
            // 
            // cmbAssignTo
            // 
            cmbAssignTo.FormattingEnabled = true;
            cmbAssignTo.Location = new Point(192, 23);
            cmbAssignTo.Name = "cmbAssignTo";
            cmbAssignTo.Size = new Size(151, 31);
            cmbAssignTo.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 31);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 0;
            label8.Text = "Assign To :";
            // 
            // btnAddComment
            // 
            btnAddComment.Location = new Point(68, 123);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(194, 40);
            btnAddComment.TabIndex = 18;
            btnAddComment.Text = "Add Comment";
            btnAddComment.UseVisualStyleBackColor = true;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(19, 36);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.ScrollBars = ScrollBars.Vertical;
            txtComment.Size = new Size(316, 73);
            txtComment.TabIndex = 19;
            // 
            // groupBoxtcktinfo
            // 
            groupBoxtcktinfo.BackColor = Color.Transparent;
            groupBoxtcktinfo.Controls.Add(txtDescription);
            groupBoxtcktinfo.Controls.Add(lblTicketNumber);
            groupBoxtcktinfo.Controls.Add(label1);
            groupBoxtcktinfo.Controls.Add(label5);
            groupBoxtcktinfo.Controls.Add(lblSubject);
            groupBoxtcktinfo.Controls.Add(label4);
            groupBoxtcktinfo.Controls.Add(lblAssignedTo);
            groupBoxtcktinfo.Controls.Add(label3);
            groupBoxtcktinfo.Controls.Add(label2);
            groupBoxtcktinfo.Controls.Add(label6);
            groupBoxtcktinfo.Controls.Add(lblPriority);
            groupBoxtcktinfo.Controls.Add(lblCreatedDate);
            groupBoxtcktinfo.Controls.Add(label7);
            groupBoxtcktinfo.Controls.Add(lblStatus);
            groupBoxtcktinfo.Location = new Point(56, 12);
            groupBoxtcktinfo.Name = "groupBoxtcktinfo";
            groupBoxtcktinfo.Size = new Size(1158, 312);
            groupBoxtcktinfo.TabIndex = 20;
            groupBoxtcktinfo.TabStop = false;
            groupBoxtcktinfo.Text = "Ticket Info";
            // 
            // groupBoxadmin
            // 
            groupBoxadmin.BackColor = Color.Transparent;
            groupBoxadmin.Controls.Add(cmbStatus);
            groupBoxadmin.Controls.Add(btnSave);
            groupBoxadmin.Controls.Add(label8);
            groupBoxadmin.Controls.Add(label9);
            groupBoxadmin.Controls.Add(cmbAssignTo);
            groupBoxadmin.Location = new Point(65, 345);
            groupBoxadmin.Name = "groupBoxadmin";
            groupBoxadmin.Size = new Size(698, 125);
            groupBoxadmin.TabIndex = 21;
            groupBoxadmin.TabStop = false;
            groupBoxadmin.Text = "Admin Penal";
            // 
            // groupBoxcommtn
            // 
            groupBoxcommtn.BackColor = Color.Transparent;
            groupBoxcommtn.Controls.Add(btnAddComment);
            groupBoxcommtn.Controls.Add(txtComment);
            groupBoxcommtn.Location = new Point(780, 355);
            groupBoxcommtn.Name = "groupBoxcommtn";
            groupBoxcommtn.Size = new Size(357, 175);
            groupBoxcommtn.TabIndex = 4;
            groupBoxcommtn.TabStop = false;
            groupBoxcommtn.Text = "Add Comment";
            // 
            // FrmTicketDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1252, 758);
            Controls.Add(groupBoxcommtn);
            Controls.Add(groupBoxadmin);
            Controls.Add(groupBoxtcktinfo);
            Controls.Add(button1);
            Controls.Add(dgvHistory);
            Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTicketDetails";
            Text = "FrmTicketDetails";
            Load += FrmTicketDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            groupBoxtcktinfo.ResumeLayout(false);
            groupBoxtcktinfo.PerformLayout();
            groupBoxadmin.ResumeLayout(false);
            groupBoxadmin.PerformLayout();
            groupBoxcommtn.ResumeLayout(false);
            groupBoxcommtn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTicketNumber;
        private Label lblSubject;
        private Label label3;
        private Label lblCreatedDate;
        private Label lblStatus;
        private Label lblPriority;
        private TextBox txtDescription;
        private Label lblAssignedTo;
        private DataGridView dgvHistory;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btnSave;
        private Label label9;
        private ComboBox cmbStatus;
        private ComboBox cmbAssignTo;
        private Label label8;
        private Button btnclose;
        private Button btnAddComment;
        private TextBox txtComment;
        private GroupBox groupBoxtcktinfo;
        private GroupBox groupBoxadmin;
        private GroupBox groupBoxcommtn;
    }
}