//namespace WindowsFormsApp2
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
//            this.comboBoxItems = new System.Windows.Forms.ComboBox();
//            this.btnGetSelection = new System.Windows.Forms.Button();
//            this.lblSelectedValue = new System.Windows.Forms.Label();
//            this.lblRemove = new System.Windows.Forms.Button();
//            this.radioButtonSelectAll = new System.Windows.Forms.RadioButton();
//            this.radioButtonDeselect = new System.Windows.Forms.RadioButton();
//            this.button1 = new System.Windows.Forms.Button();
//            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.btnProcessed = new System.Windows.Forms.Button();
//            this.lblPercent = new System.Windows.Forms.Label();
//            this.cmbClients = new System.Windows.Forms.ComboBox();
//            this.btnAddToClient = new System.Windows.Forms.Button();
//            this.btnRemoveFromClient = new System.Windows.Forms.Button();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.processedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.bastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.bastaKani = new WindowsFormsApp2.bastaKani();
//            this.bastaTableAdapter = new WindowsFormsApp2.bastaKaniTableAdapters.BastaTableAdapter();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bastaBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bastaKani)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // checkedListBox1
//            // 
//            this.checkedListBox1.CheckOnClick = true;
//            this.checkedListBox1.FormattingEnabled = true;
//            this.checkedListBox1.Location = new System.Drawing.Point(73, 264);
//            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
//            this.checkedListBox1.Name = "checkedListBox1";
//            this.checkedListBox1.Size = new System.Drawing.Size(423, 174);
//            this.checkedListBox1.TabIndex = 0;
//            // 
//            // comboBoxItems
//            // 
//            this.comboBoxItems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
//            this.comboBoxItems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
//            this.comboBoxItems.FormattingEnabled = true;
//            this.comboBoxItems.Items.AddRange(new object[] {
//            "AFP Beneficiary ID",
//            "AFPSLAI ID *",
//            "Barangay ID *",
//            "BIR (TIN)",
//            "COMELEC / Voter’s ID / COMELEC Registration Form",
//            "Documents with picture and signature",
//            "Driver’s License*",
//            "e-Card / UMID",
//            "Employee’s ID / Office Id",
//            "Firearms License *",
//            "Integrated Bar of the Philippines (IBP) ID",
//            "NBI Clearance *",
//            "Other valid government-issued IDs or",
//            "Pag-ibig ID",
//            "Pantawid Pamilya Pilipino Program (4Ps) ID *",
//            "Passport *",
//            "Person’s With Disability (PWD) ID",
//            "Phil-health ID",
//            "Philippine Identification (PhilID / ePhilID)",
//            "Philippine Postal ID *",
//            "Professional Regulation Commission (PRC) ID *",
//            "PVAO ID",
//            "School ID **",
//            "Senior Citizen ID",
//            "Solo Parent ID",
//            "SSS ID"});
//            this.comboBoxItems.Location = new System.Drawing.Point(74, 191);
//            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(4);
//            this.comboBoxItems.Name = "comboBoxItems";
//            this.comboBoxItems.Size = new System.Drawing.Size(423, 24);
//            this.comboBoxItems.Sorted = true;
//            this.comboBoxItems.TabIndex = 1;
//            // 
//            // btnGetSelection
//            // 
//            this.btnGetSelection.Location = new System.Drawing.Point(574, 32);
//            this.btnGetSelection.Margin = new System.Windows.Forms.Padding(4);
//            this.btnGetSelection.Name = "btnGetSelection";
//            this.btnGetSelection.Size = new System.Drawing.Size(100, 28);
//            this.btnGetSelection.TabIndex = 2;
//            this.btnGetSelection.Text = "Add";
//            this.btnGetSelection.UseVisualStyleBackColor = true;
//            this.btnGetSelection.Click += new System.EventHandler(this.btnGetSelection_Click_1);
//            // 
//            // lblSelectedValue
//            // 
//            this.lblSelectedValue.AutoSize = true;
//            this.lblSelectedValue.Location = new System.Drawing.Point(270, 25);
//            this.lblSelectedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.lblSelectedValue.Name = "lblSelectedValue";
//            this.lblSelectedValue.Size = new System.Drawing.Size(44, 16);
//            this.lblSelectedValue.TabIndex = 3;
//            this.lblSelectedValue.Text = "label1";
//            // 
//            // lblRemove
//            // 
//            this.lblRemove.Location = new System.Drawing.Point(574, 70);
//            this.lblRemove.Name = "lblRemove";
//            this.lblRemove.Size = new System.Drawing.Size(100, 37);
//            this.lblRemove.TabIndex = 4;
//            this.lblRemove.Text = "Remove";
//            this.lblRemove.UseVisualStyleBackColor = true;
//            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
//            // 
//            // radioButtonSelectAll
//            // 
//            this.radioButtonSelectAll.AutoSize = true;
//            this.radioButtonSelectAll.Location = new System.Drawing.Point(73, 237);
//            this.radioButtonSelectAll.Name = "radioButtonSelectAll";
//            this.radioButtonSelectAll.Size = new System.Drawing.Size(83, 20);
//            this.radioButtonSelectAll.TabIndex = 5;
//            this.radioButtonSelectAll.TabStop = true;
//            this.radioButtonSelectAll.Text = "Select all";
//            this.radioButtonSelectAll.UseVisualStyleBackColor = true;
//            this.radioButtonSelectAll.CheckedChanged += new System.EventHandler(this.radioButtonSelectAll_CheckedChanged);
//            // 
//            // radioButtonDeselect
//            // 
//            this.radioButtonDeselect.AutoSize = true;
//            this.radioButtonDeselect.Location = new System.Drawing.Point(176, 237);
//            this.radioButtonDeselect.Name = "radioButtonDeselect";
//            this.radioButtonDeselect.Size = new System.Drawing.Size(99, 20);
//            this.radioButtonDeselect.TabIndex = 6;
//            this.radioButtonDeselect.TabStop = true;
//            this.radioButtonDeselect.Text = "Deselect all";
//            this.radioButtonDeselect.UseVisualStyleBackColor = true;
//            this.radioButtonDeselect.CheckedChanged += new System.EventHandler(this.radioButtonDeselect_CheckedChanged);
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(524, 479);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(141, 54);
//            this.button1.TabIndex = 7;
//            this.button1.Text = "Mark as done";
//            this.button1.UseVisualStyleBackColor = true;
//            // 
//            // checkedListBox2
//            // 
//            this.checkedListBox2.CheckOnClick = true;
//            this.checkedListBox2.FormattingEnabled = true;
//            this.checkedListBox2.Location = new System.Drawing.Point(73, 488);
//            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4);
//            this.checkedListBox2.Name = "checkedListBox2";
//            this.checkedListBox2.Size = new System.Drawing.Size(423, 123);
//            this.checkedListBox2.TabIndex = 8;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(70, 468);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(73, 16);
//            this.label1.TabIndex = 9;
//            this.label1.Text = "Completed";
//            // 
//            // btnProcessed
//            // 
//            this.btnProcessed.Location = new System.Drawing.Point(524, 355);
//            this.btnProcessed.Name = "btnProcessed";
//            this.btnProcessed.Size = new System.Drawing.Size(141, 40);
//            this.btnProcessed.TabIndex = 10;
//            this.btnProcessed.Text = "Processed";
//            this.btnProcessed.UseVisualStyleBackColor = true;
//            this.btnProcessed.Click += new System.EventHandler(this.btnProcessed_Click);
//            // 
//            // lblPercent
//            // 
//            this.lblPercent.AutoSize = true;
//            this.lblPercent.Location = new System.Drawing.Point(205, 446);
//            this.lblPercent.Name = "lblPercent";
//            this.lblPercent.Size = new System.Drawing.Size(53, 16);
//            this.lblPercent.TabIndex = 11;
//            this.lblPercent.Text = "Percent";
//            // 
//            // cmbClients
//            // 
//            this.cmbClients.FormattingEnabled = true;
//            this.cmbClients.Location = new System.Drawing.Point(73, 70);
//            this.cmbClients.Name = "cmbClients";
//            this.cmbClients.Size = new System.Drawing.Size(423, 24);
//            this.cmbClients.TabIndex = 12;
//            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
//            // 
//            // btnAddToClient
//            // 
//            this.btnAddToClient.Location = new System.Drawing.Point(524, 221);
//            this.btnAddToClient.Name = "btnAddToClient";
//            this.btnAddToClient.Size = new System.Drawing.Size(141, 41);
//            this.btnAddToClient.TabIndex = 13;
//            this.btnAddToClient.Text = "Add to client";
//            this.btnAddToClient.UseVisualStyleBackColor = true;
//            this.btnAddToClient.Click += new System.EventHandler(this.btnAddToClient_Click);
//            // 
//            // btnRemoveFromClient
//            // 
//            this.btnRemoveFromClient.Location = new System.Drawing.Point(524, 283);
//            this.btnRemoveFromClient.Name = "btnRemoveFromClient";
//            this.btnRemoveFromClient.Size = new System.Drawing.Size(141, 45);
//            this.btnRemoveFromClient.TabIndex = 14;
//            this.btnRemoveFromClient.Text = "Remove from Client";
//            this.btnRemoveFromClient.UseVisualStyleBackColor = true;
//            this.btnRemoveFromClient.Click += new System.EventHandler(this.btnRemoveFromClient_Click);
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AutoGenerateColumns = false;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.iDDataGridViewTextBoxColumn,
//            this.processedDataGridViewTextBoxColumn,
//            this.clientNameDataGridViewTextBoxColumn});
//            this.dataGridView1.DataSource = this.bastaBindingSource;
//            this.dataGridView1.Location = new System.Drawing.Point(75, 100);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowHeadersWidth = 51;
//            this.dataGridView1.RowTemplate.Height = 24;
//            this.dataGridView1.Size = new System.Drawing.Size(422, 84);
//            this.dataGridView1.TabIndex = 15;
//            // 
//            // iDDataGridViewTextBoxColumn
//            // 
//            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
//            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
//            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
//            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
//            this.iDDataGridViewTextBoxColumn.Width = 125;
//            // 
//            // processedDataGridViewTextBoxColumn
//            // 
//            this.processedDataGridViewTextBoxColumn.DataPropertyName = "Processed";
//            this.processedDataGridViewTextBoxColumn.HeaderText = "Processed";
//            this.processedDataGridViewTextBoxColumn.MinimumWidth = 6;
//            this.processedDataGridViewTextBoxColumn.Name = "processedDataGridViewTextBoxColumn";
//            this.processedDataGridViewTextBoxColumn.Width = 125;
//            // 
//            // clientNameDataGridViewTextBoxColumn
//            // 
//            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
//            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
//            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
//            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
//            this.clientNameDataGridViewTextBoxColumn.Width = 125;
//            // 
//            // bastaBindingSource
//            // 
//            this.bastaBindingSource.DataMember = "Basta";
//            this.bastaBindingSource.DataSource = this.bastaKani;
//            // 
//            // bastaKani
//            // 
//            this.bastaKani.DataSetName = "bastaKani";
//            this.bastaKani.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//            // 
//            // bastaTableAdapter
//            // 
//            this.bastaTableAdapter.ClearBeforeFill = true;
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(705, 633);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.btnRemoveFromClient);
//            this.Controls.Add(this.btnAddToClient);
//            this.Controls.Add(this.cmbClients);
//            this.Controls.Add(this.lblPercent);
//            this.Controls.Add(this.btnProcessed);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.checkedListBox2);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.radioButtonDeselect);
//            this.Controls.Add(this.radioButtonSelectAll);
//            this.Controls.Add(this.lblRemove);
//            this.Controls.Add(this.lblSelectedValue);
//            this.Controls.Add(this.btnGetSelection);
//            this.Controls.Add(this.comboBoxItems);
//            this.Controls.Add(this.checkedListBox1);
//            this.Margin = new System.Windows.Forms.Padding(4);
//            this.Name = "Form1";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Planning";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bastaBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bastaKani)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.CheckedListBox checkedListBox1;
//        private System.Windows.Forms.ComboBox comboBoxItems;
//        private System.Windows.Forms.Button btnGetSelection;
//        private System.Windows.Forms.Label lblSelectedValue;
//        private System.Windows.Forms.Button lblRemove;
//        private System.Windows.Forms.RadioButton radioButtonSelectAll;
//        private System.Windows.Forms.RadioButton radioButtonDeselect;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.CheckedListBox checkedListBox2;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Button btnProcessed;
//        private System.Windows.Forms.Label lblPercent;
//        private System.Windows.Forms.ComboBox cmbClients;
//        private System.Windows.Forms.Button btnAddToClient;
//        private System.Windows.Forms.Button btnRemoveFromClient;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private bastaKani bastaKani;
//        private System.Windows.Forms.BindingSource bastaBindingSource;
//        private bastaKaniTableAdapters.BastaTableAdapter bastaTableAdapter;
//        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn processedDataGridViewTextBoxColumn;
//        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
//    }
//}

