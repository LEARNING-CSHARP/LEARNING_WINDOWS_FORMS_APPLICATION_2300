namespace Dtx
{
	partial class PersianDate
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.yearComboBox = new System.Windows.Forms.ComboBox();
			this.monthComboBox = new System.Windows.Forms.ComboBox();
			this.dayComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// yearComboBox
			// 
			this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.yearComboBox.FormattingEnabled = true;
			this.yearComboBox.Location = new System.Drawing.Point(3, 3);
			this.yearComboBox.Name = "yearComboBox";
			this.yearComboBox.Size = new System.Drawing.Size(52, 21);
			this.yearComboBox.TabIndex = 0;
			// 
			// monthComboBox
			// 
			this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.monthComboBox.FormattingEnabled = true;
			this.monthComboBox.Location = new System.Drawing.Point(61, 3);
			this.monthComboBox.Name = "monthComboBox";
			this.monthComboBox.Size = new System.Drawing.Size(53, 21);
			this.monthComboBox.TabIndex = 1;
			// 
			// dayComboBox
			// 
			this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dayComboBox.FormattingEnabled = true;
			this.dayComboBox.Location = new System.Drawing.Point(120, 3);
			this.dayComboBox.Name = "dayComboBox";
			this.dayComboBox.Size = new System.Drawing.Size(57, 21);
			this.dayComboBox.TabIndex = 2;
			// 
			// PersianDate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.dayComboBox);
			this.Controls.Add(this.monthComboBox);
			this.Controls.Add(this.yearComboBox);
			this.Name = "PersianDate";
			this.Size = new System.Drawing.Size(293, 66);
			this.Load += new System.EventHandler(this.PersianDate_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox yearComboBox;
		private System.Windows.Forms.ComboBox monthComboBox;
		private System.Windows.Forms.ComboBox dayComboBox;
	}
}
