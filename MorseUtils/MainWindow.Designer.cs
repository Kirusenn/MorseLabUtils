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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabController.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.v1MinInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v1MaxInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MinInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.incrementInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.omega1MaxInput)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// calculateWorker
			// 
			this.calculateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.calculateWorker_DoWork);
			this.calculateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
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
			this.tabPage1.Text = "Vibrational Calculations";
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
			this.tabPage2.Controls.Add(this.tableLayoutPanel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 113);
			this.label1.TabIndex = 0;
			this.label1.Text = "cm-1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(230, 113);
			this.label2.TabIndex = 1;
			this.label2.Text = "nm";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(388, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 113);
			this.label3.TabIndex = 2;
			this.label3.Text = "cm-1";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(388, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 113);
			this.label4.TabIndex = 3;
			this.label4.Text = "cm-1";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(388, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 192);
			this.label5.TabIndex = 4;
			this.label5.Text = "cm-1";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 226);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(230, 192);
			this.label6.TabIndex = 5;
			this.label6.Text = "eV";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// vibrationalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabController);
			this.Name = "vibrationalForm";
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

