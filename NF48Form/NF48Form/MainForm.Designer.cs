﻿namespace NF48Form
{
	partial class MainForm
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
			this.GetNewForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
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
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.GetNewForm);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button GetNewForm;
	}
}

