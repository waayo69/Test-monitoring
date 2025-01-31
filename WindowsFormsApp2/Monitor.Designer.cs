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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblkani = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbAA = new System.Windows.Forms.ComboBox();
            this.lblkann = new System.Windows.Forms.Label();
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
            this.waayo69 = new WindowsFormsApp2.waayo69();
            this.waayo69BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new WindowsFormsApp2.waayo69TableAdapters.ClientsTableAdapter();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waayo69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waayo69BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSend.Location = new System.Drawing.Point(786, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 52);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send to monitoring";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 400);
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
            this.lblTimer.Location = new System.Drawing.Point(164, 372);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 16);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label1";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(351, 418);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(83, 16);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Data fetched";
            // 
            // lblkani
            // 
            this.lblkani.AutoSize = true;
            this.lblkani.Location = new System.Drawing.Point(351, 449);
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
            this.tabControl1.Size = new System.Drawing.Size(1214, 539);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cmbAA);
            this.tabPage1.Controls.Add(this.lblkann);
            this.tabPage1.Controls.Add(this.lblkani);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.lblMessage);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblTimer);
            this.tabPage1.Location = new System.Drawing.Point(59, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Finance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.requirementsStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(26, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // cmbAA
            // 
            this.cmbAA.FormattingEnabled = true;
            this.cmbAA.Location = new System.Drawing.Point(773, 494);
            this.cmbAA.Name = "cmbAA";
            this.cmbAA.Size = new System.Drawing.Size(254, 24);
            this.cmbAA.TabIndex = 7;
            // 
            // lblkann
            // 
            this.lblkann.AutoSize = true;
            this.lblkann.Location = new System.Drawing.Point(94, 471);
            this.lblkann.Name = "lblkann";
            this.lblkann.Size = new System.Drawing.Size(44, 16);
            this.lblkann.TabIndex = 6;
            this.lblkann.Text = "label2";
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
            this.tabPage2.Size = new System.Drawing.Size(1151, 531);
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
            this.tabPage3.Size = new System.Drawing.Size(1151, 531);
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
            // waayo69
            // 
            this.waayo69.DataSetName = "waayo69";
            this.waayo69.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waayo69BindingSource
            // 
            this.waayo69BindingSource.DataSource = this.waayo69;
            this.waayo69BindingSource.Position = 0;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.waayo69BindingSource;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            // 
            // requirementsStatusDataGridViewTextBoxColumn
            // 
            this.requirementsStatusDataGridViewTextBoxColumn.DataPropertyName = "RequirementsStatus";
            this.requirementsStatusDataGridViewTextBoxColumn.HeaderText = "RequirementsStatus";
            this.requirementsStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.requirementsStatusDataGridViewTextBoxColumn.Name = "requirementsStatusDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waayo69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waayo69BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
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
        private System.Windows.Forms.Label lblkann;
        private System.Windows.Forms.ComboBox cmbAA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource waayo69BindingSource;
        private waayo69 waayo69;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private waayo69TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
    }
}