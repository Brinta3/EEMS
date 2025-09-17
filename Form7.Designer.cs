namespace EEMS
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTeamId;
        private TextBox txtTeamId;
        private Label lblSchedule;
        private TextBox txtSchedule;
        private Label lblAssignedZone;
        private TextBox txtAssignedZone;
        private Label lblReportStatus;
        private TextBox txtReportStatus;
        private Button btnEnter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTeamId = new Label();
            txtTeamId = new TextBox();
            lblSchedule = new Label();
            txtSchedule = new TextBox();
            lblAssignedZone = new Label();
            txtAssignedZone = new TextBox();
            lblReportStatus = new Label();
            txtReportStatus = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblTeamId
            // 
            lblTeamId.Location = new Point(30, 20);
            lblTeamId.Name = "lblTeamId";
            lblTeamId.Size = new Size(100, 23);
            lblTeamId.TabIndex = 0;
            lblTeamId.Text = "Team Id:";
            // 
            // txtTeamId
            // 
            txtTeamId.Location = new Point(150, 20);
            txtTeamId.Name = "txtTeamId";
            txtTeamId.Size = new Size(150, 27);
            txtTeamId.TabIndex = 1;
            // 
            // lblSchedule
            // 
            lblSchedule.Location = new Point(30, 60);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(100, 23);
            lblSchedule.TabIndex = 2;
            lblSchedule.Text = "Schedule:";
            // 
            // txtSchedule
            // 
            txtSchedule.Location = new Point(150, 60);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(150, 27);
            txtSchedule.TabIndex = 3;
            // 
            // lblAssignedZone
            // 
            lblAssignedZone.Location = new Point(30, 100);
            lblAssignedZone.Name = "lblAssignedZone";
            lblAssignedZone.Size = new Size(100, 23);
            lblAssignedZone.TabIndex = 4;
            lblAssignedZone.Text = "Assigned Zone:";
            // 
            // txtAssignedZone
            // 
            txtAssignedZone.Location = new Point(150, 100);
            txtAssignedZone.Name = "txtAssignedZone";
            txtAssignedZone.Size = new Size(150, 27);
            txtAssignedZone.TabIndex = 5;
            // 
            // lblReportStatus
            // 
            lblReportStatus.Location = new Point(30, 140);
            lblReportStatus.Name = "lblReportStatus";
            lblReportStatus.Size = new Size(100, 23);
            lblReportStatus.TabIndex = 6;
            lblReportStatus.Text = "Report Status:";
            // 
            // txtReportStatus
            // 
            txtReportStatus.Location = new Point(150, 140);
            txtReportStatus.Name = "txtReportStatus";
            txtReportStatus.Size = new Size(150, 27);
            txtReportStatus.TabIndex = 7;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(120, 180);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(100, 30);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Form7
            // 
            ClientSize = new Size(350, 230);
            Controls.Add(lblTeamId);
            Controls.Add(txtTeamId);
            Controls.Add(lblSchedule);
            Controls.Add(txtSchedule);
            Controls.Add(lblAssignedZone);
            Controls.Add(txtAssignedZone);
            Controls.Add(lblReportStatus);
            Controls.Add(txtReportStatus);
            Controls.Add(btnEnter);
            Name = "Form7";
            Text = "Team Schedule Information";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
