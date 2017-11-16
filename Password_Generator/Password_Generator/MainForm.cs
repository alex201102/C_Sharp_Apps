/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 25/02/2017
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Password_Generator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private static Thread thread = null;
		private static bool stopThread = false, closeLock = false;
		private static string toDisp = "";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Text = "Password Generator";
			FormBorderStyle = FormBorderStyle.FixedDialog;
			StartPosition = FormStartPosition.CenterScreen;
			MaximizeBox = false;
			
			passLenNumericUpDown.Value = 14;
			upCaseCheckBox.Checked = true;
			lowCaseCheckBox.Checked = true;
			digitsCheckBox.Checked = true;
			symbTextBox.Text = @"~!@#$%^&*()-+=_\/";
			symbolsCheckBox.Enabled = true;
			toolStripStatusLabel.Text= "Ready";
		}
		
		private int GetMinPassLength()
		{
			bool reqExtraChars = symbolsCheckBox.Checked && symbTextBox.Text != "";
			int minLen = 0;
			
			if (lowCaseCheckBox.Checked)
				minLen++;
			if (upCaseCheckBox.Checked)
				minLen++;
			if (digitsCheckBox.Checked)
				minLen++;
			if (reqExtraChars)
				minLen++;
			
			return minLen;
		}
		
		private static string generate_pass(int len, bool reqLowCase, bool reqUpCase, bool reqNum, bool reqExtraChars, string extraChars = null)
		{
			int minLen = 0;
			
			reqExtraChars = reqExtraChars && extraChars != null && extraChars != "";
			
			if (reqLowCase)
				minLen++;
			if (reqUpCase)
				minLen++;
			if (reqNum)
				minLen++;
			if (reqExtraChars)
				minLen++;
			
			if (len<minLen)
				return "";
						
			bool lowLett = false, hiLett = false, numVal = false, extraVal = false;
			int valType, i, extraCharsLen = extraChars.Length;
			string pass = "";
			Random rand = new Random();
			
			while ((reqLowCase && !lowLett) || (reqUpCase && !hiLett) || (reqNum && !numVal) || (reqExtraChars && !extraVal))
			{
				if (stopThread)
						return "";
				
				lowLett = hiLett = numVal = extraVal = false;
				pass = "";
				
				i=0;
				while (i<len)
				{
					if (stopThread)
						return "";
					
					valType = rand.Next(4);
					switch (valType)
					{
						case 0:
							if (reqNum)
							{
								pass+=(char)(48 + rand.Next(10));
								if (!numVal)
									numVal=true;
							}
							else
								i--;
							break;
						case 1:
							if (reqUpCase)
							{
							pass+=(char)(65 + rand.Next(26));
							if (!hiLett)
								hiLett=true;
							}
							else
								i--;
							break;
						case 2:
							if (reqLowCase)
							{
								pass+=(char)(97 + rand.Next(26));
								if (!lowLett)
									lowLett=true;
							}
							else
								i--;
							break;
						case 3:
							if (reqExtraChars)
							{
								pass+=(char)(extraChars[rand.Next(extraCharsLen)]);
								if (!extraVal)
									extraVal=true;
							}
							else
								i--;
							break;
					}
					i++;
				}
			}
			return pass;
		}
		
		void ExitBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void GenBtnClick(object sender, EventArgs e)
		{
			if (genBtn.Text == "Stop")
			{
				if (!stopThread)
					stopThread = true;
			}
			else
			{
				passTextBox.Text = "";
				closeLock = true;
				genBtn.Text = "Stop";
				saveBtn.Enabled = false;
				exitBtn.Enabled = false;
				stopThread = false;
				this.toolStripStatusLabel.Text= "Running ...";
				thread = new Thread(() => {
				                    	toDisp = generate_pass(Convert.ToInt32(passLenNumericUpDown.Value), lowCaseCheckBox.Checked, upCaseCheckBox.Checked, digitsCheckBox.Checked, symbolsCheckBox.Checked, symbTextBox.Text);
				                    	Invoke(new MethodInvoker(delegate {
				                    	                         	passTextBox.Text = toDisp;
				                    	                         	this.toolStripStatusLabel.Text= "Ready";
				                    	                         	stopThread = false;
				                    	                         	genBtn.Text = "Generate";
				                    	                         	closeLock = false;
				                    	                         	saveBtn.Enabled = true;
				                    	                         	exitBtn.Enabled = true;
				                    	                         }));
				                    });
				thread.Start();
			}
		}
		
		void SaveBtnClick(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.DefaultExt = "Text File (*.txt)|*.txt";
			saveFileDialog.OverwritePrompt = true;
			saveFileDialog.FileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + "_Passwords.txt";
			
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, passTextBox.Text);
				MessageBox.Show("Saved to: " + saveFileDialog.FileName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (closeLock)
				e.Cancel = true;
		}
		
		void SymbTextBoxTextChanged(object sender, EventArgs e)
		{
			symbolsCheckBox.Enabled = symbTextBox.Text.Length > 0;
		}
		
		private void chkLegalPassLength()
		{
			int minLen = GetMinPassLength();
			if (minLen == 0 || minLen>Convert.ToInt32(passLenNumericUpDown.Value))
				genBtn.Enabled = false;
			else
				genBtn.Enabled = true;
		}
		
		void LowCaseCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			chkLegalPassLength();
		}
		
		void UpCaseCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			chkLegalPassLength();
		}
		
		void DigitsCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			chkLegalPassLength();
		}
		
		void SymbolsCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			chkLegalPassLength();
		}
		
		void PassLenNumericUpDownValueChanged(object sender, EventArgs e)
		{
			chkLegalPassLength();
		}
	}
}
