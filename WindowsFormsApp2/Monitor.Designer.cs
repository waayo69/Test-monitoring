namespace WindowsFormsApp2
{
    partial class Monitor
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbqueueDataSet3 = new WindowsFormsApp2.dbqueueDataSet3();
            this.btnSend = new System.Windows.Forms.Button();
            this.clientsTableAdapter1 = new WindowsFormsApp2.dbqueueDataSet3TableAdapters.ClientsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblkani = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemoveFromClient = new System.Windows.Forms.Button();
            this.btnAddToClient = new System.Windows.Forms.Button();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.btnProcessed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.radioButtonDeselect = new System.Windows.Forms.RadioButton();
            this.radioButtonSelectAll = new System.Windows.Forms.RadioButton();
            this.lblSelectedValue = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequirementsStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbqueueDataSet1 = new WindowsFormsApp2.dbqueueDataSet1();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new WindowsFormsApp2.dbqueueDataSet1TableAdapters.ClientsTableAdapter();
            this.lblkann = new System.Windows.Forms.Label();
            this.cmbAA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbqueueDataSet3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbqueueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.InvoiceNum,
            this.ClientName,
            this.TransactionDate,
            this.QueuePosition,
            this.RequirementsStatus,
            this.PaymentStatus,
            this.ID});
            this.DataGridView1.DataSource = this.clientsBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(0, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1148, 269);
            this.DataGridView1.TabIndex = 0;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.dbqueueDataSet3;
            // 
            // dbqueueDataSet3
            // 
            this.dbqueueDataSet3.DataSetName = "dbqueueDataSet3";
            this.dbqueueDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSend.Location = new System.Drawing.Point(772, 342);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 52);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send to monitoring";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fetch new data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(150, 314);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 16);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label1";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(337, 360);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(83, 16);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Data fetched";
            // 
            // lblkani
            // 
            this.lblkani.AutoSize = true;
            this.lblkani.Location = new System.Drawing.Point(337, 391);
            this.lblkani.Name = "lblkani";
            this.lblkani.Size = new System.Drawing.Size(44, 16);
            this.lblkani.TabIndex = 5;
            this.lblkani.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 20);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1214, 496);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbAA);
            this.tabPage1.Controls.Add(this.lblkann);
            this.tabPage1.Controls.Add(this.DataGridView1);
            this.tabPage1.Controls.Add(this.lblkani);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblTimer);
            this.tabPage1.Location = new System.Drawing.Point(59, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Finance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemoveFromClient);
            this.tabPage2.Controls.Add(this.btnAddToClient);
            this.tabPage2.Controls.Add(this.cmbClients);
            this.tabPage2.Controls.Add(this.lblPercent);
            this.tabPage2.Controls.Add(this.btnProcessed);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.checkedListBox2);
            this.tabPage2.Controls.Add(this.btnDone);
            this.tabPage2.Controls.Add(this.radioButtonDeselect);
            this.tabPage2.Controls.Add(this.radioButtonSelectAll);
            this.tabPage2.Controls.Add(this.lblSelectedValue);
            this.tabPage2.Controls.Add(this.comboBoxItems);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(59, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnRemoveFromClient
            // 
            this.btnRemoveFromClient.Location = new System.Drawing.Point(296, 349);
            this.btnRemoveFromClient.Name = "btnRemoveFromClient";
            this.btnRemoveFromClient.Size = new System.Drawing.Size(141, 40);
            this.btnRemoveFromClient.TabIndex = 30;
            this.btnRemoveFromClient.Text = "Remove from Client";
            this.btnRemoveFromClient.UseVisualStyleBackColor = true;
            // 
            // btnAddToClient
            // 
            this.btnAddToClient.Location = new System.Drawing.Point(126, 349);
            this.btnAddToClient.Name = "btnAddToClient";
            this.btnAddToClient.Size = new System.Drawing.Size(141, 41);
            this.btnAddToClient.TabIndex = 29;
            this.btnAddToClient.Text = "Add to client";
            this.btnAddToClient.UseVisualStyleBackColor = true;
            this.btnAddToClient.Click += new System.EventHandler(this.btnAddToClient_Click);
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(11, 31);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(423, 24);
            this.cmbClients.TabIndex = 28;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(615, 80);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(53, 16);
            this.lblPercent.TabIndex = 27;
            this.lblPercent.Text = "Percent";
            this.lblPercent.Click += new System.EventHandler(this.lblPercent_Click);
            // 
            // btnProcessed
            // 
            this.btnProcessed.Location = new System.Drawing.Point(496, 349);
            this.btnProcessed.Name = "btnProcessed";
            this.btnProcessed.Size = new System.Drawing.Size(141, 40);
            this.btnProcessed.TabIndex = 26;
            this.btnProcessed.Text = "Processed";
            this.btnProcessed.UseVisualStyleBackColor = true;
            this.btnProcessed.Click += new System.EventHandler(this.btnProcessed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Completed";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(451, 138);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(423, 123);
            this.checkedListBox2.TabIndex = 24;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(696, 349);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(141, 40);
            this.btnDone.TabIndex = 23;
            this.btnDone.Text = "Mark as done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonDeselect
            // 
            this.radioButtonDeselect.AutoSize = true;
            this.radioButtonDeselect.Location = new System.Drawing.Point(114, 110);
            this.radioButtonDeselect.Name = "radioButtonDeselect";
            this.radioButtonDeselect.Size = new System.Drawing.Size(99, 20);
            this.radioButtonDeselect.TabIndex = 22;
            this.radioButtonDeselect.TabStop = true;
            this.radioButtonDeselect.Text = "Deselect all";
            this.radioButtonDeselect.UseVisualStyleBackColor = true;
            this.radioButtonDeselect.CheckedChanged += new System.EventHandler(this.radioButtonDeselect_CheckedChanged);
            // 
            // radioButtonSelectAll
            // 
            this.radioButtonSelectAll.AutoSize = true;
            this.radioButtonSelectAll.Location = new System.Drawing.Point(11, 110);
            this.radioButtonSelectAll.Name = "radioButtonSelectAll";
            this.radioButtonSelectAll.Size = new System.Drawing.Size(83, 20);
            this.radioButtonSelectAll.TabIndex = 21;
            this.radioButtonSelectAll.TabStop = true;
            this.radioButtonSelectAll.Text = "Select all";
            this.radioButtonSelectAll.UseVisualStyleBackColor = true;
            this.radioButtonSelectAll.CheckedChanged += new System.EventHandler(this.radioButtonSelectAll_CheckedChanged);
            // 
            // lblSelectedValue
            // 
            this.lblSelectedValue.AutoSize = true;
            this.lblSelectedValue.Location = new System.Drawing.Point(458, 34);
            this.lblSelectedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedValue.Name = "lblSelectedValue";
            this.lblSelectedValue.Size = new System.Drawing.Size(44, 16);
            this.lblSelectedValue.TabIndex = 19;
            this.lblSelectedValue.Text = "label1";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "AFP Beneficiary ID",
            "AFPSLAI ID *",
            "Barangay ID *",
            "BIR (TIN)",
            "COMELEC / Voter’s ID / COMELEC Registration Form",
            "Documents with picture and signature",
            "Driver’s License*",
            "e-Card / UMID",
            "Employee’s ID / Office Id",
            "Firearms License *",
            "Integrated Bar of the Philippines (IBP) ID",
            "NBI Clearance *",
            "Other valid government-issued IDs or",
            "Pag-ibig ID",
            "Pantawid Pamilya Pilipino Program (4Ps) ID *",
            "Passport *",
            "Person’s With Disability (PWD) ID",
            "Phil-health ID",
            "Philippine Identification (PhilID / ePhilID)",
            "Philippine Postal ID *",
            "Professional Regulation Commission (PRC) ID *",
            "PVAO ID",
            "School ID **",
            "Senior Citizen ID",
            "Solo Parent ID",
            "SSS ID"});
            this.comboBoxItems.Location = new System.Drawing.Point(11, 80);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(423, 24);
            this.comboBoxItems.Sorted = true;
            this.comboBoxItems.TabIndex = 17;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 137);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(423, 174);
            this.checkedListBox1.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstHistory);
            this.tabPage3.Location = new System.Drawing.Point(59, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1151, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 16;
            this.lstHistory.Location = new System.Drawing.Point(0, 0);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(1151, 484);
            this.lstHistory.TabIndex = 0;
            // 
            // ClientID
            // 
            this.ClientID.DataPropertyName = "ClientID";
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.MinimumWidth = 6;
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.DataPropertyName = "InvoiceNum";
            this.InvoiceNum.HeaderText = "InvoiceNumber";
            this.InvoiceNum.MinimumWidth = 6;
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            // 
            // TransactionDate
            // 
            this.TransactionDate.DataPropertyName = "TransactionDate";
            this.TransactionDate.HeaderText = "TransactionDate";
            this.TransactionDate.MinimumWidth = 6;
            this.TransactionDate.Name = "TransactionDate";
            // 
            // QueuePosition
            // 
            this.QueuePosition.DataPropertyName = "QueuePosition";
            this.QueuePosition.HeaderText = "QueuePosition";
            this.QueuePosition.MinimumWidth = 6;
            this.QueuePosition.Name = "QueuePosition";
            // 
            // RequirementsStatus
            // 
            this.RequirementsStatus.DataPropertyName = "RequirementsStatus";
            this.RequirementsStatus.HeaderText = "RequirementsStatus";
            this.RequirementsStatus.MinimumWidth = 6;
            this.RequirementsStatus.Name = "RequirementsStatus";
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            this.PaymentStatus.HeaderText = "PaymentStatus";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // dbqueueDataSet1
            // 
            this.dbqueueDataSet1.DataSetName = "dbqueueDataSet1";
            this.dbqueueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dbqueueDataSet1;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // lblkann
            // 
            this.lblkann.AutoSize = true;
            this.lblkann.Location = new System.Drawing.Point(197, 439);
            this.lblkann.Name = "lblkann";
            this.lblkann.Size = new System.Drawing.Size(44, 16);
            this.lblkann.TabIndex = 6;
            this.lblkann.Text = "label2";
            // 
            // cmbAA
            // 
            this.cmbAA.FormattingEnabled = true;
            this.cmbAA.Location = new System.Drawing.Point(445, 431);
            this.cmbAA.Name = "cmbAA";
            this.cmbAA.Size = new System.Drawing.Size(254, 24);
            this.cmbAA.TabIndex = 7;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbqueueDataSet3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbqueueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btnSend;
        private dbqueueDataSet3 dbqueueDataSet3;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private dbqueueDataSet3TableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblkani;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemoveFromClient;
        private System.Windows.Forms.Button btnAddToClient;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button btnProcessed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.RadioButton radioButtonDeselect;
        private System.Windows.Forms.RadioButton radioButtonSelectAll;
        private System.Windows.Forms.Label lblSelectedValue;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueuePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementsStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private dbqueueDataSet1 dbqueueDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private dbqueueDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label lblkann;
        private System.Windows.Forms.ComboBox cmbAA;
    }
}