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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-Q0SB2E60\\SQLEXPRESS;Initial Catalog=MyEMS;Integrated Security=True;Encrypt=False";

            // Validate and parse inputs
            if (!int.TryParse(txtTeamId.Text.Trim(), out int teamId))
            {
                MessageBox.Show("Invalid Team ID.");
                return;
            }

            if (!DateTime.TryParse(txtSchedule.Text.Trim(), out DateTime schedule))
            {
                MessageBox.Show("Invalid schedule. Use a valid date-time format (e.g., 2025-05-11 14:30).");
                return;
            }

            string assignedZone = txtAssignedZone.Text.Trim();
            string reportStatus = txtReportStatus.Text.Trim();

            if (string.IsNullOrWhiteSpace(assignedZone) || string.IsNullOrWhiteSpace(reportStatus))
            {
                MessageBox.Show("Assigned zone and report status are required.");
                return;
            }

            // Insert query
            string query = "INSERT INTO TeamSchedule (team_id, schedule, assigned_zone, report_status) " +
                           "VALUES (@team_id, @schedule, @assigned_zone, @report_status)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@team_id", teamId);
                command.Parameters.AddWithValue("@schedule", schedule);
                command.Parameters.AddWithValue("@assigned_zone", assignedZone);
                command.Parameters.AddWithValue("@report_status", reportStatus);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Team schedule inserted successfully." : "Insert failed.");
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