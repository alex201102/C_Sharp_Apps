/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 25/02/2017
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Password_Generator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox passTextBox;
		private System.Windows.Forms.Label passLbl;
		private System.Windows.Forms.Button genBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label passLenLbl;
		private System.Windows.Forms.NumericUpDown passLenNumericUpDown;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.CheckBox lowCaseCheckBox;
		private System.Windows.Forms.CheckBox upCaseCheckBox;
		private System.Windows.Forms.CheckBox digitsCheckBox;
		private System.Windows.Forms.CheckBox symbolsCheckBox;
		private System.Windows.Forms.TextBox symbTextBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.passTextBox = new System.Windows.Forms.TextBox();
			this.passLbl = new System.Windows.Forms.Label();
			this.genBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.passLenLbl = new System.Windows.Forms.Label();
			this.passLenNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.lowCaseCheckBox = new System.Windows.Forms.CheckBox();
			this.upCaseCheckBox = new System.Windows.Forms.CheckBox();
			this.digitsCheckBox = new System.Windows.Forms.CheckBox();
			this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
			this.symbTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.passLenNumericUpDown)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// passTextBox
			// 
			this.passTextBox.Location = new System.Drawing.Point(13, 119);
			this.passTextBox.Multiline = true;
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.ReadOnly = true;
			this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.passTextBox.Size = new System.Drawing.Size(259, 185);
			this.passTextBox.TabIndex = 0;
			// 
			// passLbl
			// 
			this.passLbl.Location = new System.Drawing.Point(13, 96);
			this.passLbl.Name = "passLbl";
			this.passLbl.Size = new System.Drawing.Size(61, 20);
			this.passLbl.TabIndex = 1;
			this.passLbl.Text = "Password:";
			// 
			// genBtn
			// 
			this.genBtn.Location = new System.Drawing.Point(13, 313);
			this.genBtn.Name = "genBtn";
			this.genBtn.Size = new System.Drawing.Size(75, 23);
			this.genBtn.TabIndex = 2;
			this.genBtn.Text = "Generate";
			this.genBtn.UseVisualStyleBackColor = true;
			this.genBtn.Click += new System.EventHandler(this.GenBtnClick);
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(197, 313);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(75, 23);
			this.exitBtn.TabIndex = 3;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(105, 313);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 4;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.SaveBtnClick);
			// 
			// passLenLbl
			// 
			this.passLenLbl.Location = new System.Drawing.Point(12, 13);
			this.passLenLbl.Name = "passLenLbl";
			this.passLenLbl.Size = new System.Drawing.Size(100, 19);
			this.passLenLbl.TabIndex = 5;
			this.passLenLbl.Text = "Password lenght:";
			// 
			// passLenNumericUpDown
			// 
			this.passLenNumericUpDown.Location = new System.Drawing.Point(105, 11);
			this.passLenNumericUpDown.Maximum = new decimal(new int[] {
			99999,
			0,
			0,
			0});
			this.passLenNumericUpDown.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.passLenNumericUpDown.Name = "passLenNumericUpDown";
			this.passLenNumericUpDown.Size = new System.Drawing.Size(75, 20);
			this.passLenNumericUpDown.TabIndex = 6;
			this.passLenNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.passLenNumericUpDown.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.passLenNumericUpDown.ValueChanged += new System.EventHandler(this.PassLenNumericUpDownValueChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 346);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
			// 
			// lowCaseCheckBox
			// 
			this.lowCaseCheckBox.Location = new System.Drawing.Point(13, 37);
			this.lowCaseCheckBox.Name = "lowCaseCheckBox";
			this.lowCaseCheckBox.Size = new System.Drawing.Size(75, 24);
			this.lowCaseCheckBox.TabIndex = 8;
			this.lowCaseCheckBox.Text = "Low Case";
			this.lowCaseCheckBox.UseVisualStyleBackColor = true;
			this.lowCaseCheckBox.CheckedChanged += new System.EventHandler(this.LowCaseCheckBoxCheckedChanged);
			// 
			// upCaseCheckBox
			// 
			this.upCaseCheckBox.Location = new System.Drawing.Point(94, 37);
			this.upCaseCheckBox.Name = "upCaseCheckBox";
			this.upCaseCheckBox.Size = new System.Drawing.Size(73, 24);
			this.upCaseCheckBox.TabIndex = 9;
			this.upCaseCheckBox.Text = "Up Case";
			this.upCaseCheckBox.UseVisualStyleBackColor = true;
			this.upCaseCheckBox.CheckedChanged += new System.EventHandler(this.UpCaseCheckBoxCheckedChanged);
			// 
			// digitsCheckBox
			// 
			this.digitsCheckBox.Location = new System.Drawing.Point(168, 37);
			this.digitsCheckBox.Name = "digitsCheckBox";
			this.digitsCheckBox.Size = new System.Drawing.Size(60, 24);
			this.digitsCheckBox.TabIndex = 10;
			this.digitsCheckBox.Text = "Digits";
			this.digitsCheckBox.UseVisualStyleBackColor = true;
			this.digitsCheckBox.CheckedChanged += new System.EventHandler(this.DigitsCheckBoxCheckedChanged);
			// 
			// symbolsCheckBox
			// 
			this.symbolsCheckBox.Location = new System.Drawing.Point(13, 67);
			this.symbolsCheckBox.Name = "symbolsCheckBox";
			this.symbolsCheckBox.Size = new System.Drawing.Size(75, 24);
			this.symbolsCheckBox.TabIndex = 11;
			this.symbolsCheckBox.Text = "Symbols:";
			this.symbolsCheckBox.UseVisualStyleBackColor = true;
			this.symbolsCheckBox.CheckedChanged += new System.EventHandler(this.SymbolsCheckBoxCheckedChanged);
			// 
			// symbTextBox
			// 
			this.symbTextBox.Location = new System.Drawing.Point(80, 69);
			this.symbTextBox.Name = "symbTextBox";
			this.symbTextBox.Size = new System.Drawing.Size(192, 20);
			this.symbTextBox.TabIndex = 12;
			this.symbTextBox.TextChanged += new System.EventHandler(this.SymbTextBoxTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 368);
			this.Controls.Add(this.symbTextBox);
			this.Controls.Add(this.symbolsCheckBox);
			this.Controls.Add(this.digitsCheckBox);
			this.Controls.Add(this.upCaseCheckBox);
			this.Controls.Add(this.lowCaseCheckBox);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.passLenNumericUpDown);
			this.Controls.Add(this.passLenLbl);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.genBtn);
			this.Controls.Add(this.passLbl);
			this.Controls.Add(this.passTextBox);
			this.Name = "MainForm";
			this.Text = "Password_Generator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.passLenNumericUpDown)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
