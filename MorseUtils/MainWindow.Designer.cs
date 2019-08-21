﻿namespace MorseUtils {
	partial class vibrationalForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.calculateWorker = new System.ComponentModel.BackgroundWorker();
			this.tabController = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.calculateButton = new System.Windows.Forms.Button();
			this.resultsLabel = new System.Windows.Forms.Label();
			this.v1MinInput = new System.Windows.Forms.NumericUpDown();
			this.v1MaxInput = new System.Windows.Forms.NumericUpDown();
			this.omega1MinInput = new System.Windows.Forms.NumericUpDown();
			this.incrementInput = new System.Windows.Forms.NumericUpDown();
			this.omega1IncLabel = new System.Windows.Forms.Label();
			this.max2Label = new System.Windows.Forms.Label();
			this.min2Label = new System.Windows.Forms.Label();
			this.omega1MaxInput = new System.Windows.Forms.NumericUpDown();
			this.max1Label = new System.Windows.Forms.Label();
			this.min1Label = new System.Windows.Forms.Label();
			this.rhoInput = new System.Windows.Forms.TextBox();
			this.omega2Input = new System.Windows.Forms.TextBox();
			this.targetInput = new System.Windows.Forms.TextBox();
			this.omega1RangeLabel = new System.Windows.Forms.Label();
			this.v1RangeLabel = new System.Windows.Forms.Label();
			this.rhoLabel = new System.Windows.Forms.Label();
			this.omega2Label = new System.Windows.Forms.Label();
			this.targetLabel = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.gratingOrder = new System.Windows.Forms.NumericUpDown();
			this.convertButton = new System.Windows.Forms.Button();
			this.dyeCounterInput = new System.Windows.Forms.TextBox();
			this.freqInput = new System.Windows.Forms.TextBox();
			this.nmInput = new System.Windows.Forms.TextBox();
			this.cmInput = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.freqLabel = new System.Windows.Forms.Label();
			this.nmLabel = new System.Windows.Forms.Label();
			this.cmLabel = new System.Windows.Forms.Label();
			this.convertWorker = new System.ComponentModel.BackgroundWorker();
			this.tabController.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.v1MinInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MaxInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MinInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incrementInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MaxInput)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gratingOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// calculateWorker
			// 
			this.calculateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.calculateWorker_DoWork);
			this.calculateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.calculateWorker_RunWorkerCompleted);
			// 
			// tabController
			// 
			this.tabController.Controls.Add(this.tabPage1);
			this.tabController.Controls.Add(this.tabPage2);
			this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabController.Location = new System.Drawing.Point(0, 0);
			this.tabController.Name = "tabController";
			this.tabController.SelectedIndex = 0;
			this.tabController.Size = new System.Drawing.Size(800, 450);
			this.tabController.TabIndex = 0;
			this.tabController.SelectedIndexChanged += new System.EventHandler(this.TabController_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.AutoScroll = true;
			this.tabPage1.Controls.Add(this.calculateButton);
			this.tabPage1.Controls.Add(this.resultsLabel);
			this.tabPage1.Controls.Add(this.v1MinInput);
			this.tabPage1.Controls.Add(this.v1MaxInput);
			this.tabPage1.Controls.Add(this.omega1MinInput);
			this.tabPage1.Controls.Add(this.incrementInput);
			this.tabPage1.Controls.Add(this.omega1IncLabel);
			this.tabPage1.Controls.Add(this.max2Label);
			this.tabPage1.Controls.Add(this.min2Label);
			this.tabPage1.Controls.Add(this.omega1MaxInput);
			this.tabPage1.Controls.Add(this.max1Label);
			this.tabPage1.Controls.Add(this.min1Label);
			this.tabPage1.Controls.Add(this.rhoInput);
			this.tabPage1.Controls.Add(this.omega2Input);
			this.tabPage1.Controls.Add(this.targetInput);
			this.tabPage1.Controls.Add(this.omega1RangeLabel);
			this.tabPage1.Controls.Add(this.v1RangeLabel);
			this.tabPage1.Controls.Add(this.rhoLabel);
			this.tabPage1.Controls.Add(this.omega2Label);
			this.tabPage1.Controls.Add(this.targetLabel);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(792, 424);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Vibrational";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// calculateButton
			// 
			this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculateButton.Location = new System.Drawing.Point(105, 364);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(100, 34);
			this.calculateButton.TabIndex = 37;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// resultsLabel
			// 
			this.resultsLabel.AutoSize = true;
			this.resultsLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resultsLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.resultsLabel.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsLabel.Location = new System.Drawing.Point(686, 3);
			this.resultsLabel.Name = "resultsLabel";
			this.resultsLabel.Size = new System.Drawing.Size(103, 26);
			this.resultsLabel.TabIndex = 43;
			this.resultsLabel.Text = "Results";
			// 
			// v1MinInput
			// 
			this.v1MinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.v1MinInput.Location = new System.Drawing.Point(105, 140);
			this.v1MinInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.v1MinInput.Name = "v1MinInput";
			this.v1MinInput.Size = new System.Drawing.Size(47, 32);
			this.v1MinInput.TabIndex = 30;
			this.v1MinInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// v1MaxInput
			// 
			this.v1MaxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.v1MaxInput.Location = new System.Drawing.Point(158, 140);
			this.v1MaxInput.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.v1MaxInput.Name = "v1MaxInput";
			this.v1MaxInput.Size = new System.Drawing.Size(47, 32);
			this.v1MaxInput.TabIndex = 32;
			this.v1MaxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.v1MaxInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// omega1MinInput
			// 
			this.omega1MinInput.DecimalPlaces = 3;
			this.omega1MinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1MinInput.Location = new System.Drawing.Point(105, 191);
			this.omega1MinInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.omega1MinInput.Name = "omega1MinInput";
			this.omega1MinInput.Size = new System.Drawing.Size(130, 32);
			this.omega1MinInput.TabIndex = 34;
			// 
			// incrementInput
			// 
			this.incrementInput.DecimalPlaces = 3;
			this.incrementInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.incrementInput.Location = new System.Drawing.Point(120, 242);
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
			this.incrementInput.Size = new System.Drawing.Size(100, 32);
			this.incrementInput.TabIndex = 36;
			this.incrementInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			// 
			// omega1IncLabel
			// 
			this.omega1IncLabel.AutoSize = true;
			this.omega1IncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1IncLabel.Location = new System.Drawing.Point(103, 277);
			this.omega1IncLabel.Name = "omega1IncLabel";
			this.omega1IncLabel.Size = new System.Drawing.Size(133, 26);
			this.omega1IncLabel.TabIndex = 42;
			this.omega1IncLabel.Text = "ω\' increment";
			// 
			// max2Label
			// 
			this.max2Label.AutoSize = true;
			this.max2Label.Location = new System.Drawing.Point(292, 226);
			this.max2Label.Name = "max2Label";
			this.max2Label.Size = new System.Drawing.Size(27, 13);
			this.max2Label.TabIndex = 41;
			this.max2Label.Text = "Max";
			// 
			// min2Label
			// 
			this.min2Label.AutoSize = true;
			this.min2Label.Location = new System.Drawing.Point(158, 226);
			this.min2Label.Name = "min2Label";
			this.min2Label.Size = new System.Drawing.Size(24, 13);
			this.min2Label.TabIndex = 40;
			this.min2Label.Text = "Min";
			// 
			// omega1MaxInput
			// 
			this.omega1MaxInput.DecimalPlaces = 3;
			this.omega1MaxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1MaxInput.Location = new System.Drawing.Point(241, 191);
			this.omega1MaxInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.omega1MaxInput.Name = "omega1MaxInput";
			this.omega1MaxInput.Size = new System.Drawing.Size(130, 32);
			this.omega1MaxInput.TabIndex = 35;
			this.omega1MaxInput.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// max1Label
			// 
			this.max1Label.AutoSize = true;
			this.max1Label.Location = new System.Drawing.Point(167, 175);
			this.max1Label.Name = "max1Label";
			this.max1Label.Size = new System.Drawing.Size(27, 13);
			this.max1Label.TabIndex = 39;
			this.max1Label.Text = "Max";
			// 
			// min1Label
			// 
			this.min1Label.AutoSize = true;
			this.min1Label.Location = new System.Drawing.Point(116, 175);
			this.min1Label.Name = "min1Label";
			this.min1Label.Size = new System.Drawing.Size(24, 13);
			this.min1Label.TabIndex = 38;
			this.min1Label.Text = "Min";
			// 
			// rhoInput
			// 
			this.rhoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rhoInput.Location = new System.Drawing.Point(105, 102);
			this.rhoInput.Name = "rhoInput";
			this.rhoInput.Size = new System.Drawing.Size(100, 32);
			this.rhoInput.TabIndex = 29;
			// 
			// omega2Input
			// 
			this.omega2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega2Input.Location = new System.Drawing.Point(105, 64);
			this.omega2Input.Name = "omega2Input";
			this.omega2Input.Size = new System.Drawing.Size(100, 32);
			this.omega2Input.TabIndex = 26;
			// 
			// targetInput
			// 
			this.targetInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetInput.Location = new System.Drawing.Point(105, 26);
			this.targetInput.Name = "targetInput";
			this.targetInput.Size = new System.Drawing.Size(100, 32);
			this.targetInput.TabIndex = 25;
			// 
			// omega1RangeLabel
			// 
			this.omega1RangeLabel.AutoSize = true;
			this.omega1RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega1RangeLabel.Location = new System.Drawing.Point(1, 193);
			this.omega1RangeLabel.Name = "omega1RangeLabel";
			this.omega1RangeLabel.Size = new System.Drawing.Size(98, 26);
			this.omega1RangeLabel.TabIndex = 33;
			this.omega1RangeLabel.Text = "ω\' range:";
			// 
			// v1RangeLabel
			// 
			this.v1RangeLabel.AutoSize = true;
			this.v1RangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.v1RangeLabel.Location = new System.Drawing.Point(5, 146);
			this.v1RangeLabel.Name = "v1RangeLabel";
			this.v1RangeLabel.Size = new System.Drawing.Size(94, 26);
			this.v1RangeLabel.TabIndex = 31;
			this.v1RangeLabel.Text = "v\' range:";
			// 
			// rhoLabel
			// 
			this.rhoLabel.AutoSize = true;
			this.rhoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rhoLabel.Location = new System.Drawing.Point(38, 108);
			this.rhoLabel.Name = "rhoLabel";
			this.rhoLabel.Size = new System.Drawing.Size(61, 26);
			this.rhoLabel.TabIndex = 28;
			this.rhoLabel.Text = "ρ(i,j):";
			// 
			// omega2Label
			// 
			this.omega2Label.AutoSize = true;
			this.omega2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.omega2Label.Location = new System.Drawing.Point(39, 70);
			this.omega2Label.Name = "omega2Label";
			this.omega2Label.Size = new System.Drawing.Size(60, 26);
			this.omega2Label.TabIndex = 27;
			this.omega2Label.Text = "ω\'\'(i):";
			// 
			// targetLabel
			// 
			this.targetLabel.AutoSize = true;
			this.targetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.targetLabel.Location = new System.Drawing.Point(14, 32);
			this.targetLabel.Name = "targetLabel";
			this.targetLabel.Size = new System.Drawing.Size(85, 26);
			this.targetLabel.TabIndex = 24;
			this.targetLabel.Text = "ν(j)-ν(i):";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.gratingOrder);
			this.tabPage2.Controls.Add(this.convertButton);
			this.tabPage2.Controls.Add(this.dyeCounterInput);
			this.tabPage2.Controls.Add(this.freqInput);
			this.tabPage2.Controls.Add(this.nmInput);
			this.tabPage2.Controls.Add(this.cmInput);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.freqLabel);
			this.tabPage2.Controls.Add(this.nmLabel);
			this.tabPage2.Controls.Add(this.cmLabel);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Conversions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// gratingOrder
			// 
			this.gratingOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gratingOrder.Location = new System.Drawing.Point(170, 241);
			this.gratingOrder.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.gratingOrder.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.gratingOrder.Name = "gratingOrder";
			this.gratingOrder.Size = new System.Drawing.Size(47, 32);
			this.gratingOrder.TabIndex = 39;
			this.gratingOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.gratingOrder.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// convertButton
			// 
			this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.convertButton.Location = new System.Drawing.Point(346, 382);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(100, 34);
			this.convertButton.TabIndex = 38;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			// 
			// dyeCounterInput
			// 
			this.dyeCounterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dyeCounterInput.Location = new System.Drawing.Point(223, 240);
			this.dyeCounterInput.Name = "dyeCounterInput";
			this.dyeCounterInput.Size = new System.Drawing.Size(100, 32);
			this.dyeCounterInput.TabIndex = 32;
			// 
			// freqInput
			// 
			this.freqInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.freqInput.Location = new System.Drawing.Point(150, 161);
			this.freqInput.Name = "freqInput";
			this.freqInput.Size = new System.Drawing.Size(100, 32);
			this.freqInput.TabIndex = 31;
			// 
			// nmInput
			// 
			this.nmInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmInput.Location = new System.Drawing.Point(79, 94);
			this.nmInput.Name = "nmInput";
			this.nmInput.Size = new System.Drawing.Size(100, 32);
			this.nmInput.TabIndex = 30;
			// 
			// cmInput
			// 
			this.cmInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmInput.Location = new System.Drawing.Point(92, 24);
			this.cmInput.Name = "cmInput";
			this.cmInput.Size = new System.Drawing.Size(100, 32);
			this.cmInput.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 243);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 26);
			this.label4.TabIndex = 28;
			this.label4.Text = "Dye Counter:";
			// 
			// freqLabel
			// 
			this.freqLabel.AutoSize = true;
			this.freqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.freqLabel.Location = new System.Drawing.Point(24, 164);
			this.freqLabel.Name = "freqLabel";
			this.freqLabel.Size = new System.Drawing.Size(120, 26);
			this.freqLabel.TabIndex = 27;
			this.freqLabel.Text = "Frequency:";
			// 
			// nmLabel
			// 
			this.nmLabel.AutoSize = true;
			this.nmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nmLabel.Location = new System.Drawing.Point(24, 97);
			this.nmLabel.Name = "nmLabel";
			this.nmLabel.Size = new System.Drawing.Size(49, 26);
			this.nmLabel.TabIndex = 26;
			this.nmLabel.Text = "nm:";
			// 
			// cmLabel
			// 
			this.cmLabel.AutoSize = true;
			this.cmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmLabel.Location = new System.Drawing.Point(24, 27);
			this.cmLabel.Name = "cmLabel";
			this.cmLabel.Size = new System.Drawing.Size(62, 26);
			this.cmLabel.TabIndex = 25;
			this.cmLabel.Text = "cm⁻¹:";
			// 
			// convertWorker
			// 
			this.convertWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.convertWorker_DoWork);
			this.convertWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.convertWorker_RunWorkerCompleted);
			// 
			// vibrationalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabController);
			this.Name = "vibrationalForm";
			this.ShowIcon = false;
			this.Text = "Vibrational Utility";
			this.tabController.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.v1MinInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MaxInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MinInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.incrementInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MaxInput)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gratingOrder)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.BackgroundWorker calculateWorker;
		private System.Windows.Forms.TabControl tabController;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Label resultsLabel;
		private System.Windows.Forms.NumericUpDown v1MinInput;
		private System.Windows.Forms.NumericUpDown v1MaxInput;
		private System.Windows.Forms.NumericUpDown omega1MinInput;
		private System.Windows.Forms.NumericUpDown incrementInput;
		private System.Windows.Forms.Label omega1IncLabel;
		private System.Windows.Forms.Label max2Label;
		private System.Windows.Forms.Label min2Label;
		private System.Windows.Forms.NumericUpDown omega1MaxInput;
		private System.Windows.Forms.Label max1Label;
		private System.Windows.Forms.Label min1Label;
		private System.Windows.Forms.TextBox rhoInput;
		private System.Windows.Forms.TextBox omega2Input;
		private System.Windows.Forms.TextBox targetInput;
		private System.Windows.Forms.Label omega1RangeLabel;
		private System.Windows.Forms.Label v1RangeLabel;
		private System.Windows.Forms.Label rhoLabel;
		private System.Windows.Forms.Label omega2Label;
		private System.Windows.Forms.Label targetLabel;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label freqLabel;
		private System.Windows.Forms.Label nmLabel;
		private System.Windows.Forms.Label cmLabel;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.TextBox dyeCounterInput;
		private System.Windows.Forms.TextBox freqInput;
		private System.Windows.Forms.TextBox nmInput;
		private System.Windows.Forms.TextBox cmInput;
		private System.Windows.Forms.NumericUpDown gratingOrder;
		private System.ComponentModel.BackgroundWorker convertWorker;
	}
}

