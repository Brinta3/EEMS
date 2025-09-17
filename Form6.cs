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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-Q0SB2E60\\SQLEXPRESS;Initial Catalog=MyEMS;Integrated Security=True;Encrypt=False";

            // Validate and parse inputs
            if (!int.TryParse(txtVehicleId.Text.Trim(), out int vehicleId))
            {
                MessageBox.Show("Invalid Vehicle ID.");
                return;
            }

            string vehicleType = txtVehicleType.Text.Trim();
            string tollStatus = txtTollStatus.Text.Trim();

            if (!DateTime.TryParse(txtEntryTime.Text.Trim(), out DateTime entryTime))
            {
                MessageBox.Show("Invalid Entry Time. Use format like yyyy-MM-dd HH:mm.");
                return;
            }

            if (!DateTime.TryParse(txtExitTime.Text.Trim(), out DateTime exitTime))
            {
                MessageBox.Show("Invalid Exit Time. Use format like yyyy-MM-dd HH:mm.");
                return;
            }

            if (entryTime > exitTime)
            {
                MessageBox.Show("Entry time cannot be after exit time.");
                return;
            }

            if (string.IsNullOrWhiteSpace(vehicleType) || string.IsNullOrWhiteSpace(tollStatus))
            {
                MessageBox.Show("Vehicle type and toll status are required.");
                return;
            }

            string query = "INSERT INTO VehicleInformation (vehicle_id, vehicle_type, toll_status, entry_time, exit_time) " +
                           "VALUES (@vehicle_id, @vehicle_type, @toll_status, @entry_time, @exit_time)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@vehicle_id", vehicleId);
                command.Parameters.AddWithValue("@vehicle_type", vehicleType);
                command.Parameters.AddWithValue("@toll_status", tollStatus);
                command.Parameters.AddWithValue("@entry_time", entryTime);
                command.Parameters.AddWithValue("@exit_time", exitTime);

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
