namespace Final_Project___Hardware_Tracker
{
    partial class PackageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageForm));
            this.hardwarePacksDataset = new Final_Project___Hardware_Tracker.HardwarePacksDataset();
            this.hardwarePacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwarePacksTableAdapter = new Final_Project___Hardware_Tracker.HardwarePacksDatasetTableAdapters.HardwarePacksTableAdapter();
            this.tableAdapterManager = new Final_Project___Hardware_Tracker.HardwarePacksDatasetTableAdapters.TableAdapterManager();
            this.hardwarePacksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hardwarePacksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hardwarePacksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksBindingNavigator)).BeginInit();
            this.hardwarePacksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hardwarePacksDataset
            // 
            this.hardwarePacksDataset.DataSetName = "HardwarePacksDataset";
            this.hardwarePacksDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hardwarePacksBindingSource
            // 
            this.hardwarePacksBindingSource.DataMember = "HardwarePacks";
            this.hardwarePacksBindingSource.DataSource = this.hardwarePacksDataset;
            // 
            // hardwarePacksTableAdapter
            // 
            this.hardwarePacksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HardwarePacksTableAdapter = this.hardwarePacksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project___Hardware_Tracker.HardwarePacksDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hardwarePacksBindingNavigator
            // 
            this.hardwarePacksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hardwarePacksBindingNavigator.BindingSource = this.hardwarePacksBindingSource;
            this.hardwarePacksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hardwarePacksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hardwarePacksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hardwarePacksBindingNavigatorSaveItem});
            this.hardwarePacksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hardwarePacksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hardwarePacksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hardwarePacksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hardwarePacksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hardwarePacksBindingNavigator.Name = "hardwarePacksBindingNavigator";
            this.hardwarePacksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hardwarePacksBindingNavigator.Size = new System.Drawing.Size(591, 25);
            this.hardwarePacksBindingNavigator.TabIndex = 0;
            this.hardwarePacksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hardwarePacksBindingNavigatorSaveItem
            // 
            this.hardwarePacksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hardwarePacksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hardwarePacksBindingNavigatorSaveItem.Image")));
            this.hardwarePacksBindingNavigatorSaveItem.Name = "hardwarePacksBindingNavigatorSaveItem";
            this.hardwarePacksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hardwarePacksBindingNavigatorSaveItem.Text = "Save Data";
            this.hardwarePacksBindingNavigatorSaveItem.Click += new System.EventHandler(this.hardwarePacksBindingNavigatorSaveItem_Click);
            // 
            // hardwarePacksDataGridView
            // 
            this.hardwarePacksDataGridView.AutoGenerateColumns = false;
            this.hardwarePacksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardwarePacksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hardwarePacksDataGridView.DataSource = this.hardwarePacksBindingSource;
            this.hardwarePacksDataGridView.Location = new System.Drawing.Point(23, 28);
            this.hardwarePacksDataGridView.Name = "hardwarePacksDataGridView";
            this.hardwarePacksDataGridView.Size = new System.Drawing.Size(547, 278);
            this.hardwarePacksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pack ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pack ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Generic Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Generic Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unlabeled Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unlabeled Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Menards Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Menards Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(251, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use the table and its tools above to edit and save Hardware Package information.";
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.hardwarePacksDataGridView);
            this.Controls.Add(this.hardwarePacksBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PackageForm";
            this.Text = "PackageForm";
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksBindingNavigator)).EndInit();
            this.hardwarePacksBindingNavigator.ResumeLayout(false);
            this.hardwarePacksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarePacksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HardwarePacksDataset hardwarePacksDataset;
        private System.Windows.Forms.BindingSource hardwarePacksBindingSource;
        private HardwarePacksDatasetTableAdapters.HardwarePacksTableAdapter hardwarePacksTableAdapter;
        private HardwarePacksDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hardwarePacksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hardwarePacksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hardwarePacksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}