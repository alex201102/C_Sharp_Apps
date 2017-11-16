/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 26/03/2017
 * Time: 20:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
//using System.Collections.Generic;
//using System.Drawing;
using System.Windows.Forms;

namespace IntegerOverflowDemo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private enum ShiftDirection { Right, Left };
		private static bool signedInt;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			
			signedInt = true;
			setMinMax();
			updateTitle();
		}
		
		void NumericUpDownValueChanged(object sender, EventArgs e)
		{			
			showBinValues();
		}
		
		private void showBinValues()
		{
			if (signedInt)
				showBinVal(Convert.ToInt32(numericUpDown.Value));
			else
				showBinVal(Convert.ToUInt32(numericUpDown.Value));
		}
		
		void ExitBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void MinValBtnClick(object sender, EventArgs e)
		{
			if (signedInt)
				numericUpDown.Value = int.MinValue;
			else
				numericUpDown.Value = uint.MinValue;
		}
		
		void MaxValBtnClick(object sender, EventArgs e)
		{
			if (signedInt)
				numericUpDown.Value = int.MaxValue;
			else
				numericUpDown.Value = uint.MaxValue;
		}
		
		void SignedBtnClick(object sender, EventArgs e)
		{
			signedInt = !signedInt;
			setMinMax();
				
			if (signedInt)
			{
				signedBtn.Text = "Signed";
				updateTitle();
			}
			else
			{
				signedBtn.Text = "Unsigned";
				updateTitle();
			}
		}
		
		void ShrBtnClick(object sender, EventArgs e)
		{
			if (signedInt)
				showBinVal(shiftIntVal(Convert.ToInt32(numericUpDown.Value), ShiftDirection.Right));
			else
				showBinVal(shiftIntVal(Convert.ToUInt32(numericUpDown.Value), ShiftDirection.Right));
		}
		
		void ShlBtnClick(object sender, EventArgs e)
		{
			if (signedInt)
				showBinVal(shiftIntVal(Convert.ToInt32(numericUpDown.Value), ShiftDirection.Left));
			else
				showBinVal(shiftIntVal(Convert.ToUInt32(numericUpDown.Value), ShiftDirection.Left));
		}
		
		private void setMinMax()
		{
			if (signedInt)
			{
				uint value = Convert.ToUInt32(numericUpDown.Value);
				if (value > int.MaxValue)
					numericUpDown.Value = int.MaxValue;
				
				numericUpDown.Minimum = int.MinValue;
				numericUpDown.Maximum = int.MaxValue;
			}
			else
			{
				int value = Convert.ToInt32(numericUpDown.Value);
				if (value < 0)
					numericUpDown.Value = 0;
				
				numericUpDown.Minimum = uint.MinValue;
				numericUpDown.Maximum = uint.MaxValue;
			}
			
			showBinValues();
		}
		
		private void showBinVal(int value)
		{
			int nextVal, prevVal;
				
			if (value == int.MaxValue)
				nextVal = int.MinValue;
			else
				nextVal = value + 1;
					
			if (value == int.MinValue)
				prevVal = int.MaxValue;
			else
				prevVal = value - 1;
				
			prevDecTxtBx.Text = prevVal.ToString();
			currDecTxtBx.Text = value.ToString();
			nextDecTxtBx.Text = nextVal.ToString();
				
			currNumTxtBx.Text = Convert.ToString(value, 2).PadLeft(32, '0');
			prevValTxtBx.Text = Convert.ToString(prevVal, 2).PadLeft(32, '0');
			nextValTxtBx.Text = Convert.ToString(nextVal, 2).PadLeft(32, '0');
		}
		
		private void showBinVal(uint value)
		{
			uint nextVal, prevVal;
				
			if (value == uint.MaxValue)
				nextVal = uint.MinValue;
			else
				nextVal = value + 1;
					
			if (value == uint.MinValue)
				prevVal = uint.MaxValue;
			else
				prevVal = value - 1;
				
			prevDecTxtBx.Text = prevVal.ToString();
			currDecTxtBx.Text = value.ToString();
			nextDecTxtBx.Text = nextVal.ToString();
				
			currNumTxtBx.Text = Convert.ToString(value, 2).PadLeft(32, '0');
			prevValTxtBx.Text = Convert.ToString(prevVal, 2).PadLeft(32, '0');
			nextValTxtBx.Text = Convert.ToString(nextVal, 2).PadLeft(32, '0');
		}
		
		private int shiftIntVal(int value, ShiftDirection dir)
		{
			// Shift has no effect on the value 0
			if (value == 0)
				return value;
			
			if (dir == ShiftDirection.Right)
				value >>= 1;
			else // if (dir == ShiftDirection.Left)
				value <<= 1;
			
			numericUpDown.Value = value;
			
			return value;
		}
		
		private uint shiftIntVal(uint value, ShiftDirection dir)
		{
			// Shift has no effect on the value 0
			if (value == 0)
				return value;
			
			if (dir == ShiftDirection.Right)
				value >>= 1;
			else // if (dir == ShiftDirection.Left)
				value <<= 1;
			
			numericUpDown.Value = value;
			
			return value;
		}
		
		private void updateTitle()
		{
			if (signedInt)
				this.Text = "Signed ";
			else
				this.Text = "Unsigned ";
			
			this.Text += " Integer Overflow Demo";
		}
	}
}
