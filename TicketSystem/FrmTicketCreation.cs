using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicketSystem.Models;
using Newtonsoft.Json;


namespace TicketSystem
{
    public partial class FrmTicketCreation : Form
    {

        string _userId;

        public FrmTicketCreation(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        private void FrmTicketCreation_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.Add("Low");
            cmbPriority.Items.Add("Medium");
            cmbPriority.Items.Add("High");
            cmbPriority.SelectedIndex = 0;

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            TicketCreateModel model = new TicketCreateModel()
            {
                Subject = txtSubject.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Priority = cmbPriority.Text,
                CreatedBy = _userId
            };

            string json = JsonConvert.SerializeObject(model);

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (msg, cert, chain, errors) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Config.BaseUrl);

                HttpContent content =
                    new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response =
                    await client.PostAsync("api/Ticket/Create", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ticket Created Successfully");
                    txtSubject.Clear();
                    txtDescription.Clear();
            //        FrmTicketList frm = new FrmTicketList(frmLogin.LoggedInUserId, frmLogin.LoggedInRole);
              //      frm.Show();
                //    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error while creating ticket");
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }
    }
}
