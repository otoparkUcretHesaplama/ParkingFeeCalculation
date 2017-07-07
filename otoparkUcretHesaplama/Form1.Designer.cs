namespace ParkingFeeCalculation
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
            this.lblParkingType = new System.Windows.Forms.Label();
            this.txtcheckinTime = new System.Windows.Forms.TextBox();
            this.cbParkingType = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.lblCheckOutTime = new System.Windows.Forms.Label();
            this.txtcheckOutTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEuroKur = new System.Windows.Forms.TextBox();
            this.lblEuroChange = new System.Windows.Forms.Label();
            this.lblTotalEuro = new System.Windows.Forms.Label();
            this.lblTotalTL = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblTotalAmountEuro = new System.Windows.Forms.Label();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.LblTotalTimeHour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParkingType
            // 
            this.lblParkingType.AutoSize = true;
            this.lblParkingType.Location = new System.Drawing.Point(26, 27);
            this.lblParkingType.Name = "lblParkingType";
            this.lblParkingType.Size = new System.Drawing.Size(70, 13);
            this.lblParkingType.TabIndex = 0;
            this.lblParkingType.Text = "Parking Type";
            // 
            // txtcheckinTime
            // 
            this.txtcheckinTime.Location = new System.Drawing.Point(114, 127);
            this.txtcheckinTime.MaxLength = 5;
            this.txtcheckinTime.Name = "txtcheckinTime";
            this.txtcheckinTime.Size = new System.Drawing.Size(121, 20);
            this.txtcheckinTime.TabIndex = 1;
            // 
            // cbParkingType
            // 
            this.cbParkingType.FormattingEnabled = true;
            this.cbParkingType.Items.AddRange(new object[] {
            "Outdoor Parking",
            "Indoor Parking"});
            this.cbParkingType.Location = new System.Drawing.Point(114, 27);
            this.cbParkingType.Name = "cbParkingType";
            this.cbParkingType.Size = new System.Drawing.Size(121, 21);
            this.cbParkingType.TabIndex = 2;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(26, 77);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(65, 13);
            this.lblVehicleType.TabIndex = 3;
            this.lblVehicleType.Text = "Vehicle type";
            // 
            // cbCarType
            // 
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Items.AddRange(new object[] {
            "Truck",
            "Mini Truck",
            "Taxi",
            "Commercial vehicles",
            "Motorcycle",
            "Others"});
            this.cbCarType.Location = new System.Drawing.Point(114, 77);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(121, 21);
            this.cbCarType.TabIndex = 4;
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Location = new System.Drawing.Point(26, 127);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(75, 13);
            this.lblCheckInTime.TabIndex = 5;
            this.lblCheckInTime.Text = "Check-in Time";
            // 
            // lblCheckOutTime
            // 
            this.lblCheckOutTime.AutoSize = true;
            this.lblCheckOutTime.Location = new System.Drawing.Point(26, 176);
            this.lblCheckOutTime.Name = "lblCheckOutTime";
            this.lblCheckOutTime.Size = new System.Drawing.Size(84, 13);
            this.lblCheckOutTime.TabIndex = 6;
            this.lblCheckOutTime.Text = "Check-Out Time";
            // 
            // txtcheckOutTime
            // 
            this.txtcheckOutTime.Location = new System.Drawing.Point(114, 176);
            this.txtcheckOutTime.MaxLength = 5;
            this.txtcheckOutTime.Name = "txtcheckOutTime";
            this.txtcheckOutTime.Size = new System.Drawing.Size(121, 20);
            this.txtcheckOutTime.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblParkingType);
            this.panel1.Controls.Add(this.txtcheckOutTime);
            this.panel1.Controls.Add(this.txtcheckinTime);
            this.panel1.Controls.Add(this.lblCheckOutTime);
            this.panel1.Controls.Add(this.cbParkingType);
            this.panel1.Controls.Add(this.lblCheckInTime);
            this.panel1.Controls.Add(this.lblVehicleType);
            this.panel1.Controls.Add(this.cbCarType);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 235);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtEuroKur);
            this.panel2.Controls.Add(this.lblEuroChange);
            this.panel2.Controls.Add(this.lblTotalEuro);
            this.panel2.Controls.Add(this.lblTotalTL);
            this.panel2.Controls.Add(this.lblTotalTime);
            this.panel2.Controls.Add(this.lblTotalAmountEuro);
            this.panel2.Controls.Add(this.LblTotalAmount);
            this.panel2.Controls.Add(this.LblTotalTimeHour);
            this.panel2.Location = new System.Drawing.Point(325, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 235);
            this.panel2.TabIndex = 10;
            // 
            // txtEuroKur
            // 
            this.txtEuroKur.Location = new System.Drawing.Point(123, 20);
            this.txtEuroKur.Name = "txtEuroKur";
            this.txtEuroKur.Size = new System.Drawing.Size(100, 20);
            this.txtEuroKur.TabIndex = 21;
            this.txtEuroKur.Text = "3,8701";
            // 
            // lblEuroChange
            // 
            this.lblEuroChange.AutoSize = true;
            this.lblEuroChange.Location = new System.Drawing.Point(19, 27);
            this.lblEuroChange.Name = "lblEuroChange";
            this.lblEuroChange.Size = new System.Drawing.Size(69, 13);
            this.lblEuroChange.TabIndex = 19;
            this.lblEuroChange.Text = "Euro Change";
            // 
            // lblTotalEuro
            // 
            this.lblTotalEuro.AutoSize = true;
            this.lblTotalEuro.Location = new System.Drawing.Point(120, 177);
            this.lblTotalEuro.Name = "lblTotalEuro";
            this.lblTotalEuro.Size = new System.Drawing.Size(31, 13);
            this.lblTotalEuro.TabIndex = 18;
            this.lblTotalEuro.Text = "........";
            // 
            // lblTotalTL
            // 
            this.lblTotalTL.AutoSize = true;
            this.lblTotalTL.Location = new System.Drawing.Point(120, 127);
            this.lblTotalTL.Name = "lblTotalTL";
            this.lblTotalTL.Size = new System.Drawing.Size(31, 13);
            this.lblTotalTL.TabIndex = 17;
            this.lblTotalTL.Text = "........";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(120, 77);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(31, 13);
            this.lblTotalTime.TabIndex = 16;
            this.lblTotalTime.Text = "........";
            // 
            // lblTotalAmountEuro
            // 
            this.lblTotalAmountEuro.AutoSize = true;
            this.lblTotalAmountEuro.Location = new System.Drawing.Point(19, 177);
            this.lblTotalAmountEuro.Name = "lblTotalAmountEuro";
            this.lblTotalAmountEuro.Size = new System.Drawing.Size(85, 13);
            this.lblTotalAmountEuro.TabIndex = 15;
            this.lblTotalAmountEuro.Text = "Total Amount (€)";
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.AutoSize = true;
            this.LblTotalAmount.Location = new System.Drawing.Point(19, 127);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(92, 13);
            this.LblTotalAmount.TabIndex = 14;
            this.LblTotalAmount.Text = "Total Amount (TL)";
            // 
            // LblTotalTimeHour
            // 
            this.LblTotalTimeHour.AutoSize = true;
            this.LblTotalTimeHour.Location = new System.Drawing.Point(19, 77);
            this.LblTotalTimeHour.Name = "LblTotalTimeHour";
            this.LblTotalTimeHour.Size = new System.Drawing.Size(89, 13);
            this.LblTotalTimeHour.TabIndex = 13;
            this.LblTotalTimeHour.Text = "Total Time (Hour)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "INTRODUCTION INFORMATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "FEE AND TIME INFORMATION";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(160, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 29);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "..:CALCULATE..";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 336);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Parking Fee Calculator V1.00";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParkingType;
        private System.Windows.Forms.TextBox txtcheckinTime;
        private System.Windows.Forms.ComboBox cbParkingType;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblCheckOutTime;
        private System.Windows.Forms.TextBox txtcheckOutTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalAmountEuro;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label LblTotalTimeHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalEuro;
        private System.Windows.Forms.Label lblTotalTL;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtEuroKur;
        private System.Windows.Forms.Label lblEuroChange;
    }
}

