namespace EEMS
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblVehicleId;
        private TextBox txtVehicleId;
        private Label lblVehicleType;
        private TextBox txtVehicleType;
        private Label lblTollStatus;
        private TextBox txtTollStatus;
        private Label lblEntryTime;
        private TextBox txtEntryTime;
        private Label lblExitTime;
        private TextBox txtExitTime;
        private Button btnEnter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblVehicleId = new Label();
            txtVehicleId = new TextBox();
            lblVehicleType = new Label();
            txtVehicleType = new TextBox();
            lblTollStatus = new Label();
            txtTollStatus = new TextBox();
            lblEntryTime = new Label();
            txtEntryTime = new TextBox();
            lblExitTime = new Label();
            txtExitTime = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblVehicleId
            // 
            lblVehicleId.Location = new Point(30, 20);
            lblVehicleId.Name = "lblVehicleId";
            lblVehicleId.Size = new Size(100, 23);
            lblVehicleId.TabIndex = 0;
            lblVehicleId.Text = "Vehicle ID:";
            // 
            // txtVehicleId
            // 
            txtVehicleId.Location = new Point(150, 20);
            txtVehicleId.Name = "txtVehicleId";
            txtVehicleId.Size = new Size(150, 27);
            txtVehicleId.TabIndex = 1;
            // 
            // lblVehicleType
            // 
            lblVehicleType.Location = new Point(30, 60);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(100, 23);
            lblVehicleType.TabIndex = 2;
            lblVehicleType.Text = "Vehicle Type:";
            // 
            // txtVehicleType
            // 
            txtVehicleType.Location = new Point(150, 60);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(150, 27);
            txtVehicleType.TabIndex = 3;
            // 
            // lblTollStatus
            // 
            lblTollStatus.Location = new Point(30, 100);
            lblTollStatus.Name = "lblTollStatus";
            lblTollStatus.Size = new Size(100, 23);
            lblTollStatus.TabIndex = 4;
            lblTollStatus.Text = "Toll Status:";
            // 
            // txtTollStatus
            // 
            txtTollStatus.Location = new Point(150, 100);
            txtTollStatus.Name = "txtTollStatus";
            txtTollStatus.Size = new Size(150, 27);
            txtTollStatus.TabIndex = 5;
            // 
            // lblEntryTime
            // 
            lblEntryTime.Location = new Point(30, 140);
            lblEntryTime.Name = "lblEntryTime";
            lblEntryTime.Size = new Size(100, 23);
            lblEntryTime.TabIndex = 6;
            lblEntryTime.Text = "Entry Time:";
            // 
            // txtEntryTime
            // 
            txtEntryTime.Location = new Point(150, 140);
            txtEntryTime.Name = "txtEntryTime";
            txtEntryTime.Size = new Size(150, 27);
            txtEntryTime.TabIndex = 7;
            // 
            // lblExitTime
            // 
            lblExitTime.Location = new Point(30, 180);
            lblExitTime.Name = "lblExitTime";
            lblExitTime.Size = new Size(100, 23);
            lblExitTime.TabIndex = 8;
            lblExitTime.Text = "Exit Time:";
            // 
            // txtExitTime
            // 
            txtExitTime.Location = new Point(150, 180);
            txtExitTime.Name = "txtExitTime";
            txtExitTime.Size = new Size(150, 27);
            txtExitTime.TabIndex = 9;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(120, 230);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(100, 30);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Form6
            // 
            ClientSize = new Size(350, 290);
            Controls.Add(lblVehicleId);
            Controls.Add(txtVehicleId);
            Controls.Add(lblVehicleType);
            Controls.Add(txtVehicleType);
            Controls.Add(lblTollStatus);
            Controls.Add(txtTollStatus);
            Controls.Add(lblEntryTime);
            Controls.Add(txtEntryTime);
            Controls.Add(lblExitTime);
            Controls.Add(txtExitTime);
            Controls.Add(btnEnter);
            Name = "Form6";
            Text = "Vehicle Information";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
