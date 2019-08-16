using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace MorseUtils {
	public partial class vibrationalForm : Form {
		private VibrationalCalculator vibCalc;

		public vibrationalForm() {
			InitializeComponent();
			AcceptButton = calculateButton;	//	Default
		}

		///	<summary>
		/// Ran when the Calculate button is pressed, or the Enter key is pressed. Tells BackgroundWorker to calculate possible ω' values using VibrationalCalculator.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CalculateButton_Click(object sender, System.EventArgs e) {
			List<object> inputs = new List<object>();

			//	Add all textbox values to List for passing to BackgroundWorker (to avoid thread issues)
			//	TODO: ensure only numbers are entered
			inputs.Add(double.Parse(targetInput.Text));
			inputs.Add((double.Parse(omega2Input.Text)));
			inputs.Add((double.Parse(rhoInput.Text)));
			inputs.Add((double)omega1MinInput.Value);
			inputs.Add((double)omega1MaxInput.Value);
			inputs.Add((int)v1MinInput.Value);
			inputs.Add((int)v1MaxInput.Value);
			inputs.Add((double)incrementInput.Value);
			
			calculateWorker.RunWorkerAsync(inputs);
		}

		/// <summary>
		/// Handles the DoWork event of the calculateWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
		private void calculateWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
			List<object> inputs = e.Argument as List<object>;
			//	Pass textbox values to VibCalc by extracting from passed List
			vibCalc = new VibrationalCalculator((double)inputs[0], (double)inputs[1], (double)inputs[2], (double)inputs[3], (double)inputs[4], (int)inputs[5], (int)inputs[6]);

			e.Result = vibCalc.Calculate((double)inputs[7]);
		}

		private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			resultsLabel.Text = e.Result.ToString();
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the TabController control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void TabController_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch (tabController.SelectedIndex) {
				case 0:
					AcceptButton = calculateButton;
					break;
			}
		}
	}
}
