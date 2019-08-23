﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace MorseUtils {
	public partial class vibrationalForm : Form {
		private VibrationalCalculator vibCalc;
		private List<TextBox> convertBoxes;
		private double energy;

		public vibrationalForm() {
			InitializeComponent();
			AcceptButton = calculateButton; //	Default
			convertBoxes = new List<TextBox>() { mjInput, nmInput, cmInput, eVInput, freqInput, kcalInput, dyeCounterInput };
			foreach (TextBox box in convertBoxes) {
				box.LostFocus += convertBox_Changed;
			}
		}

		///	<summary>
		/// Ran when the Calculate button is pressed, or the Enter key is pressed. Tells BackgroundWorker to calculate possible ω' values using VibrationalCalculator.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CalculateButton_Click(object sender, System.EventArgs e) {
			//	Add all textbox values to List for passing to BackgroundWorker (to avoid thread issues)
			List<object> inputs = new List<object>();

			try {
				inputs.Add(double.Parse(targetInput.Text));
				inputs.Add((double.Parse(omega2Input.Text)));
				inputs.Add((double.Parse(rhoInput.Text)));
				inputs.Add((double)omega1MinInput.Value);
				inputs.Add((double)omega1MaxInput.Value);
				inputs.Add((int)v1MinInput.Value);
				inputs.Add((int)v1MaxInput.Value);
				inputs.Add((double)incrementInput.Value);
			} catch (Exception exc) {
				if (exc is FormatException) {
					MessageBox.Show("Make sure to only enter numbers!");
				} else if (exc is NullReferenceException) {
					MessageBox.Show("Make sure to enter all values!");
				} else {
					MessageBox.Show(exc.Message);
				}
			}

			calculateWorker.RunWorkerAsync(inputs);
		}

		/// <summary>
		/// Handles the DoWork event of the calculateWorker control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
		private void calculateWorker_DoWork(object sender, DoWorkEventArgs e) {
			List<object> inputs = e.Argument as List<object>;
			//	Pass textbox values to VibCalc by extracting from passed List
			vibCalc = new VibrationalCalculator((double)inputs[0], (double)inputs[1], (double)inputs[2], (double)inputs[3], (double)inputs[4], (int)inputs[5], (int)inputs[6]);

			e.Result = vibCalc.Calculate((double)inputs[7]);
		}

		/// <summary>
		/// Runs when vibrational calculations are done; displays results.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void calculateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			resultsLabel.Text = e.Result.ToString();
		}

		private void convertBox_Changed(object sender, System.EventArgs e) {
			TextBox senderBox = sender as TextBox;
			int senderIndex = convertBoxes.FindIndex(b => b.Name.Equals(senderBox.Name));
			List<double> boxValues = new List<double>();

			try {
				foreach (TextBox box in convertBoxes) {
					boxValues.Add(double.Parse(box.Text));

					convertWorker.RunWorkerAsync(new Tuple<int, List<double>(senderIndex, boxValues));
				}
			} catch (Exception exc) {
				if (exc is FormatException) {
					MessageBox.Show("Make sure to only enter numbers!");
					senderBox.Text = "";
				} else if (exc is NullReferenceException) {
					MessageBox.Show("Please enter a number!");
					senderBox.Text = "";
				} else {
					MessageBox.Show(exc.Message);
				}
			}
		}

		private void convertWorker_DoWork(object sender, DoWorkEventArgs e) {
			Tuple<int, List<double>> args = e.Argument as Tuple<int, List<double>>;
			e.Result = Converter.Convert(args.Item1, args.Item2);
		}

		private void convertWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			Dictionary<TextBox, double> results = e.Result as Dictionary<TextBox, double>;
			foreach (KeyValuePair<TextBox, double> result in results) {
				result.Key.Text = result.Value.ToString();
			}
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
				case 1:
					AcceptButton = convertButton;
					break;
			}
		}
	}
}
