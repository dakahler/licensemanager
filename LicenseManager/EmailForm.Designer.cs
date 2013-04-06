namespace LicenseManager
{
	partial class EmailForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailForm));
			this.EmailTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EmailTextBox.Location = new System.Drawing.Point(0, 0);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(744, 610);
			this.EmailTextBox.TabIndex = 0;
			this.EmailTextBox.Text = resources.GetString("EmailTextBox.Text");
			// 
			// EmailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 610);
			this.Controls.Add(this.EmailTextBox);
			this.Name = "EmailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EmailForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox EmailTextBox;

	}
}