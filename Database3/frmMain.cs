using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Database3
{
    public partial class frmMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public frmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Database3.Properties.Settings.Database3ConnectionString"].ConnectionString;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database3DataSet.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.database3DataSet.Clinic);
            PopulateClinic();
        }

        private void lstPop_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateLab(); 
            PopulateOt();
        }

        private void PopulateClinic()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clinic", connection))
            {
                DataTable clinicTable = new DataTable();
                adapter.Fill(clinicTable);

                lstPop.DisplayMember = "Name_clinic";
                lstPop.ValueMember = "C_number";
                lstPop.DataSource = clinicTable;
            }
        }

        private void PopulateLab()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT a.L_name FROM Laboratory a INNER JOIN Clinic b ON a.L_number = b.Laboratory WHERE b.C_number = @Laboratory", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Laboratory", lstPop.SelectedValue);
                

                DataTable clinicinfTable = new DataTable();
                adapter.Fill(clinicinfTable);

                lstLab.DisplayMember = "L_name";
                lstLab.ValueMember = "L_number";
                lstLab.DataSource = clinicinfTable;
            }

        }

        private void PopulateOt()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT a.O_name FROM Otdelenie a INNER JOIN Clinic b ON a.Clinic = b.C_number WHERE b.C_number = @C_numb", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@C_numb", lstPop.SelectedValue);


                DataTable clinicinfTable = new DataTable();
                adapter.Fill(clinicinfTable);

                lstOt.DisplayMember = "O_name";
                lstOt.ValueMember = "O_number";
                lstOt.DataSource = clinicinfTable;
            }

        }


        private void PopulatePers()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT a.FIO FROM Personal a INNER JOIN Clinic b ON a.Clinic = b.C_number WHERE b.C_number = @C_numb", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@C_numb", cbClinic.SelectedValue);


                DataTable clinicinfTable = new DataTable();
                adapter.Fill(clinicinfTable);

                lstPers.DisplayMember = "FIO";
                lstPers.ValueMember = "FIO";
                lstPers.DataSource = clinicinfTable;
            }

        }

        private void PopulatePat()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT a.FIO FROM Patient a INNER JOIN Clinic b ON a.Clinic = b.C_number WHERE b.C_number = @C_numb", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@C_numb", cbClinic.SelectedValue);


                DataTable clinicinfTable = new DataTable();
                adapter.Fill(clinicinfTable);

                lstPat.DisplayMember = "FIO";
                lstPat.ValueMember = "FIO";
                lstPat.DataSource = clinicinfTable;
            }

        }

        private void cbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePers();
            PopulatePat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

        }

        private void lstPers_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePersInf();
            PopulatePersInf1();
        }

        private void PopulatePersInf()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT b_Date FROM Personal  WHERE FIO = @FIO", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@FIO", lstPers.SelectedValue);

                DataTable persinfTable = new DataTable();
                adapter.Fill(persinfTable);

                lstB_date.DisplayMember = "b_Date";
                lstB_date.ValueMember = "P_number";
                lstB_date.DataSource = persinfTable;

            }

        }

        private void PopulatePersInf1()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT Doljnost FROM Personal  WHERE FIO = @FIO", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@FIO", lstPers.SelectedValue);

                DataTable persinfTable = new DataTable();
                adapter.Fill(persinfTable);

                lstDol.DisplayMember = "Doljnost";
                lstDol.ValueMember = "P_number";
                lstDol.DataSource = persinfTable;

            }

        }

        private void lstPat_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePatInf();
            PopulatePatInf1();
            PopulatePatInf2();

        }


        private void PopulatePatInf()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT b_Date FROM Patient  WHERE FIO = @FIO", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@FIO", lstPat.SelectedValue);

                DataTable persinfTable = new DataTable();
                adapter.Fill(persinfTable);

                lstPatBd.DisplayMember = "b_Date";
                lstPatBd.ValueMember = "Pa_number";
                lstPatBd.DataSource = persinfTable;

            }

        }

        private void PopulatePatInf1()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT post_Date FROM Patient  WHERE FIO = @FIO", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@FIO", lstPat.SelectedValue);

                DataTable persinfTable = new DataTable();
                adapter.Fill(persinfTable);

                lstPatDP.DisplayMember = "post_Date";
                lstPatDP.ValueMember = "Pa_number";
                lstPatDP.DataSource = persinfTable;

            }

        }

        private void PopulatePatInf2()
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT Diagnos FROM Patient  WHERE FIO = @FIO", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@FIO", lstPat.SelectedValue);

                DataTable persinfTable = new DataTable();
                adapter.Fill(persinfTable);

                lstD.DisplayMember = "Diagnos";
                lstD.ValueMember = "Pa_number";
                lstD.DataSource = persinfTable;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO Clinic VALUES(@C_number,@Name_clinic,@Laboratory)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@C_number", textBox1.Text);
                command.Parameters.AddWithValue("@Name_clinic", textBox2.Text);
                command.Parameters.AddWithValue("@Laboratory", textBox3.Text);

                command.ExecuteScalar();
            }

            PopulateClinic();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO laboratory VALUES(@L_number,@L_name,@Profil)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@L_number", textBox6.Text);
                command.Parameters.AddWithValue("@L_name", textBox5.Text);
                command.Parameters.AddWithValue("@Profil", textBox4.Text);

                command.ExecuteScalar();
            }
            PopulateClinic();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO Otdelenie VALUES(@O_number,@O_name,@Clinic)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@O_number", textBox9.Text);
                command.Parameters.AddWithValue("@O_name", textBox8.Text);
                command.Parameters.AddWithValue("@Clinic", textBox7.Text);

                command.ExecuteScalar();
            }
            PopulateClinic();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO Patient VALUES(@Pa_number,@FIO,@b_Date,@Clinic,@post_Date,@Personal,@Otdelenie,@Diagnos)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Pa_number", textBox10.Text);
                command.Parameters.AddWithValue("@FIO", textBox11.Text);
                command.Parameters.AddWithValue("@b_Date", textBox12.Text);
                command.Parameters.AddWithValue("@Clinic", textBox13.Text);
                command.Parameters.AddWithValue("@post_Date", textBox14.Text);
                command.Parameters.AddWithValue("@Personal", textBox15.Text);
                command.Parameters.AddWithValue("@Otdelenie", textBox16.Text);
                command.Parameters.AddWithValue("@Diagnos", textBox17.Text);

                command.ExecuteScalar();
            }
            PopulatePat();
            PopulatePatInf();
            PopulatePatInf1();
            PopulatePatInf2();

        }

        private void button12_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO Personal VALUES(@P_number,@FIO,@b_Date,@Doljnost,@Otdelenie,@Clinic)", connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@P_number", textBox18.Text);
                command.Parameters.AddWithValue("@FIO", textBox19.Text);
                command.Parameters.AddWithValue("@b_Date", textBox20.Text);
                command.Parameters.AddWithValue("@Doljnost", textBox21.Text);
                command.Parameters.AddWithValue("@Otdelenie", textBox22.Text);
                command.Parameters.AddWithValue("@Clinic", textBox23.Text);

                command.ExecuteScalar();
            }
            PopulatePers();
            PopulatePersInf();
            PopulatePersInf1();

        }


    }
}
