using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EEMS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Connection string to your SQL Server database
            string connectionString = "Data Source=LAPTOP-Q0SB2E60\\SQLEXPRESS;Initial Catalog=MyEMS;Integrated Security=True;Encrypt=False";

            // Validate and retrieve input
            if (!int.TryParse(txtCentreId.Text.Trim(), out int centreId))
            {
                MessageBox.Show("Invalid Centre ID.");
                return;
            }

            if (!int.TryParse(txtActiveMonitor.Text.Trim(), out int activeMonitor))
            {
                MessageBox.Show("Invalid Active Monitor ID.");
                return;
            }

            string alert = txtAlert.Text.Trim();
            string operation = txtOperation.Text.Trim();

            if (string.IsNullOrWhiteSpace(alert) || string.IsNullOrWhiteSpace(operation))
            {
                MessageBox.Show("Alert and Operation fields cannot be empty.");
                return;
            }

            // SQL Insert statement
            string query = "INSERT INTO ControlCentre (centre_id, active_monitor, alert, operation) " +
                           "VALUES (@centre_id, @active_monitor, @alert, @operation)";

            // Insert logic
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@centre_id", centreId);
                command.Parameters.AddWithValue("@active_monitor", activeMonitor);
                command.Parameters.AddWithValue("@alert", alert);
                command.Parameters.AddWithValue("@operation", operation);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Data inserted successfully." : "Insert failed.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message);
                }
            }
        }
    }
}
