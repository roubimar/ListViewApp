using Xamarin.Forms;

namespace ListViewApp.All.Pages
{
    public class MainPage : NavigationPage
    {
        public MainPage(Page root = null)
        {
            if (root != null)
            {
                PushAsync(root);
            }
        }
    }
}
