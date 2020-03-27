namespace part_10
{
	partial class FormMain
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
			this.btnAddName = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnRemoveName = new System.Windows.Forms.Button();
			this.btnEditName = new System.Windows.Forms.Button();
			this.lstNames = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnAddName
			// 
			this.btnAddName.Location = new System.Drawing.Point(12, 12);
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.Size = new System.Drawing.Size(97, 23);
			this.btnAddName.TabIndex = 1;
			this.btnAddName.Text = "Add Names";
			this.btnAddName.UseVisualStyleBackColor = true;
			this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(12, 161);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 2;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// btnRemoveName
			// 
			this.btnRemoveName.Location = new System.Drawing.Point(12, 70);
			this.btnRemoveName.Name = "btnRemoveName";
			this.btnRemoveName.Size = new System.Drawing.Size(97, 21);
			this.btnRemoveName.TabIndex = 3;
			this.btnRemoveName.Text = "Remove Names";
			this.btnRemoveName.UseVisualStyleBackColor = true;
			this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click);
			// 
			// btnEditName
			// 
			this.btnEditName.Location = new System.Drawing.Point(12, 41);
			this.btnEditName.Name = "btnEditName";
			this.btnEditName.Size = new System.Drawing.Size(97, 23);
			this.btnEditName.TabIndex = 4;
			this.btnEditName.Text = "Edit Names";
			this.btnEditName.UseVisualStyleBackColor = true;
			this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
			// 
			// lstNames
			// 
			this.lstNames.FormattingEnabled = true;
			this.lstNames.Location = new System.Drawing.Point(115, 12);
			this.lstNames.Name = "lstNames";
			this.lstNames.Size = new System.Drawing.Size(124, 173);
			this.lstNames.TabIndex = 5;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(251, 190);
			this.Controls.Add(this.lstNames);
			this.Controls.Add(this.btnEditName);
			this.Controls.Add(this.btnRemoveName);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnAddName);
			this.Name = "FormMain";
			this.Text = "Part 10";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddName;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnRemoveName;
		private System.Windows.Forms.Button btnEditName;
		public System.Windows.Forms.ListBox lstNames;
	}
}

