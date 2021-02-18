//--------------------------------------------------
// This is just a project create for fun by Ryo3504
// Please do not take it for profit purposes
//--------------------------------------------------
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
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

			//Task Manager Action: Enable
			//EnableTaskManager();
			//DisableTaskManager();
		}

		#region Task Manager Action
		/// <summary>
		/// Disable Task Manager 
		/// </summary>
		private void DisableTaskManager()
		{
			RegistryKey regkey = default(RegistryKey);
			string keyValueInt = "1";
			string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			try
			{
				regkey = Registry.CurrentUser.CreateSubKey(subKey);
				regkey.SetValue("DisableTaskMgr", keyValueInt);
				regkey.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Registry Error!");
			}
		}

		/// <summary>
		/// Enable Task Manager
		/// </summary>
		private void EnableTaskManager()
		{
			RegistryKey regkey = default(RegistryKey);
			string keyValueInt = "0";
			//0x00000000 (0)
			string subKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			try
			{
				regkey = Registry.CurrentUser.CreateSubKey(subKey);
				regkey.SetValue("DisableTaskMgr", keyValueInt);
				regkey.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Registry Error!");
			}

		}
		#endregion

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
				MessageBox.Show("Allow to Exit this kawaii Ransomware!");
				Application.Exit();
			}
			else
			{
				MessageBox.Show("Wrong Key Input!");
			}
		}

		/// <summary>
		/// Button Get Key validate Enter not Cick
		/// </summary>
		/// <param name="sender">object</param>
		/// <param name="e">Key Press EventArgs</param>
		private void btnGetKey_Click(object sender, EventArgs e)
		{
			//if (e.KeyCode == Keys.Enter)
			//{
			//	MessageBox.Show("Use your mouse to click! \r Not your keyboard to click!");
			//}
		}

		/// <summary>
		/// Mouse Click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGetKey_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				input++;
				temp = result - input;
				MessageBox.Show("You click " + input + " times \r Remain " + temp + " times");
				if (input == 1000)
				{
					MessageBox.Show("Key to unlock: 132556487921465736156753724316432167563134");
				}
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
