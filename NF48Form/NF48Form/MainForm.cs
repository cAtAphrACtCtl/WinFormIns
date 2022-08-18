using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NF48Form
{
	public partial class MainForm : Form
	{
		//List<Form> childForms = new List<Form>();

		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 16)
			{

			}
			base.WndProc(ref m);
		}


		static int globalChildIndex = 0;
		private void GetNewForm_Click(object sender, EventArgs e)
		{
			
			var childForm = new ChildForm();
			childForm.TopMost = true;
			childForm.Owner = this;
			childForm.Show();
			childForm.Text = $"{childForm.GetType().Name} {globalChildIndex++}";
			
		}

		private void GetSickFormButton_Click(object sender, EventArgs e)
		{
		}
	}
}
