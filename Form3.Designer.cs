namespace EEMS
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUnitId;
        private TextBox txtUnitId;
        private Label lblSensorType;
        private TextBox txtSensorType;
        private Label lblTrafficData;
        private TextBox txtTrafficData;
        private Label lblIncident;
        private TextBox txtIncident;
        private Button btnEnter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUnitId = new Label();
            txtUnitId = new TextBox();
            lblSensorType = new Label();
            txtSensorType = new TextBox();
            lblTrafficData = new Label();
            txtTrafficData = new TextBox();
            lblIncident = new Label();
            txtIncident = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblUnitId
            // 
            lblUnitId.Location = new Point(30, 20);
            lblUnitId.Name = "lblUnitId";
            lblUnitId.Size = new Size(100, 23);
            lblUnitId.TabIndex = 0;
            lblUnitId.Text = "Unit ID:";
            // 
            // txtUnitId
            // 
            txtUnitId.Location = new Point(150, 20);
            txtUnitId.Name = "txtUnitId";
            txtUnitId.Size = new Size(150, 27);
            txtUnitId.TabIndex = 1;
            // 
            // lblSensorType
            // 
            lblSensorType.Location = new Point(30, 60);
            lblSensorType.Name = "lblSensorType";
            lblSensorType.Size = new Size(100, 23);
            lblSensorType.TabIndex = 2;
            lblSensorType.Text = "Sensor Type:";
            // 
            // txtSensorType
            // 
            txtSensorType.Location = new Point(150, 60);
            txtSensorType.Name = "txtSensorType";
            txtSensorType.Size = new Size(150, 27);
            txtSensorType.TabIndex = 3;
            // 
            // lblTrafficData
            // 
            lblTrafficData.Location = new Point(30, 100);
            lblTrafficData.Name = "lblTrafficData";
            lblTrafficData.Size = new Size(100, 23);
            lblTrafficData.TabIndex = 4;
            lblTrafficData.Text = "Traffic Data:";
            // 
            // txtTrafficData
            // 
            txtTrafficData.Location = new Point(150, 100);
            txtTrafficData.Name = "txtTrafficData";
            txtTrafficData.Size = new Size(150, 27);
            txtTrafficData.TabIndex = 5;
            // 
            // lblIncident
            // 
            lblIncident.Location = new Point(30, 140);
            lblIncident.Name = "lblIncident";
            lblIncident.Size = new Size(100, 23);
            lblIncident.TabIndex = 6;
            lblIncident.Text = "Incident:";
            // 
            // txtIncident
            // 
            txtIncident.Location = new Point(150, 140);
            txtIncident.Name = "txtIncident";
            txtIncident.Size = new Size(150, 27);
            txtIncident.TabIndex = 7;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(120, 190);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(100, 30);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "Enter";
            btnEnter.Click += btnEnter_Click;
            // 
            // Form3
            // 
            ClientSize = new Size(350, 250);
            Controls.Add(lblUnitId);
            Controls.Add(txtUnitId);
            Controls.Add(lblSensorType);
            Controls.Add(txtSensorType);
            Controls.Add(lblTrafficData);
            Controls.Add(txtTrafficData);
            Controls.Add(lblIncident);
            Controls.Add(txtIncident);
            Controls.Add(btnEnter);
            Name = "Form3";
            Text = "Traffic Monitor Input";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
