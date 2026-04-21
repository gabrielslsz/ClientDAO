using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.id = 0;
            client.firstName = this.tbFirstName.Text;
            client.lastName = this.tbLastName.Text;
            client.email = this.tbEmail.Text;
            client.phone = this.tbPhone.Text;
            client.address = this.tbAdress.Text; 

            var repo = new ClientRepository();
            repo.CreateClient(client);

            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
