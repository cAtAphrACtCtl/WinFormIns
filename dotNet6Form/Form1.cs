namespace dotNet6Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int globalChildIndex = 0;

		private void GetNewForm_Click(object sender, EventArgs e)
		{
			var childForm = new Form();
			childForm.TopMost = true;
			childForm.Show(this);
			childForm.Text = $"{childForm.GetType().Name} {globalChildIndex++}";
		}
	}
}