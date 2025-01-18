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
            this.radioButtonSelectAll = new System.Windows.Forms.RadioButton();
            this.radioButtonDeselect = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(78, 181);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
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
            this.comboBoxItems.Location = new System.Drawing.Point(78, 81);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(423, 24);
            this.comboBoxItems.Sorted = true;
            this.comboBoxItems.TabIndex = 1;
            // 
            // btnGetSelection
            // 
            this.btnGetSelection.Location = new System.Drawing.Point(535, 81);
            this.btnGetSelection.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblSelectedValue.Location = new System.Drawing.Point(270, 25);
            this.lblSelectedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedValue.Name = "lblSelectedValue";
            this.lblSelectedValue.Size = new System.Drawing.Size(44, 16);
            this.lblSelectedValue.TabIndex = 3;
            this.lblSelectedValue.Text = "label1";
            // 
            // lblRemove
            // 
            this.lblRemove.Location = new System.Drawing.Point(535, 202);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(100, 48);
            this.lblRemove.TabIndex = 4;
            this.lblRemove.Text = "Remove";
            this.lblRemove.UseVisualStyleBackColor = true;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // radioButtonSelectAll
            // 
            this.radioButtonSelectAll.AutoSize = true;
            this.radioButtonSelectAll.Location = new System.Drawing.Point(78, 154);
            this.radioButtonSelectAll.Name = "radioButtonSelectAll";
            this.radioButtonSelectAll.Size = new System.Drawing.Size(83, 20);
            this.radioButtonSelectAll.TabIndex = 5;
            this.radioButtonSelectAll.TabStop = true;
            this.radioButtonSelectAll.Text = "Select all";
            this.radioButtonSelectAll.UseVisualStyleBackColor = true;
            this.radioButtonSelectAll.CheckedChanged += new System.EventHandler(this.radioButtonSelectAll_CheckedChanged);
            // 
            // radioButtonDeselect
            // 
            this.radioButtonDeselect.AutoSize = true;
            this.radioButtonDeselect.Location = new System.Drawing.Point(181, 154);
            this.radioButtonDeselect.Name = "radioButtonDeselect";
            this.radioButtonDeselect.Size = new System.Drawing.Size(99, 20);
            this.radioButtonDeselect.TabIndex = 6;
            this.radioButtonDeselect.TabStop = true;
            this.radioButtonDeselect.Text = "Deselect all";
            this.radioButtonDeselect.UseVisualStyleBackColor = true;
            this.radioButtonDeselect.CheckedChanged += new System.EventHandler(this.radioButtonDeselect_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mark as done";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(78, 405);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(423, 123);
            this.checkedListBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Completed";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Processed";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonDeselect);
            this.Controls.Add(this.radioButtonSelectAll);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblSelectedValue);
            this.Controls.Add(this.btnGetSelection);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.checkedListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnGetSelection;
        private System.Windows.Forms.Label lblSelectedValue;
        private System.Windows.Forms.Button lblRemove;
        private System.Windows.Forms.RadioButton radioButtonSelectAll;
        private System.Windows.Forms.RadioButton radioButtonDeselect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

