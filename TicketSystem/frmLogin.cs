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
using static TicketSystem.Models;

namespace TicketSystem
{
    public partial class frmLogin : Form
    {
        public static string LoggedInUsername = "";
        public static string LoggedInRole = "";
        public static string LoggedInUserId = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter Username and Password");
                return;
            }

            try
            {
                var handler = new HttpClientHandler();
                handler.ServerCertificateCustomValidationCallback =
                    (msg, cert, chain, errors) => true;

                using (HttpClient client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Config.BaseUrl);

                    string url = "api/Login/CondtionalUser?Username=" + username + "&Password=" + password + "";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json =
                            await response.Content.ReadAsStringAsync();

                        var list = JsonConvert.DeserializeObject<List<LoginResponse>>(json);

                        if (list != null && list.Count > 0)
                        {
                            LoginResponse login = list[0];

                            LoggedInUsername = login.Username;
                            LoggedInRole = login.Role;
                            LoggedInUserId = login.UserId;
                            this.Hide();
                            //MessageBox.Show("Login Successful");
                            frmDeshbrd frmDeshbrd = new frmDeshbrd();
                            frmDeshbrd.ShowDialog();
                            //this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid login response");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPsss   frmForgotPsss = new frmForgotPsss();
            frmForgotPsss.ShowDialog();
        }
    }
}
