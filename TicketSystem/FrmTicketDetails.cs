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
using System.Xml.Linq;
using static TicketSystem.Models;

namespace TicketSystem
{
    public partial class FrmTicketDetails : Form
    {
        int _ticketId;

        public FrmTicketDetails(int ticketId)
        {
            InitializeComponent();
            _ticketId = ticketId;
        }

        private void FrmTicketDetails_Load(object sender, EventArgs e)
        {
            //  pnlAdminAssign.Visible = false;
            LoadTicketDetails();
            LoadHistory();

            groupBoxadmin.Visible = (frmLogin.LoggedInRole == "Admin");

            if (frmLogin.LoggedInRole == "Admin")
            {
                LoadAdminAssignControls();    
            }

        }
        private async void LoadHistory()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (m, c, ch, e) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Config.BaseUrl);

                HttpResponseMessage response =
                    await client.GetAsync("api/Ticket/GetTicketHistory?TicketId=" + _ticketId + "");

                if (response.IsSuccessStatusCode)
                {
                    string json =
                        await response.Content.ReadAsStringAsync();

                    var history =
                        JsonConvert.DeserializeObject<List<TicketHistory>>(json);

                    dgvHistory.DataSource = history;
                }
            }
        }

        private async void LoadTicketDetails()
        {
            try
            {
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback =
                    (msg, cert, chain, errors) => true;

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.BaseUrl);

                    HttpResponseMessage response =
                        await client.GetAsync("api/Ticket/TicketDetails?TicketId="+_ticketId+"");

                    if (response.IsSuccessStatusCode)
                    {
                        string json =
                            await response.Content.ReadAsStringAsync();

                        var list = JsonConvert.DeserializeObject<List<TicketDetailsResponse>>(json);

                        if (list != null && list.Count > 0)
                        {
                            TicketDetailsResponse data = list[0];

                            lblTicketNumber.Text = data.TicketNumber;
                            lblSubject.Text = data.Subject;
                            lblPriority.Text = data.Priority;
                            lblStatus.Text = data.Status;
                            lblCreatedDate.Text = data.Createdat;
                            lblAssignedTo.Text = data.AssignedTo;
                            txtDescription.Text = data.Description;
                            if (lblStatus.Text == "Closed")
                            {
                                groupBoxadmin.Enabled = false;
                                txtComment.Enabled = false;
                                btnAddComment.Enabled = false;
                            }
                            else
                            {
                                groupBoxadmin.Enabled = true;
                            }

                            // dgvHistory.DataSource = data.History;
                        }
                        else
                        {
                            MessageBox.Show("No ticket details found");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeshbrd frmDeshbrd = new frmDeshbrd();
            frmDeshbrd.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //pnlAdminAssign.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback =
                    (m, c, ch, e1) => true;

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.BaseUrl);


                    if (!string.IsNullOrEmpty(cmbAssignTo.Text))
                    {

                        await client.PostAsync("api/Ticket/AssignTicket?TicketId=" + _ticketId + "&AssignedTo=" + cmbAssignTo.Text + "&UpdatedBy=" + frmLogin.LoggedInUsername, null);

                    }


                    if (!string.IsNullOrEmpty(cmbStatus.Text))
                    {
                        await client.PostAsync("api/Ticket/UpdateStatus?TicketId=" + _ticketId + "&NewStatus=" + cmbStatus.Text + "&UpdatedBy=" + frmLogin.LoggedInUsername, null);

                    }

                    MessageBox.Show("Ticket assigned / updated successfully");

                    LoadTicketDetails();
                    LoadHistory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void LoadAdminAssignControls()
        {
            try
            {
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback =
                    (m, c, ch, e) => true;

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.BaseUrl);

                    HttpResponseMessage response =
                        await client.GetAsync("api/Ticket/GetAssignableUsers");

                    if (response.IsSuccessStatusCode)
                    {
                        string json =
                            await response.Content.ReadAsStringAsync();

                        var users =
                            JsonConvert.DeserializeObject<List<AssignUser>>(json);

                        cmbAssignTo.DataSource = users;
                        cmbAssignTo.DisplayMember = "Username";
                        cmbAssignTo.ValueMember = "Username"; 
                    }
                }

                cmbStatus.Items.Clear();
                cmbStatus.Items.Add("Open");
                cmbStatus.Items.Add("In Progress");
                cmbStatus.Items.Add("Closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAddComment_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrWhiteSpace(txtComment.Text))
                {
                    MessageBox.Show("Please enter comment");
                    return;
                }

                if (lblStatus.Text == "Closed")
                {
                    MessageBox.Show("Closed ticket cannot be commented");
                    return;
                }

                try
                {
                    var handler = new HttpClientHandler();
                    handler.ServerCertificateCustomValidationCallback =
                        (m, c, ch, e1) => true;

                    using (HttpClient client = new HttpClient(handler))
                    {
                        client.BaseAddress = new Uri(Config.BaseUrl);

                        await client.PostAsync(
     "api/Ticket/AddComment?TicketId=" + _ticketId +
     "&Comment=" + txtComment.Text +
     "&CreatedBy=" + frmLogin.LoggedInUsername,
     null
 );

                        LoadHistory();


                        MessageBox.Show("Comment added successfully");

                        txtComment.Clear();
                        LoadHistory(); // refresh history grid
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
    }
