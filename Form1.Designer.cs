namespace Csharp_Ass3
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heightBoxInches = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.heightBoxFeet = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bmiOutputBox = new System.Windows.Forms.TextBox();
            this.weightCategoryOutputBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savingPlanBox = new System.Windows.Forms.GroupBox();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.monthlyDepositBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.futureValueBox = new System.Windows.Forms.GroupBox();
            this.finalBalanceBox = new System.Windows.Forms.TextBox();
            this.amountPaidBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateSavingsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.savingPlanBox.SuspendLayout();
            this.futureValueBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 853);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(125, 195);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(203, 36);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Imperial (ft,lbs)";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 158);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(197, 36);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Metric (kg,cm)";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.heightBoxInches);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.heightBoxFeet);
            this.groupBox1.Controls.Add(this.heightBox);
            this.groupBox1.Controls.Add(this.weightLabel);
            this.groupBox1.Controls.Add(this.weightBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.heightLabel);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI Calculator";
            // 
            // heightBoxInches
            // 
            this.heightBoxInches.Location = new System.Drawing.Point(280, 158);
            this.heightBoxInches.Name = "heightBoxInches";
            this.heightBoxInches.Size = new System.Drawing.Size(142, 39);
            this.heightBoxInches.TabIndex = 3;
            this.heightBoxInches.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heightBoxFeet
            // 
            this.heightBoxFeet.Location = new System.Drawing.Point(74, 158);
            this.heightBoxFeet.Name = "heightBoxFeet";
            this.heightBoxFeet.Size = new System.Drawing.Size(200, 39);
            this.heightBoxFeet.TabIndex = 2;
            this.heightBoxFeet.Visible = false;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(4, 158);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(418, 39);
            this.heightBox.TabIndex = 6;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(4, 210);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(137, 32);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight (kg)";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(4, 261);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(418, 39);
            this.weightBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(4, 110);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(139, 32);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height (cm)";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(4, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(418, 39);
            this.nameBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Weight Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "BMI";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // bmiOutputBox
            // 
            this.bmiOutputBox.Location = new System.Drawing.Point(297, 43);
            this.bmiOutputBox.Name = "bmiOutputBox";
            this.bmiOutputBox.ReadOnly = true;
            this.bmiOutputBox.Size = new System.Drawing.Size(418, 39);
            this.bmiOutputBox.TabIndex = 7;
            // 
            // weightCategoryOutputBox
            // 
            this.weightCategoryOutputBox.Location = new System.Drawing.Point(297, 113);
            this.weightCategoryOutputBox.Name = "weightCategoryOutputBox";
            this.weightCategoryOutputBox.ReadOnly = true;
            this.weightCategoryOutputBox.Size = new System.Drawing.Size(418, 39);
            this.weightCategoryOutputBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkGreen;
            this.label11.Location = new System.Drawing.Point(182, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(444, 32);
            this.label11.TabIndex = 9;
            this.label11.Text = "A normal BMI is between 18.50 and 24.9";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(43, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(715, 32);
            this.label12.TabIndex = 10;
            this.label12.Text = "Normal weight should be between INPUTNUM1 and INPUTNUM2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultBox);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(25, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 782);
            this.panel1.TabIndex = 0;
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.label12);
            this.resultBox.Controls.Add(this.label11);
            this.resultBox.Controls.Add(this.label10);
            this.resultBox.Controls.Add(this.label9);
            this.resultBox.Controls.Add(this.weightCategoryOutputBox);
            this.resultBox.Controls.Add(this.bmiOutputBox);
            this.resultBox.Location = new System.Drawing.Point(16, 476);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(853, 279);
            this.resultBox.TabIndex = 4;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Results for YOUR NAME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(490, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 408);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit Types";
            // 
            // savingPlanBox
            // 
            this.savingPlanBox.Controls.Add(this.periodBox);
            this.savingPlanBox.Controls.Add(this.monthlyDepositBox);
            this.savingPlanBox.Controls.Add(this.label2);
            this.savingPlanBox.Controls.Add(this.label1);
            this.savingPlanBox.Location = new System.Drawing.Point(946, 59);
            this.savingPlanBox.Name = "savingPlanBox";
            this.savingPlanBox.Size = new System.Drawing.Size(875, 398);
            this.savingPlanBox.TabIndex = 2;
            this.savingPlanBox.TabStop = false;
            this.savingPlanBox.Text = "Saving Plan";
            // 
            // periodBox
            // 
            this.periodBox.Location = new System.Drawing.Point(446, 191);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(200, 39);
            this.periodBox.TabIndex = 3;
            // 
            // monthlyDepositBox
            // 
            this.monthlyDepositBox.Location = new System.Drawing.Point(446, 144);
            this.monthlyDepositBox.Name = "monthlyDepositBox";
            this.monthlyDepositBox.Size = new System.Drawing.Size(200, 39);
            this.monthlyDepositBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Period (years)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Deposit";
            // 
            // futureValueBox
            // 
            this.futureValueBox.Controls.Add(this.finalBalanceBox);
            this.futureValueBox.Controls.Add(this.amountPaidBox);
            this.futureValueBox.Controls.Add(this.label4);
            this.futureValueBox.Controls.Add(this.label3);
            this.futureValueBox.Location = new System.Drawing.Point(946, 535);
            this.futureValueBox.Name = "futureValueBox";
            this.futureValueBox.Size = new System.Drawing.Size(875, 306);
            this.futureValueBox.TabIndex = 3;
            this.futureValueBox.TabStop = false;
            this.futureValueBox.Text = "Future Value";
            // 
            // finalBalanceBox
            // 
            this.finalBalanceBox.Location = new System.Drawing.Point(446, 176);
            this.finalBalanceBox.Name = "finalBalanceBox";
            this.finalBalanceBox.ReadOnly = true;
            this.finalBalanceBox.Size = new System.Drawing.Size(200, 39);
            this.finalBalanceBox.TabIndex = 5;
            // 
            // amountPaidBox
            // 
            this.amountPaidBox.Location = new System.Drawing.Point(446, 131);
            this.amountPaidBox.Name = "amountPaidBox";
            this.amountPaidBox.ReadOnly = true;
            this.amountPaidBox.Size = new System.Drawing.Size(200, 39);
            this.amountPaidBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount Paid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Final Balance";
            // 
            // calculateSavingsButton
            // 
            this.calculateSavingsButton.Location = new System.Drawing.Point(1250, 463);
            this.calculateSavingsButton.Name = "calculateSavingsButton";
            this.calculateSavingsButton.Size = new System.Drawing.Size(326, 68);
            this.calculateSavingsButton.TabIndex = 4;
            this.calculateSavingsButton.Text = "Calculate Savings";
            this.calculateSavingsButton.UseVisualStyleBackColor = true;
            this.calculateSavingsButton.Click += new System.EventHandler(this.calculateSavingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1847, 853);
            this.Controls.Add(this.calculateSavingsButton);
            this.Controls.Add(this.futureValueBox);
            this.Controls.Add(this.savingPlanBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.savingPlanBox.ResumeLayout(false);
            this.savingPlanBox.PerformLayout();
            this.futureValueBox.ResumeLayout(false);
            this.futureValueBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Splitter splitter1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox heightBox;
        private Label weightLabel;
        private TextBox weightBox;
        private Label label6;
        private Label heightLabel;
        private TextBox nameBox;
        private Label label9;
        private Label label10;
        private TextBox bmiOutputBox;
        private TextBox weightCategoryOutputBox;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private GroupBox resultBox;
        private GroupBox groupBox2;
        private TextBox heightBoxInches;
        private TextBox heightBoxFeet;
        private GroupBox savingPlanBox;
        private TextBox monthlyDepositBox;
        private Label label2;
        private Label label1;
        private GroupBox futureValueBox;
        private Button calculateSavingsButton;
        private TextBox periodBox;
        private TextBox finalBalanceBox;
        private TextBox amountPaidBox;
        private Label label4;
        private Label label3;
    }
}