/*
 * Created by SharpDevelop.
 * User: Home3
 * Date: 25/02/2017
 * Time: 10:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Password_Generator
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				Application.Run(new MainForm());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error:\r\n\r\n" + ex.Message,"General Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
	}
}
