namespace dotNet6Form
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Text = "Form1";


			this.GetNewForm = new System.Windows.Forms.Button();
			// 
			// GetNewForm
			// 
			this.GetNewForm.Location = new System.Drawing.Point(330, 234);
			this.GetNewForm.Name = "GetNewForm";
			this.GetNewForm.Size = new System.Drawing.Size(199, 56);
			this.GetNewForm.TabIndex = 0;
			this.GetNewForm.Text = "GetNewForm";
			this.GetNewForm.UseVisualStyleBackColor = true;
			this.GetNewForm.Click += new System.EventHandler(this.GetNewForm_Click);

			this.Controls.Add(this.GetNewForm);
		}
		#endregion


		private System.Windows.Forms.Button GetNewForm;
	}
}