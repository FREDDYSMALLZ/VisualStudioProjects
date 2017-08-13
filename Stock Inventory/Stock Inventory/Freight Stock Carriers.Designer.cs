namespace Stock_Inventory
{
    partial class Freight_Carriers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Freight_Carriers));
            this.stock_InventoryDataSet = new Stock_Inventory.Stock_InventoryDataSet();
            this.freight_Carrier_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.freight_Carrier_TableTableAdapter = new Stock_Inventory.Stock_InventoryDataSetTableAdapters.Freight_Carrier_TableTableAdapter();
            this.tableAdapterManager = new Stock_Inventory.Stock_InventoryDataSetTableAdapters.TableAdapterManager();
            this.freight_Carrier_TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.freight_Carrier_TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.freight_Carrier_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freight_Carrier_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freight_Carrier_TableBindingNavigator)).BeginInit();
            this.freight_Carrier_TableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freight_Carrier_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stock_InventoryDataSet
            // 
            this.stock_InventoryDataSet.DataSetName = "Stock_InventoryDataSet";
            this.stock_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freight_Carrier_TableBindingSource
            // 
            this.freight_Carrier_TableBindingSource.DataMember = "Freight Carrier Table";
            this.freight_Carrier_TableBindingSource.DataSource = this.stock_InventoryDataSet;
            // 
            // freight_Carrier_TableTableAdapter
            // 
            this.freight_Carrier_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_TableTableAdapter = null;
            this.tableAdapterManager.Freight_Carrier_TableTableAdapter = this.freight_Carrier_TableTableAdapter;
            this.tableAdapterManager.Products_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Stock_Inventory.Stock_InventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // freight_Carrier_TableBindingNavigator
            // 
            this.freight_Carrier_TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.freight_Carrier_TableBindingNavigator.BindingSource = this.freight_Carrier_TableBindingSource;
            this.freight_Carrier_TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.freight_Carrier_TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.freight_Carrier_TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.freight_Carrier_TableBindingNavigatorSaveItem});
            this.freight_Carrier_TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.freight_Carrier_TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.freight_Carrier_TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.freight_Carrier_TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.freight_Carrier_TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.freight_Carrier_TableBindingNavigator.Name = "freight_Carrier_TableBindingNavigator";
            this.freight_Carrier_TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.freight_Carrier_TableBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.freight_Carrier_TableBindingNavigator.TabIndex = 0;
            this.freight_Carrier_TableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // freight_Carrier_TableBindingNavigatorSaveItem
            // 
            this.freight_Carrier_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.freight_Carrier_TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("freight_Carrier_TableBindingNavigatorSaveItem.Image")));
            this.freight_Carrier_TableBindingNavigatorSaveItem.Name = "freight_Carrier_TableBindingNavigatorSaveItem";
            this.freight_Carrier_TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.freight_Carrier_TableBindingNavigatorSaveItem.Text = "Save Data";
            this.freight_Carrier_TableBindingNavigatorSaveItem.Click += new System.EventHandler(this.freight_Carrier_TableBindingNavigatorSaveItem_Click_1);
            // 
            // freight_Carrier_TableDataGridView
            // 
            this.freight_Carrier_TableDataGridView.AutoGenerateColumns = false;
            this.freight_Carrier_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freight_Carrier_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.freight_Carrier_TableDataGridView.DataSource = this.freight_Carrier_TableBindingSource;
            this.freight_Carrier_TableDataGridView.Location = new System.Drawing.Point(52, 56);
            this.freight_Carrier_TableDataGridView.Name = "freight_Carrier_TableDataGridView";
            this.freight_Carrier_TableDataGridView.Size = new System.Drawing.Size(471, 220);
            this.freight_Carrier_TableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Freight_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Freight_Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Freight_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Freight_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Freight_Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Freight_Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Driver_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Driver_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Freight_Carriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 296);
            this.Controls.Add(this.freight_Carrier_TableDataGridView);
            this.Controls.Add(this.freight_Carrier_TableBindingNavigator);
            this.Name = "Freight_Carriers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freight_Carriers";
            this.Load += new System.EventHandler(this.Freight_Carriers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freight_Carrier_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freight_Carrier_TableBindingNavigator)).EndInit();
            this.freight_Carrier_TableBindingNavigator.ResumeLayout(false);
            this.freight_Carrier_TableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freight_Carrier_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stock_Inventory.Stock_InventoryDataSet stock_InventoryDataSet;
        private System.Windows.Forms.BindingSource freight_Carrier_TableBindingSource;
        private Stock_Inventory.Stock_InventoryDataSetTableAdapters.Freight_Carrier_TableTableAdapter freight_Carrier_TableTableAdapter;
        private Stock_Inventory.Stock_InventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator freight_Carrier_TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton freight_Carrier_TableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView freight_Carrier_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}