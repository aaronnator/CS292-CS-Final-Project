using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Hardware_Tracker
{
    public partial class EditUsersForm : Form
    {
        public EditUsersForm()
        {
            InitializeComponent();
        }

        private void credentialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.credentialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginCredentials);

        }

        private void EditUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginCredentials.Credentials' table. You can move, or remove it, as needed.
            this.credentialsTableAdapter.Fill(this.loginCredentials.Credentials);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
