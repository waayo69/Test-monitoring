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
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                // Loop through checked items and remove them
                for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
                {
                    int index = checkedListBox1.Items.IndexOf(checkedListBox1.CheckedItems[i]);
                    if (index >= 0)
                    {
                        checkedListBox1.Items.RemoveAt(index);
                    }
                }

                // Display success message
                MessageBox.Show("Selected items were successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Display message if no items were selected
                MessageBox.Show("No items were selected to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void radioButtonSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSelectAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
        }

        private void radioButtonDeselect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDeselect.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}
