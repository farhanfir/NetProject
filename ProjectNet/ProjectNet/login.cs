using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectNet
{
    public partial class login : Form
    {
        private const string connectionString = "Data Source=FARHAN\\MSSQLSERVER01;Initial Catalog=manajement_event;Integrated Security=True;Trust Server Certificate=True";

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login berhasil!");
                // Lakukan navigasi ke Form Manajemen Event atau form lainnya.
                manajement_event formManajemenEvent = new manajement_event();
                formManajemenEvent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal. Harap periksa kembali username dan password Anda.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Pastikan Anda memiliki tabel Pengguna dengan kolom NamaPengguna dan KataSandi di database.
                string query = "SELECT COUNT(*) FROM Pengguna WHERE NamaPengguna = @Username AND KataSandi = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
