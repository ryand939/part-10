namespace part_10
{
	partial class FormAddName
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Done = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstPendingAdd = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(11, 183);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(91, 23);
			this.btn_Add.TabIndex = 0;
			this.btn_Add.Text = "Add";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btnAddName_Click);
			// 
			// btn_Done
			// 
			this.btn_Done.Location = new System.Drawing.Point(108, 183);
			this.btn_Done.Name = "btn_Done";
			this.btn_Done.Size = new System.Drawing.Size(75, 23);
			this.btn_Done.TabIndex = 1;
			this.btn_Done.Text = "Done";
			this.btn_Done.UseVisualStyleBackColor = true;
			this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(12, 157);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(171, 20);
			this.txtName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter a name below and click add.";
			// 
			// lstPendingAdd
			// 
			this.lstPendingAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstPendingAdd.FormattingEnabled = true;
			this.lstPendingAdd.Items.AddRange(new object[] {
            "[Pending additions to main list]"});
			this.lstPendingAdd.Location = new System.Drawing.Point(11, 13);
			this.lstPendingAdd.Name = "lstPendingAdd";
			this.lstPendingAdd.Size = new System.Drawing.Size(172, 119);
			this.lstPendingAdd.TabIndex = 5;
			// 
			// FormAddName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 212);
			this.Controls.Add(this.lstPendingAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btn_Done);
			this.Controls.Add(this.btn_Add);
			this.Name = "FormAddName";
			this.Text = "FormAddName";
			this.Load += new System.EventHandler(this.FormAddName_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Done;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstPendingAdd;
	}
}