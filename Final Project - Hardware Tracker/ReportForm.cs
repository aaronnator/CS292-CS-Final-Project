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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private HardwareComponentsDatasetTableAdapters.HardwareComponentsTableAdapter compAdapter;
        private HardwarePacksDatasetTableAdapters.HardwarePacksTableAdapter packAdapter;

        private void RunReport()
        {

            HardwarePacksDataset.HardwarePacksDataTable packTable;
            HardwareComponentsDataset.HardwareComponentsDataTable compTable;

       
                packTable = packAdapter.GetData();
                compTable = compAdapter.GetData();
      
                statStripReport.Text = "Error accessing database.";
       
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
