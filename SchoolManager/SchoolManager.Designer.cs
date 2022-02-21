
namespace SchoolManager
{
	partial class SchoolManager
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
			this.btnAddPeople = new System.Windows.Forms.Button();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.btnShowAllPeople = new System.Windows.Forms.Button();
			this.lbPeople = new System.Windows.Forms.ListBox();
			this.btnAddFromFile = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbFirst = new System.Windows.Forms.RadioButton();
			this.rbLast = new System.Windows.Forms.RadioButton();
			this.rbDOB = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAddPeople
			// 
			this.btnAddPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPeople.Location = new System.Drawing.Point(16, 65);
			this.btnAddPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAddPeople.Name = "btnAddPeople";
			this.btnAddPeople.Size = new System.Drawing.Size(223, 42);
			this.btnAddPeople.TabIndex = 0;
			this.btnAddPeople.Text = "Add Several People";
			this.btnAddPeople.UseVisualStyleBackColor = true;
			this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
			// 
			// btnAddPerson
			// 
			this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPerson.Location = new System.Drawing.Point(16, 140);
			this.btnAddPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(223, 42);
			this.btnAddPerson.TabIndex = 1;
			this.btnAddPerson.Text = "Add New Person";
			this.btnAddPerson.UseVisualStyleBackColor = true;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnShowAllPeople
			// 
			this.btnShowAllPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAllPeople.Location = new System.Drawing.Point(437, 366);
			this.btnShowAllPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowAllPeople.Name = "btnShowAllPeople";
			this.btnShowAllPeople.Size = new System.Drawing.Size(223, 42);
			this.btnShowAllPeople.TabIndex = 2;
			this.btnShowAllPeople.Text = "Show All People";
			this.btnShowAllPeople.UseVisualStyleBackColor = true;
			this.btnShowAllPeople.Click += new System.EventHandler(this.btnShowAllPeople_Click);
			// 
			// lbPeople
			// 
			this.lbPeople.FormattingEnabled = true;
			this.lbPeople.HorizontalScrollbar = true;
			this.lbPeople.ItemHeight = 16;
			this.lbPeople.Location = new System.Drawing.Point(428, 28);
			this.lbPeople.Name = "lbPeople";
			this.lbPeople.Size = new System.Drawing.Size(298, 308);
			this.lbPeople.TabIndex = 3;
			// 
			// btnAddFromFile
			// 
			this.btnAddFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddFromFile.Location = new System.Drawing.Point(790, 341);
			this.btnAddFromFile.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddFromFile.Name = "btnAddFromFile";
			this.btnAddFromFile.Size = new System.Drawing.Size(223, 42);
			this.btnAddFromFile.TabIndex = 4;
			this.btnAddFromFile.Text = "Add From File";
			this.btnAddFromFile.UseVisualStyleBackColor = true;
			this.btnAddFromFile.Click += new System.EventHandler(this.btnAddFromFile_Click);
			// 
			// btnSort
			// 
			this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSort.Location = new System.Drawing.Point(790, 277);
			this.btnSort.Margin = new System.Windows.Forms.Padding(4);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(131, 42);
			this.btnSort.TabIndex = 5;
			this.btnSort.Text = "Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbDOB);
			this.groupBox1.Controls.Add(this.rbLast);
			this.groupBox1.Controls.Add(this.rbFirst);
			this.groupBox1.Location = new System.Drawing.Point(790, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(131, 118);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sort Order";
			// 
			// rbFirst
			// 
			this.rbFirst.AutoSize = true;
			this.rbFirst.Location = new System.Drawing.Point(7, 28);
			this.rbFirst.Name = "rbFirst";
			this.rbFirst.Size = new System.Drawing.Size(97, 21);
			this.rbFirst.TabIndex = 0;
			this.rbFirst.TabStop = true;
			this.rbFirst.Text = "First Name";
			this.rbFirst.UseVisualStyleBackColor = true;
			// 
			// rbLast
			// 
			this.rbLast.AutoSize = true;
			this.rbLast.Location = new System.Drawing.Point(6, 55);
			this.rbLast.Name = "rbLast";
			this.rbLast.Size = new System.Drawing.Size(97, 21);
			this.rbLast.TabIndex = 1;
			this.rbLast.TabStop = true;
			this.rbLast.Text = "Last Name";
			this.rbLast.UseVisualStyleBackColor = true;
			// 
			// rbDOB
			// 
			this.rbDOB.AutoSize = true;
			this.rbDOB.Location = new System.Drawing.Point(6, 82);
			this.rbDOB.Name = "rbDOB";
			this.rbDOB.Size = new System.Drawing.Size(111, 21);
			this.rbDOB.TabIndex = 2;
			this.rbDOB.TabStop = true;
			this.rbDOB.Text = "Date Of Birth";
			this.rbDOB.UseVisualStyleBackColor = true;
			// 
			// SchoolManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 465);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnAddFromFile);
			this.Controls.Add(this.lbPeople);
			this.Controls.Add(this.btnShowAllPeople);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.btnAddPeople);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SchoolManager";
			this.Text = "SchoolManager";
			this.Load += new System.EventHandler(this.SchoolManager_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddPeople;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.Button btnShowAllPeople;
		private System.Windows.Forms.ListBox lbPeople;
		private System.Windows.Forms.Button btnAddFromFile;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDOB;
		private System.Windows.Forms.RadioButton rbLast;
		private System.Windows.Forms.RadioButton rbFirst;
	}
}

