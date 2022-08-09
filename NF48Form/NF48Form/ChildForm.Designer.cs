namespace NF48Form
{
	partial class ChildForm
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
			this.NumberText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// NumberText
			// 
			this.NumberText.Location = new System.Drawing.Point(297, 233);
			this.NumberText.Name = "NumberText";
			this.NumberText.Size = new System.Drawing.Size(100, 29);
			this.NumberText.TabIndex = 0;
			// 
			// ChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.NumberText);
			this.Name = "ChildForm";
			this.Text = "ChildForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NumberText;
	}
}