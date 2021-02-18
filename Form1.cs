//--------------------------------------------------
// This is just a project create for fun by Ryo3504
// Please do not take it for profit purposes
//--------------------------------------------------
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WannaSmile
{
	public partial class WannaSmileForm : Form
	{
		#region Object Create
		// Object
		int input = 0;
		int result = 1000;
		int temp = 0;
		bool click =false;
		#endregion

		/// <summary>
		/// Default Constructor
		/// </summary>
		public WannaSmileForm()
		{
			InitializeComponent();

			//Hide Control Box
			ControlBox = false;
			TaskmgrBlock();
		}

		void TaskmgrBlock() 
		{
			ProcessStartInfo psi = new ProcessStartInfo(System.IO.Path.Combine(Environment.SystemDirectory, "taskmgr.exe"));
			psi.RedirectStandardOutput = false;
			psi.WindowStyle = ProcessWindowStyle.Hidden;
			psi.UseShellExecute = true;
		}

		#region Button Event
		/// <summary>
		/// Button Check Key Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCheck_Click(object sender, EventArgs e)
		{
			if (tKey.Text.Equals("132556487921465736156753724316432167563134"))
			{
				Application.Exit();
			}
			else
			{
				MessageBox.Show("Wrong Key Input!");
			}
		}

		/// <summary>
		/// Button Get Key validate
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGetKey_Click(object sender, EventArgs e)
		{
			if (click)
			{
				MessageBox.Show("Use your mouse to click! \r Not your keyboard to click!");
			}
		}

		/// <summary>
		/// Mouse Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGetKey_MouseClick(object sender, MouseEventArgs e)
		{
			click = true;
			input++;
			temp = result - input;
			MessageBox.Show("You click " + input + " times \r Remain " + temp + " times");
			if (input == 1000)
			{
				MessageBox.Show("Key to unlock: 132556487921465736156753724316432167563134");
			}
		}

		/// <summary>
		/// Button Decryption
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">EventArgs</param>
		private void btnSend_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Wrong Key and Seri Number!");
		}
		#endregion
	}
}
