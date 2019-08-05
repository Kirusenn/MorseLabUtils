using System.ComponentModel;
using System.Windows.Forms;

namespace MorseUtils {
	public partial class vibrationalForm : Form {
		
		public vibrationalForm() {
			InitializeComponent();
		}

		private void CalculateButton_Click(object sender, System.EventArgs e) {
			backgroundWorker1.RunWorkerAsync();
		}

		private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
			VibrationalCalculator vibCalc = new VibrationalCalculator(double.Parse(targetInput.Text), double.Parse(omega2Input.Text), double.Parse(rhoInput.Text), (double)omega1MinInput.Value, (double)omega1MaxInput.Value, (int)v1MinInput.Value, (int)v1MaxInput.Value);

			e.Result = vibCalc.Calculate((double)incrementInput.Value);
		}

		private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			this.Invoke(new MethodInvoker(delegate {
				if (resultsLabel.Text == "Results") {
					resultsLabel.Text = "";
				}
				if (e.Cancelled) {
					resultsLabel.Text += "\nCalculation cancelled!";
				} else {
					resultsLabel.Text += "\n" + e.Result.ToString();
				}
			}));
		}
	}
}
