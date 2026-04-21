using System.Data;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ReadClients();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Edit Client
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete
        }

        private void ReadClients()
        { 
            try
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Phone");
                dataTable.Columns.Add("Date");

                var repo = new ClientRepository();
                var clients = repo.GetClients();

                foreach (var client in clients)
                {
                    var row = dataTable.NewRow();

                    row["ID"] = client.id;
                    row["Name"] = client.firstName + " " + client.lastName;
                    row["Email"] = client.email;
                    row["Phone"] = client.phone;
                    row["Date"] = client.createdAt;

                    dataTable.Rows.Add(row);
                }

                this.clientsTable.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }
    }
}
