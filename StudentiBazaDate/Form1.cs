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

namespace StudentiBazaDate
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        Student s;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Studenti", connection);
            adapter.Fill(dt);
            dgvStudenti.DataSource = dt;
            connection.Close();
        }

        private void btnInsereaza_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dgvStudenti_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int matricol = Convert.ToInt32(dgvStudenti.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nume = dgvStudenti.Rows[e.RowIndex].Cells[1].Value.ToString();
            string facultate = dgvStudenti.Rows[e.RowIndex].Cells[2].Value.ToString();
            decimal medie = decimal.Parse(dgvStudenti.Rows[e.RowIndex].Cells[3].Value.ToString());
            s = new Student(matricol, nume, facultate, medie);
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(s);
            form2.Show();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Studenti WHERE Matricol = @matricol", connection);
            command.Parameters.AddWithValue("@matricol", Convert.ToInt32(s.Matricol));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul a fost sters!");
        }
    }
}
