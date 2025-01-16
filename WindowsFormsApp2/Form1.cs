using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            string selectedItem = checkedListBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedItem))
            {
                // Add the selected value to the CheckedListBox
                checkedListBox1.Items.Remove(selectedItem);
            }
            else
            {
                lblSelectedValue.Text = "Not selected anything";
                MessageBox.Show("Please select an item from the Checked Box.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetSelection_Click_1(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItems.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedItem))
            {
                // Add the selected value to the CheckedListBox
                checkedListBox1.Items.Add(selectedItem);
            }
            else
            {
                lblSelectedValue.Text = "Not selected anything";
                MessageBox.Show("Please select an item from the Requirements Box.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
