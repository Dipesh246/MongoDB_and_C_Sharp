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
            string selectedDatabase = listBox1.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedDatabase))
            {
                var result = MessageBox.Show($"Do you want to proceed with: {selectedDatabase}?", "Confirmation", MessageBoxButtons.YesNo);
                var collections = DatabaseUtility.GetCollections(selectedDatabase);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(collections.ToArray());

            }
        }

        private void showdbbtn_Click(object sender, EventArgs e)
        {
            var databases = DatabaseUtility.GetDatabaseNames();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(databases.ToArray());
        }
    }
}
