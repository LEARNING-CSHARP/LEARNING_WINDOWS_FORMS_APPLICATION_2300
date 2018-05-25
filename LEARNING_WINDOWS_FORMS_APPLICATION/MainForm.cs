namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			//string result =
			//	Dtx.Utility.ConvertMiladiToShamsi(System.DateTime.Now);

			//System.Windows.Forms.MessageBox.Show(result);

			//System.DateTime dtm =
			//	System.DateTime.Now.AddDays(20);

			//result =
			//	Dtx.Utility.ConvertMiladiToShamsi(dtm);

			//System.Windows.Forms.MessageBox.Show(result);

			persianDate3.Date = System.DateTime.Now.AddDays(37);
		}
	}
}
