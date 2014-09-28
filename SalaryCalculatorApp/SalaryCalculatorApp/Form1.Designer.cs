namespace SalaryCalculatorApp
{
    partial class SalaryCalcForm
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
            this.medicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.basicAccountTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.showMeSalaryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalAllowanceTextBox
            // 
            this.medicalAllowanceTextBox.Location = new System.Drawing.Point(118, 96);
            this.medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            this.medicalAllowanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicalAllowanceTextBox.TabIndex = 26;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(118, 70);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(100, 20);
            this.houseRentTextBox.TabIndex = 25;
            // 
            // basicAccountTextBox
            // 
            this.basicAccountTextBox.Location = new System.Drawing.Point(118, 44);
            this.basicAccountTextBox.Name = "basicAccountTextBox";
            this.basicAccountTextBox.Size = new System.Drawing.Size(134, 20);
            this.basicAccountTextBox.TabIndex = 24;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(118, 18);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(205, 20);
            this.employeeNameTextBox.TabIndex = 23;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(17, 99);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Medical Allowance";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(17, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "House Rent";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 13);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Basic Account";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 13);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Employee Name";
            // 
            // showMeSalaryButton
            // 
            this.showMeSalaryButton.Location = new System.Drawing.Point(20, 138);
            this.showMeSalaryButton.Name = "showMeSalaryButton";
            this.showMeSalaryButton.Size = new System.Drawing.Size(303, 44);
            this.showMeSalaryButton.TabIndex = 18;
            this.showMeSalaryButton.Text = "Show me salary";
            this.showMeSalaryButton.UseVisualStyleBackColor = true;
            this.showMeSalaryButton.Click += new System.EventHandler(this.showMeSalaryButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medicalAllowanceTextBox);
            this.groupBox1.Controls.Add(this.houseRentTextBox);
            this.groupBox1.Controls.Add(this.basicAccountTextBox);
            this.groupBox1.Controls.Add(this.employeeNameTextBox);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.showMeSalaryButton);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 195);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SalaryCalculator";
            // 
            // SalaryCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryCalcForm";
            this.Text = "SalaryCalculatorUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox medicalAllowanceTextBox;
        internal System.Windows.Forms.TextBox houseRentTextBox;
        internal System.Windows.Forms.TextBox basicAccountTextBox;
        internal System.Windows.Forms.TextBox employeeNameTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button showMeSalaryButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

