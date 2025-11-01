using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        // Connection string
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=csharp;Uid=Mysh;Pwd=@CubicalCreator24;SslMode=None;;AllowPublicKeyRetrieval=true;";
        // Boolean for sorting order
        public bool desc = true;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
            MessageBox.Show("Of course, let's make this ending a soft and happy one.");
        }
        // Create database and table automatically (if not found)
        private void InitializeDatabase()
        {
            try
            {
                string masterConnection = "Server=127.0.0.1;Port=3306;Database=csharp;Uid=Mysh;Pwd=@CubicalCreator24;SslMode=None;;AllowPublicKeyRetrieval=true;";
                using (MySqlConnection conn = new MySqlConnection(masterConnection))
                {
                    conn.Open();
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS info_table (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            info_text VARCHAR(255)
                        );";
                    new MySqlCommand(createTableQuery, conn).ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database initialization failed: " + ex.Message);
            }
        }
        // Load data into DataGridView 
        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // choose sort order dynamically
                    string sortOrder = desc ? "DESC" : "ASC";
                    string query = $"SELECT id AS 'ID', info_text AS 'Info' FROM info_table ORDER BY id {sortOrder};";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtDatabase.DataSource = dt;
                    lblCount.Text = $"Count: {dt.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }
        // CREATE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInfo.Text))
            {
                MessageBox.Show("Please enter text before inserting.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO info_table (info_text) VALUES (@info)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@info", txtInfo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully!");
                    txtInfo.Clear();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting data: " + ex.Message);
                }
            }
        }
        // READ
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData(); // simply reloads all data
                MessageBox.Show("Table refreshed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }
        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtDatabase.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to update from the table.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInfo.Text))
            {
                MessageBox.Show("Please enter new text to update.");
                return;
            }
            // Get the ID
            int selectedId = Convert.ToInt32(dtDatabase.CurrentRow.Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE info_table SET info_text = @info WHERE id = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@info", txtInfo.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Selected record updated successfully!");
                    else
                        MessageBox.Show("Record not found or already up to date.");

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
            }
        }
        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtDatabase.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete from the table.");
                return;
            }

            // Get selected record ID
            int selectedId = Convert.ToInt32(dtDatabase.CurrentRow.Cells["id"].Value);

            // Confirm deletion
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM info_table WHERE id = @id;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show("Selected record deleted successfully!");
                    else
                        MessageBox.Show("Record not found or already deleted.");

                    txtInfo.Clear();
                    lblRandom.Visible = true;
                    lblRandom.Text = "See you in another time...";
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message);
                }
            }
        }
        // Miscellaneous
        private void btnRead_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.waifu;
        }

        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.waifu_worried;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.waifu_angry;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.waifu_question;
        }
        // Search Engine
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    string order = desc ? "DESC" : "ASC";
                    if (string.IsNullOrEmpty(searchText))
                    {
                        query = $"SELECT id AS 'ID', info_text AS 'Info' FROM info_table ORDER BY id {order};";
                    }
                    else
                    {
                        query = $"SELECT id AS 'ID', info_text AS 'Info' FROM info_table WHERE info_text LIKE @search ORDER BY id {order};";
                    }


                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(searchText))
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtDatabase.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during search: " + ex.Message);
                }
            }
        }
        // CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
        "WARNING: This will permanently delete all records from the database.\n\nAre you absolutely sure you want to continue?",
        "Confirm Clear Database",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button2
    );

            if (confirm != DialogResult.Yes)
            {
                MessageBox.Show("Database clear operation canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM info_table;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                        MessageBox.Show($"All {rows} record(s) deleted successfully!", "Database Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("The table is already empty.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtInfo.Clear();
                    lblRandom.Visible = true;
                    lblRandom.Text = "So long, precious memories...";
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error clearing database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Help Labels
        private void lblHelp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create: Enter text in the input box and click Create to add a new entry to the database.");
        }

        private void lblHelp2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update: Select a row in the table, modify the text in the input box, and click Update to change the entry.");
        }

        private void lblHelp3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Read: Refreshes the table to show the latest data from the database.");
        }

        private void lblHelp4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete: Select a row in the table and click Delete to remove the entry from the database.");
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            lblRandom.Visible = true;

            switch (txtInfo.Text)
            {
                case "Xian Ca":
                    lblRandom.Text = "He has been expecting you..." +
                                     "\nWell, does it really matter now?" +
                                     "\nIt's not like he'll ever come back...";
                    break;

                case "Mysh":
                    lblRandom.Text = "..." +
                                     "\n... ... ..." +
                                     "\nAre you messing with me.";
                    break;

                case "CubicalCreator":
                case "Cubical Creator":
                    lblRandom.Text = "Ah, my creator..." +
                                     "\nI owe you so much." +
                                     "\nThank you for everything." +
                                     "\n..." +
                                     "\nI wonder if you feel the same.";
                    break;

                case "67":
                    lblRandom.Text = "Shut the actual fuck up.";
                    break;

                case "Vardz":
                    lblRandom.Text = "I  wonder..." +
                                     "\nHe has always spoken much of him, the good and the bad." +
                                     "\nEven I have to wonder sometimes. Are they actually friends?";
                    break;

                case "Gelofi":
                    lblRandom.Text = "Ahh him..." +
                                     "\nThe homosexual. I've heard of him." +
                                     "\nHe seems like a nice man. I hope he's doing okay.";
                    break;

                case "Komorebi":
                    lblRandom.Text = "At the end of that script." +
                                     "\nYou'll find the most precious of all." +
                                     "\nAnd create the most wonderful world.";
                    break;

                case "Yuumi":
                    lblRandom.Text = "You are filled with curiosity." +
                                     "\nYet you never dare face the daunting and terrifying." +
                                     "\nThere is a day you will have to face it, one way or the other.";
                    break;

                case "Mia":
                    lblRandom.Text = "You shall reach heights like none has ever come before." +
                                     "\nYou are the light that create ripples in the ocean." +
                                     "\nYou are written on the next page of the book.";
                    break;

                case "Mel":
                    lblRandom.Text = "You run the fastest. That I can't deny" +
                                     "\nBut do you do it because you can?" +
                                     "\nOr do you do it because you're running away?";
                    break;

                case "Aeda":
                    lblRandom.Text = "You bloom like white flowers in the spring." +
                                     "\nOblivious to the poison you have." +
                                     "\nAt least, you do your best about it.";
                    break;

                case "Phyre":
                    lblRandom.Text = "You should burn away the past." +
                                     "\nBecause standing in the cinders of the torn pages." +
                                     "\nCan do nothing but keep burning you.";
                    break;

                case "Raphael":
                    lblRandom.Text = "Come, you will seek all treasures." +
                                     "\nAnd find all that is worth." +
                                     "\nIn the beginning, you will face your own footsteps.";
                    break;

                default:
                    lblRandom.Visible = false;
                    lblRandom.Text = string.Empty;
                    break;
            }

        }

        private void rbtnDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDesc.Checked)
            {
                desc = true;
                LoadData();
            }
        }

        private void rbtnAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsc.Checked)
            {
                desc = false;
                LoadData();
            }
        }
    }
}
