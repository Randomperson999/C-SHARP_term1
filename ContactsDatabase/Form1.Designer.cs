
namespace ContactsDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleInitalLabel;
            System.Windows.Forms.Label emailsLabel;
            System.Windows.Forms.Label phoneNumsLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label date_ofBirthLabel;
            System.Windows.Forms.Label jobTitleLabel;
            System.Windows.Forms.Label personalLabel;
            System.Windows.Forms.Label lastContactLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personInfoDataSet = new ContactsDatabase.PersonInfoDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new ContactsDatabase.PersonInfoDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new ContactsDatabase.PersonInfoDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleInitalTextBox = new System.Windows.Forms.TextBox();
            this.emailsTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumsTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.date_ofBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.personalCheckBox = new System.Windows.Forms.CheckBox();
            this.lastContactDateTimePicker = new System.Windows.Forms.DateTimePicker();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleInitalLabel = new System.Windows.Forms.Label();
            emailsLabel = new System.Windows.Forms.Label();
            phoneNumsLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            date_ofBirthLabel = new System.Windows.Forms.Label();
            jobTitleLabel = new System.Windows.Forms.Label();
            personalLabel = new System.Windows.Forms.Label();
            lastContactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactsDatabase.Properties.Resources.The_Company_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(506, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 301);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // personInfoDataSet
            // 
            this.personInfoDataSet.DataSetName = "PersonInfoDataSet";
            this.personInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.personInfoDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ContactsDatabase.PersonInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.tableBindingNavigator.TabIndex = 1;
            this.tableBindingNavigator.Text = "bindingNavigator1";
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
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(17, 46);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(57, 13);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "first Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(80, 43);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(17, 85);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(57, 13);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(80, 82);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // middleInitalLabel
            // 
            middleInitalLabel.AutoSize = true;
            middleInitalLabel.Location = new System.Drawing.Point(9, 124);
            middleInitalLabel.Name = "middleInitalLabel";
            middleInitalLabel.Size = new System.Drawing.Size(65, 13);
            middleInitalLabel.TabIndex = 6;
            middleInitalLabel.Text = "middle Inital:";
            // 
            // middleInitalTextBox
            // 
            this.middleInitalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "middleInital", true));
            this.middleInitalTextBox.Location = new System.Drawing.Point(80, 121);
            this.middleInitalTextBox.Name = "middleInitalTextBox";
            this.middleInitalTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleInitalTextBox.TabIndex = 7;
            // 
            // emailsLabel
            // 
            emailsLabel.AutoSize = true;
            emailsLabel.Location = new System.Drawing.Point(35, 165);
            emailsLabel.Name = "emailsLabel";
            emailsLabel.Size = new System.Drawing.Size(39, 13);
            emailsLabel.TabIndex = 8;
            emailsLabel.Text = "emails:";
            // 
            // emailsTextBox
            // 
            this.emailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "emails", true));
            this.emailsTextBox.Location = new System.Drawing.Point(80, 162);
            this.emailsTextBox.Name = "emailsTextBox";
            this.emailsTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailsTextBox.TabIndex = 9;
            // 
            // phoneNumsLabel
            // 
            phoneNumsLabel.AutoSize = true;
            phoneNumsLabel.Location = new System.Drawing.Point(4, 205);
            phoneNumsLabel.Name = "phoneNumsLabel";
            phoneNumsLabel.Size = new System.Drawing.Size(70, 13);
            phoneNumsLabel.TabIndex = 10;
            phoneNumsLabel.Text = "phone Nums:";
            // 
            // phoneNumsTextBox
            // 
            this.phoneNumsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "phoneNums", true));
            this.phoneNumsTextBox.Location = new System.Drawing.Point(80, 202);
            this.phoneNumsTextBox.Name = "phoneNumsTextBox";
            this.phoneNumsTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumsTextBox.TabIndex = 11;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(21, 250);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(53, 13);
            companyLabel.TabIndex = 12;
            companyLabel.Text = "company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "company", true));
            this.companyTextBox.Location = new System.Drawing.Point(80, 247);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 13;
            // 
            // date_ofBirthLabel
            // 
            date_ofBirthLabel.AutoSize = true;
            date_ofBirthLabel.Location = new System.Drawing.Point(7, 297);
            date_ofBirthLabel.Name = "date_ofBirthLabel";
            date_ofBirthLabel.Size = new System.Drawing.Size(67, 13);
            date_ofBirthLabel.TabIndex = 14;
            date_ofBirthLabel.Text = "date of Birth:";
            // 
            // date_ofBirthDateTimePicker
            // 
            this.date_ofBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "date_ofBirth", true));
            this.date_ofBirthDateTimePicker.Location = new System.Drawing.Point(80, 293);
            this.date_ofBirthDateTimePicker.Name = "date_ofBirthDateTimePicker";
            this.date_ofBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_ofBirthDateTimePicker.TabIndex = 15;
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new System.Drawing.Point(27, 338);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new System.Drawing.Size(47, 13);
            jobTitleLabel.TabIndex = 16;
            jobTitleLabel.Text = "job Title:";
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "jobTitle", true));
            this.jobTitleTextBox.Location = new System.Drawing.Point(80, 335);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTitleTextBox.TabIndex = 17;
            // 
            // personalLabel
            // 
            personalLabel.AutoSize = true;
            personalLabel.Location = new System.Drawing.Point(24, 379);
            personalLabel.Name = "personalLabel";
            personalLabel.Size = new System.Drawing.Size(50, 13);
            personalLabel.TabIndex = 18;
            personalLabel.Text = "personal:";
            // 
            // personalCheckBox
            // 
            this.personalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "personal", true));
            this.personalCheckBox.Location = new System.Drawing.Point(80, 374);
            this.personalCheckBox.Name = "personalCheckBox";
            this.personalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.personalCheckBox.TabIndex = 19;
            this.personalCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastContactLabel
            // 
            lastContactLabel.AutoSize = true;
            lastContactLabel.Location = new System.Drawing.Point(194, 378);
            lastContactLabel.Name = "lastContactLabel";
            lastContactLabel.Size = new System.Drawing.Size(66, 13);
            lastContactLabel.TabIndex = 20;
            lastContactLabel.Text = "last Contact:";
            // 
            // lastContactDateTimePicker
            // 
            this.lastContactDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "lastContact", true));
            this.lastContactDateTimePicker.Location = new System.Drawing.Point(266, 374);
            this.lastContactDateTimePicker.Name = "lastContactDateTimePicker";
            this.lastContactDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastContactDateTimePicker.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(lastContactLabel);
            this.Controls.Add(this.lastContactDateTimePicker);
            this.Controls.Add(personalLabel);
            this.Controls.Add(this.personalCheckBox);
            this.Controls.Add(jobTitleLabel);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(date_ofBirthLabel);
            this.Controls.Add(this.date_ofBirthDateTimePicker);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(phoneNumsLabel);
            this.Controls.Add(this.phoneNumsTextBox);
            this.Controls.Add(emailsLabel);
            this.Controls.Add(this.emailsTextBox);
            this.Controls.Add(middleInitalLabel);
            this.Controls.Add(this.middleInitalTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonInfoDataSet personInfoDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private PersonInfoDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private PersonInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleInitalTextBox;
        private System.Windows.Forms.TextBox emailsTextBox;
        private System.Windows.Forms.TextBox phoneNumsTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.DateTimePicker date_ofBirthDateTimePicker;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.CheckBox personalCheckBox;
        private System.Windows.Forms.DateTimePicker lastContactDateTimePicker;
    }
}

