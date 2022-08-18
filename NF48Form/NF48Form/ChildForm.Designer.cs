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
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBox
			// 
			this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
			this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			//comboBox.DataSource = comboBoxSource;
			//this.comboBox.FormattingEnabled = true;
			//this.comboBox.Location = new System.Drawing.Point(433, 233);
			//this.comboBox.Name = "comboBox";
			//this.comboBox.Size = new System.Drawing.Size(164, 32);
			//this.comboBox.TabIndex = 1;
			// 
			// textBox
			// 
			//this.textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBox.Location = new System.Drawing.Point(433, 178);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(100, 29);
			this.textBox.TabIndex = 3;
			// 
			// ChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.comboBox);
			this.Name = "ChildForm";
			this.Text = "ChildForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.TextBox textBox;
	}
}