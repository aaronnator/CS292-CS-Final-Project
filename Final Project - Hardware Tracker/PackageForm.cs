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
    public partial class PackageForm : Form
    {
        
        public PackageForm()
        {
            InitializeComponent();
        }
              
        private void hardwarePacksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hardwarePacksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hardwarePacksDataset);

        }

        private void PackageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardwarePacksDataset.HardwarePacks' table. You can move, or remove it, as needed.
            this.hardwarePacksTableAdapter.Fill(this.hardwarePacksDataset.HardwarePacks);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
