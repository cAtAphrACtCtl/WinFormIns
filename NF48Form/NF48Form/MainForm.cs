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
	public partial class MainForm : ZForm
	{
		List<ChildForm> childForms = new List<ChildForm>();

		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
		}

		
		static int globalChildIndex = 0;
		private void GetNewForm_Click(object sender, EventArgs e)
		{
			
			var childForm = new ChildForm();
			childForm.TopMost = true;
			childForm.Show(this);
			childForms.Add(childForm);
			childForm.Text = $"child Form {globalChildIndex++}";
		}

		public void DeleteChildForm(ChildForm childForm)
		{
			childForms.Remove(childForm);
		}
	}
}
