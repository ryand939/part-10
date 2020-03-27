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
	public partial class FormMain : Form
	{

		public static List<string> names = new List<string>();

		public FormMain()
		{
			InitializeComponent();
		}

		private void btnAddName_Click(object sender, EventArgs e)
		{
			FormAddName frmAddName = new FormAddName();
			frmAddName.ShowDialog();
			lstNames.DataSource = null;
			lstNames.DataSource = FormMain.names;
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			names.Add("phil");
			names.Add("gary");
			names.Add("wayne");
			names.Sort();
			lstNames.DataSource = names;
		}
		

		


		private void btnRemoveName_Click(object sender, EventArgs e)
		{
			names.RemoveAt(lstNames.SelectedIndex);
			lstNames.DataSource = null;
			lstNames.DataSource = names;
		}

		private void btnEditName_Click(object sender, EventArgs e)
		{
			FormChangeName frmChangeName = new FormChangeName(lstNames.SelectedIndex);
			frmChangeName.ShowDialog();

			lstNames.DataSource = null;
			lstNames.DataSource = names;

		}
	}
}
