using Xamarin.Forms;

namespace LogcatViewer
{
    public partial class MainPage : ContentPage
    {
        private ILogCat _logcat; 

        public MainPage(ILogCat logCat)
        {
            _logcat = logCat; 
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            Logcat.Text = _logcat.GetLogcatOutput();

            base.OnAppearing();
        }
    }
}
