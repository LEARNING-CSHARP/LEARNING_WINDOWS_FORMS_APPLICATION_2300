namespace Dtx
{
	public static class Utility
	{
		static Utility()
		{
		}

		/// <summary>
		/// Helper
		/// </summary>
		public static string ConvertMiladiToShamsi(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar
				persianCalendar = new System.Globalization.PersianCalendar();

			int shamsiYear = persianCalendar.GetYear(dateTime);
			int shamsiMonth = persianCalendar.GetMonth(dateTime);
			int shamsiDay = persianCalendar.GetDayOfMonth(dateTime);

			string shamsiDayString = shamsiDay.ToString().PadLeft(2, '0');
			string shamsiMonthString = shamsiMonth.ToString().PadLeft(2, '0');

			string result =
				$"{ shamsiYear }/{ shamsiMonthString }/{ shamsiDayString }";

			return result;
		}
	}
}
