using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNet
{
    public partial class manajement_event : Form
    {
        private const string connectionString = "Data Source=FARHAN\\MSSQLSERVER01;Initial Catalog=manajement_event;Integrated Security=True;Trust Server Certificate=True";

        public manajement_event()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query untuk mendapatkan daftar event dari database
                string query = "SELECT * FROM Event";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Menampilkan daftar event dalam DataGridView
                dgvevent.DataSource = dataTable;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manajement_event_Load(object sender, EventArgs e)
        {

        }

        private void btntambah_Click(object sender, EventArgs e)
        {

        }
    }
}
