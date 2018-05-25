namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.persianDate2 = new Dtx.PersianDate();
			this.persianDate1 = new Dtx.PersianDate();
			this.persianDate3 = new Dtx.PersianDate();
			this.SuspendLayout();
			// 
			// persianDate2
			// 
			this.persianDate2.BackColor = System.Drawing.Color.Yellow;
			this.persianDate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.persianDate2.Location = new System.Drawing.Point(13, 45);
			this.persianDate2.Margin = new System.Windows.Forms.Padding(4);
			this.persianDate2.Name = "persianDate2";
			this.persianDate2.Size = new System.Drawing.Size(228, 24);
			this.persianDate2.TabIndex = 1;
			// 
			// persianDate1
			// 
			this.persianDate1.BackColor = System.Drawing.Color.Yellow;
			this.persianDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.persianDate1.Location = new System.Drawing.Point(13, 13);
			this.persianDate1.Margin = new System.Windows.Forms.Padding(4);
			this.persianDate1.Name = "persianDate1";
			this.persianDate1.Size = new System.Drawing.Size(228, 24);
			this.persianDate1.TabIndex = 0;
			// 
			// persianDate3
			// 
			this.persianDate3.BackColor = System.Drawing.Color.Yellow;
			this.persianDate3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.persianDate3.Location = new System.Drawing.Point(13, 77);
			this.persianDate3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.persianDate3.Name = "persianDate3";
			this.persianDate3.Size = new System.Drawing.Size(228, 24);
			this.persianDate3.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(286, 183);
			this.Controls.Add(this.persianDate3);
			this.Controls.Add(this.persianDate2);
			this.Controls.Add(this.persianDate1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Dtx.PersianDate persianDate1;
		private Dtx.PersianDate persianDate2;
		private Dtx.PersianDate persianDate3;
	}
}
