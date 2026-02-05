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
using static TicketSystem.FrmTicketCreation;
using static TicketSystem.Models;

namespace TicketSystem
{
    public partial class FrmTicketList : Form
    {
        string _userId;
        string _role;
        public string StatusFilter = "";

        public FrmTicketList(string userId, string role)
        {
            InitializeComponent();
            _userId = userId;
            _role = role;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket");
                return;
            }

            int ticketId =
                Convert.ToInt32(
                    dgvTickets.SelectedRows[0]
                    .Cells["TicketId"].Value);

            FrmTicketDetails frm = new FrmTicketDetails(ticketId);

            frm.ShowDialog();
        }
        private async void LoadTickets()
        {
            try
            {
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback =
                    (msg, cert, chain, errors) => true;

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.BaseUrl);

                    string url =
                        $"api/Ticket/TicketList?userId={_userId}&role={_role}";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Failed to load tickets");
                        return;
                    }

                    string json = await response.Content.ReadAsStringAsync();

                    // deserialize
                    var list =
                        JsonConvert.DeserializeObject<List<TicketListModel>>(json);

                    // OPTIONAL STATUS FILTER (Open / Closed etc)
                    if (!string.IsNullOrEmpty(StatusFilter))
                    {
                        list = list
                            .Where(x => x.Status == StatusFilter)
                            .ToList();
                    }

                    dgvTickets.AutoGenerateColumns = true;
                    dgvTickets.DataSource = list;

                    // hide internal id
                    if (dgvTickets.Columns.Contains("TicketId"))
                        dgvTickets.Columns["TicketId"].Visible = false;

                    dgvTickets.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private async void LoadTickets()
        //{
        //    try
        //    {
        //        var handler = new HttpClientHandler();
        //        handler.ServerCertificateCustomValidationCallback =
        //            (msg, cert, chain, errors) => true;

        //        using (HttpClient client = new HttpClient(handler))
        //        {
        //            client.BaseAddress = new Uri(Config.BaseUrl);

        //            string url =
        //                "api/Ticket/TicketList?userId=" + _userId+"&role="+_role+"";

        //            HttpResponseMessage response = await client.GetAsync(url);

        //            if (response.IsSuccessStatusCode)
        //            {
        //                string json =
        //                    await response.Content.ReadAsStringAsync();

        //                var list =
        //                    JsonConvert.DeserializeObject<List<dynamic>>(json);

        //                dgvTickets.DataSource = list;

        //                dgvTickets.Columns["TicketId"].Visible = false;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Failed to load tickets");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void FrmTicketList_Load(object sender, EventArgs e)
        {

            lblUser.Text = "Logged in as: " + _role;
            LoadTickets();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this .Hide();
            //frmDeshbrd frmDeshbrd  = new frmDeshbrd();
            //frmDeshbrd.ShowDialog();
        }
    }
}
