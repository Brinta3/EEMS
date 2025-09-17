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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-Q0SB2E60\\SQLEXPRESS;Initial Catalog=MyEMS;Integrated Security=True;Encrypt=False";

            // Validate inputs
            if (!int.TryParse(txtBoothId.Text.Trim(), out int boothId))
            {
                MessageBox.Show("Invalid Booth ID.");
                return;
            }

            if (!int.TryParse(txtOperatorId.Text.Trim(), out int operatorId))
            {
                MessageBox.Show("Invalid Operator ID.");
                return;
            }

            if (!decimal.TryParse(txtTollRate.Text.Trim(), out decimal tollRate))
            {
                MessageBox.Show("Invalid Toll Rate.");
                return;
            }

            if (!decimal.TryParse(txtCollectedAmount.Text.Trim(), out decimal collectedAmount))
            {
                MessageBox.Show("Invalid Collected Amount.");
                return;
            }

            string location = txtLocation.Text.Trim();
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Location cannot be empty.");
                return;
            }

            // SQL INSERT
            string query = "INSERT INTO TollBooth (booth_id, operator_id, toll_rate, collected_amount, location) " +
                           "VALUES (@booth_id, @operator_id, @toll_rate, @collected_amount, @location)";

            // Execute INSERT
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@booth_id", boothId);
                command.Parameters.AddWithValue("@operator_id", operatorId);
                command.Parameters.AddWithValue("@toll_rate", tollRate);
                command.Parameters.AddWithValue("@collected_amount", collectedAmount);
                command.Parameters.AddWithValue("@location", location);

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
