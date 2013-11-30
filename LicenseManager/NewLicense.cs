using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseManager
{
	public partial class NewLicense : Form
	{
		public NewLicense()
		{
			InitializeComponent();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			LicenseInfo newLicense = new LicenseInfo();
			newLicense.Name = NameTextBox.Text;
			newLicense.Email = EmailTextBox.Text;
			newLicense.NumUsers = int.Parse(NumUsersTextBox.Text);
			newLicense.EndDate = DateTime.Now.AddYears(1);
			newLicense.Floating = FloatingCheckBox.Checked;

			LicenseInfo.Licenses.Add(newLicense);

			this.Close();
		}
	}
}
