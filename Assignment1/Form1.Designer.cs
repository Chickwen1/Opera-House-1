namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.txtTicketsAvailable = new System.Windows.Forms.TextBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.txtConcessions = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.lblConcessions = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.btnBuyTickets = new System.Windows.Forms.Button();
            this.btnReturnTickets = new System.Windows.Forms.Button();
            this.txtReturnTickets = new System.Windows.Forms.TextBox();
            this.txtBuyTickets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfTickets = new System.Windows.Forms.Label();
            this.lblCurrentEvent = new System.Windows.Forms.Label();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(63, 110);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(75, 23);
            this.btnNewEvent.TabIndex = 0;
            this.btnNewEvent.Text = "New Event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // txtTicketsAvailable
            // 
            this.txtTicketsAvailable.Location = new System.Drawing.Point(225, 74);
            this.txtTicketsAvailable.Name = "txtTicketsAvailable";
            this.txtTicketsAvailable.Size = new System.Drawing.Size(100, 20);
            this.txtTicketsAvailable.TabIndex = 3;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(411, 74);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTicketPrice.TabIndex = 4;
            // 
            // txtConcessions
            // 
            this.txtConcessions.Location = new System.Drawing.Point(64, 74);
            this.txtConcessions.Name = "txtConcessions";
            this.txtConcessions.Size = new System.Drawing.Size(100, 20);
            this.txtConcessions.TabIndex = 6;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(60, 6);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(72, 13);
            this.lblEvent.TabIndex = 7;
            this.lblEvent.Text = "Create Event:";
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Location = new System.Drawing.Point(222, 9);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(55, 13);
            this.lblPerformer.TabIndex = 8;
            this.lblPerformer.Text = "Performer:";
            // 
            // lblConcessions
            // 
            this.lblConcessions.AutoSize = true;
            this.lblConcessions.Location = new System.Drawing.Point(61, 55);
            this.lblConcessions.Name = "lblConcessions";
            this.lblConcessions.Size = new System.Drawing.Size(113, 13);
            this.lblConcessions.TabIndex = 9;
            this.lblConcessions.Text = "Concessions (Yes/No)";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(408, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(33, 13);
            this.lblDateTime.TabIndex = 10;
            this.lblDateTime.Text = "Date:";
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Location = new System.Drawing.Point(222, 55);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(148, 13);
            this.lblTicketsSold.TabIndex = 11;
            this.lblTicketsSold.Text = "How Many Tickets Available?";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(408, 55);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(86, 13);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Price Per Ticket:";
            // 
            // txtPerformer
            // 
            this.txtPerformer.Location = new System.Drawing.Point(225, 25);
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(100, 20);
            this.txtPerformer.TabIndex = 14;
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(63, 25);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(100, 20);
            this.txtEvent.TabIndex = 15;
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpNewDate.Location = new System.Drawing.Point(411, 25);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(103, 20);
            this.dtpNewDate.TabIndex = 16;
            this.dtpNewDate.Value = new System.DateTime(2017, 9, 24, 15, 5, 28, 0);
            // 
            // lstEvent
            // 
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.Location = new System.Drawing.Point(64, 248);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(450, 95);
            this.lstEvent.TabIndex = 17;
            // 
            // btnBuyTickets
            // 
            this.btnBuyTickets.Location = new System.Drawing.Point(64, 349);
            this.btnBuyTickets.Name = "btnBuyTickets";
            this.btnBuyTickets.Size = new System.Drawing.Size(75, 23);
            this.btnBuyTickets.TabIndex = 18;
            this.btnBuyTickets.Text = "Buy Tickets";
            this.btnBuyTickets.UseVisualStyleBackColor = true;
            this.btnBuyTickets.Click += new System.EventHandler(this.btnBuyTickets_Click_1);
            // 
            // btnReturnTickets
            // 
            this.btnReturnTickets.Location = new System.Drawing.Point(145, 349);
            this.btnReturnTickets.Name = "btnReturnTickets";
            this.btnReturnTickets.Size = new System.Drawing.Size(91, 23);
            this.btnReturnTickets.TabIndex = 19;
            this.btnReturnTickets.Text = "Return Tickets";
            this.btnReturnTickets.UseVisualStyleBackColor = true;
            this.btnReturnTickets.Click += new System.EventHandler(this.btnReturnTickets_Click);
            // 
            // txtReturnTickets
            // 
            this.txtReturnTickets.Location = new System.Drawing.Point(411, 205);
            this.txtReturnTickets.Name = "txtReturnTickets";
            this.txtReturnTickets.Size = new System.Drawing.Size(100, 20);
            this.txtReturnTickets.TabIndex = 20;
            // 
            // txtBuyTickets
            // 
            this.txtBuyTickets.Location = new System.Drawing.Point(225, 206);
            this.txtBuyTickets.Name = "txtBuyTickets";
            this.txtBuyTickets.Size = new System.Drawing.Size(100, 20);
            this.txtBuyTickets.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "How Many Tickets Do You Want To Return?";
            // 
            // lblNumberOfTickets
            // 
            this.lblNumberOfTickets.AutoSize = true;
            this.lblNumberOfTickets.Location = new System.Drawing.Point(222, 189);
            this.lblNumberOfTickets.Name = "lblNumberOfTickets";
            this.lblNumberOfTickets.Size = new System.Drawing.Size(170, 13);
            this.lblNumberOfTickets.TabIndex = 23;
            this.lblNumberOfTickets.Text = "How Many Tickets Do You Want?";
            // 
            // lblCurrentEvent
            // 
            this.lblCurrentEvent.AutoSize = true;
            this.lblCurrentEvent.Location = new System.Drawing.Point(61, 189);
            this.lblCurrentEvent.Name = "lblCurrentEvent";
            this.lblCurrentEvent.Size = new System.Drawing.Size(77, 13);
            this.lblCurrentEvent.TabIndex = 24;
            this.lblCurrentEvent.Text = "Choose Event:";
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(64, 205);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(121, 21);
            this.cboEvent.TabIndex = 25;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 391);
            this.Controls.Add(this.cboEvent);
            this.Controls.Add(this.lblCurrentEvent);
            this.Controls.Add(this.lblNumberOfTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuyTickets);
            this.Controls.Add(this.txtReturnTickets);
            this.Controls.Add(this.btnReturnTickets);
            this.Controls.Add(this.btnBuyTickets);
            this.Controls.Add(this.lstEvent);
            this.Controls.Add(this.dtpNewDate);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtPerformer);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTicketsSold);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblConcessions);
            this.Controls.Add(this.lblPerformer);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.txtConcessions);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.txtTicketsAvailable);
            this.Controls.Add(this.btnNewEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.TextBox txtTicketsAvailable;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.TextBox txtConcessions;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.Label lblConcessions;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.ListBox lstEvent;
        private System.Windows.Forms.Button btnBuyTickets;
        private System.Windows.Forms.Button btnReturnTickets;
        private System.Windows.Forms.TextBox txtReturnTickets;
        private System.Windows.Forms.TextBox txtBuyTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfTickets;
        private System.Windows.Forms.Label lblCurrentEvent;
        private System.Windows.Forms.ComboBox cboEvent;
    }
}

