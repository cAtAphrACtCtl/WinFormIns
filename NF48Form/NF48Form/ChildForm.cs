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
	public partial class ChildForm : Form
	{

		List<int> FontSize = new List<int>{1,2,4,8,16};
		public ChildForm()
		{
			InitializeComponent();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
		}

		public class KComboBox : ComboBox
		{
		}

		public class KButton : Button
		{
		}

		string[] comboBoxSource = { "C", "C#", "C++", "Swift", "Objective-C", "Java", "JavaScript" };
	}
}
