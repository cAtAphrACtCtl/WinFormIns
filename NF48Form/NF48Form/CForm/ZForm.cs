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
	public partial class ZForm : KForm
	{
		public ZForm()
		{
			InitializeComponent();
		}

		protected override void WndProc(ref Message m)
		{
			//switch (m.Msg)
			//{
			//	case 16:
			//		MessageBox.Show($"window close event in {nameof(ZForm)}");
			//		break;
			//	default:
			//		break;
			//}

			base.WndProc(ref m);
		}
	}
}
