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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Your actual connection string
            string connectionString = "Data Source=LAPTOP-Q0SB2E60\\SQLEXPRESS;Initial Catalog=MyEMS;Integrated Security=True;Encrypt=False";

            // Validate and collect input data
            if (!int.TryParse(txtUnitId.Text.Trim(), out int unitId))
            {
                MessageBox.Show("Invalid Unit ID. Please enter a number.");
                return;
            }

            string sensorType = txtSensorType.Text.Trim();
            string trafficData = txtTrafficData.Text.Trim();
            string incident = txtIncident.Text.Trim();

            if (string.IsNullOrWhiteSpace(sensorType) ||
                string.IsNullOrWhiteSpace(trafficData) ||
                string.IsNullOrWhiteSpace(incident))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // SQL Insert command
            string query = "INSERT INTO TrafficMonitor (unit_id, sensor_type, traffic_data, incident) " +
                           "VALUES (@unit_id, @sensor_type, @traffic_data, @incident)";

            // Execute database operation
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@unit_id", unitId);
                command.Parameters.AddWithValue("@sensor_type", sensorType);
                command.Parameters.AddWithValue("@traffic_data", trafficData);
                command.Parameters.AddWithValue("@incident", incident);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Data inserted successfully." : "No data was inserted.");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message);
                }
            }
        }
    }
}
