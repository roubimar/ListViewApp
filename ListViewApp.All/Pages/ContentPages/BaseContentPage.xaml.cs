using Xamarin.Forms;

namespace ListViewApp.All.Pages.ContentPages
{
    public partial class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TranslationX = 500;
            this.TranslateTo(0, 0);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.TranslateTo(500, 0);
        }
    }
}
