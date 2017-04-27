using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project___Hardware_Tracker
{
    public partial class MainForm : Form
    {

        private LoginCredentialsTableAdapters.CredentialsTableAdapter loginAdapter = new LoginCredentialsTableAdapters.CredentialsTableAdapter();
        private HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter compAdapter = new HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter();
        private HardwarePacksDatasetTableAdapters.HardwarePacksTableAdapter packAdapter = new HardwarePacksDatasetTableAdapters.HardwarePacksTableAdapter();
        public MainForm()
        {
            InitializeComponent();
        }

        bool packageChecked = false;
        bool componentChecked = false;

        private void btnPassword_Click(object sender, EventArgs e)
        {
            statStripLogin.Text = "";
            string enteredUser;
            string enteredPass;
            enteredUser = txtUsername.Text;
            enteredPass = txtPassword.Text;

            // Need to figure out how to prevent SQL injection here.
            if (enteredUser.Contains("'") || enteredPass.Contains("'"))
            {
                statStripLogin.Text = "No symbols or punctuation may be used for login.";
                return;
            }


            // POST-VALIDATION +++++

            try
            {
                if (loginAdapter.SearchUserPass(loginAdapter.GetData(), enteredUser, enteredPass) > 0)
                {
                    panelLogin.Hide();
                    panelMenu.Show();
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    statStripLogin.Text = "Incorrect credentials.";
                }
            }
            catch
            {
                statStripLogin.Text = "Login Failed - Exception.";
            }
        }
        // Exit Program
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLogin.Show();
            panelMenu.Hide();
        }
        // Setting bool vars for radio buttons.
        private void radPack_CheckedChanged(object sender, EventArgs e)
        {
            if (radPack.Checked == true)
            {
                packageChecked = true;
                componentChecked = false;
            }
        }

        private void radComp_CheckedChanged(object sender, EventArgs e)
        {
            if (radComp.Checked == true)
            {
                packageChecked = false;
                componentChecked = true;
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            PackageForm frm = new PackageForm();
            ComponentForm form = new ComponentForm();

            if (packageChecked == true && !frm.Visible)
            {
                frm.ShowDialog();
            }
            else if (componentChecked == true && !form.Visible)
            {
                form.ShowDialog();
            }
            else
            {
                statStripLogin.Text = "Please select a data type.";
            }
        }

        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUsersForm frm = new EditUsersForm();
            if (!frm.Visible)
            {
                frm.ShowDialog();
            }

        }

        
        private void createReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            statStripLogin.Text = "";
            HardwarePacksDataset.HardwarePacksDataTable packTable;
            HardwareComponentsDataset.HardwareComponentsDataTable compTable;


            packTable = packAdapter.GetData();
            compTable = compAdapter.GetData();


            StreamWriter outFile;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outFile = File.CreateText(saveFileDialog.FileName);
                outFile.WriteLine("Perma-Column Hardware Report:");
                outFile.WriteLine("-----------------------------");
                outFile.WriteLine("Pack ID | Generic | Unlabeled | Menards | Total");
                outFile.WriteLine("");

                foreach (HardwarePacksDataset.HardwarePacksRow row in packTable)
                {
                    outFile.WriteLine(row.Pack_ID + "|" + row.Generic_Quantity + "|" + row.Unlabeled_Quantity + "|" + row.Menards_Quantity + "|" + row.Total_Quantity);
                }

                outFile.WriteLine("---------- Component Quantities -----------");
                outFile.WriteLine("Component | Quantity | Recommended Quantity");

                foreach (HardwareComponentsDataset.HardwareComponentsRow row in compTable)
                {
                    outFile.WriteLine(row.Component_Type + "|" + row.Quantity + "|" + row.Recommended_Quantity);
                }
                outFile.Close();
            }
        }
    }
}
