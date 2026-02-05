using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystem
{
    public partial class frmDeshbrd : Form
    {
        public frmDeshbrd()
        {
            InitializeComponent();
        }
        private async void LoadTicketSummary()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (m, c, ch, e) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Config.BaseUrl);

                var res = await client.GetAsync("api/Admin/TicketSummary");
                var json = await res.Content.ReadAsStringAsync();

                var dt = JsonConvert.DeserializeObject<DataTable>(json);

                if (dt.Rows.Count > 0)
                {
                    lblTotalTickets.Text = "Total Ticket :"+dt.Rows[0]["TotalTickets"].ToString();
                    lblOpenTickets.Text = "Open Ticket :" + dt.Rows[0]["OpenTickets"].ToString();
                    lblClosedTickets.Text = "Closed Ticket :" + dt.Rows[0]["ClosedTickets"].ToString();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmTicketCreation frm = new FrmTicketCreation(frmLogin.LoggedInUserId);

            frm.ShowDialog();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            FrmTicketList frm = new FrmTicketList(frmLogin.LoggedInUserId, frmLogin.LoggedInRole);
            OpenFormInPanel(frm);
        }

        private void btnallticket_Click(object sender, EventArgs e)
        {
            if (frmLogin.LoggedInRole != "Admin")
            {
                MessageBox.Show("Access Denied");
                return;
            }

            FrmTicketList frm = new FrmTicketList(frmLogin.LoggedInUserId, frmLogin.LoggedInRole);
            OpenFormInPanel(frm);
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            if (frmLogin.LoggedInRole != "Admin")
            {
                MessageBox.Show("Only Admin can assign tickets");
                return;
            }

            FrmTicketList frm = new FrmTicketList(frmLogin.LoggedInUserId, frmLogin.LoggedInRole);
            OpenFormInPanel(frm);
        }

        private void btnOpentickt_Click(object sender, EventArgs e)
        {
            FrmTicketList frm = new FrmTicketList(frmLogin.LoggedInUserId, frmLogin.LoggedInRole);
            frm.StatusFilter = "Open";   
            OpenFormInPanel(frm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (frmLogin.LoggedInRole != "Admin")
            {
                MessageBox.Show("Only Admin can close tickets");
                return;
            }

            FrmTicketList frm = new FrmTicketList(frmLogin.LoggedInUserId, frmLogin.LoggedInRole);
            frm.StatusFilter = "Closed";
            OpenFormInPanel(frm);
        }
        private void OpenFormInPanel(Form childForm)
        {

            panelMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            childForm.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDeshbrd_Load(object sender, EventArgs e)
        {
            LoadTicketSummary();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdduser frm = new frmAdduser();
            frm.ShowDialog();
        }

        private    void button3_Click(object sender, EventArgs e)
        {
           // await client.PostAsync(
       //"api/Admin/UpdateUserRole?UserId=" + selectedUserId +
       //"&Role=" + cmbRole.Text,
       //null);

            MessageBox.Show("working on it..");
        }
    }
}
