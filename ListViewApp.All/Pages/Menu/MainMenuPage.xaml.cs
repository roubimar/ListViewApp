using ListViewApp.All.Pages.ContentPages;
using ListViewApp.All.Pages.ContentPages.PrescriptionPages;
using ListViewApp.All.Resx;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewApp.All.Pages.Menu
{
    public partial class MainMenuPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MainMenuPage()
        {
            InitializeComponent();
            var masterPageItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Text = "Recepty",
                    Icon = "recepty.png",
                    CommandParameter = typeof(PrescriptionsPage)

                },
                new MenuItem
                {
                    Text = "Recept",
                    Icon = "prescription.png",
                    CommandParameter = typeof(PrescriptionTabbedPage)
                },
                new MenuItem
                {
                    Text = AppResources.Settings,
                    Icon = "settings.png",
                    CommandParameter = typeof(PrescriptionTabbedPage)
                },
                new MenuItem
                {
                    Text = "Odhlásit se",
                    Icon = "logout.png",
                    CommandParameter = typeof(PrescriptionTabbedPage)
                },
            };
            listView.ItemsSource = masterPageItems;

        }
    }
}
