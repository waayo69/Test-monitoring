namespace WindowsFormsApp2
{
    partial class STM
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
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblQueuePosition = new System.Windows.Forms.Label();
            this.lblRequirementsStatus = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(233, 147);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(79, 29);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "label1";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionDate.Location = new System.Drawing.Point(381, 147);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(79, 29);
            this.lblTransactionDate.TabIndex = 1;
            this.lblTransactionDate.Text = "label2";
            // 
            // lblQueuePosition
            // 
            this.lblQueuePosition.AutoSize = true;
            this.lblQueuePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueuePosition.Location = new System.Drawing.Point(546, 147);
            this.lblQueuePosition.Name = "lblQueuePosition";
            this.lblQueuePosition.Size = new System.Drawing.Size(79, 29);
            this.lblQueuePosition.TabIndex = 2;
            this.lblQueuePosition.Text = "label3";
            // 
            // lblRequirementsStatus
            // 
            this.lblRequirementsStatus.AutoSize = true;
            this.lblRequirementsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirementsStatus.Location = new System.Drawing.Point(731, 147);
            this.lblRequirementsStatus.Name = "lblRequirementsStatus";
            this.lblRequirementsStatus.Size = new System.Drawing.Size(79, 29);
            this.lblRequirementsStatus.TabIndex = 3;
            this.lblRequirementsStatus.Text = "label4";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(891, 147);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(79, 29);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "TO DO";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(83, 147);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(79, 29);
            this.lblClientID.TabIndex = 6;
            this.lblClientID.Text = "label5";
            // 
            // STM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblRequirementsStatus);
            this.Controls.Add(this.lblQueuePosition);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblClientName);
            this.Name = "STM";
            this.Text = "Show";
            this.Load += new System.EventHandler(this.STM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblQueuePosition;
        private System.Windows.Forms.Label lblRequirementsStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientID;
    }
}