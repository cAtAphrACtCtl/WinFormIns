using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NF48Form.Forms
{
	public partial class KForm : Form
	{
		public KForm()
		{
			InitializeComponent();
		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case 16:
					//var dialogResult = MessageBox.Show($"window close event in {nameof(KForm)}:{Text}");
					m.Result = IntPtr.Zero;
					break;
				default:
					break;
			}

			base.WndProc(ref m);
		}

		protected override void DefWndProc(ref Message m)
		{
			
			base.DefWndProc(ref m);
		}
	}
}
