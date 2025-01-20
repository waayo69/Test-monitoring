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
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePercentage();
        }

        private Dictionary<string, List<string>> clientAssociations = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> processedItems = new Dictionary<string, List<string>>();

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
                //MessageBox.Show("Selected items were successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdatePercentage()
        {
            // Calculate the percentage of items in checkedListBox2 compared to the total in both lists
            int totalItems = checkedListBox1.Items.Count + checkedListBox2.Items.Count;
            int transferredItems = checkedListBox2.Items.Count;

            if (totalItems > 0)
            {
                double percentage = (double)transferredItems / totalItems * 100;
                lblPercent.Text = $"Transferred: {percentage:F2}%";
            }
            else
            {
                lblPercent.Text = "Transferred: 0%";
            }
        }




        public void AddClientToComboBox(string clientName, int queuePosition)
        {
            // Format the display text
            string displayText = $"{clientName} (Queue: {queuePosition})";

            // Add the data to the ComboBox
            cmbClients.Items.Add(displayText);
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedClient)) return;

            // Load unprocessed items into checkedListBox1
            checkedListBox1.Items.Clear();
            if (clientAssociations.ContainsKey(selectedClient))
            {
                foreach (var item in clientAssociations[selectedClient])
                {
                    checkedListBox1.Items.Add(item);
                }
            }

            // Load processed items into checkedListBox2
            checkedListBox2.Items.Clear();
            if (processedItems.ContainsKey(selectedClient))
            {
                foreach (var item in processedItems[selectedClient])
                {
                    checkedListBox2.Items.Add(item);
                }
            }

            // Update percentage
            UpdateProcessedPercentage();
        }

        private void btnAddToClient_Click(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Please select a client before adding items.", "No Client Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newItem = comboBoxItems.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newItem))
            {
                MessageBox.Show("Please select an item to add.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure the client has a list of items in clientAssociations
            if (!clientAssociations.ContainsKey(selectedClient))
            {
                clientAssociations[selectedClient] = new List<string>();
            }

            // Check if the item already exists in the client's list
            if (clientAssociations[selectedClient].Contains(newItem) ||
                (processedItems.ContainsKey(selectedClient) && processedItems[selectedClient].Contains(newItem)))
            {
                MessageBox.Show("This item is already associated with the selected client.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the item to the client's list of unprocessed items
            clientAssociations[selectedClient].Add(newItem);
            checkedListBox1.Items.Add(newItem);

            // Update the percentage dynamically
            UpdateProcessedPercentage();

            MessageBox.Show("Item successfully added to the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnRemoveFromClient_Click(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Please select a client before removing items.", "No Client Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select items to remove.", "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clientAssociations.ContainsKey(selectedClient))
            {
                MessageBox.Show("This client has no associated items to remove.", "No Items Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Loop through the checked items and remove them
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                string item = checkedListBox1.CheckedItems[i].ToString();

                // Remove the item from the CheckedListBox
                checkedListBox1.Items.Remove(item);

                // Remove the item from the client's unprocessed list
                clientAssociations[selectedClient].Remove(item);
            }

            // Update the percentage dynamically
            UpdateProcessedPercentage();

            MessageBox.Show("Selected items were successfully removed from the client.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClient))
            {
                MessageBox.Show("Please select a client before processing.", "No Client Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clientAssociations.ContainsKey(selectedClient) || clientAssociations[selectedClient].Count == 0)
            {
                MessageBox.Show("No items are associated with this client to process.", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Initialize processed items for the client if not already present
            if (!processedItems.ContainsKey(selectedClient))
            {
                processedItems[selectedClient] = new List<string>();
            }

            // Transfer checked items to processed items
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string itemStr = item.ToString();
                if (!processedItems[selectedClient].Contains(itemStr))
                {
                    checkedListBox2.Items.Add(itemStr);
                    processedItems[selectedClient].Add(itemStr); // Add to processed items
                }
            }

            // Remove processed items from checkedListBox1 and clientAssociations
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                string itemToRemove = checkedListBox1.CheckedItems[i].ToString();
                checkedListBox1.Items.Remove(itemToRemove);
                clientAssociations[selectedClient].Remove(itemToRemove);
            }

            // Update the percentage
            UpdateProcessedPercentage();

            MessageBox.Show("Items successfully processed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void UpdateProcessedPercentage()
        {
            string selectedClient = cmbClients.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedClient)) return;

            int totalItems = 0;
            int processedItemsCount = 0;

            if (clientAssociations.ContainsKey(selectedClient))
            {
                totalItems += clientAssociations[selectedClient].Count;
            }

            if (processedItems.ContainsKey(selectedClient))
            {
                processedItemsCount = processedItems[selectedClient].Count;
                totalItems += processedItemsCount;
            }

            if (totalItems > 0)
            {
                double percentage = (double)processedItemsCount / totalItems * 100;
                lblPercent.Text = $"Processed: {percentage:F2}%";
            }
            else
            {
                lblPercent.Text = "Processed: 0%";
            }
        }
    }
}
