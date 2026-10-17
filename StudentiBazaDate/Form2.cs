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
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Student s)
        {
            InitializeComponent();
            tbMatricol.Text = s.Matricol.ToString();
            tbNume.Text = s.Nume.ToString();
            tbFacultate.Text = s.Facultate.ToString();
            tbMedie.Text = s.Medie.ToString();
            btnInsereaza.Hide();
        }

        private void btnInsereaza_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Studenti(Matricol, Nume, Facultate, Medie) " +
                "VALUES (@matricol, @nume, @facultate, @medie)", connection);
            command.Parameters.AddWithValue("@matricol", Convert.ToInt32(tbMatricol.Text));
            command.Parameters.AddWithValue("@nume", tbNume.Text);
            command.Parameters.AddWithValue("@facultate", tbFacultate.Text);
            command.Parameters.AddWithValue("@medie", decimal.Parse(tbMedie.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul a fost inserat!");
            this.Close();

        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Studenti SET Nume = @nume, Facultate = @facultate," +
                "Medie=@medie WHERE Matricol = @matricol", connection);
            command.Parameters.AddWithValue("@matricol", Convert.ToInt32(tbMatricol.Text));
            command.Parameters.AddWithValue("@nume", tbNume.Text);
            command.Parameters.AddWithValue("@facultate", tbFacultate.Text);
            command.Parameters.AddWithValue("@medie", decimal.Parse(tbMedie.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Studentul a fost modificat!");
            this.Close();
        }
    }
}
