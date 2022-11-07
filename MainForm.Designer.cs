namespace PartyOrganizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newPartyGroupBox = new System.Windows.Forms.GroupBox();
            this.createListButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feePerPersonBox = new System.Windows.Forms.TextBox();
            this.costPerPersonBox = new System.Windows.Forms.TextBox();
            this.maxNmrOfGuestsBox = new System.Windows.Forms.TextBox();
            this.inviteGuestBox = new System.Windows.Forms.GroupBox();
            this.addGuestButton = new System.Windows.Forms.Button();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrOfGuestsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.surplusDeficitBox = new System.Windows.Forms.TextBox();
            this.totalFeesBox = new System.Windows.Forms.TextBox();
            this.totalCostBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.guestListBox = new System.Windows.Forms.ListBox();
            this.newPartyGroupBox.SuspendLayout();
            this.inviteGuestBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPartyGroupBox
            // 
            this.newPartyGroupBox.Controls.Add(this.createListButton);
            this.newPartyGroupBox.Controls.Add(this.label4);
            this.newPartyGroupBox.Controls.Add(this.label3);
            this.newPartyGroupBox.Controls.Add(this.label1);
            this.newPartyGroupBox.Controls.Add(this.feePerPersonBox);
            this.newPartyGroupBox.Controls.Add(this.costPerPersonBox);
            this.newPartyGroupBox.Controls.Add(this.maxNmrOfGuestsBox);
            this.newPartyGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newPartyGroupBox.Location = new System.Drawing.Point(24, 40);
            this.newPartyGroupBox.Name = "newPartyGroupBox";
            this.newPartyGroupBox.Size = new System.Drawing.Size(441, 331);
            this.newPartyGroupBox.TabIndex = 0;
            this.newPartyGroupBox.TabStop = false;
            this.newPartyGroupBox.Text = "New Party";
            // 
            // createListButton
            // 
            this.createListButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createListButton.Location = new System.Drawing.Point(90, 243);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(240, 62);
            this.createListButton.TabIndex = 4;
            this.createListButton.Text = "Create List";
            this.createListButton.UseVisualStyleBackColor = true;
            this.createListButton.Click += new System.EventHandler(this.createListButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fee Per Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costs Per Person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Number of Guests";
            // 
            // feePerPersonBox
            // 
            this.feePerPersonBox.Location = new System.Drawing.Point(261, 182);
            this.feePerPersonBox.Name = "feePerPersonBox";
            this.feePerPersonBox.Size = new System.Drawing.Size(145, 39);
            this.feePerPersonBox.TabIndex = 2;
            // 
            // costPerPersonBox
            // 
            this.costPerPersonBox.Location = new System.Drawing.Point(261, 114);
            this.costPerPersonBox.Name = "costPerPersonBox";
            this.costPerPersonBox.Size = new System.Drawing.Size(145, 39);
            this.costPerPersonBox.TabIndex = 2;
            // 
            // maxNmrOfGuestsBox
            // 
            this.maxNmrOfGuestsBox.Location = new System.Drawing.Point(261, 50);
            this.maxNmrOfGuestsBox.Name = "maxNmrOfGuestsBox";
            this.maxNmrOfGuestsBox.Size = new System.Drawing.Size(145, 39);
            this.maxNmrOfGuestsBox.TabIndex = 1;
            // 
            // inviteGuestBox
            // 
            this.inviteGuestBox.Controls.Add(this.addGuestButton);
            this.inviteGuestBox.Controls.Add(this.lastNameBox);
            this.inviteGuestBox.Controls.Add(this.firstNameBox);
            this.inviteGuestBox.Controls.Add(this.label5);
            this.inviteGuestBox.Controls.Add(this.label6);
            this.inviteGuestBox.Location = new System.Drawing.Point(30, 396);
            this.inviteGuestBox.Name = "inviteGuestBox";
            this.inviteGuestBox.Size = new System.Drawing.Size(435, 240);
            this.inviteGuestBox.TabIndex = 2;
            this.inviteGuestBox.TabStop = false;
            this.inviteGuestBox.Text = "Invite Guest";
            // 
            // addGuestButton
            // 
            this.addGuestButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addGuestButton.Location = new System.Drawing.Point(84, 172);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(240, 62);
            this.addGuestButton.TabIndex = 6;
            this.addGuestButton.Text = "Add Guest";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(182, 109);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(218, 39);
            this.lastNameBox.TabIndex = 3;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(182, 56);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(218, 39);
            this.firstNameBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            // 
            // nmrOfGuestsBox
            // 
            this.nmrOfGuestsBox.Location = new System.Drawing.Point(285, 684);
            this.nmrOfGuestsBox.Name = "nmrOfGuestsBox";
            this.nmrOfGuestsBox.Size = new System.Drawing.Size(161, 39);
            this.nmrOfGuestsBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(49, 691);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of Guests";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(48, 816);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Surplus/Deficit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(48, 772);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Fees";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(49, 731);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Cost";
            // 
            // surplusDeficitBox
            // 
            this.surplusDeficitBox.Location = new System.Drawing.Point(285, 821);
            this.surplusDeficitBox.Name = "surplusDeficitBox";
            this.surplusDeficitBox.Size = new System.Drawing.Size(161, 39);
            this.surplusDeficitBox.TabIndex = 10;
            // 
            // totalFeesBox
            // 
            this.totalFeesBox.Location = new System.Drawing.Point(285, 776);
            this.totalFeesBox.Name = "totalFeesBox";
            this.totalFeesBox.Size = new System.Drawing.Size(161, 39);
            this.totalFeesBox.TabIndex = 11;
            // 
            // totalCostBox
            // 
            this.totalCostBox.Location = new System.Drawing.Point(285, 731);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.Size = new System.Drawing.Size(161, 39);
            this.totalCostBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(661, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 45);
            this.label11.TabIndex = 13;
            this.label11.Text = "Guest List";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(495, 821);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 62);
            this.button3.TabIndex = 15;
            this.button3.Text = "Change (WIP)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(741, 821);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(240, 62);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // guestListBox
            // 
            this.guestListBox.FormattingEnabled = true;
            this.guestListBox.ItemHeight = 32;
            this.guestListBox.Location = new System.Drawing.Point(495, 57);
            this.guestListBox.Name = "guestListBox";
            this.guestListBox.Size = new System.Drawing.Size(486, 740);
            this.guestListBox.TabIndex = 18;
            this.guestListBox.SelectedIndexChanged += new System.EventHandler(this.guestListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 917);
            this.Controls.Add(this.guestListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalCostBox);
            this.Controls.Add(this.totalFeesBox);
            this.Controls.Add(this.surplusDeficitBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrOfGuestsBox);
            this.Controls.Add(this.inviteGuestBox);
            this.Controls.Add(this.newPartyGroupBox);
            this.Name = "MainForm";
            this.Text = "Party Organizer by Eric Malmström";
            this.newPartyGroupBox.ResumeLayout(false);
            this.newPartyGroupBox.PerformLayout();
            this.inviteGuestBox.ResumeLayout(false);
            this.inviteGuestBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox newPartyGroupBox;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox feePerPersonBox;
        private TextBox costPerPersonBox;
        private TextBox maxNmrOfGuestsBox;
        private Label label2;
        private GroupBox inviteGuestBox;
        private TextBox lastNameBox;
        private TextBox firstNameBox;
        private Label label5;
        private Label label6;
        private TextBox nmrOfGuestsBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox surplusDeficitBox;
        private TextBox totalFeesBox;
        private TextBox totalCostBox;
        private Label label11;
        private Button button3;
        private Button createListButton;
        private Button addGuestButton;
        private Button deleteButton;
        private ListBox guestListBox;
    }
}