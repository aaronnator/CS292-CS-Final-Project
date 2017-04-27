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
    public partial class ComponentForm : Form
    {
        private HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter componentAdapter = new HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter();
        public ComponentForm()
        {
            InitializeComponent();
        }

        private void hardwareComponentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hardwareComponentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hardwareComponentsDataset);

        }

        private void ComponentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardwareComponentsDataset.HardwareComponents' table. You can move, or remove it, as needed.
            this.hardwareComponentsTableAdapter.Fill(this.hardwareComponentsDataset.HardwareComponents);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
