using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_10
{
	public partial class FormChangeName : Form
	{
		int index;
		public FormChangeName(int index)
		{
			InitializeComponent();
			this.index = index;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FormChangeName_Load(object sender, EventArgs e)
		{
			lblName.Text = "You have chosen to edit " + FormMain.names[index] + "'s name. \r\nWhat would you like to change it to?";
			txtName.Text = FormMain.names[index];
		}

		private void lblCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void lblChange_Click(object sender, EventArgs e)
		{
			FormMain.names.RemoveAt(index);
			FormMain.names.Insert(index, txtName.Text.Trim());

			this.Dispose();
		}
	}
}
