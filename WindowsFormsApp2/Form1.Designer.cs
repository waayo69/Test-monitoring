namespace WindowsFormsApp2
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.btnGetSelection = new System.Windows.Forms.Button();
            this.lblSelectedValue = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(36, 216);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(423, 174);
            this.checkedListBox1.TabIndex = 0;
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
            this.comboBoxItems.Location = new System.Drawing.Point(36, 142);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(423, 24);
            this.comboBoxItems.Sorted = true;
            this.comboBoxItems.TabIndex = 1;
            // 
            // btnGetSelection
            // 
            this.btnGetSelection.Location = new System.Drawing.Point(493, 142);
            this.btnGetSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetSelection.Name = "btnGetSelection";
            this.btnGetSelection.Size = new System.Drawing.Size(100, 28);
            this.btnGetSelection.TabIndex = 2;
            this.btnGetSelection.Text = "Add";
            this.btnGetSelection.UseVisualStyleBackColor = true;
            this.btnGetSelection.Click += new System.EventHandler(this.btnGetSelection_Click_1);
            // 
            // lblSelectedValue
            // 
            this.lblSelectedValue.AutoSize = true;
            this.lblSelectedValue.Location = new System.Drawing.Point(264, 70);
            this.lblSelectedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedValue.Name = "lblSelectedValue";
            this.lblSelectedValue.Size = new System.Drawing.Size(44, 16);
            this.lblSelectedValue.TabIndex = 3;
            this.lblSelectedValue.Text = "label1";
            // 
            // lblRemove
            // 
            this.lblRemove.Location = new System.Drawing.Point(493, 216);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(100, 36);
            this.lblRemove.TabIndex = 4;
            this.lblRemove.Text = "Remove";
            this.lblRemove.UseVisualStyleBackColor = true;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblSelectedValue);
            this.Controls.Add(this.btnGetSelection);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.checkedListBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnGetSelection;
        private System.Windows.Forms.Label lblSelectedValue;
        private System.Windows.Forms.Button lblRemove;
    }
}

