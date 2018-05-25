namespace Dtx
{
	public partial class PersianDate : System.Windows.Forms.UserControl
	{
		public PersianDate()
		{
			InitializeComponent();

			// **************************************************
			dayComboBox.Items.Clear();

			for (int index = 1; index <= 31; index++)
			{
				dayComboBox.Items.Add(index);
			}
			// **************************************************

			// **************************************************
			monthComboBox.Items.Clear();

			for (int index = 1; index <= 12; index++)
			{
				monthComboBox.Items.Add(index);
			}
			// **************************************************

			// **************************************************
			yearComboBox.Items.Clear();

			for (int index = 1300; index <= 1400; index++)
			{
				yearComboBox.Items.Add(index);
			}
			// **************************************************

			Date = System.DateTime.Now;
		}

		private System.DateTime date;

		public System.DateTime Date
		{
			//get
			//{

			//}
			set
			{
				date = value;

				System.Globalization.PersianCalendar
					persianCalendar = new System.Globalization.PersianCalendar();

				int shamsiYear = persianCalendar.GetYear(date);
				int shamsiMonth = persianCalendar.GetMonth(date);
				int shamsiDay = persianCalendar.GetDayOfMonth(date);

				//dayComboBox.SelectedText = shamsiDay.ToString();
				//dayComboBox.SelectedValue = shamsiDay;
				dayComboBox.SelectedItem = shamsiDay;
				yearComboBox.SelectedItem = shamsiYear;
				monthComboBox.SelectedItem = shamsiMonth;
			}
		}

		private void PersianDate_Load(object sender, System.EventArgs e)
		{
			FixLayout();
		}

		protected override void OnResize(System.EventArgs e)
		{
			base.OnResize(e);

			FixLayout();
		}

		private void FixLayout()
		{
			Padding = new System.Windows.Forms.Padding(all: 0);

			dayComboBox.Margin = new System.Windows.Forms.Padding(all: 0);
			yearComboBox.Margin = new System.Windows.Forms.Padding(all: 0);
			monthComboBox.Margin = new System.Windows.Forms.Padding(all: 0);

			int margin = 8;

			yearComboBox.Top = 0;
			yearComboBox.Left = 0;

			monthComboBox.Top = 0;
			monthComboBox.Left = yearComboBox.Left + yearComboBox.Width + margin;

			dayComboBox.Top = 0;
			dayComboBox.Left = monthComboBox.Left + monthComboBox.Width + margin;

			Width = dayComboBox.Left + dayComboBox.Width;
			Height = dayComboBox.Top + dayComboBox.Height;
		}
	}
}
