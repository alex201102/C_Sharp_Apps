/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 26/03/2017
 * Time: 20:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IntegerOverflowDemo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button minValBtn;
		private System.Windows.Forms.Button maxValBtn;
		private System.Windows.Forms.Button signedBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox currNumTxtBx;
		private System.Windows.Forms.TextBox nextValTxtBx;
		private System.Windows.Forms.Label prevValLbl;
		private System.Windows.Forms.TextBox prevValTxtBx;
		private System.Windows.Forms.TextBox prevDecTxtBx;
		private System.Windows.Forms.TextBox currDecTxtBx;
		private System.Windows.Forms.TextBox nextDecTxtBx;
		private System.Windows.Forms.Button shlBtn;
		private System.Windows.Forms.Button shrBtn;
		
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
			this.minValBtn = new System.Windows.Forms.Button();
			this.maxValBtn = new System.Windows.Forms.Button();
			this.signedBtn = new System.Windows.Forms.Button();
			this.exitBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.currNumTxtBx = new System.Windows.Forms.TextBox();
			this.nextValTxtBx = new System.Windows.Forms.TextBox();
			this.prevValLbl = new System.Windows.Forms.Label();
			this.prevValTxtBx = new System.Windows.Forms.TextBox();
			this.prevDecTxtBx = new System.Windows.Forms.TextBox();
			this.currDecTxtBx = new System.Windows.Forms.TextBox();
			this.nextDecTxtBx = new System.Windows.Forms.TextBox();
			this.shlBtn = new System.Windows.Forms.Button();
			this.shrBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// minValBtn
			// 
			this.minValBtn.Location = new System.Drawing.Point(12, 151);
			this.minValBtn.Name = "minValBtn";
			this.minValBtn.Size = new System.Drawing.Size(75, 23);
			this.minValBtn.TabIndex = 0;
			this.minValBtn.Text = "Min. Value";
			this.minValBtn.UseVisualStyleBackColor = true;
			this.minValBtn.Click += new System.EventHandler(this.MinValBtnClick);
			// 
			// maxValBtn
			// 
			this.maxValBtn.Location = new System.Drawing.Point(118, 151);
			this.maxValBtn.Name = "maxValBtn";
			this.maxValBtn.Size = new System.Drawing.Size(75, 23);
			this.maxValBtn.TabIndex = 1;
			this.maxValBtn.Text = "Max. Value";
			this.maxValBtn.UseVisualStyleBackColor = true;
			this.maxValBtn.Click += new System.EventHandler(this.MaxValBtnClick);
			// 
			// signedBtn
			// 
			this.signedBtn.Location = new System.Drawing.Point(232, 151);
			this.signedBtn.Name = "signedBtn";
			this.signedBtn.Size = new System.Drawing.Size(75, 23);
			this.signedBtn.TabIndex = 2;
			this.signedBtn.Text = "Signed";
			this.signedBtn.UseVisualStyleBackColor = true;
			this.signedBtn.Click += new System.EventHandler(this.SignedBtnClick);
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(338, 151);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(75, 23);
			this.exitBtn.TabIndex = 3;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.ExitBtnClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Number:";
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(70, 11);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(123, 20);
			this.numericUpDown.TabIndex = 5;
			this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Current Number:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Next Value:";
			// 
			// currNumTxtBx
			// 
			this.currNumTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.currNumTxtBx.Location = new System.Drawing.Point(107, 82);
			this.currNumTxtBx.Name = "currNumTxtBx";
			this.currNumTxtBx.ReadOnly = true;
			this.currNumTxtBx.Size = new System.Drawing.Size(211, 20);
			this.currNumTxtBx.TabIndex = 8;
			// 
			// nextValTxtBx
			// 
			this.nextValTxtBx.Location = new System.Drawing.Point(107, 112);
			this.nextValTxtBx.Name = "nextValTxtBx";
			this.nextValTxtBx.ReadOnly = true;
			this.nextValTxtBx.Size = new System.Drawing.Size(211, 20);
			this.nextValTxtBx.TabIndex = 9;
			// 
			// prevValLbl
			// 
			this.prevValLbl.Location = new System.Drawing.Point(12, 54);
			this.prevValLbl.Name = "prevValLbl";
			this.prevValLbl.Size = new System.Drawing.Size(89, 19);
			this.prevValLbl.TabIndex = 10;
			this.prevValLbl.Text = "Prev. Value:";
			// 
			// prevValTxtBx
			// 
			this.prevValTxtBx.Location = new System.Drawing.Point(107, 51);
			this.prevValTxtBx.Name = "prevValTxtBx";
			this.prevValTxtBx.ReadOnly = true;
			this.prevValTxtBx.Size = new System.Drawing.Size(211, 20);
			this.prevValTxtBx.TabIndex = 11;
			// 
			// prevDecTxtBx
			// 
			this.prevDecTxtBx.Location = new System.Drawing.Point(324, 51);
			this.prevDecTxtBx.Name = "prevDecTxtBx";
			this.prevDecTxtBx.ReadOnly = true;
			this.prevDecTxtBx.Size = new System.Drawing.Size(89, 20);
			this.prevDecTxtBx.TabIndex = 12;
			// 
			// currDecTxtBx
			// 
			this.currDecTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.currDecTxtBx.Location = new System.Drawing.Point(324, 82);
			this.currDecTxtBx.Name = "currDecTxtBx";
			this.currDecTxtBx.ReadOnly = true;
			this.currDecTxtBx.Size = new System.Drawing.Size(89, 20);
			this.currDecTxtBx.TabIndex = 13;
			// 
			// nextDecTxtBx
			// 
			this.nextDecTxtBx.Location = new System.Drawing.Point(324, 112);
			this.nextDecTxtBx.Name = "nextDecTxtBx";
			this.nextDecTxtBx.ReadOnly = true;
			this.nextDecTxtBx.Size = new System.Drawing.Size(89, 20);
			this.nextDecTxtBx.TabIndex = 14;
			// 
			// shlBtn
			// 
			this.shlBtn.Location = new System.Drawing.Point(199, 8);
			this.shlBtn.Name = "shlBtn";
			this.shlBtn.Size = new System.Drawing.Size(52, 23);
			this.shlBtn.TabIndex = 15;
			this.shlBtn.Text = "<<";
			this.shlBtn.UseVisualStyleBackColor = true;
			this.shlBtn.Click += new System.EventHandler(this.ShlBtnClick);
			// 
			// shrBtn
			// 
			this.shrBtn.Location = new System.Drawing.Point(257, 8);
			this.shrBtn.Name = "shrBtn";
			this.shrBtn.Size = new System.Drawing.Size(52, 23);
			this.shrBtn.TabIndex = 16;
			this.shrBtn.Text = ">>";
			this.shrBtn.UseVisualStyleBackColor = true;
			this.shrBtn.Click += new System.EventHandler(this.ShrBtnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 188);
			this.Controls.Add(this.shrBtn);
			this.Controls.Add(this.shlBtn);
			this.Controls.Add(this.nextDecTxtBx);
			this.Controls.Add(this.currDecTxtBx);
			this.Controls.Add(this.prevDecTxtBx);
			this.Controls.Add(this.prevValTxtBx);
			this.Controls.Add(this.prevValLbl);
			this.Controls.Add(this.nextValTxtBx);
			this.Controls.Add(this.currNumTxtBx);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.signedBtn);
			this.Controls.Add(this.maxValBtn);
			this.Controls.Add(this.minValBtn);
			this.Name = "MainForm";
			this.Text = "Integer Overflow Demo";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
