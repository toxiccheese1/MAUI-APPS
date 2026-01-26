
namespace log_in
{
    public partial class MainPage : ContentPage
    {
        private User _user;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new User();
        }
    }
}
