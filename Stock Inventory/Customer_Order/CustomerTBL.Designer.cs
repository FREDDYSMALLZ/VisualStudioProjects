namespace Customer_Order
{
    partial class CustomerTBL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTBL));
            System.Windows.Forms.Label customer_IdLabel;
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label customer_AddressLabel;
            System.Windows.Forms.Label customer_freight_carrierLabel;
            System.Windows.Forms.Label order_numberLabel;
            System.Windows.Forms.Label customer_Order_dateLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label product_quantityLabel;
            System.Windows.Forms.Label product_unit_priceLabel;
            this.stock_InventoryDataSet = new Customer_Order.Stock_InventoryDataSet();
            this.customer_OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_OrdersTableAdapter = new Customer_Order.Stock_InventoryDataSetTableAdapters.Customer_OrdersTableAdapter();
            this.tableAdapterManager = new Customer_Order.Stock_InventoryDataSetTableAdapters.TableAdapterManager();
            this.customer_OrdersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customer_OrdersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.customer_IdTextBox = new System.Windows.Forms.TextBox();
            this.customer_nameTextBox = new System.Windows.Forms.TextBox();
            this.customer_AddressTextBox = new System.Windows.Forms.TextBox();
            this.customer_freight_carrierTextBox = new System.Windows.Forms.TextBox();
            this.order_numberTextBox = new System.Windows.Forms.TextBox();
            this.customer_Order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_quantityTextBox = new System.Windows.Forms.TextBox();
            this.product_unit_priceTextBox = new System.Windows.Forms.TextBox();
            customer_IdLabel = new System.Windows.Forms.Label();
            customer_nameLabel = new System.Windows.Forms.Label();
            customer_AddressLabel = new System.Windows.Forms.Label();
            customer_freight_carrierLabel = new System.Windows.Forms.Label();
            order_numberLabel = new System.Windows.Forms.Label();
            customer_Order_dateLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            product_quantityLabel = new System.Windows.Forms.Label();
            product_unit_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrdersBindingNavigator)).BeginInit();
            this.customer_OrdersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // stock_InventoryDataSet
            // 
            this.stock_InventoryDataSet.DataSetName = "Stock_InventoryDataSet";
            this.stock_InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_OrdersBindingSource
            // 
            this.customer_OrdersBindingSource.DataMember = "Customer Orders";
            this.customer_OrdersBindingSource.DataSource = this.stock_InventoryDataSet;
            // 
            // customer_OrdersTableAdapter
            // 
            this.customer_OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_OrdersTableAdapter = this.customer_OrdersTableAdapter;
            this.tableAdapterManager.Customer_TableTableAdapter = null;
            this.tableAdapterManager.Freight_Carrier_TableTableAdapter = null;
            this.tableAdapterManager.Products_TableTableAdapter = null;
            this.tableAdapterManager.Stock_ReportsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Customer_Order.Stock_InventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customer_OrdersBindingNavigator
            // 
            this.customer_OrdersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customer_OrdersBindingNavigator.BindingSource = this.customer_OrdersBindingSource;
            this.customer_OrdersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customer_OrdersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customer_OrdersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.customer_OrdersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customer_OrdersBindingNavigatorSaveItem});
            this.customer_OrdersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customer_OrdersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customer_OrdersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customer_OrdersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customer_OrdersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customer_OrdersBindingNavigator.Name = "customer_OrdersBindingNavigator";
            this.customer_OrdersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customer_OrdersBindingNavigator.Size = new System.Drawing.Size(697, 39);
            this.customer_OrdersBindingNavigator.TabIndex = 0;
            this.customer_OrdersBindingNavigator.Text = "bindingNavigator1";
            this.customer_OrdersBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // customer_OrdersBindingNavigatorSaveItem
            // 
            this.customer_OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customer_OrdersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customer_OrdersBindingNavigatorSaveItem.Image")));
            this.customer_OrdersBindingNavigatorSaveItem.Name = "customer_OrdersBindingNavigatorSaveItem";
            this.customer_OrdersBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.customer_OrdersBindingNavigatorSaveItem.Text = "Save Data";
            this.customer_OrdersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customer_OrdersBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(697, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Data";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(697, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 62);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // customer_IdLabel
            // 
            customer_IdLabel.AutoSize = true;
            customer_IdLabel.Location = new System.Drawing.Point(58, 37);
            customer_IdLabel.Name = "customer_IdLabel";
            customer_IdLabel.Size = new System.Drawing.Size(164, 33);
            customer_IdLabel.TabIndex = 5;
            customer_IdLabel.Text = "Customer Id:";
            // 
            // customer_IdTextBox
            // 
            this.customer_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Customer Id", true));
            this.customer_IdTextBox.Location = new System.Drawing.Point(352, 20);
            this.customer_IdTextBox.Name = "customer_IdTextBox";
            this.customer_IdTextBox.Size = new System.Drawing.Size(200, 41);
            this.customer_IdTextBox.TabIndex = 6;
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.Location = new System.Drawing.Point(58, 84);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(201, 33);
            customer_nameLabel.TabIndex = 7;
            customer_nameLabel.Text = "Customer name:";
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Customer name", true));
            this.customer_nameTextBox.Location = new System.Drawing.Point(352, 67);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(200, 41);
            this.customer_nameTextBox.TabIndex = 8;
            // 
            // customer_AddressLabel
            // 
            customer_AddressLabel.AutoSize = true;
            customer_AddressLabel.Location = new System.Drawing.Point(58, 131);
            customer_AddressLabel.Name = "customer_AddressLabel";
            customer_AddressLabel.Size = new System.Drawing.Size(230, 33);
            customer_AddressLabel.TabIndex = 9;
            customer_AddressLabel.Text = "Customer Address:";
            // 
            // customer_AddressTextBox
            // 
            this.customer_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Customer Address", true));
            this.customer_AddressTextBox.Location = new System.Drawing.Point(352, 123);
            this.customer_AddressTextBox.Name = "customer_AddressTextBox";
            this.customer_AddressTextBox.Size = new System.Drawing.Size(200, 41);
            this.customer_AddressTextBox.TabIndex = 10;
            // 
            // customer_freight_carrierLabel
            // 
            customer_freight_carrierLabel.AutoSize = true;
            customer_freight_carrierLabel.Location = new System.Drawing.Point(58, 178);
            customer_freight_carrierLabel.Name = "customer_freight_carrierLabel";
            customer_freight_carrierLabel.Size = new System.Drawing.Size(293, 33);
            customer_freight_carrierLabel.TabIndex = 11;
            customer_freight_carrierLabel.Text = "Customer freight carrier:";
            // 
            // customer_freight_carrierTextBox
            // 
            this.customer_freight_carrierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Customer freight carrier", true));
            this.customer_freight_carrierTextBox.Location = new System.Drawing.Point(352, 170);
            this.customer_freight_carrierTextBox.Name = "customer_freight_carrierTextBox";
            this.customer_freight_carrierTextBox.Size = new System.Drawing.Size(200, 41);
            this.customer_freight_carrierTextBox.TabIndex = 12;
            // 
            // order_numberLabel
            // 
            order_numberLabel.AutoSize = true;
            order_numberLabel.Location = new System.Drawing.Point(58, 225);
            order_numberLabel.Name = "order_numberLabel";
            order_numberLabel.Size = new System.Drawing.Size(181, 33);
            order_numberLabel.TabIndex = 13;
            order_numberLabel.Text = "Order number:";
            // 
            // order_numberTextBox
            // 
            this.order_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Order number", true));
            this.order_numberTextBox.Location = new System.Drawing.Point(352, 217);
            this.order_numberTextBox.Name = "order_numberTextBox";
            this.order_numberTextBox.Size = new System.Drawing.Size(200, 41);
            this.order_numberTextBox.TabIndex = 14;
            // 
            // customer_Order_dateLabel
            // 
            customer_Order_dateLabel.AutoSize = true;
            customer_Order_dateLabel.Location = new System.Drawing.Point(58, 273);
            customer_Order_dateLabel.Name = "customer_Order_dateLabel";
            customer_Order_dateLabel.Size = new System.Drawing.Size(259, 33);
            customer_Order_dateLabel.TabIndex = 15;
            customer_Order_dateLabel.Text = "Customer Order date:";
            // 
            // customer_Order_dateDateTimePicker
            // 
            this.customer_Order_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customer_OrdersBindingSource, "Customer Order date", true));
            this.customer_Order_dateDateTimePicker.Location = new System.Drawing.Point(352, 273);
            this.customer_Order_dateDateTimePicker.Name = "customer_Order_dateDateTimePicker";
            this.customer_Order_dateDateTimePicker.Size = new System.Drawing.Size(200, 41);
            this.customer_Order_dateDateTimePicker.TabIndex = 16;
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(58, 319);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(178, 33);
            product_nameLabel.TabIndex = 17;
            product_nameLabel.Text = "Product name:";
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Product name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(352, 320);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(200, 41);
            this.product_nameTextBox.TabIndex = 18;
            // 
            // product_quantityLabel
            // 
            product_quantityLabel.AutoSize = true;
            product_quantityLabel.Location = new System.Drawing.Point(58, 366);
            product_quantityLabel.Name = "product_quantityLabel";
            product_quantityLabel.Size = new System.Drawing.Size(206, 33);
            product_quantityLabel.TabIndex = 19;
            product_quantityLabel.Text = "product quantity:";
            // 
            // product_quantityTextBox
            // 
            this.product_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "product quantity", true));
            this.product_quantityTextBox.Location = new System.Drawing.Point(352, 367);
            this.product_quantityTextBox.Name = "product_quantityTextBox";
            this.product_quantityTextBox.Size = new System.Drawing.Size(200, 41);
            this.product_quantityTextBox.TabIndex = 20;
            // 
            // product_unit_priceLabel
            // 
            product_unit_priceLabel.AutoSize = true;
            product_unit_priceLabel.Location = new System.Drawing.Point(58, 413);
            product_unit_priceLabel.Name = "product_unit_priceLabel";
            product_unit_priceLabel.Size = new System.Drawing.Size(224, 33);
            product_unit_priceLabel.TabIndex = 21;
            product_unit_priceLabel.Text = "Product unit price:";
            // 
            // product_unit_priceTextBox
            // 
            this.product_unit_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_OrdersBindingSource, "Product unit price", true));
            this.product_unit_priceTextBox.Location = new System.Drawing.Point(352, 414);
            this.product_unit_priceTextBox.Name = "product_unit_priceTextBox";
            this.product_unit_priceTextBox.Size = new System.Drawing.Size(200, 41);
            this.product_unit_priceTextBox.TabIndex = 22;
            // 
            // CustomerTBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 561);
            this.Controls.Add(customer_IdLabel);
            this.Controls.Add(this.customer_IdTextBox);
            this.Controls.Add(customer_nameLabel);
            this.Controls.Add(this.customer_nameTextBox);
            this.Controls.Add(customer_AddressLabel);
            this.Controls.Add(this.customer_AddressTextBox);
            this.Controls.Add(customer_freight_carrierLabel);
            this.Controls.Add(this.customer_freight_carrierTextBox);
            this.Controls.Add(order_numberLabel);
            this.Controls.Add(this.order_numberTextBox);
            this.Controls.Add(customer_Order_dateLabel);
            this.Controls.Add(this.customer_Order_dateDateTimePicker);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(product_quantityLabel);
            this.Controls.Add(this.product_quantityTextBox);
            this.Controls.Add(product_unit_priceLabel);
            this.Controls.Add(this.product_unit_priceTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_OrdersBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerTBL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Order Table";
            this.Load += new System.EventHandler(this.CustomerTBL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock_InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_OrdersBindingNavigator)).EndInit();
            this.customer_OrdersBindingNavigator.ResumeLayout(false);
            this.customer_OrdersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stock_InventoryDataSet stock_InventoryDataSet;
        private System.Windows.Forms.BindingSource customer_OrdersBindingSource;
        private Stock_InventoryDataSetTableAdapters.Customer_OrdersTableAdapter customer_OrdersTableAdapter;
        private Stock_InventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customer_OrdersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customer_OrdersBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox customer_IdTextBox;
        private System.Windows.Forms.TextBox customer_nameTextBox;
        private System.Windows.Forms.TextBox customer_AddressTextBox;
        private System.Windows.Forms.TextBox customer_freight_carrierTextBox;
        private System.Windows.Forms.TextBox order_numberTextBox;
        private System.Windows.Forms.DateTimePicker customer_Order_dateDateTimePicker;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox product_quantityTextBox;
        private System.Windows.Forms.TextBox product_unit_priceTextBox;
    }
}

