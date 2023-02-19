namespace PierceStat
{
    partial class Form_Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_I1ACoeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_I1BCoeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_I2ACoeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_I2BCoeff = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_U_HeaterCoeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_U_PowerCoeff = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_Temp1Coeff = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_Temp2Coeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp3Coeff = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Temp4Coeff = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Gate1A = new System.Windows.Forms.CheckBox();
            this.checkBox_Gate1B = new System.Windows.Forms.CheckBox();
            this.checkBox_Gate2A = new System.Windows.Forms.CheckBox();
            this.checkBox_Gate2B = new System.Windows.Forms.CheckBox();
            this.numericUpDown_PWM1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_PWM2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I1ACoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I1BCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I2ACoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I2BCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Coeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Coeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Coeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Coeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PWM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PWM2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "I_1A ADC coeff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "I_1B ADC coeff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "I_2A ADC coeff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "I_2B ADC coeff";
            // 
            // numericUpDown_I1ACoeff
            // 
            this.numericUpDown_I1ACoeff.DecimalPlaces = 4;
            this.numericUpDown_I1ACoeff.Location = new System.Drawing.Point(166, 23);
            this.numericUpDown_I1ACoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_I1ACoeff.Name = "numericUpDown_I1ACoeff";
            this.numericUpDown_I1ACoeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_I1ACoeff.TabIndex = 4;
            this.numericUpDown_I1ACoeff.ValueChanged += new System.EventHandler(this.numericUpDown_I1ACoeff_ValueChanged);
            // 
            // numericUpDown_I1BCoeff
            // 
            this.numericUpDown_I1BCoeff.DecimalPlaces = 4;
            this.numericUpDown_I1BCoeff.Location = new System.Drawing.Point(166, 55);
            this.numericUpDown_I1BCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_I1BCoeff.Name = "numericUpDown_I1BCoeff";
            this.numericUpDown_I1BCoeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_I1BCoeff.TabIndex = 5;
            this.numericUpDown_I1BCoeff.ValueChanged += new System.EventHandler(this.numericUpDown_I1BCoeff_ValueChanged);
            // 
            // numericUpDown_I2ACoeff
            // 
            this.numericUpDown_I2ACoeff.DecimalPlaces = 4;
            this.numericUpDown_I2ACoeff.Location = new System.Drawing.Point(166, 88);
            this.numericUpDown_I2ACoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_I2ACoeff.Name = "numericUpDown_I2ACoeff";
            this.numericUpDown_I2ACoeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_I2ACoeff.TabIndex = 6;
            this.numericUpDown_I2ACoeff.ValueChanged += new System.EventHandler(this.numericUpDown_I2ACoeff_ValueChanged);
            // 
            // numericUpDown_I2BCoeff
            // 
            this.numericUpDown_I2BCoeff.DecimalPlaces = 4;
            this.numericUpDown_I2BCoeff.Location = new System.Drawing.Point(166, 118);
            this.numericUpDown_I2BCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_I2BCoeff.Name = "numericUpDown_I2BCoeff";
            this.numericUpDown_I2BCoeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_I2BCoeff.TabIndex = 7;
            this.numericUpDown_I2BCoeff.ValueChanged += new System.EventHandler(this.numericUpDown_I2BCoeff_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "U_Heater ADC coeff";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "U_Power ADC coeff";
            // 
            // numericUpDown_U_HeaterCoeff
            // 
            this.numericUpDown_U_HeaterCoeff.DecimalPlaces = 4;
            this.numericUpDown_U_HeaterCoeff.Location = new System.Drawing.Point(177, 171);
            this.numericUpDown_U_HeaterCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_U_HeaterCoeff.Name = "numericUpDown_U_HeaterCoeff";
            this.numericUpDown_U_HeaterCoeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_HeaterCoeff.TabIndex = 10;
            this.numericUpDown_U_HeaterCoeff.ValueChanged += new System.EventHandler(this.numericUpDown_U_HeaterCoeff_ValueChanged);
            // 
            // numericUpDown_U_PowerCoeff
            // 
            this.numericUpDown_U_PowerCoeff.DecimalPlaces = 4;
            this.numericUpDown_U_PowerCoeff.Location = new System.Drawing.Point(177, 205);
            this.numericUpDown_U_PowerCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_U_PowerCoeff.Name = "numericUpDown_U_PowerCoeff";
            this.numericUpDown_U_PowerCoeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_U_PowerCoeff.TabIndex = 11;
            this.numericUpDown_U_PowerCoeff.ValueChanged += new System.EventHandler(this.numericUpDown_U_PowerCoeff_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Temp1 ADC coeff";
            // 
            // numericUpDown_Temp1Coeff
            // 
            this.numericUpDown_Temp1Coeff.DecimalPlaces = 4;
            this.numericUpDown_Temp1Coeff.Location = new System.Drawing.Point(177, 254);
            this.numericUpDown_Temp1Coeff.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.numericUpDown_Temp1Coeff.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp1Coeff.Name = "numericUpDown_Temp1Coeff";
            this.numericUpDown_Temp1Coeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp1Coeff.TabIndex = 13;
            this.numericUpDown_Temp1Coeff.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp1Coeff.ValueChanged += new System.EventHandler(this.numericUpDown_Temp1Coeff_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Temp2 ADC coeff";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Temp3 ADC coeff";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Temp4 ADC coeff";
            // 
            // numericUpDown_Temp2Coeff
            // 
            this.numericUpDown_Temp2Coeff.DecimalPlaces = 4;
            this.numericUpDown_Temp2Coeff.Location = new System.Drawing.Point(177, 288);
            this.numericUpDown_Temp2Coeff.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.numericUpDown_Temp2Coeff.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp2Coeff.Name = "numericUpDown_Temp2Coeff";
            this.numericUpDown_Temp2Coeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp2Coeff.TabIndex = 17;
            this.numericUpDown_Temp2Coeff.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp2Coeff.ValueChanged += new System.EventHandler(this.numericUpDown_Temp2Coeff_ValueChanged);
            // 
            // numericUpDown_Temp3Coeff
            // 
            this.numericUpDown_Temp3Coeff.DecimalPlaces = 4;
            this.numericUpDown_Temp3Coeff.Location = new System.Drawing.Point(177, 325);
            this.numericUpDown_Temp3Coeff.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.numericUpDown_Temp3Coeff.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp3Coeff.Name = "numericUpDown_Temp3Coeff";
            this.numericUpDown_Temp3Coeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp3Coeff.TabIndex = 18;
            this.numericUpDown_Temp3Coeff.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp3Coeff.ValueChanged += new System.EventHandler(this.numericUpDown_Temp3Coeff_ValueChanged);
            // 
            // numericUpDown_Temp4Coeff
            // 
            this.numericUpDown_Temp4Coeff.DecimalPlaces = 4;
            this.numericUpDown_Temp4Coeff.Location = new System.Drawing.Point(177, 363);
            this.numericUpDown_Temp4Coeff.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.numericUpDown_Temp4Coeff.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp4Coeff.Name = "numericUpDown_Temp4Coeff";
            this.numericUpDown_Temp4Coeff.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_Temp4Coeff.TabIndex = 19;
            this.numericUpDown_Temp4Coeff.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.numericUpDown_Temp4Coeff.ValueChanged += new System.EventHandler(this.numericUpDown_Temp4Coeff_ValueChanged);
            // 
            // checkBox_Gate1A
            // 
            this.checkBox_Gate1A.AutoCheck = false;
            this.checkBox_Gate1A.AutoSize = true;
            this.checkBox_Gate1A.Location = new System.Drawing.Point(406, 26);
            this.checkBox_Gate1A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Gate1A.Name = "checkBox_Gate1A";
            this.checkBox_Gate1A.Size = new System.Drawing.Size(91, 24);
            this.checkBox_Gate1A.TabIndex = 20;
            this.checkBox_Gate1A.Text = "Gate1A";
            this.checkBox_Gate1A.UseVisualStyleBackColor = true;
            // 
            // checkBox_Gate1B
            // 
            this.checkBox_Gate1B.AutoCheck = false;
            this.checkBox_Gate1B.AutoSize = true;
            this.checkBox_Gate1B.Location = new System.Drawing.Point(406, 57);
            this.checkBox_Gate1B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Gate1B.Name = "checkBox_Gate1B";
            this.checkBox_Gate1B.Size = new System.Drawing.Size(91, 24);
            this.checkBox_Gate1B.TabIndex = 21;
            this.checkBox_Gate1B.Text = "Gate1B";
            this.checkBox_Gate1B.UseVisualStyleBackColor = true;
            // 
            // checkBox_Gate2A
            // 
            this.checkBox_Gate2A.AutoCheck = false;
            this.checkBox_Gate2A.AutoSize = true;
            this.checkBox_Gate2A.Location = new System.Drawing.Point(406, 89);
            this.checkBox_Gate2A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Gate2A.Name = "checkBox_Gate2A";
            this.checkBox_Gate2A.Size = new System.Drawing.Size(91, 24);
            this.checkBox_Gate2A.TabIndex = 22;
            this.checkBox_Gate2A.Text = "Gate2A";
            this.checkBox_Gate2A.UseVisualStyleBackColor = true;
            // 
            // checkBox_Gate2B
            // 
            this.checkBox_Gate2B.AutoCheck = false;
            this.checkBox_Gate2B.AutoSize = true;
            this.checkBox_Gate2B.Location = new System.Drawing.Point(406, 120);
            this.checkBox_Gate2B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_Gate2B.Name = "checkBox_Gate2B";
            this.checkBox_Gate2B.Size = new System.Drawing.Size(91, 24);
            this.checkBox_Gate2B.TabIndex = 23;
            this.checkBox_Gate2B.Text = "Gate2B";
            this.checkBox_Gate2B.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_PWM1
            // 
            this.numericUpDown_PWM1.DecimalPlaces = 2;
            this.numericUpDown_PWM1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PWM1.Location = new System.Drawing.Point(406, 163);
            this.numericUpDown_PWM1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_PWM1.Name = "numericUpDown_PWM1";
            this.numericUpDown_PWM1.ReadOnly = true;
            this.numericUpDown_PWM1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_PWM1.TabIndex = 24;
            // 
            // numericUpDown_PWM2
            // 
            this.numericUpDown_PWM2.DecimalPlaces = 2;
            this.numericUpDown_PWM2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_PWM2.Location = new System.Drawing.Point(406, 200);
            this.numericUpDown_PWM2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_PWM2.Name = "numericUpDown_PWM2";
            this.numericUpDown_PWM2.ReadOnly = true;
            this.numericUpDown_PWM2.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_PWM2.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "PWM1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "PWM2";
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown_PWM2);
            this.Controls.Add(this.numericUpDown_PWM1);
            this.Controls.Add(this.checkBox_Gate2B);
            this.Controls.Add(this.checkBox_Gate2A);
            this.Controls.Add(this.checkBox_Gate1B);
            this.Controls.Add(this.checkBox_Gate1A);
            this.Controls.Add(this.numericUpDown_Temp4Coeff);
            this.Controls.Add(this.numericUpDown_Temp3Coeff);
            this.Controls.Add(this.numericUpDown_Temp2Coeff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_Temp1Coeff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_U_PowerCoeff);
            this.Controls.Add(this.numericUpDown_U_HeaterCoeff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_I2BCoeff);
            this.Controls.Add(this.numericUpDown_I2ACoeff);
            this.Controls.Add(this.numericUpDown_I1BCoeff);
            this.Controls.Add(this.numericUpDown_I1ACoeff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Settings";
            this.Text = "Settings & Debug";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I1ACoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I1BCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I2ACoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I2BCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_HeaterCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_U_PowerCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp1Coeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp2Coeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp3Coeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Temp4Coeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PWM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PWM2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_I1ACoeff;
        private System.Windows.Forms.NumericUpDown numericUpDown_I1BCoeff;
        private System.Windows.Forms.NumericUpDown numericUpDown_I2ACoeff;
        private System.Windows.Forms.NumericUpDown numericUpDown_I2BCoeff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_U_HeaterCoeff;
        private System.Windows.Forms.NumericUpDown numericUpDown_U_PowerCoeff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_Temp1Coeff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_Temp2Coeff;
        private System.Windows.Forms.NumericUpDown numericUpDown_Temp3Coeff;
        private System.Windows.Forms.NumericUpDown numericUpDown_Temp4Coeff;
        private System.Windows.Forms.CheckBox checkBox_Gate1A;
        private System.Windows.Forms.CheckBox checkBox_Gate1B;
        private System.Windows.Forms.CheckBox checkBox_Gate2A;
        private System.Windows.Forms.CheckBox checkBox_Gate2B;
        private System.Windows.Forms.NumericUpDown numericUpDown_PWM1;
        private System.Windows.Forms.NumericUpDown numericUpDown_PWM2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}