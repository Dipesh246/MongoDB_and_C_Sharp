using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDatabase = databaselist.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedDatabase))
            {
                var collections = DatabaseUtility.GetCollections(selectedDatabase);
                collectionList.Items.Clear();
                collectionList.Items.AddRange(collections.ToArray());

            }
        }

        private void showdbbtn_Click(object sender, EventArgs e)
        {
            var databases = DatabaseUtility.GetDatabaseNames();
            databaselist.Items.Clear();
            databaselist.Items.AddRange(databases.ToArray());
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void createcolbtn_Click(object sender, EventArgs e)
        {
            using (var form = new CreateCollectionForm())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    string databaseName = databaselist.SelectedItem?.ToString();
                    if(string.IsNullOrEmpty(databaseName))
                    {
                        MessageBox.Show("Please select a database first.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string collectionName = form.CollectionName;

                    try
                    {
                        DatabaseUtility.CreateCollection(databaseName, collectionName);
                        MessageBox.Show($"Collection '{collectionName}' created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        collectionList.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deletecolbtn_Click(object sender, EventArgs e)
        {
            string databaseName = databaselist.SelectedItem?.ToString();
            string collectionName = collectionList.SelectedItem?.ToString();
            if(string.IsNullOrEmpty(databaseName))
            {
                MessageBox.Show("Please select a database first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(collectionName))
            {
                MessageBox.Show("Please select a collection to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete the collection '{collectionName}'?","Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    DatabaseUtility.DeleteCollection(databaseName, collectionName);
                    MessageBox.Show($"Collection '{collectionName}' deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    collectionList.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
