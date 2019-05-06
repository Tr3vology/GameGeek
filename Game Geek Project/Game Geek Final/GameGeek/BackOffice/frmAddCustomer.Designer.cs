namespace BackOffice
{
    partial class frmAddCustomer
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
            System.Windows.Forms.Label customerNoLabel;
            System.Windows.Forms.Label tilteLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gameGeekCustomerDataSet = new BackOffice.GameGeekCustomerDataSet();
            this.getCustomerNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerNoTableAdapter = new BackOffice.GameGeekCustomerDataSetTableAdapters.GetCustomerNoTableAdapter();
            this.tableAdapterManager = new BackOffice.GameGeekCustomerDataSetTableAdapters.TableAdapterManager();
            this.tblCustomerTableAdapter = new BackOffice.GameGeekCustomerDataSetTableAdapters.tblCustomerTableAdapter();
            this.getCustomerNoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerNoTextBox = new System.Windows.Forms.TextBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tilteTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.getCustomerNoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            customerNoLabel = new System.Windows.Forms.Label();
            tilteLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameGeekCustomerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerNoBindingNavigator)).BeginInit();
            this.getCustomerNoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNoLabel
            // 
            customerNoLabel.AutoSize = true;
            customerNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNoLabel.Location = new System.Drawing.Point(205, 74);
            customerNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerNoLabel.Name = "customerNoLabel";
            customerNoLabel.Size = new System.Drawing.Size(125, 20);
            customerNoLabel.TabIndex = 3;
            customerNoLabel.Text = "Customer No:";
            // 
            // tilteLabel
            // 
            tilteLabel.AutoSize = true;
            tilteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tilteLabel.Location = new System.Drawing.Point(261, 128);
            tilteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tilteLabel.Name = "tilteLabel";
            tilteLabel.Size = new System.Drawing.Size(52, 20);
            tilteLabel.TabIndex = 5;
            tilteLabel.Text = "Tilte:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(205, 249);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(106, 20);
            lastNameLabel.TabIndex = 7;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(205, 186);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(108, 20);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.Location = new System.Drawing.Point(205, 306);
            dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(128, 20);
            dateOfBirthLabel.TabIndex = 11;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(246, 378);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(84, 20);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "Address:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postCodeLabel.Location = new System.Drawing.Point(228, 448);
            postCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(102, 20);
            postCodeLabel.TabIndex = 15;
            postCodeLabel.Text = "Post Code:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(885, 480);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(46, 480);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gameGeekCustomerDataSet
            // 
            this.gameGeekCustomerDataSet.DataSetName = "GameGeekCustomerDataSet";
            this.gameGeekCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerNoBindingSource
            // 
            this.getCustomerNoBindingSource.DataMember = "GetCustomerNo";
            this.getCustomerNoBindingSource.DataSource = this.gameGeekCustomerDataSet;
            // 
            // getCustomerNoTableAdapter
            // 
            this.getCustomerNoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCustomerTableAdapter = this.tblCustomerTableAdapter;
            this.tableAdapterManager.UpdateOrder = BackOffice.GameGeekCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // getCustomerNoBindingNavigator
            // 
            this.getCustomerNoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.getCustomerNoBindingNavigator.BindingSource = this.getCustomerNoBindingSource;
            this.getCustomerNoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.getCustomerNoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.getCustomerNoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.getCustomerNoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.getCustomerNoBindingNavigatorSaveItem});
            this.getCustomerNoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.getCustomerNoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.getCustomerNoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.getCustomerNoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.getCustomerNoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.getCustomerNoBindingNavigator.Name = "getCustomerNoBindingNavigator";
            this.getCustomerNoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.getCustomerNoBindingNavigator.Size = new System.Drawing.Size(1100, 27);
            this.getCustomerNoBindingNavigator.TabIndex = 2;
            this.getCustomerNoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(67, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // customerNoTextBox
            // 
            this.customerNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getCustomerNoBindingSource, "CustomerNo", true));
            this.customerNoTextBox.Location = new System.Drawing.Point(356, 69);
            this.customerNoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerNoTextBox.Name = "customerNoTextBox";
            this.customerNoTextBox.Size = new System.Drawing.Size(136, 27);
            this.customerNoTextBox.TabIndex = 4;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.gameGeekCustomerDataSet;
            // 
            // tilteTextBox
            // 
            this.tilteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Tilte", true));
            this.tilteTextBox.Location = new System.Drawing.Point(356, 123);
            this.tilteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tilteTextBox.Name = "tilteTextBox";
            this.tilteTextBox.Size = new System.Drawing.Size(136, 27);
            this.tilteTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(356, 244);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(136, 27);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(356, 181);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(136, 27);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCustomerBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(356, 301);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(274, 27);
            this.dateOfBirthDateTimePicker.TabIndex = 12;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(356, 379);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(136, 27);
            this.addressTextBox.TabIndex = 14;
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomerBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(356, 449);
            this.postCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(136, 27);
            this.postCodeTextBox.TabIndex = 16;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // getCustomerNoBindingNavigatorSaveItem
            // 
            this.getCustomerNoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.getCustomerNoBindingNavigatorSaveItem.Enabled = false;
            this.getCustomerNoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("getCustomerNoBindingNavigatorSaveItem.Image")));
            this.getCustomerNoBindingNavigatorSaveItem.Name = "getCustomerNoBindingNavigatorSaveItem";
            this.getCustomerNoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.getCustomerNoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1100, 563);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(tilteLabel);
            this.Controls.Add(this.tilteTextBox);
            this.Controls.Add(customerNoLabel);
            this.Controls.Add(this.customerNoTextBox);
            this.Controls.Add(this.getCustomerNoBindingNavigator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddCustomer";
            this.Text = "frmAddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGeekCustomerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerNoBindingNavigator)).EndInit();
            this.getCustomerNoBindingNavigator.ResumeLayout(false);
            this.getCustomerNoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private GameGeekCustomerDataSet gameGeekCustomerDataSet;
        private System.Windows.Forms.BindingSource getCustomerNoBindingSource;
        private GameGeekCustomerDataSetTableAdapters.GetCustomerNoTableAdapter getCustomerNoTableAdapter;
        private GameGeekCustomerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator getCustomerNoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton getCustomerNoBindingNavigatorSaveItem;
        private GameGeekCustomerDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.TextBox customerNoTextBox;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.TextBox tilteTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
    }
}