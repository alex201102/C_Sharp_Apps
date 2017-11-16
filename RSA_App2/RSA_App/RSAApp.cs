/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 07/07/2016
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace RSA_App
{
	public partial class MainForm : Form
	{
		private Thread thread;
		private bool running;
		private static string encTime, decTime;
		
		public MainForm()
		{
			InitializeComponent();
			//this.MinimumSize = new System.Drawing.Size(this.Size.Width, this.Size.Height);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.MaximizeBox = false;
			this.toolStripStatusLabel1.Text = "Ready";
			this.Text = "RSA App - For small values of n (Educational purpose only)";
			this.numberRadioButton.Select();
			this.mkKeyAndEncRadioButton.Select();
			updateButton();
			running = false;
			timer1.Enabled = false;
			this.tempRadioButton.Visible = false;
			encTime = string.Empty;
			decTime = string.Empty;
		}
			
		private void ExitBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void updateButton()
		{
			this.startStopBtn.Enabled =
				(// Create Keys and Encrypt Decrypt Mode
					(mkKeyAndEncRadioButton.Checked && pTxtBx.Text != "" && qTxtBx.Text != "" && eTxtBx.Text != "" &&
				  	((numberRadioButton.Checked && valueTxtBx.Text != "") || (textRadioButton.Checked && dataTextBox.Text != ""))) ||
					
				 // Encrypt Only Mode
				 	((encFileRadioButton.Checked || encStrRadioButton.Checked) && eTxtBx.Text != "" && nTxtBx.Text != "" &&
				  	((numberRadioButton.Enabled && numberRadioButton.Checked && valueTxtBx.Text != "") || (textRadioButton.Checked && dataTextBox.Text != ""))) ||
					
				//Decrypt Only Mode
					((decFileRadioButton.Checked || decStrRadioButton.Checked) && dTxtBx.Text != "" && nTxtBx.Text != "" &&
				 	((numberRadioButton.Enabled && numberRadioButton.Checked && encTxtBx.Text != "") || (textRadioButton.Checked && encDataTextBox.Text != "")))
				);
		}
		
		private void updateRunning(bool val)
		{
			try
			{
				Invoke(new MethodInvoker(delegate
			    {
			    	running = val;
			    	if (val)
			    	{
			    		this.toolStripStatusLabel1.Text = "Running...";
			    		startStopBtn.Text = "Stop";
			    	}
			    	else
			    	{
			    		this.toolStripStatusLabel1.Text = "Ready" +
			    			((encTime != string.Empty)?(", Last enc.: " + encTime):("")) +
			    			((decTime != string.Empty)?(", Last dec.: " + decTime):(""));
			    		
			    		System.Diagnostics.Debug.WriteLine(this.toolStripStatusLabel1.Text);
			    		startStopBtn.Text = "Start";
			    	}
			    	exitBtn.Enabled = !val;
			    	mkKeyAndEncRadioButton.Enabled = !val;
				    encFileRadioButton.Enabled = !val;
				    encStrRadioButton.Enabled = !val;
				    decFileRadioButton.Enabled = !val;
				    decStrRadioButton.Enabled = !val;
				    numberRadioButton.Enabled = !val;
					textRadioButton.Enabled = !val;
			    	
			    	if (val)
			    	{
				    	pTxtBx.ReadOnly = val;
				    	qTxtBx.ReadOnly = val;
				    	eTxtBx.ReadOnly = val;
				    	dTxtBx.ReadOnly = val;
				    	nTxtBx.ReadOnly = val;
				    	valueTxtBx.ReadOnly = val;
				    	dataTextBox.ReadOnly = val;
				    	encTxtBx.ReadOnly = val;
				    	encDataTextBox.ReadOnly = val;	
			    	}
			    	else
			    	{
			    		int selectedOption = -1;
			    		
			    		if (mkKeyAndEncRadioButton.Checked)
				    		selectedOption = 0;
				    	else if (encFileRadioButton.Checked)
				    		selectedOption = 1;	
				    	else if (encStrRadioButton.Checked)
				    		selectedOption = 2;
				    	else if (decFileRadioButton.Checked)
				    		selectedOption = 3;			
				    	else if (decStrRadioButton.Checked)
				    		selectedOption = 4;
			    		
			    		tempRadioButton.Select();
			    		
			    		switch (selectedOption)
			    		{
			    			case 0:
			    				mkKeyAndEncRadioButton.Select();
			    				break;
			    			case 1:
			    				encFileRadioButton.Select();
			    				break;
			    			case 2:
			    				encStrRadioButton.Select();
			    				break;
			    			case 3:
			    				decFileRadioButton.Select();
			    				break;
			    			case 4:
			    				decStrRadioButton.Select();
			    				break;
			    		}
			    	}
			    }));
			}
			catch
			{
				running = val;
				if (val)
			    {
			    	this.toolStripStatusLabel1.Text = "Running...";
			    	startStopBtn.Text = "Stop";
			    }
			    else
			    {
			    	this.toolStripStatusLabel1.Text = "Ready" +
			    		((encTime != string.Empty)?(", Last enc.: " + encTime):("")) +
			    		((decTime != string.Empty)?(", Last dec.: " + decTime):(""));
			    	
			    	System.Diagnostics.Debug.WriteLine(this.toolStripStatusLabel1.Text);
			    	startStopBtn.Text = "Start";
			    }
			    exitBtn.Enabled = !val;
			    mkKeyAndEncRadioButton.Enabled = !val;
				encFileRadioButton.Enabled = !val;
				encStrRadioButton.Enabled = !val;
				decFileRadioButton.Enabled = !val;
				decStrRadioButton.Enabled = !val;
				numberRadioButton.Enabled = !val;
				textRadioButton.Enabled = !val;
			    
			    if (val)
			    {
				   	pTxtBx.ReadOnly = val;
				   	qTxtBx.ReadOnly = val;
				   	eTxtBx.ReadOnly = val;
				   	dTxtBx.ReadOnly = val;
			    	nTxtBx.ReadOnly = val;
			    	valueTxtBx.ReadOnly = val;
			    	dataTextBox.ReadOnly = val;
			    	encTxtBx.ReadOnly = val;
			    	encDataTextBox.ReadOnly = val;
			   	}
			   	else
			   	{
			   		int selectedOption = -1;
			    		
			   		if (mkKeyAndEncRadioButton.Checked)
				   		selectedOption = 0;
				   	else if (encFileRadioButton.Checked)
				   		selectedOption = 1;	
				   	else if (encStrRadioButton.Checked)
				   		selectedOption = 2;
				   	else if (decFileRadioButton.Checked)
				   		selectedOption = 3;			
				   	else if (decStrRadioButton.Checked)
				   		selectedOption = 4;
			    		
			   		tempRadioButton.Select();
			   		
			   		switch (selectedOption)
			   		{
			   			case 0:
			   				mkKeyAndEncRadioButton.Select();
			   				break;
			   			case 1:
			   				encFileRadioButton.Select();
			   				break;
			   			case 2:
			   				encStrRadioButton.Select();
			   				break;
			   			case 3:
			   				decFileRadioButton.Select();
			   				break;
			   			case 4:
			   				decStrRadioButton.Select();
			   				break;
			   		}
		    	}
			}
		}
		
		private bool isPrime(UInt64 val)
		{
			if (val < 2)
				return false;
			
			if (val == 2)
				return true;
			
			UInt64 maxVal = Convert.ToUInt64(Math.Ceiling(Math.Sqrt(Convert.ToDouble(val))));
			
			for (UInt64 i=2; i<=maxVal; i++)
			{
				if (val % i == 0)
					return false;
				
				if (!running)
					return false;
			}
			
			return true;
		}
		
		private UInt64 calcDecEnc(UInt64 eOrD, UInt64 n, UInt64 mOrC, bool useV2=true)
		{
			UInt64 modVal = mOrC % n;
			UInt64 val = 1;
			UInt64 powVal = eOrD;
			
			if (!useV2)
			{
				System.Diagnostics.Debug.WriteLine(String.Format("Using slow method (n={0} base={1} pow={2}):",n,mOrC,eOrD));
				
				for (UInt64 i=0; i<eOrD; i++)
				{
					val = (modVal*val) % n;
					System.Diagnostics.Debug.WriteLine("i= " + i + "\r\nval= " + val);
					
					if (!running)
						return 0;
				}
			}
			else
			{
				System.Diagnostics.Debug.WriteLine(String.Format("Using fast method (n={0} base={1} pow={2}):",n,mOrC,eOrD));
				
				while (powVal > 0)
				{
					if (powVal % 2 == 1) // Is powVal odd?
					{
						val = (modVal*val) % n;
						System.Diagnostics.Debug.WriteLine("powVal= " + powVal + "\r\nval= " + val);
					}
					powVal /= 2;
					modVal = (modVal*modVal) % n;
				}
				
				if (!running)
					return 0;
			}
			
			System.Diagnostics.Debug.WriteLine("Return value = " + val);
			return val;
		}
		
		private UInt64 encrypt(UInt64 e, UInt64 n, UInt64 m)
		{
			try
			{
				return calcDecEnc(e,n,m,true);
			}
			catch
			{
				return calcDecEnc(e,n,m,false);
			}
		}
		
		private UInt64 decrypt(UInt64 d, UInt64 n, UInt64 c)
		{
			try
			{
				return calcDecEnc(d,n,c,true);
			}
			catch
			{
				return calcDecEnc(d,n,c,false);
			}
		}
		
		private UInt64 calcPhi(UInt64 p, UInt64 q)
		{
			return ((p-1)*(q-1));
		}
		
		private UInt64 calcN(UInt64 p, UInt64 q)
		{
			return (p*q);
		}
		
		private UInt64 calcD(UInt64 phi, UInt64 e)
		{
			long phiVal, a1, a2, b1, b2=1, temp1, temp2;
			
			try
			{
				phiVal=Convert.ToInt64(phi);
				a1=phiVal;
				a2=Convert.ToInt64(e);
				b1=phiVal;
			
				System.Diagnostics.Debug.WriteLine("\r\n\r\n" + a1 + "\t" + b1 + "\r\n" + a2 + "\t" + b2 + "\r\n==========");
				while (a2!=1)
				{
					temp1 = b2;
					b2 *= a1/a2;
					temp2 = a2;
					a2 = a1%a2;
					a1 = temp2;
					b2 = b1-b2;
					while (b2<0)
					{
						b2 += phiVal;
					}
					b1 = temp1;
				
					System.Diagnostics.Debug.WriteLine(a1 + "\t" + b1 + "\r\n" + a2 + "\t" + b2 + "\r\n==========");
					
					if (!running)
						return 0;
				}
			}	
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(string.Format("Error: phi = {0}\te = {1}\r\n{2}", phi, e, ex.Message));
				MessageBox.Show("Error - Invalid value(s)\r\n" + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
			
			return Convert.ToUInt64(b2); // d
		}
		
		private bool str2long(string str, out UInt64 val)
		{
			try
			{
				return (UInt64.TryParse(str,out val));
			}
			catch
			{
				val = 0;
				return false;
			}
		}
		
		private void runEncDec()
		{
			UInt64 p, q ,eVal, val = 0;
			string data2Enc = null, str = null;

			Invoke(new MethodInvoker(delegate
			{
				str = pTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out p))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
				
			if (!isPrime(p))
			{
				if (!running)
				{
					updateRunning(false);
					return;
				}
				
				MessageBox.Show("Error - " + p + " is not a prime number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
				str = qTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out q))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (p == q)
			{
				MessageBox.Show("Error - p and q have the same value","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (!isPrime(q))
			{
				if (!running)
				{
					updateRunning(false);
					return;
				}
				
				MessageBox.Show("Error - " + q + " is not a prime number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
				str = eTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out eVal))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (!isPrime(eVal))
			{
				if (!running)
				{
					updateRunning(false);
					return;
				}
				
				MessageBox.Show("Error - " + eVal + " is not a prime number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (numberRadioButton.Checked)
			{
				Invoke(new MethodInvoker(delegate
				{
					str = valueTxtBx.Text.ToString();
				}));
				
				if (!str2long(str,out val))
				{
					MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			else // if (textRadioButton.Checked)
			{
				Invoke(new MethodInvoker(delegate
				{
					data2Enc = dataTextBox.Text;
				}));
			}
			
			UInt64 phi = calcPhi(p,q);
			if (!running)
			{
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
				phiTxtBx.Text = phi.ToString();
				nTxtBx.Text = "";
				dTxtBx.Text = "";
				encTxtBx.Text = "";
				testTxtBx.Text = "";
				encDataTextBox.Text = "";
				testDataTextBox.Text = "";
			}));
			
			if (phi % eVal == 0)
			{
				MessageBox.Show("Error: " + phi + " % " + eVal + " == 0","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (phi <= eVal)
			{
				MessageBox.Show("Error: e must be less than phi","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}

			if (!running)
			{
				updateRunning(false);
				return;
			}
			UInt64 n=calcN(p,q);
			
			Invoke(new MethodInvoker(delegate
			{
				nTxtBx.Text = n.ToString();
			}));
			
			if (numberRadioButton.Checked)
			{
				if (val >= n)
				{
					MessageBox.Show("Error: " + val + " >= " + n,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			else
			{
				bool legalN = true;
				UInt64 temp, maxVal = UInt64.MinValue;
				
				for (int i=0; legalN && i<data2Enc.Length; i++)
				{
					temp = (UInt64)data2Enc[i];
					if (temp>maxVal)
						maxVal = temp;
					legalN &= maxVal < n;
					
					if (!running)
					{
						updateRunning(false);
						return;
					}
				}
				
				if (!legalN)
				{
					MessageBox.Show("Error: " + maxVal + " (the highest char value in the text) >= " + n,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			
			UInt64 d=calcD(phi,eVal);
			
			if (d==0)
			{
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
					dTxtBx.Text = d.ToString();
			}));
			
			encTime = string.Empty;
			decTime = string.Empty;
				
			if (numberRadioButton.Checked)
			{
				UInt64 enc;
				
				try
				{
					Stopwatch sw = new Stopwatch();
					sw.Start();
					
					enc = encrypt(eVal,n,val);
					
					sw.Stop();
					encTime = sw.Elapsed.ToString();
					System.Diagnostics.Debug.WriteLine(string.Format("encTime = {0}", encTime));
					
					if (!running)
					{
						updateRunning(false);
						return;
					}
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(string.Format("Error: e = {0}\tn = {1}\tm = {2}\r\n{3}", eVal, n, val, ex.Message));
					MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
				
				UInt64 testVal;
				
				try
				{
					Stopwatch sw = new Stopwatch();
					sw.Start();
					
					testVal = decrypt(d,n,enc);
					
					sw.Stop();
					decTime = sw.Elapsed.ToString();
					System.Diagnostics.Debug.WriteLine(string.Format("decTime = {0}", decTime));
					
					if (!running)
					{
						updateRunning(false);
						return;
					}
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(string.Format("Error: d = {0}\tn = {1}\tc = {2}\r\n{3}", d, n, enc, ex.Message));
					MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
								
				Invoke(new MethodInvoker(delegate
				{
					encTxtBx.Text = enc.ToString();
					testTxtBx.Text = testVal.ToString();
				}));
			}
			else
			{
				string tempStr = "", encStr = null;
				
				encTime = string.Empty;
				decTime = string.Empty;
				
				Stopwatch sw = new Stopwatch();
				sw.Start();
				
				for (int i=0; i<data2Enc.Length; i++)
				{
					if (tempStr != "")
						tempStr += " ";
					
					try
					{
						tempStr += encrypt(eVal,n,(UInt64)data2Enc[i]).ToString();
						
						if (!running)
						{
							updateRunning(false);
							return;
						}
					}
					catch (Exception ex)
					{
						System.Diagnostics.Debug.WriteLine(string.Format("Error: e = {0}\tn = {1}\tm = {2}\r\n{3}", eVal, n, (UInt64)data2Enc[i], ex.Message));
						MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
						updateRunning(false);
						return;
					}
				}
				
				sw.Stop();
				encTime = sw.Elapsed.ToString();
				System.Diagnostics.Debug.WriteLine(string.Format("encTime = {0}", encTime));
					
				Invoke(new MethodInvoker(delegate
				{
					encDataTextBox.Text = tempStr;
					encStr = encDataTextBox.Text;
				}));
				
				tempStr = "";
				
				sw = new Stopwatch();
				sw.Start();
				
				int nextSpace,useChars;
				while (encStr != "")
				{
					nextSpace = encStr.IndexOf(" ");
					if (nextSpace<0)
					{
						nextSpace = encStr.Length-1;
						useChars = encStr.Length;
					}
					else
					{
						useChars = nextSpace;
					}
					
					try
					{	
						tempStr += (char)Convert.ToByte(decrypt(d,n,Convert.ToUInt64(encStr.Substring(0,useChars))));
						
						if (!running)
						{
							updateRunning(false);
							return;
						}
					}
					catch (Exception ex)
					{
						System.Diagnostics.Debug.WriteLine(string.Format("Error: d = {0}\tn = {1}\tc = {2}\r\n{3}", d, n, Convert.ToUInt64(encStr.Substring(0,useChars)), ex.Message));
						MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
						updateRunning(false);
						return;
					}
					
					encStr = encStr.Substring(nextSpace + 1);
				}
				
				sw.Stop();
				decTime = sw.Elapsed.ToString();
				System.Diagnostics.Debug.WriteLine(string.Format("encTime = {0}", decTime));
				
				Invoke(new MethodInvoker(delegate
				{
					testDataTextBox.Text = tempStr;
				}));	
			}
			updateRunning(false);
		}
		
		private void runEncOnly(bool onFile)
		{
			UInt64 n, eVal, val = 0;
			string data2Enc = null, str = null;
			
			Invoke(new MethodInvoker(delegate
			{
				str = nTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out n))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
				str = eTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out eVal))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (!isPrime(eVal))
			{
				if (!running)
				{
					updateRunning(false);
					return;
				}
				
				MessageBox.Show("Error - " + eVal + " is not a prime number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (numberRadioButton.Checked)
			{
				Invoke(new MethodInvoker(delegate
				{
					str = valueTxtBx.Text.ToString();
				}));
				
				if (!str2long(str,out val))
				{
					MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			else // if (textRadioButton.Checked)
			{
				Invoke(new MethodInvoker(delegate
				{
					data2Enc = dataTextBox.Text;
				}));
				
				if (onFile)
				{
					data2Enc = readDataFromFile(data2Enc);
					if (data2Enc == null)
					{
						updateRunning(false);
						return;
					}
				}
			}
			
			if (!running)
			{
				updateRunning(false);
				return;
			}
				
			Invoke(new MethodInvoker(delegate
			{
				phiTxtBx.Text = "";
				dTxtBx.Text = "";
				encTxtBx.Text = "";
				testTxtBx.Text = "";
				if (!onFile)
					encDataTextBox.Text = "";
				testDataTextBox.Text = "";
				pTxtBx.Text = "";
				qTxtBx.Text = "";
				testDataTextBox.Text = "";
				testTxtBx.Text = "";
			}));
			
			if (numberRadioButton.Checked)
			{
				if (val >= n)
				{
					MessageBox.Show("Error: " + val + " >= " + n,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			else
			{
				bool legalN = true;
				UInt64 temp, maxVal = UInt64.MinValue;
				
				for (int i=0; legalN && i<data2Enc.Length; i++)
				{
					temp = (UInt64)data2Enc[i];
					if (temp>maxVal)
						maxVal = temp;
					legalN &= maxVal < n;
					
					if (!running)
					{
						updateRunning(false);
						return;
					}
				}
				
				if (!legalN)
				{
					MessageBox.Show("Error: " + maxVal + " (the highest char value in the text) >= " + n,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			
			encTime = string.Empty;
			decTime = string.Empty;

			if (numberRadioButton.Checked)
			{
				UInt64 enc;
				
				try
				{
					Stopwatch sw = new Stopwatch();
					sw.Start();

					enc = encrypt(eVal,n,val);
					
					sw.Stop();
					encTime = sw.Elapsed.ToString();
					System.Diagnostics.Debug.WriteLine(string.Format("encTime = {0}", encTime));
					
					if (!running)
					{
						updateRunning(false);
						return;
					}
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(string.Format("Error: e = {0}\tn = {1}\tm = {2}\r\n{3}", eVal, n, val, ex.Message));
					MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
								
				Invoke(new MethodInvoker(delegate
				{
					encTxtBx.Text = enc.ToString();
				}));
			}
			else
			{
				string tempStr = "";
				
				Stopwatch sw = new Stopwatch();
				sw.Start();
				
				for (int i=0; i<data2Enc.Length; i++)
				{
					if (tempStr != "")
						tempStr += " ";
					
					try
					{
						tempStr += encrypt(eVal,n,(UInt64)data2Enc[i]).ToString();
						if (!running)
						{
							updateRunning(false);
							return;
						}
					}
					catch (Exception ex)
					{
						System.Diagnostics.Debug.WriteLine(string.Format("Error: e = {0}\tn = {1}\tm = {2}\r\n{3}", eVal, n, (UInt64)data2Enc[i], ex.Message));
						MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
						updateRunning(false);
						return;
					}
				}
				
				sw.Stop();
				encTime = sw.Elapsed.ToString();
				System.Diagnostics.Debug.WriteLine(string.Format("encTime = {0}", encTime));
					
				if (!onFile)
				{
					Invoke(new MethodInvoker(delegate
					{
						encDataTextBox.Text = tempStr;
					}));
				}
				else
				{
					string saveDst = null;
					
					Invoke(new MethodInvoker(delegate
					{
						saveDst = encDataTextBox.Text;
					}));
					
					writeDataToFile(saveDst, tempStr);
				}
			}
			updateRunning(false);
		}
		
		private void runDecOnly(bool onFile)
		{
			UInt64 n ,d, val = 0;
			string data2Dec = null, str = null;

			Invoke(new MethodInvoker(delegate
			{
				str = nTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out n))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (!running)
			{
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
				str = dTxtBx.Text.ToString();
			}));
			
			if (!str2long(str,out d))
			{
				MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				updateRunning(false);
				return;
			}
			
			if (!running)
			{
				updateRunning(false);
				return;
			}
			
			if (numberRadioButton.Checked)
			{
				Invoke(new MethodInvoker(delegate
				{
					str = encTxtBx.Text.ToString();
				}));
				
				if (!str2long(str,out val))
				{
					MessageBox.Show("Error - \"" + str + "\" is not a legal number","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
			}
			else // if (textRadioButton.Checked)
			{
				Invoke(new MethodInvoker(delegate
				{
					data2Dec = encDataTextBox.Text;
				}));
				
				if (onFile)
				{
					data2Dec = readDataFromFile(data2Dec);
					if (data2Dec == null)
					{
						updateRunning(false);
						return;
					}
				}
			}
			
			if (!running)
			{
				updateRunning(false);
				return;
			}
			
			Invoke(new MethodInvoker(delegate
			{
				phiTxtBx.Text = "";
				eTxtBx.Text = "";
				valueTxtBx.Text = "";
				testTxtBx.Text = "";
				if (!onFile)
					dataTextBox.Text = "";
				testDataTextBox.Text = "";
				pTxtBx.Text = "";
				qTxtBx.Text = "";
				testDataTextBox.Text = "";
				testTxtBx.Text = "";
			}));
			
			encTime = string.Empty;
			decTime = string.Empty;
			
			if (numberRadioButton.Checked)
			{			
				try
				{
					Stopwatch sw = new Stopwatch();
					sw.Start();
					
					val = decrypt(d,n,val);
					
					sw.Stop();
					decTime = sw.Elapsed.ToString();
					System.Diagnostics.Debug.WriteLine(string.Format("decTime = {0}", decTime));
					
					if (!running)
					{
						updateRunning(false);
						return;
					}
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(string.Format("Error: d = {0}\tn = {1}\tc = {2}\r\n{3}", d, n, val, ex.Message));
					MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
								
				Invoke(new MethodInvoker(delegate
				{
					valueTxtBx.Text = val.ToString();
				}));
			}
			else
			{
				if (!checkEncFileData(data2Dec))
				{
					if (!running)
					{
						updateRunning(false);
						return;
					}
					
					MessageBox.Show("This is not an encrypted string","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
					updateRunning(false);
					return;
				}
				
				string tempStr = "";
				int nextSpace,useChars;
				
				if (data2Dec != "" && data2Dec[0]==' ')
				{
					int st;
					for (st = 0; st < data2Dec.Length && data2Dec[st] == ' '; st++);
					if (st < data2Dec.Length)
						data2Dec = data2Dec.Substring(st);
					else
						data2Dec = "";
				}
				
				Stopwatch sw = new Stopwatch();
				sw.Start();
				
				while (data2Dec != "")
				{
					nextSpace = data2Dec.IndexOf(" ");
					if (nextSpace<0)
					{
						nextSpace = data2Dec.Length-1;
						useChars = data2Dec.Length;
					}
					else
					{
						useChars = nextSpace;
					}
					
					try
					{
						tempStr += (char)Convert.ToByte(decrypt(d,n,Convert.ToUInt64(data2Dec.Substring(0,useChars))));
						
						if (!running)
						{
							updateRunning(false);
							return;
						}
					}
					catch (Exception ex)
					{
						System.Diagnostics.Debug.WriteLine(string.Format("Error: d = {0}\tn = {1}\tdata2Dec = \"{2}\"\tc = \"{3}\"\r\n{4}", d, n, data2Dec, data2Dec.Substring(0,useChars), ex.Message));
						MessageBox.Show("Error - " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
						updateRunning(false);
						return;
					}
					
					data2Dec = data2Dec.Substring(nextSpace + 1);
					
					if (data2Dec != "" && data2Dec[0]==' ')
					{
						int st;
						for (st = 0; st < data2Dec.Length && data2Dec[st] == ' '; st++);
						if (st < data2Dec.Length)
							data2Dec = data2Dec.Substring(st);
						else
							data2Dec = "";
					}
				}
				
				sw.Stop();
				decTime = sw.Elapsed.ToString();
				System.Diagnostics.Debug.WriteLine(string.Format("decTime = {0}", decTime));
					
				if (!onFile)
				{
					Invoke(new MethodInvoker(delegate
					{
						dataTextBox.Text = tempStr;
					}));
				}
				else
				{
					string saveDst = null;
					
					Invoke(new MethodInvoker(delegate
					{
						saveDst = dataTextBox.Text;
					}));
					
					writeDataToFile(saveDst, tempStr);
				}
			}
			updateRunning(false);
		}
		
		
		private void CalcBtnClick(object sender, EventArgs e)
		{
			if (startStopBtn.Text == "Start")
			{
				updateRunning(true);
				if (mkKeyAndEncRadioButton.Checked)
					thread = new Thread(runEncDec);
				else if (decFileRadioButton.Checked)
					thread = new Thread(() => runDecOnly(true));
				else if (encFileRadioButton.Checked)
					thread = new Thread(() => runEncOnly(true));
				else if (decStrRadioButton.Checked)
					thread = new Thread(() => runDecOnly(false));
				else //if (encStrRadioButton.Checked)
					thread = new Thread(() => runEncOnly(false));
				thread.Start();
			}
			else
			{
				if (running)
				{
					startStopBtn.Enabled = false;
					this.toolStripStatusLabel1.Text = "Stopping...";
					timer1.Enabled = true;
					running = false;
				}
			}
		}
		
		void PTxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void QTxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void ETxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void ValueTxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void DataTextBoxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void NumberRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			textPanel.Enabled = false;
			numPanel.Enabled = true;
			updateButton();
		}
		
		void TextRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			textPanel.Enabled = true;
			numPanel.Enabled = false;
			updateButton();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (running)
			{
				e.Cancel = true;
				MessageBox.Show("A process is still running in the background","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void MkKeyAndEncRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			numberRadioButton.Enabled = true;
			
			pTxtBx.ReadOnly = false;
			pTxtBx.Enabled = true;
			qTxtBx.ReadOnly = false;
			qTxtBx.Enabled = true;
			eTxtBx.ReadOnly = false;
			eTxtBx.Enabled = true;
				
			nTxtBx.ReadOnly = true;
			nTxtBx.Enabled = true;
			phiTxtBx.ReadOnly = true;
			phiTxtBx.Enabled = true;
			dTxtBx.ReadOnly = true;
			dTxtBx.Enabled = true;
			
			valueTxtBx.ReadOnly = false;
			valueTxtBx.Enabled = true;
			encTxtBx.ReadOnly = true;
			encTxtBx.Enabled = true;
			testTxtBx.ReadOnly = true;
			testTxtBx.Enabled = true;
			
			dataTextBox.ReadOnly = false;
			dataTextBox.Enabled = true;
			encDataTextBox.ReadOnly = true;
			encDataTextBox.Enabled = true;
			testDataTextBox.ReadOnly = true;
			testDataTextBox.Enabled = true;
		
			label6.Enabled = true; // Test value decryption
			label12.Enabled = true; // Test string decryption
			label1.Enabled = true; // p
			label2.Enabled = true; // q	
			label3.Enabled = true; // phi	
			label9.Enabled = true; // d	
			label7.Enabled = true; //e
			
			updateButton();
		}
		
		void EncFileRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			numberRadioButton.Enabled = false;
			textRadioButton.Select();
			
			pTxtBx.ReadOnly = true;
			pTxtBx.Enabled = false;
			qTxtBx.ReadOnly = true;
			qTxtBx.Enabled = false;
			eTxtBx.ReadOnly = false;
			eTxtBx.Enabled = true;
				
			nTxtBx.ReadOnly = false;
			nTxtBx.Enabled = true;
			phiTxtBx.ReadOnly = true;
			phiTxtBx.Enabled = false;
			dTxtBx.ReadOnly = true;
			dTxtBx.Enabled = false;
			
			dataTextBox.ReadOnly = true;
			dataTextBox.Enabled = true;
			encDataTextBox.ReadOnly = true;
			encDataTextBox.Enabled = true;
			testDataTextBox.ReadOnly = true;
			testDataTextBox.Enabled = false;
		
			label12.Enabled = false; // Test string decryption
			label1.Enabled = false; // p
			label2.Enabled = false; // q	
			label3.Enabled = false; // phi	
			label9.Enabled = false; // d	
			label7.Enabled = true; //e
			
			updateButton();
		}
		
		void DecFileRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			numberRadioButton.Enabled = false;
			textRadioButton.Select();
			
			pTxtBx.ReadOnly = true;
			pTxtBx.Enabled = false;
			qTxtBx.ReadOnly = true;
			qTxtBx.Enabled = false;
			eTxtBx.ReadOnly = true;
			eTxtBx.Enabled = false;
				
			nTxtBx.ReadOnly = false;
			nTxtBx.Enabled = true;
			phiTxtBx.ReadOnly = true;
			phiTxtBx.Enabled = false;
			dTxtBx.ReadOnly = false;
			dTxtBx.Enabled = true;
						
			dataTextBox.ReadOnly = true;
			dataTextBox.Enabled = true;
			encDataTextBox.ReadOnly = true;
			encDataTextBox.Enabled = true;
			testDataTextBox.ReadOnly = true;
			testDataTextBox.Enabled = false;
		
			label6.Enabled = false; // Test value decryption
			label12.Enabled = false; // Test string decryption
			label1.Enabled = false; // p
			label2.Enabled = false; // q	
			label3.Enabled = false; // phi
			label9.Enabled = true; // d	
			label7.Enabled = false; //e
			
			updateButton();
		}
		
		void EncStrRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			numberRadioButton.Enabled = true;
			
			pTxtBx.ReadOnly = true;
			pTxtBx.Enabled = false;
			qTxtBx.ReadOnly = true;
			qTxtBx.Enabled = false;
			eTxtBx.ReadOnly = false;
			eTxtBx.Enabled = true;
				
			nTxtBx.ReadOnly = false;
			nTxtBx.Enabled = true;
			phiTxtBx.ReadOnly = true;
			phiTxtBx.Enabled = false;
			dTxtBx.ReadOnly = true;
			dTxtBx.Enabled = false;
			
			valueTxtBx.ReadOnly = false;
			valueTxtBx.Enabled = true;
			encTxtBx.ReadOnly = true;
			encTxtBx.Enabled = true;
			testTxtBx.ReadOnly = true;
			testTxtBx.Enabled = false;
			
			dataTextBox.ReadOnly = false;
			dataTextBox.Enabled = true;
			encDataTextBox.ReadOnly = true;
			encDataTextBox.Enabled = true;
			testDataTextBox.ReadOnly = true;
			testDataTextBox.Enabled = false;
		
			label6.Enabled = false; // Test value decryption
			label12.Enabled = false; // Test string decryption
			label1.Enabled = false; // p
			label2.Enabled = false; // q	
			label3.Enabled = false; // phi	
			label9.Enabled = false; // d	
			label7.Enabled = true; //e
			
			updateButton();
		}
		
		void DecStrRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			numberRadioButton.Enabled = true;
			
			pTxtBx.ReadOnly = true;
			pTxtBx.Enabled = false;
			qTxtBx.ReadOnly = true;
			qTxtBx.Enabled = false;
			eTxtBx.ReadOnly = true;
			eTxtBx.Enabled = false;
				
			nTxtBx.ReadOnly = false;
			nTxtBx.Enabled = true;
			phiTxtBx.ReadOnly = true;
			phiTxtBx.Enabled = false;
			dTxtBx.ReadOnly = false;
			dTxtBx.Enabled = true;
			
			valueTxtBx.ReadOnly = true;
			valueTxtBx.Enabled = true;
			encTxtBx.ReadOnly = false;
			encTxtBx.Enabled = true;
			testTxtBx.ReadOnly = true;
			testTxtBx.Enabled = false;
			
			dataTextBox.ReadOnly = true;
			dataTextBox.Enabled = true;
			encDataTextBox.ReadOnly = false;
			encDataTextBox.Enabled = true;
			testDataTextBox.ReadOnly = true;
			testDataTextBox.Enabled = false;
		
			label6.Enabled = false; // Test value decryption
			label12.Enabled = false; // Test string decryption
			label1.Enabled = false; // p
			label2.Enabled = false; // q	
			label3.Enabled = false; // phi
			label9.Enabled = true; // d	
			label7.Enabled = false; //e
			
			updateButton();
		}
		
		private bool checkEncFileData(string data)
		{
			foreach (char chr in data)
			{
				if (!((chr>='0' && chr<='9') || chr==' '))
					return false;
				
				if (!running)
				{
					return false;
				}
			}
			return true;
		}
		
		private string getExistingFile()
		{
			OpenFileDialog openDialog = new OpenFileDialog();
			openDialog.Multiselect = false;
			if (openDialog.ShowDialog()==DialogResult.OK)
				return openDialog.FileName;
			else
				return null;
		}
		
		private string getNewFile()
		{
			SaveFileDialog saveDialog = new SaveFileDialog();
			if (saveDialog.ShowDialog()==DialogResult.OK)
				return saveDialog.FileName;
			else
				return null;
		}
		
		void DataTextBoxMouseClick(object sender, MouseEventArgs e)
		{
			if (encFileRadioButton.Checked)
			{
				string file = getExistingFile();
				if (file != null)
				{
					dataTextBox.Text = file;
					int dotIdx = file.IndexOf('.');
					if (dotIdx!=(-1))
						encDataTextBox.Text = file.Substring(0,dotIdx) + ".enc";
					else
						encDataTextBox.Text = file + ".enc";
				}
			}
			else if (decFileRadioButton.Checked)
			{
				string file = getNewFile();
				if (file != null)
					dataTextBox.Text = file;
			}
		}
		
		void EncDataTextBoxMouseClick(object sender, MouseEventArgs e)
		{
			if (encFileRadioButton.Checked)
			{
				string file = getNewFile();
				if (file != null)
					encDataTextBox.Text = file;
			}
			else if (decFileRadioButton.Checked)
			{
				string file = getExistingFile();
				if (file != null)
				{
					encDataTextBox.Text = file;
					int dotIdx = file.IndexOf('.');
					if (dotIdx!=(-1))
						dataTextBox.Text = file.Substring(0,dotIdx) + ".txt";
					else
						dataTextBox.Text = file + ".txt";
				}
			}
		}
		
		private string readDataFromFile(string filePath)
		{
			FileInfo fileInfo = null;
			
			System.Diagnostics.Debug.WriteLine("Reading data from: " + filePath);
			
			try
			{
				fileInfo = new FileInfo(filePath);
				if (!fileInfo.Exists)
				{
					MessageBox.Show("The file doesn't exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return null;
				}
				else
				{
					string str = File.ReadAllText(filePath);
					return str;
				}	
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return null;
			}
		}
		
		private bool writeDataToFile(string filePath, string dataToWrite)
		{
			FileInfo fileInfo = null;
			
			System.Diagnostics.Debug.WriteLine("Saving data to: " + filePath);
			
			try
			{
				fileInfo = new FileInfo(filePath);
				if (fileInfo.Exists)
				{
					filePath += "." + DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss.fff") + ".txt";
					//MessageBox.Show("The file already exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					MessageBox.Show("The file already exists. Saving to " + filePath,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
					System.Diagnostics.Debug.WriteLine("The file already exists. Saving to " + filePath);
					//return false;
				}
				
				File.WriteAllText(filePath, dataToWrite);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (!thread.IsAlive)
			{
				startStopBtn.Enabled = true;
				timer1.Enabled = false;
				thread = null;
			}
		}
		
		void NTxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}

		void DTxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void EncTxtBxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
		
		void EncDataTextBoxTextChanged(object sender, EventArgs e)
		{
			updateButton();
		}
	}
}
