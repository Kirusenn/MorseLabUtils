namespace MorseUtils
{
    partial class vibrationalForm
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
			this.targetLabel = new System.Windows.Forms.Label();
			this.omega2Label = new System.Windows.Forms.Label();
			this.rhoLabel = new System.Windows.Forms.Label();
			this.v1RangeLabel = new System.Windows.Forms.Label();
			this.omega1RangeLabel = new System.Windows.Forms.Label();
			this.targetInput = new System.Windows.Forms.TextBox();
			this.omega2Input = new System.Windows.Forms.TextBox();
			this.rhoInput = new System.Windows.Forms.TextBox();
			this.min1Label = new System.Windows.Forms.Label();
			this.max1Label = new System.Windows.Forms.Label();
			this.omega1MaxInput = new System.Windows.Forms.NumericUpDown();
			this.min2Label = new System.Windows.Forms.Label();
			this.max2Label = new System.Windows.Forms.Label();
			this.omega1IncLabel = new System.Windows.Forms.Label();
			this.incrementInput = new System.Windows.Forms.NumericUpDown();
			this.omega1MinInput = new System.Windows.Forms.NumericUpDown();
			this.v1MaxInput = new System.Windows.Forms.NumericUpDown();
			this.v1MinInput = new System.Windows.Forms.NumericUpDown();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.omega1MaxInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incrementInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MinInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MaxInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MinInput)).BeginInit();
			this.SuspendLayout();
			// 
			// targetLabel
			// 
			this.targetLabel.AutoSize = true;
			this.targetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetLabel.Location = new System.Drawing.Point(12, 9);
			this.targetLabel.Name = "targetLabel";
			this.targetLabel.Size = new System.Drawing.Size(85, 26);
			this.targetLabel.TabIndex = 0;
			this.targetLabel.Text = "ν(j)-ν(i):";
			// 
			// omega2Label
			// 
			this.omega2Label.AutoSize = true;
			this.omega2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega2Label.Location = new System.Drawing.Point(37, 47);
			this.omega2Label.Name = "omega2Label";
			this.omega2Label.Size = new System.Drawing.Size(60, 26);
			this.omega2Label.TabIndex = 1;
			this.omega2Label.Text = "ω\'\'(i):";
			// 
			// rhoLabel
			// 
			this.rhoLabel.AutoSize = true;
			this.rhoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rhoLabel.Location = new System.Drawing.Point(36, 85);
			this.rhoLabel.Name = "rhoLabel";
			this.rhoLabel.Size = new System.Drawing.Size(61, 26);
			this.rhoLabel.TabIndex = 2;
			this.rhoLabel.Text = "ρ(i,j):";
			// 
			// v1RangeLabel
			// 
			this.v1RangeLabel.AutoSize = true;
			this.v1RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.v1RangeLabel.Location = new System.Drawing.Point(3, 123);
			this.v1RangeLabel.Name = "v1RangeLabel";
			this.v1RangeLabel.Size = new System.Drawing.Size(94, 26);
			this.v1RangeLabel.TabIndex = 3;
			this.v1RangeLabel.Text = "v\' range:";
			// 
			// omega1RangeLabel
			// 
			this.omega1RangeLabel.AutoSize = true;
			this.omega1RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1RangeLabel.Location = new System.Drawing.Point(-1, 170);
			this.omega1RangeLabel.Name = "omega1RangeLabel";
			this.omega1RangeLabel.Size = new System.Drawing.Size(98, 26);
			this.omega1RangeLabel.TabIndex = 4;
			this.omega1RangeLabel.Text = "ω\' range:";
			// 
			// targetInput
			// 
			this.targetInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetInput.Location = new System.Drawing.Point(103, 3);
			this.targetInput.Name = "targetInput";
			this.targetInput.Size = new System.Drawing.Size(100, 32);
			this.targetInput.TabIndex = 0;
			// 
			// omega2Input
			// 
			this.omega2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega2Input.Location = new System.Drawing.Point(103, 41);
			this.omega2Input.Name = "omega2Input";
			this.omega2Input.Size = new System.Drawing.Size(100, 32);
			this.omega2Input.TabIndex = 1;
			// 
			// rhoInput
			// 
			this.rhoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rhoInput.Location = new System.Drawing.Point(103, 79);
			this.rhoInput.Name = "rhoInput";
			this.rhoInput.Size = new System.Drawing.Size(100, 32);
			this.rhoInput.TabIndex = 2;
			// 
			// min1Label
			// 
			this.min1Label.AutoSize = true;
			this.min1Label.Location = new System.Drawing.Point(114, 152);
			this.min1Label.Name = "min1Label";
			this.min1Label.Size = new System.Drawing.Size(24, 13);
			this.min1Label.TabIndex = 11;
			this.min1Label.Text = "Min";
			// 
			// max1Label
			// 
			this.max1Label.AutoSize = true;
			this.max1Label.Location = new System.Drawing.Point(165, 152);
			this.max1Label.Name = "max1Label";
			this.max1Label.Size = new System.Drawing.Size(27, 13);
			this.max1Label.TabIndex = 12;
			this.max1Label.Text = "Max";
			// 
			// omega1MaxInput
			// 
			this.omega1MaxInput.DecimalPlaces = 4;
			this.omega1MaxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1MaxInput.Location = new System.Drawing.Point(209, 168);
			this.omega1MaxInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.omega1MaxInput.Name = "omega1MaxInput";
			this.omega1MaxInput.Size = new System.Drawing.Size(100, 32);
			this.omega1MaxInput.TabIndex = 6;
			// 
			// min2Label
			// 
			this.min2Label.AutoSize = true;
			this.min2Label.Location = new System.Drawing.Point(141, 203);
			this.min2Label.Name = "min2Label";
			this.min2Label.Size = new System.Drawing.Size(24, 13);
			this.min2Label.TabIndex = 16;
			this.min2Label.Text = "Min";
			// 
			// max2Label
			// 
			this.max2Label.AutoSize = true;
			this.max2Label.Location = new System.Drawing.Point(244, 203);
			this.max2Label.Name = "max2Label";
			this.max2Label.Size = new System.Drawing.Size(27, 13);
			this.max2Label.TabIndex = 17;
			this.max2Label.Text = "Max";
			// 
			// omega1IncLabel
			// 
			this.omega1IncLabel.AutoSize = true;
			this.omega1IncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1IncLabel.Location = new System.Drawing.Point(78, 254);
			this.omega1IncLabel.Name = "omega1IncLabel";
			this.omega1IncLabel.Size = new System.Drawing.Size(133, 26);
			this.omega1IncLabel.TabIndex = 18;
			this.omega1IncLabel.Text = "ω\' increment";
			// 
			// incrementInput
			// 
			this.incrementInput.DecimalPlaces = 3;
			this.incrementInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.incrementInput.Location = new System.Drawing.Point(108, 219);
			this.incrementInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.incrementInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.incrementInput.Name = "incrementInput";
			this.incrementInput.Size = new System.Drawing.Size(75, 32);
			this.incrementInput.TabIndex = 7;
			this.incrementInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			// 
			// omega1MinInput
			// 
			this.omega1MinInput.DecimalPlaces = 4;
			this.omega1MinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1MinInput.Location = new System.Drawing.Point(103, 168);
			this.omega1MinInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.omega1MinInput.Name = "omega1MinInput";
			this.omega1MinInput.Size = new System.Drawing.Size(100, 32);
			this.omega1MinInput.TabIndex = 5;
			// 
			// v1MaxInput
			// 
			this.v1MaxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.v1MaxInput.Location = new System.Drawing.Point(156, 117);
			this.v1MaxInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.v1MaxInput.Name = "v1MaxInput";
			this.v1MaxInput.Size = new System.Drawing.Size(47, 32);
			this.v1MaxInput.TabIndex = 4;
			this.v1MaxInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// v1MinInput
			// 
			this.v1MinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.v1MinInput.Location = new System.Drawing.Point(103, 117);
			this.v1MinInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.v1MinInput.Name = "v1MinInput";
			this.v1MinInput.Size = new System.Drawing.Size(47, 32);
			this.v1MinInput.TabIndex = 3;
			// 
			// resultsLabel
			// 
			this.resultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.resultsLabel.AutoSize = true;
			this.resultsLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsLabel.Location = new System.Drawing.Point(703, 9);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(87, 28);
			this.resultsLabel.TabIndex = 23;
			this.resultsLabel.Text = "Results";
			// 
			// calculateButton
			// 
			this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculateButton.Location = new System.Drawing.Point(103, 341);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(100, 34);
			this.calculateButton.TabIndex = 8;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			// 
			// vibrationalForm
			// 
			this.AcceptButton = this.calculateButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.resultsLabel);
			this.Controls.Add(this.v1MinInput);
			this.Controls.Add(this.v1MaxInput);
			this.Controls.Add(this.omega1MinInput);
			this.Controls.Add(this.incrementInput);
			this.Controls.Add(this.omega1IncLabel);
			this.Controls.Add(this.max2Label);
			this.Controls.Add(this.min2Label);
			this.Controls.Add(this.omega1MaxInput);
			this.Controls.Add(this.max1Label);
			this.Controls.Add(this.min1Label);
			this.Controls.Add(this.rhoInput);
			this.Controls.Add(this.omega2Input);
			this.Controls.Add(this.targetInput);
			this.Controls.Add(this.omega1RangeLabel);
			this.Controls.Add(this.v1RangeLabel);
			this.Controls.Add(this.rhoLabel);
			this.Controls.Add(this.omega2Label);
			this.Controls.Add(this.targetLabel);
			this.Name = "vibrationalForm";
			this.Text = "Vibrational Utility";
			((System.ComponentModel.ISupportInitialize)(this.omega1MaxInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incrementInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MinInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MaxInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MinInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label omega2Label;
        private System.Windows.Forms.Label rhoLabel;
        private System.Windows.Forms.Label v1RangeLabel;
        private System.Windows.Forms.Label omega1RangeLabel;
        private System.Windows.Forms.TextBox targetInput;
        private System.Windows.Forms.TextBox omega2Input;
        private System.Windows.Forms.TextBox rhoInput;
        private System.Windows.Forms.Label min1Label;
        private System.Windows.Forms.Label max1Label;
        private System.Windows.Forms.NumericUpDown omega1MaxInput;
        private System.Windows.Forms.Label min2Label;
        private System.Windows.Forms.Label max2Label;
        private System.Windows.Forms.Label omega1IncLabel;
        private System.Windows.Forms.NumericUpDown incrementInput;
        private System.Windows.Forms.NumericUpDown omega1MinInput;
        private System.Windows.Forms.NumericUpDown v1MaxInput;
        private System.Windows.Forms.NumericUpDown v1MinInput;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button calculateButton;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

