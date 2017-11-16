/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 07/07/2016
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RSA_App
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button startStopBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox pTxtBx;
		private System.Windows.Forms.TextBox qTxtBx;
		private System.Windows.Forms.TextBox phiTxtBx;
		private System.Windows.Forms.TextBox valueTxtBx;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox eTxtBx;
		private System.Windows.Forms.TextBox encTxtBx;
		private System.Windows.Forms.TextBox testTxtBx;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox nTxtBx;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox dTxtBx;
		private System.Windows.Forms.Panel numPanel;
		private System.Windows.Forms.Panel textPanel;
		private System.Windows.Forms.RadioButton numberRadioButton;
		private System.Windows.Forms.RadioButton textRadioButton;
		private System.Windows.Forms.TextBox testDataTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox encDataTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox dataTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton decStrRadioButton;
		private System.Windows.Forms.RadioButton encStrRadioButton;
		private System.Windows.Forms.RadioButton decFileRadioButton;
		private System.Windows.Forms.RadioButton encFileRadioButton;
		private System.Windows.Forms.RadioButton mkKeyAndEncRadioButton;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.RadioButton tempRadioButton;
		
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
			this.components = new System.ComponentModel.Container();
			this.startStopBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pTxtBx = new System.Windows.Forms.TextBox();
			this.qTxtBx = new System.Windows.Forms.TextBox();
			this.phiTxtBx = new System.Windows.Forms.TextBox();
			this.valueTxtBx = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.eTxtBx = new System.Windows.Forms.TextBox();
			this.encTxtBx = new System.Windows.Forms.TextBox();
			this.testTxtBx = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nTxtBx = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dTxtBx = new System.Windows.Forms.TextBox();
			this.numPanel = new System.Windows.Forms.Panel();
			this.textPanel = new System.Windows.Forms.Panel();
			this.testDataTextBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.encDataTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dataTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.numberRadioButton = new System.Windows.Forms.RadioButton();
			this.textRadioButton = new System.Windows.Forms.RadioButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tempRadioButton = new System.Windows.Forms.RadioButton();
			this.decStrRadioButton = new System.Windows.Forms.RadioButton();
			this.encStrRadioButton = new System.Windows.Forms.RadioButton();
			this.decFileRadioButton = new System.Windows.Forms.RadioButton();
			this.encFileRadioButton = new System.Windows.Forms.RadioButton();
			this.mkKeyAndEncRadioButton = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.numPanel.SuspendLayout();
			this.textPanel.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// startStopBtn
			// 
			this.startStopBtn.Location = new System.Drawing.Point(12, 420);
			this.startStopBtn.Name = "startStopBtn";
			this.startStopBtn.Size = new System.Drawing.Size(75, 23);
			this.startStopBtn.TabIndex = 0;
			this.startStopBtn.Text = "Start";
			this.startStopBtn.UseVisualStyleBackColor = true;
			this.startStopBtn.Click += new System.EventHandler(this.CalcBtnClick);
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(344, 420);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(75, 23);
			this.exitBtn.TabIndex = 1;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "P=";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Q=";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(233, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phi=";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Value=";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Encrypted Value:";
			// 
			// pTxtBx
			// 
			this.pTxtBx.Location = new System.Drawing.Point(50, 90);
			this.pTxtBx.Name = "pTxtBx";
			this.pTxtBx.Size = new System.Drawing.Size(150, 20);
			this.pTxtBx.TabIndex = 7;
			this.pTxtBx.TextChanged += new System.EventHandler(this.PTxtBxTextChanged);
			// 
			// qTxtBx
			// 
			this.qTxtBx.Location = new System.Drawing.Point(50, 117);
			this.qTxtBx.Name = "qTxtBx";
			this.qTxtBx.Size = new System.Drawing.Size(150, 20);
			this.qTxtBx.TabIndex = 8;
			this.qTxtBx.TextChanged += new System.EventHandler(this.QTxtBxTextChanged);
			// 
			// phiTxtBx
			// 
			this.phiTxtBx.Location = new System.Drawing.Point(270, 116);
			this.phiTxtBx.Name = "phiTxtBx";
			this.phiTxtBx.ReadOnly = true;
			this.phiTxtBx.Size = new System.Drawing.Size(150, 20);
			this.phiTxtBx.TabIndex = 9;
			// 
			// valueTxtBx
			// 
			this.valueTxtBx.Location = new System.Drawing.Point(64, 8);
			this.valueTxtBx.Name = "valueTxtBx";
			this.valueTxtBx.Size = new System.Drawing.Size(150, 20);
			this.valueTxtBx.TabIndex = 10;
			this.valueTxtBx.TextChanged += new System.EventHandler(this.ValueTxtBxTextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Test Decryption:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "e=";
			// 
			// eTxtBx
			// 
			this.eTxtBx.Location = new System.Drawing.Point(50, 149);
			this.eTxtBx.Name = "eTxtBx";
			this.eTxtBx.Size = new System.Drawing.Size(150, 20);
			this.eTxtBx.TabIndex = 13;
			this.eTxtBx.TextChanged += new System.EventHandler(this.ETxtBxTextChanged);
			// 
			// encTxtBx
			// 
			this.encTxtBx.Location = new System.Drawing.Point(104, 35);
			this.encTxtBx.Name = "encTxtBx";
			this.encTxtBx.ReadOnly = true;
			this.encTxtBx.Size = new System.Drawing.Size(150, 20);
			this.encTxtBx.TabIndex = 14;
			this.encTxtBx.TextChanged += new System.EventHandler(this.EncTxtBxTextChanged);
			// 
			// testTxtBx
			// 
			this.testTxtBx.Location = new System.Drawing.Point(104, 62);
			this.testTxtBx.Name = "testTxtBx";
			this.testTxtBx.ReadOnly = true;
			this.testTxtBx.Size = new System.Drawing.Size(150, 20);
			this.testTxtBx.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(233, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "n=";
			// 
			// nTxtBx
			// 
			this.nTxtBx.Location = new System.Drawing.Point(269, 90);
			this.nTxtBx.Name = "nTxtBx";
			this.nTxtBx.ReadOnly = true;
			this.nTxtBx.Size = new System.Drawing.Size(151, 20);
			this.nTxtBx.TabIndex = 17;
			this.nTxtBx.TextChanged += new System.EventHandler(this.NTxtBxTextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(233, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(30, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "d=";
			// 
			// dTxtBx
			// 
			this.dTxtBx.Location = new System.Drawing.Point(269, 149);
			this.dTxtBx.Name = "dTxtBx";
			this.dTxtBx.ReadOnly = true;
			this.dTxtBx.Size = new System.Drawing.Size(150, 20);
			this.dTxtBx.TabIndex = 19;
			this.dTxtBx.TextChanged += new System.EventHandler(this.DTxtBxTextChanged);
			// 
			// numPanel
			// 
			this.numPanel.Controls.Add(this.encTxtBx);
			this.numPanel.Controls.Add(this.label4);
			this.numPanel.Controls.Add(this.label5);
			this.numPanel.Controls.Add(this.valueTxtBx);
			this.numPanel.Controls.Add(this.label6);
			this.numPanel.Controls.Add(this.testTxtBx);
			this.numPanel.Location = new System.Drawing.Point(13, 203);
			this.numPanel.Name = "numPanel";
			this.numPanel.Size = new System.Drawing.Size(406, 92);
			this.numPanel.TabIndex = 20;
			// 
			// textPanel
			// 
			this.textPanel.Controls.Add(this.testDataTextBox);
			this.textPanel.Controls.Add(this.label12);
			this.textPanel.Controls.Add(this.encDataTextBox);
			this.textPanel.Controls.Add(this.label11);
			this.textPanel.Controls.Add(this.dataTextBox);
			this.textPanel.Controls.Add(this.label10);
			this.textPanel.Location = new System.Drawing.Point(13, 322);
			this.textPanel.Name = "textPanel";
			this.textPanel.Size = new System.Drawing.Size(406, 92);
			this.textPanel.TabIndex = 21;
			// 
			// testDataTextBox
			// 
			this.testDataTextBox.Location = new System.Drawing.Point(104, 62);
			this.testDataTextBox.Name = "testDataTextBox";
			this.testDataTextBox.ReadOnly = true;
			this.testDataTextBox.Size = new System.Drawing.Size(299, 20);
			this.testDataTextBox.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(12, 65);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "Test Decryption:";
			// 
			// encDataTextBox
			// 
			this.encDataTextBox.Location = new System.Drawing.Point(104, 35);
			this.encDataTextBox.Name = "encDataTextBox";
			this.encDataTextBox.ReadOnly = true;
			this.encDataTextBox.Size = new System.Drawing.Size(299, 20);
			this.encDataTextBox.TabIndex = 3;
			this.encDataTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EncDataTextBoxMouseClick);
			this.encDataTextBox.TextChanged += new System.EventHandler(this.EncDataTextBoxTextChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 38);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Encrypted Text:";
			// 
			// dataTextBox
			// 
			this.dataTextBox.Location = new System.Drawing.Point(64, 9);
			this.dataTextBox.Name = "dataTextBox";
			this.dataTextBox.Size = new System.Drawing.Size(339, 20);
			this.dataTextBox.TabIndex = 1;
			this.dataTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataTextBoxMouseClick);
			this.dataTextBox.TextChanged += new System.EventHandler(this.DataTextBoxTextChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(13, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Text=";
			// 
			// numberRadioButton
			// 
			this.numberRadioButton.Location = new System.Drawing.Point(13, 179);
			this.numberRadioButton.Name = "numberRadioButton";
			this.numberRadioButton.Size = new System.Drawing.Size(74, 24);
			this.numberRadioButton.TabIndex = 22;
			this.numberRadioButton.TabStop = true;
			this.numberRadioButton.Text = "Number";
			this.numberRadioButton.UseVisualStyleBackColor = true;
			this.numberRadioButton.CheckedChanged += new System.EventHandler(this.NumberRadioButtonCheckedChanged);
			// 
			// textRadioButton
			// 
			this.textRadioButton.Location = new System.Drawing.Point(13, 297);
			this.textRadioButton.Name = "textRadioButton";
			this.textRadioButton.Size = new System.Drawing.Size(74, 24);
			this.textRadioButton.TabIndex = 23;
			this.textRadioButton.TabStop = true;
			this.textRadioButton.Text = "Text";
			this.textRadioButton.UseVisualStyleBackColor = true;
			this.textRadioButton.CheckedChanged += new System.EventHandler(this.TextRadioButtonCheckedChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 449);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(433, 22);
			this.statusStrip1.TabIndex = 24;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tempRadioButton);
			this.panel1.Controls.Add(this.decStrRadioButton);
			this.panel1.Controls.Add(this.encStrRadioButton);
			this.panel1.Controls.Add(this.decFileRadioButton);
			this.panel1.Controls.Add(this.encFileRadioButton);
			this.panel1.Controls.Add(this.mkKeyAndEncRadioButton);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Location = new System.Drawing.Point(12, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 80);
			this.panel1.TabIndex = 25;
			// 
			// tempRadioButton
			// 
			this.tempRadioButton.Location = new System.Drawing.Point(221, 3);
			this.tempRadioButton.Name = "tempRadioButton";
			this.tempRadioButton.Size = new System.Drawing.Size(155, 24);
			this.tempRadioButton.TabIndex = 6;
			this.tempRadioButton.TabStop = true;
			this.tempRadioButton.Text = "tempRadioButton";
			this.tempRadioButton.UseVisualStyleBackColor = true;
			// 
			// decStrRadioButton
			// 
			this.decStrRadioButton.Location = new System.Drawing.Point(221, 50);
			this.decStrRadioButton.Name = "decStrRadioButton";
			this.decStrRadioButton.Size = new System.Drawing.Size(155, 24);
			this.decStrRadioButton.TabIndex = 5;
			this.decStrRadioButton.TabStop = true;
			this.decStrRadioButton.Text = "String/Value: Decrypt Only";
			this.decStrRadioButton.UseVisualStyleBackColor = true;
			this.decStrRadioButton.CheckedChanged += new System.EventHandler(this.DecStrRadioButtonCheckedChanged);
			// 
			// encStrRadioButton
			// 
			this.encStrRadioButton.Location = new System.Drawing.Point(221, 26);
			this.encStrRadioButton.Name = "encStrRadioButton";
			this.encStrRadioButton.Size = new System.Drawing.Size(155, 24);
			this.encStrRadioButton.TabIndex = 4;
			this.encStrRadioButton.TabStop = true;
			this.encStrRadioButton.Text = "String/Value: Encrypt Only";
			this.encStrRadioButton.UseVisualStyleBackColor = true;
			this.encStrRadioButton.CheckedChanged += new System.EventHandler(this.EncStrRadioButtonCheckedChanged);
			// 
			// decFileRadioButton
			// 
			this.decFileRadioButton.Location = new System.Drawing.Point(70, 50);
			this.decFileRadioButton.Name = "decFileRadioButton";
			this.decFileRadioButton.Size = new System.Drawing.Size(118, 24);
			this.decFileRadioButton.TabIndex = 3;
			this.decFileRadioButton.TabStop = true;
			this.decFileRadioButton.Text = "File: Decrypt Only";
			this.decFileRadioButton.UseVisualStyleBackColor = true;
			this.decFileRadioButton.CheckedChanged += new System.EventHandler(this.DecFileRadioButtonCheckedChanged);
			// 
			// encFileRadioButton
			// 
			this.encFileRadioButton.Location = new System.Drawing.Point(70, 26);
			this.encFileRadioButton.Name = "encFileRadioButton";
			this.encFileRadioButton.Size = new System.Drawing.Size(109, 24);
			this.encFileRadioButton.TabIndex = 2;
			this.encFileRadioButton.TabStop = true;
			this.encFileRadioButton.Text = "File: Encrypt Only";
			this.encFileRadioButton.UseVisualStyleBackColor = true;
			this.encFileRadioButton.CheckedChanged += new System.EventHandler(this.EncFileRadioButtonCheckedChanged);
			// 
			// mkKeyAndEncRadioButton
			// 
			this.mkKeyAndEncRadioButton.Location = new System.Drawing.Point(70, 3);
			this.mkKeyAndEncRadioButton.Name = "mkKeyAndEncRadioButton";
			this.mkKeyAndEncRadioButton.Size = new System.Drawing.Size(145, 24);
			this.mkKeyAndEncRadioButton.TabIndex = 1;
			this.mkKeyAndEncRadioButton.TabStop = true;
			this.mkKeyAndEncRadioButton.Text = "Create Key and Encrypt";
			this.mkKeyAndEncRadioButton.UseVisualStyleBackColor = true;
			this.mkKeyAndEncRadioButton.CheckedChanged += new System.EventHandler(this.MkKeyAndEncRadioButtonCheckedChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(3, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 18);
			this.label13.TabIndex = 0;
			this.label13.Text = "Work Mode:";
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 471);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textRadioButton);
			this.Controls.Add(this.numberRadioButton);
			this.Controls.Add(this.textPanel);
			this.Controls.Add(this.numPanel);
			this.Controls.Add(this.dTxtBx);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.nTxtBx);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.eTxtBx);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.phiTxtBx);
			this.Controls.Add(this.qTxtBx);
			this.Controls.Add(this.pTxtBx);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.startStopBtn);
			this.Name = "MainForm";
			this.Text = "RSA App";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.numPanel.ResumeLayout(false);
			this.numPanel.PerformLayout();
			this.textPanel.ResumeLayout(false);
			this.textPanel.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
