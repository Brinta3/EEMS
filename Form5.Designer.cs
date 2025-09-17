namespace EEMS
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBoothId;
        private TextBox txtBoothId;
        private Label lblOperatorId;
        private TextBox txtOperatorId;
        private Label lblTollRate;
        private TextBox txtTollRate;
        private Label lblCollectedAmount;
        private TextBox txtCollectedAmount;
        private Label lblLocation;
        private TextBox txtLocation;
        private Button btnEnter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBoothId = new Label();
            txtBoothId = new TextBox();
            lblOperatorId = new Label();
            txtOperatorId = new TextBox();
            lblTollRate = new Label();
            txtTollRate = new TextBox();
            lblCollectedAmount = new Label();
            txtCollectedAmount = new TextBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblBoothId
            // 
            lblBoothId.Location = new Point(30, 20);
            lblBoothId.Name = "lblBoothId";
            lblBoothId.Size = new Size(100, 23);
            lblBoothId.TabIndex = 0;
            lblBoothId.Text = "Booth ID:";
            // 
            // txtBoothId
            // 
            txtBoothId.Location = new Point(150, 20);
            txtBoothId.Name = "txtBoothId";
            txtBoothId.Size = new Size(150, 27);
            txtBoothId.TabIndex = 1;
            // 
            // lblOperatorId
            // 
            lblOperatorId.Location = new Point(30, 60);
            lblOperatorId.Name = "lblOperatorId";
            lblOperatorId.Size = new Size(100, 23);
            lblOperatorId.TabIndex = 2;
            lblOperatorId.Text = "Operator ID:";
            // 
            // txtOperatorId
            // 
            txtOperatorId.Location = new Point(150, 60);
            txtOperatorId.Name = "txtOperatorId";
            txtOperatorId.Size = new Size(150, 27);
            txtOperatorId.TabIndex = 3;
            // 
            // lblTollRate
            // 
            lblTollRate.Location = new Point(30, 100);
            lblTollRate.Name = "lblTollRate";
            lblTollRate.Size = new Size(100, 23);
            lblTollRate.TabIndex = 4;
            lblTollRate.Text = "Toll Rate:";
            // 
            // txtTollRate
            // 
            txtTollRate.Location = new Point(150, 100);
            txtTollRate.Name = "txtTollRate";
            txtTollRate.Size = new Size(150, 27);
            txtTollRate.TabIndex = 5;
            // 
            // lblCollectedAmount
            // 
            lblCollectedAmount.Location = new Point(30, 140);
            lblCollectedAmount.Name = "lblCollectedAmount";
            lblCollectedAmount.Size = new Size(120, 23);
            lblCollectedAmount.TabIndex = 6;
            lblCollectedAmount.Text = "Collected Amount:";
            // 
            // txtCollectedAmount
            // 
            txtCollectedAmount.Location = new Point(150, 140);
            txtCollectedAmount.Name = "txtCollectedAmount";
            txtCollectedAmount.Size = new Size(150, 27);
            txtCollectedAmount.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.Location = new Point(30, 180);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(100, 23);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(150, 180);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(150, 27);
            txtLocation.TabIndex = 9;
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
            // Form5
            // 
            ClientSize = new Size(350, 290);
            Controls.Add(lblBoothId);
            Controls.Add(txtBoothId);
            Controls.Add(lblOperatorId);
            Controls.Add(txtOperatorId);
            Controls.Add(lblTollRate);
            Controls.Add(txtTollRate);
            Controls.Add(lblCollectedAmount);
            Controls.Add(txtCollectedAmount);
            Controls.Add(lblLocation);
            Controls.Add(txtLocation);
            Controls.Add(btnEnter);
            Name = "Form5";
            Text = "Toll Booth Information";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
