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
    public partial class frmAdduser : Form
    {
        public frmAdduser()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
        string.IsNullOrWhiteSpace(txtPassword.Text) ||
        string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (m, c, ch, e1) => true;

            using (HttpClient client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Config.BaseUrl);

                await client.PostAsync(
                    "api/Admin/AddUser?Username=" + txtUsername.Text +
                    "&Password=" + txtPassword.Text +
                    "&Role=" + cmbRole.Text,
                    null);
            }

            MessageBox.Show("User added successfully");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
