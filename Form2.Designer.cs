namespace EEMS
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTrafficMonitor;
        private Button btnControlCentre;
        private Button btnTollBooth;
        private Button btnVehicle;
        private Button btnMaintenance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnTrafficMonitor = new Button();
            btnControlCentre = new Button();
            btnTollBooth = new Button();
            btnVehicle = new Button();
            btnMaintenance = new Button();
            SuspendLayout();
            // 
            // btnTrafficMonitor
            // 
            btnTrafficMonitor.Location = new Point(40, 30);
            btnTrafficMonitor.Name = "btnTrafficMonitor";
            btnTrafficMonitor.Size = new Size(200, 30);
            btnTrafficMonitor.TabIndex = 0;
            btnTrafficMonitor.Text = "Traffic Monitor";
            btnTrafficMonitor.UseVisualStyleBackColor = true;
            btnTrafficMonitor.Click += btnTrafficMonitor_Click;
            // 
            // btnControlCentre
            // 
            btnControlCentre.Location = new Point(40, 70);
            btnControlCentre.Name = "btnControlCentre";
            btnControlCentre.Size = new Size(200, 30);
            btnControlCentre.TabIndex = 1;
            btnControlCentre.Text = "Control Centre";
            btnControlCentre.UseVisualStyleBackColor = true;
            btnControlCentre.Click += btnControlCentre_Click;
            // 
            // btnTollBooth
            // 
            btnTollBooth.Location = new Point(40, 110);
            btnTollBooth.Name = "btnTollBooth";
            btnTollBooth.Size = new Size(200, 30);
            btnTollBooth.TabIndex = 2;
            btnTollBooth.Text = "Toll Booth";
            btnTollBooth.UseVisualStyleBackColor = true;
            btnTollBooth.Click += btnTollBooth_Click;
            // 
            // btnVehicle
            // 
            btnVehicle.Location = new Point(40, 150);
            btnVehicle.Name = "btnVehicle";
            btnVehicle.Size = new Size(200, 30);
            btnVehicle.TabIndex = 3;
            btnVehicle.Text = "Vehicle";
            btnVehicle.UseVisualStyleBackColor = true;
            btnVehicle.Click += btnVehicle_Click; // ✅ ADDED THIS LINE
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(40, 190);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(200, 30);
            btnMaintenance.TabIndex = 4;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click); // ✅ ADDED THIS LINE
            // 
            // Form2
            // 
            ClientSize = new Size(267, 261);
            Controls.Add(btnTrafficMonitor);
            Controls.Add(btnControlCentre);
            Controls.Add(btnTollBooth);
            Controls.Add(btnVehicle);
            Controls.Add(btnMaintenance);
            Name = "Form2";
            Text = "Dashboard - EEMS";
            ResumeLayout(false);
        }
    }
}
