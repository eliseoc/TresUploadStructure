/*
 * Created by SharpDevelop.
 * User: walterh
 * Date: 4/26/2016
 * Time: 5:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TresUploadStructure
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button BtnClose;
		private System.Windows.Forms.Label lbl_title;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnClose = new System.Windows.Forms.Button();
			this.lbl_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnClose
			// 
			this.BtnClose.Location = new System.Drawing.Point(89, 226);
			this.BtnClose.Name = "BtnClose";
			this.BtnClose.Size = new System.Drawing.Size(77, 23);
			this.BtnClose.TabIndex = 0;
			this.BtnClose.Text = "Close";
			this.BtnClose.UseVisualStyleBackColor = true;
			this.BtnClose.Click += new System.EventHandler(this.Button1Click);
			// 
			// lbl_title
			// 
			this.lbl_title.Location = new System.Drawing.Point(49, 92);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 23);
			this.lbl_title.TabIndex = 1;
			this.lbl_title.Text = "Hello World!";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lbl_title);
			this.Controls.Add(this.BtnClose);
			this.Name = "MainForm";
			this.Text = "TresUploadStructure";
			this.ResumeLayout(false);

		}
	}
}
