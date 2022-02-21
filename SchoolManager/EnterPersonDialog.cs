using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager
{
	public partial class EnterPersonDialog : Form
	{
		public string FirstName = "";
		public string LastName = "";
		public DateTime DOB;

		public EnterPersonDialog()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			FirstName = txtFirstName.Text;
			LastName = txtLastName.Text;
			DOB = dateTimePicker1.Value;

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
