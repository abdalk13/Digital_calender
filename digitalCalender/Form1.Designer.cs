namespace DigitalCalendar
{
    partial class Form1
    {
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;

        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(20, 20);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;

            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(20, 200);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.TabIndex = 1;

            // 
            // lstEvents
            // 
            this.lstEvents.Location = new System.Drawing.Point(250, 20);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(200, 150);
            this.lstEvents.TabIndex = 2;

            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(250, 200);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(75, 23);
            this.btnAddEvent.TabIndex = 3;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);

            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(375, 200);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEvent.TabIndex = 4;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);

            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 230);
            this.lblTime.Name = "lblTime";
            this.lblTime.TabIndex = 5;

            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(100, 230);
            this.lblDate.Name = "lblDate";
            this.lblDate.TabIndex = 6;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Name = "Form1";
            this.Text = "Digital Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
