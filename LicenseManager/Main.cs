using LicenseManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LicenseManager
{
	public partial class Main : Form
	{
		readonly String XmlPath = "..\\..\\..\\assets\\licenses.xml";

		public Main()
		{
			InitializeComponent();

			ReadXml();

			dataGridView1.AutoGenerateColumns = false;

			DataGridViewCell cell = new DataGridViewTextBoxCell();
			DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn()
			{
				CellTemplate = cell, 
				Name = "Name",
				HeaderText = "Name",
				DataPropertyName = "Name"
			};

			DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn()
			{
				CellTemplate = cell,
				Name = "Email",
				HeaderText = "Email",
				DataPropertyName = "Email"
			};

			DataGridViewTextBoxColumn colNumUsers = new DataGridViewTextBoxColumn()
			{
				CellTemplate = cell,
				Name = "NumUsers",
				HeaderText = "Number Of Users",
				DataPropertyName = "NumUsers"
			};

			DataGridViewTextBoxColumn colEndDate = new DataGridViewTextBoxColumn()
			{
				CellTemplate = cell,
				Name = "EndDate",
				HeaderText = "End Date",
				DataPropertyName = "EndDate"
			};

			DataGridViewTextBoxColumn colCommercial = new DataGridViewTextBoxColumn()
			{
				CellTemplate = cell,
				Name = "Commercial",
				HeaderText = "Commercial",
				DataPropertyName = "Commercial"
			};

			dataGridView1.Columns.Add(colName);
			dataGridView1.Columns.Add(colEmail);
			dataGridView1.Columns.Add(colNumUsers);
			dataGridView1.Columns.Add(colEndDate);
			dataGridView1.Columns.Add(colCommercial);

			if (LicenseInfo.Licenses.Count > 0)
			{
				var bindingList = new BindingList<LicenseInfo>(LicenseInfo.Licenses);
				dataGridView1.DataSource = bindingList;
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewLicense newLicense = new NewLicense();
			newLicense.ShowDialog(this);

			var bindingList = new BindingList<LicenseInfo>(LicenseInfo.Licenses);
			dataGridView1.DataSource = bindingList;

			WriteXml();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			LicenseInfo licenseInfo = LicenseInfo.Licenses[e.RowIndex];
			EmailForm emailForm = new EmailForm(licenseInfo);
			emailForm.ShowDialog(this);
		}

		private void WriteXml()
		{
			XmlSerializer serializer = new XmlSerializer(LicenseInfo.Licenses.GetType(), new Type[] { typeof(LicenseInfo) });
			TextWriter writer = new StreamWriter(XmlPath);
			serializer.Serialize(writer, LicenseInfo.Licenses);
			writer.Close();
		}

		private void ReadXml()
		{
			XmlSerializer serializer = new XmlSerializer(LicenseInfo.Licenses.GetType(), new Type[] {typeof(LicenseInfo)});
			TextReader reader = new StreamReader(XmlPath);
			LicenseInfo.Licenses = (List<LicenseInfo>)serializer.Deserialize(reader);
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			WriteXml();
		}
	}
}
