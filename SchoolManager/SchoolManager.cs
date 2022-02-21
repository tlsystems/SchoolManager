using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// ReSharper disable StringCompareToIsCultureSpecific

namespace SchoolManager
{
	public partial class SchoolManager : Form
	{
		private List<Person> _personList = new List<Person>();
		public SchoolManager()
		{
			InitializeComponent();
			rbFirst.Checked = true;
		}

		private void SchoolManager_Load(object sender, EventArgs e)
		{

		}

		private void btnAddPeople_Click(object sender, EventArgs e)
		{
			var person = new Person("Scrooge", "McDuck", "1/1/1921");
			_personList.Add(person);
			person = new Person("Huey", "McDuck", "1/2/1951 23:58:00");
			_personList.Add(person);

			_personList.Add(new Person("Dewey", "McDuck", "1/2/1951 23:59:00"));
			_personList.Add(new Person("Louie", "McDuck", "1/3/1951 00:00:00"));

		}

		private void btnAddNew_Click(object sender, EventArgs e)
		{
			var dlg = new EnterPersonDialog();
			var result = dlg.ShowDialog();
			if (result == DialogResult.Cancel)
				return;

			var person = new Person(dlg.FirstName, dlg.LastName, dlg.DOB);
			_personList.Add(person);
		}

		private void btnShowAllPeople_Click(object sender, EventArgs e)
		{
			lbPeople.Items.Clear();
			foreach (var person in _personList)
				lbPeople.Items.Add(person);
		}



















		private void btnAddFromFile_Click(object sender, EventArgs e)
		{
			var sr = new StreamReader(@"..\..\PersonList.txt");
			string line;
			while ((line = sr.ReadLine()) != null)
			{
				var split = line.Split(',');
				var person = new Person(split[1], split[0], split[2]);
				_personList.Add(person);
			}
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			BubbleSort();
			lbPeople.Items.Clear();
			foreach (var person in _personList)
				lbPeople.Items.Add(person);

			//if (rbFirst.Checked)
			//	_personList.Sort((o1,o2) => o1.FirstName.CompareTo(o2.FirstName));
			//else if (rbLast.Checked)
			//	_personList.Sort((o1, o2) => o1.LastName.CompareTo(o2.LastName));
			//else if (rbDOB.Checked)
			//	_personList.Sort((o1, o2) => o1.DOB.CompareTo(o2.DOB));
			//lbPeople.Items.Clear();
			//foreach (var person in _personList)
			//	lbPeople.Items.Add(person);
		}

		private void BubbleSort()
		{
			for (var i = 1; i < _personList.Count; i++)
			{
				for (var j = i; j > 0; j--)
				{
					var swap = false;
					if (rbFirst.Checked)
						swap = _personList[j].FirstName.CompareTo(_personList[j - 1].FirstName) < 0;
					else if (rbLast.Checked)
						swap = _personList[j].LastName.CompareTo(_personList[j - 1].LastName) < 0;
					else if (rbDOB.Checked)
						swap = _personList[j].DOB < _personList[j - 1].DOB;

					if (!swap) break;

					var temp = _personList[j-1];
					_personList[j-1] = _personList[j];
					_personList[j] = temp;
				}
			}
		}
	}
}
