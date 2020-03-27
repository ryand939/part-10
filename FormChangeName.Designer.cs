namespace part_10
{
	partial class FormChangeName
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblChange = new System.Windows.Forms.Button();
			this.lblCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(14, 40);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(184, 20);
			this.txtName.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(12, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(0, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblChange
			// 
			this.lblChange.Location = new System.Drawing.Point(12, 66);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(53, 23);
			this.lblChange.TabIndex = 2;
			this.lblChange.Text = "Change";
			this.lblChange.UseVisualStyleBackColor = true;
			this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
			// 
			// lblCancel
			// 
			this.lblCancel.Location = new System.Drawing.Point(68, 66);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Size = new System.Drawing.Size(56, 23);
			this.lblCancel.TabIndex = 3;
			this.lblCancel.Text = "Cancel";
			this.lblCancel.UseVisualStyleBackColor = true;
			this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
			// 
			// FormChangeName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(212, 91);
			this.Controls.Add(this.lblCancel);
			this.Controls.Add(this.lblChange);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Name = "FormChangeName";
			this.Text = "FormChangeName";
			this.Load += new System.EventHandler(this.FormChangeName_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button lblChange;
		private System.Windows.Forms.Button lblCancel;
	}
}