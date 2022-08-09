using NF48Form.Forms;
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
	public partial class ChildForm : ZForm
	{
		public ChildForm()
		{
			InitializeComponent();
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
		}

		void ValidationAndSave()
		{
			double number = 0;
			if (NumberText.Text.Trim().Length > 0 && !double.TryParse(NumberText.Text, out number))
			{
				MessageBox.Show("Validation faild!");
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			MainForm mainForm = Owner as MainForm;
			mainForm?.DeleteChildForm(this);
			ValidationAndSave();
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
		}
	}
}
