namespace TicketSystem
{
    partial class FrmTicketCreation
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
            btnSubmit = new Button();
            label1 = new Label();
            txtSubject = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            cmbPriority = new ComboBox();
            label3 = new Label();
            btnback = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(402, 328);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(269, 72);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Create Ticket";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(50, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 1;
            label1.Text = "Subject";
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            txtSubject.Location = new Point(185, 34);
            txtSubject.Margin = new Padding(4, 3, 4, 3);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(340, 39);
            txtSubject.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(59, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 113);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(340, 81);
            txtDescription.TabIndex = 4;
            // 
            // cmbPriority
            // 
            cmbPriority.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold);
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(185, 228);
            cmbPriority.Margin = new Padding(4, 3, 4, 3);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(340, 43);
            cmbPriority.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(77, 241);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 6;
            label3.Text = "Priority";
            // 
            // btnback
            // 
            btnback.Location = new Point(38, 328);
            btnback.Margin = new Padding(4, 3, 4, 3);
            btnback.Name = "btnback";
            btnback.Size = new Size(269, 72);
            btnback.TabIndex = 7;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.cr;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnback);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(cmbPriority);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtSubject);
            groupBox1.Location = new Point(93, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 424);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Ticket";
            // 
            // FrmTicketCreation
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cr;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(823, 518);
            Controls.Add(groupBox1);
            Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTicketCreation";
            Text = "FrmTicketCreation";
            Load += FrmTicketCreation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private TextBox txtSubject;
        private Label label2;
        private TextBox txtDescription;
        private ComboBox cmbPriority;
        private Label label3;
        private Button btnback;
        private GroupBox groupBox1;
    }
}