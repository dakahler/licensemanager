namespace LicenseManager
{
	partial class NewLicense
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.NumUsersLabel = new System.Windows.Forms.Label();
			this.NumUsersTextBox = new System.Windows.Forms.TextBox();
			this.OkButton = new System.Windows.Forms.Button();
			this._CancelButton = new System.Windows.Forms.Button();
			this.CommercialCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(37, 27);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(38, 13);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Name:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(164, 24);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(286, 20);
			this.NameTextBox.TabIndex = 1;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(37, 57);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(35, 13);
			this.EmailLabel.TabIndex = 2;
			this.EmailLabel.Text = "Email:";
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(164, 54);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(286, 20);
			this.EmailTextBox.TabIndex = 3;
			// 
			// NumUsersLabel
			// 
			this.NumUsersLabel.AutoSize = true;
			this.NumUsersLabel.Location = new System.Drawing.Point(37, 91);
			this.NumUsersLabel.Name = "NumUsersLabel";
			this.NumUsersLabel.Size = new System.Drawing.Size(89, 13);
			this.NumUsersLabel.TabIndex = 4;
			this.NumUsersLabel.Text = "Number of Users:";
			// 
			// NumUsersTextBox
			// 
			this.NumUsersTextBox.Location = new System.Drawing.Point(164, 88);
			this.NumUsersTextBox.Name = "NumUsersTextBox";
			this.NumUsersTextBox.Size = new System.Drawing.Size(286, 20);
			this.NumUsersTextBox.TabIndex = 5;
			this.NumUsersTextBox.Text = "1";
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(271, 154);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 6;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// _CancelButton
			// 
			this._CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._CancelButton.Location = new System.Drawing.Point(362, 154);
			this._CancelButton.Name = "_CancelButton";
			this._CancelButton.Size = new System.Drawing.Size(75, 23);
			this._CancelButton.TabIndex = 7;
			this._CancelButton.Text = "Cancel";
			this._CancelButton.UseVisualStyleBackColor = true;
			this._CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// CommercialCheckBox
			// 
			this.CommercialCheckBox.AutoSize = true;
			this.CommercialCheckBox.Location = new System.Drawing.Point(175, 122);
			this.CommercialCheckBox.Name = "CommercialCheckBox";
			this.CommercialCheckBox.Size = new System.Drawing.Size(80, 17);
			this.CommercialCheckBox.TabIndex = 8;
			this.CommercialCheckBox.Text = "Commercial";
			this.CommercialCheckBox.UseVisualStyleBackColor = true;
			// 
			// NewLicense
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelButton;
			this.ClientSize = new System.Drawing.Size(484, 193);
			this.Controls.Add(this.CommercialCheckBox);
			this.Controls.Add(this._CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.NumUsersTextBox);
			this.Controls.Add(this.NumUsersLabel);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Name = "NewLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New License";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.Label NumUsersLabel;
		private System.Windows.Forms.TextBox NumUsersTextBox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button _CancelButton;
		private System.Windows.Forms.CheckBox CommercialCheckBox;
	}
}