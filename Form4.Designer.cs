namespace EEMS
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblCentreId;
        private TextBox txtCentreId;
        private Label lblActiveMonitor;
        private TextBox txtActiveMonitor;
        private Label lblAlert;
        private TextBox txtAlert;
        private Label lblOperation;
        private TextBox txtOperation;
        private Button btnEnter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCentreId = new Label();
            txtCentreId = new TextBox();
            lblActiveMonitor = new Label();
            txtActiveMonitor = new TextBox();
            lblAlert = new Label();
            txtAlert = new TextBox();
            lblOperation = new Label();
            txtOperation = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblCentreId
            // 
            lblCentreId.Location = new Point(30, 20);
            lblCentreId.Name = "lblCentreId";
            lblCentreId.Size = new Size(100, 23);
            lblCentreId.TabIndex = 0;
            lblCentreId.Text = "Centre ID:";
            // 
            // txtCentreId
            // 
            txtCentreId.Location = new Point(150, 20);
            txtCentreId.Name = "txtCentreId";
            txtCentreId.Size = new Size(150, 27);
            txtCentreId.TabIndex = 1;
            // 
            // lblActiveMonitor
            // 
            lblActiveMonitor.Location = new Point(30, 60);
            lblActiveMonitor.Name = "lblActiveMonitor";
            lblActiveMonitor.Size = new Size(100, 23);
            lblActiveMonitor.TabIndex = 2;
            lblActiveMonitor.Text = "Active Monitor:";
            // 
            // txtActiveMonitor
            // 
            txtActiveMonitor.Location = new Point(150, 60);
            txtActiveMonitor.Name = "txtActiveMonitor";
            txtActiveMonitor.Size = new Size(150, 27);
            txtActiveMonitor.TabIndex = 3;
            // 
            // lblAlert
            // 
            lblAlert.Location = new Point(30, 100);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(100, 23);
            lblAlert.TabIndex = 4;
            lblAlert.Text = "Alert:";
            // 
            // txtAlert
            // 
            txtAlert.Location = new Point(150, 100);
            txtAlert.Name = "txtAlert";
            txtAlert.Size = new Size(150, 27);
            txtAlert.TabIndex = 5;
            // 
            // lblOperation
            // 
            lblOperation.Location = new Point(30, 140);
            lblOperation.Name = "lblOperation";
            lblOperation.Size = new Size(100, 23);
            lblOperation.TabIndex = 6;
            lblOperation.Text = "Operation:";
            // 
            // txtOperation
            // 
            txtOperation.Location = new Point(150, 140);
            txtOperation.Name = "txtOperation";
            txtOperation.Size = new Size(150, 27);
            txtOperation.TabIndex = 7;
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
            // Form4
            // 
            ClientSize = new Size(350, 250);
            Controls.Add(lblCentreId);
            Controls.Add(txtCentreId);
            Controls.Add(lblActiveMonitor);
            Controls.Add(txtActiveMonitor);
            Controls.Add(lblAlert);
            Controls.Add(txtAlert);
            Controls.Add(lblOperation);
            Controls.Add(txtOperation);
            Controls.Add(btnEnter);
            Name = "Form4";
            Text = "Control Centre";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
