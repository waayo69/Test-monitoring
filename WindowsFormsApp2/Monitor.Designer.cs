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
            this.IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queuePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbqueueDataSet3 = new WindowsFormsApp2.dbqueueDataSet3();
            this.btnSend = new System.Windows.Forms.Button();
            this.clientsTableAdapter1 = new WindowsFormsApp2.dbqueueDataSet3TableAdapters.ClientsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.TM = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbqueueDataSet3)).BeginInit();
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
            this.IDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.queuePositionDataGridViewTextBoxColumn,
            this.requirementsStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.clientsBindingSource1;
            this.DataGridView1.Location = new System.Drawing.Point(50, 40);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(924, 269);
            this.DataGridView1.TabIndex = 0;
            // 
            // IDDataGridViewTextBoxColumn
            // 
            this.IDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.IDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.IDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // queuePositionDataGridViewTextBoxColumn
            // 
            this.queuePositionDataGridViewTextBoxColumn.DataPropertyName = "QueuePosition";
            this.queuePositionDataGridViewTextBoxColumn.HeaderText = "QueuePosition";
            this.queuePositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.queuePositionDataGridViewTextBoxColumn.Name = "queuePositionDataGridViewTextBoxColumn";
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
            this.btnSend.Location = new System.Drawing.Point(803, 354);
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
            this.button1.Location = new System.Drawing.Point(104, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fetch new data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TM
            // 
            this.TM.Enabled = true;
            this.TM.Interval = 1000;
            this.TM.Tick += new System.EventHandler(this.TM_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(415, 372);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 16);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "label1";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.DataGridView1);
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbqueueDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btnSend;
        private dbqueueDataSet3 dbqueueDataSet3;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private dbqueueDataSet3TableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queuePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementsStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer TM;
        private System.Windows.Forms.Label lblTimer;
    }
}