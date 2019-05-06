namespace BackOffice
{
    partial class frmAddGame
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
            System.Windows.Forms.Label gameNoLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label consoleLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label imagePathLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGame));
            this.gameGeekProductDataSet = new BackOffice.GameGeekProductDataSet();
            this.getGameNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getGameNoTableAdapter = new BackOffice.GameGeekProductDataSetTableAdapters.GetGameNoTableAdapter();
            this.tableAdapterManager = new BackOffice.GameGeekProductDataSetTableAdapters.TableAdapterManager();
            this.tblGameTableAdapter = new BackOffice.GameGeekProductDataSetTableAdapters.tblGameTableAdapter();
            this.getGameNoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.getGameNoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gameNoTextBox = new System.Windows.Forms.TextBox();
            this.tblGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            gameNoLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            consoleLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            imagePathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameGeekProductDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGameNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGameNoBindingNavigator)).BeginInit();
            this.getGameNoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameNoLabel
            // 
            gameNoLabel.AutoSize = true;
            gameNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gameNoLabel.Location = new System.Drawing.Point(68, 76);
            gameNoLabel.Name = "gameNoLabel";
            gameNoLabel.Size = new System.Drawing.Size(109, 25);
            gameNoLabel.TabIndex = 1;
            gameNoLabel.Text = "Game No:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(91, 136);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(61, 25);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // consoleLabel
            // 
            consoleLabel.AutoSize = true;
            consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            consoleLabel.Location = new System.Drawing.Point(67, 180);
            consoleLabel.Name = "consoleLabel";
            consoleLabel.Size = new System.Drawing.Size(99, 25);
            consoleLabel.TabIndex = 5;
            consoleLabel.Text = "Console:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(86, 230);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(68, 25);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Price:";
            // 
            // imagePathLabel
            // 
            imagePathLabel.AutoSize = true;
            imagePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imagePathLabel.Location = new System.Drawing.Point(502, 281);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new System.Drawing.Size(128, 25);
            imagePathLabel.TabIndex = 9;
            imagePathLabel.Text = "Image Path:";
            // 
            // gameGeekProductDataSet
            // 
            this.gameGeekProductDataSet.DataSetName = "GameGeekProductDataSet";
            this.gameGeekProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getGameNoBindingSource
            // 
            this.getGameNoBindingSource.DataMember = "GetGameNo";
            this.getGameNoBindingSource.DataSource = this.gameGeekProductDataSet;
            // 
            // getGameNoTableAdapter
            // 
            this.getGameNoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblGameTableAdapter = this.tblGameTableAdapter;
            this.tableAdapterManager.UpdateOrder = BackOffice.GameGeekProductDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblGameTableAdapter
            // 
            this.tblGameTableAdapter.ClearBeforeFill = true;
            // 
            // getGameNoBindingNavigator
            // 
            this.getGameNoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.getGameNoBindingNavigator.BindingSource = this.getGameNoBindingSource;
            this.getGameNoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.getGameNoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.getGameNoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.getGameNoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.getGameNoBindingNavigatorSaveItem});
            this.getGameNoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.getGameNoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.getGameNoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.getGameNoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.getGameNoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.getGameNoBindingNavigator.Name = "getGameNoBindingNavigator";
            this.getGameNoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.getGameNoBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.getGameNoBindingNavigator.TabIndex = 0;
            this.getGameNoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // getGameNoBindingNavigatorSaveItem
            // 
            this.getGameNoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.getGameNoBindingNavigatorSaveItem.Enabled = false;
            this.getGameNoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("getGameNoBindingNavigatorSaveItem.Image")));
            this.getGameNoBindingNavigatorSaveItem.Name = "getGameNoBindingNavigatorSaveItem";
            this.getGameNoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.getGameNoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // gameNoTextBox
            // 
            this.gameNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getGameNoBindingSource, "GameNo", true));
            this.gameNoTextBox.Location = new System.Drawing.Point(193, 80);
            this.gameNoTextBox.Name = "gameNoTextBox";
            this.gameNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.gameNoTextBox.TabIndex = 2;
            // 
            // tblGameBindingSource
            // 
            this.tblGameBindingSource.DataMember = "tblGame";
            this.tblGameBindingSource.DataSource = this.gameGeekProductDataSet;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblGameBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(193, 138);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblGameBindingSource, "Console", true));
            this.consoleTextBox.Location = new System.Drawing.Point(193, 187);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(100, 22);
            this.consoleTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblGameBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(193, 237);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 8;
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblGameBindingSource, "ImagePath", true));
            this.imagePathTextBox.Location = new System.Drawing.Point(638, 285);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(127, 22);
            this.imagePathTextBox.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(616, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(505, 331);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 33);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(596, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 191);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Image";
            // 
            // frmAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(imagePathLabel);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(consoleLabel);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(gameNoLabel);
            this.Controls.Add(this.gameNoTextBox);
            this.Controls.Add(this.getGameNoBindingNavigator);
            this.Name = "frmAddGame";
            this.Text = "frmAddGame";
            this.Load += new System.EventHandler(this.frmAddGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameGeekProductDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGameNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getGameNoBindingNavigator)).EndInit();
            this.getGameNoBindingNavigator.ResumeLayout(false);
            this.getGameNoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameGeekProductDataSet gameGeekProductDataSet;
        private System.Windows.Forms.BindingSource getGameNoBindingSource;
        private GameGeekProductDataSetTableAdapters.GetGameNoTableAdapter getGameNoTableAdapter;
        private GameGeekProductDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator getGameNoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton getGameNoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gameNoTextBox;
        private GameGeekProductDataSetTableAdapters.tblGameTableAdapter tblGameTableAdapter;
        private System.Windows.Forms.BindingSource tblGameBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}