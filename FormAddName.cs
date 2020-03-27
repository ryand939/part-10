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
	public partial class FormAddName : Form
	{

		// not going to put a duplicate listbox on the form because theres no point
		// im just going to modify the list on the main form


		// so i can access lstNames
		FormMain form = (FormMain)Application.OpenForms["FormMain"];


		public FormAddName()
		{
			InitializeComponent();
		}

		private void btnAddName_Click(object sender, EventArgs e)
		{
			string entry = txtName.Text.Trim();
			if(entry != "" && entry != " ")
			{
				FormMain.names.Add(entry);
				lstPendingAdd.Items.Add(entry);
			}
			txtName.Text = "";
		}

		private void FormAddName_Load(object sender, EventArgs e)
		{
			lstPendingAdd.Items.Clear();
			lstPendingAdd.Items.Add("[Pending additions to main list]");
	}

		private void btn_Done_Click(object sender, EventArgs e)
		{
			FormMain.names.Sort();
			this.Dispose();
		}
	}
}
