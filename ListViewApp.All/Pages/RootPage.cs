using ListViewApp.All.Pages.ContentPages;
using ListViewApp.All.Pages.Menu;
using System;
using Xamarin.Forms;

namespace ListViewApp.All.Pages
{
    public class RootPage : MasterDetailPage
    {
        private MainPage mainPage;
        private MainMenuPage masterPage;

        public RootPage()
        {
            masterPage = new MainMenuPage();
            masterPage.ListView.ItemSelected += OnItemSelected;
            Master = masterPage;

            mainPage = new MainPage(new PrescriptionsPage());
            Detail = mainPage;
        }

        public async void PopToRootAsync()
        {
            await mainPage.PopToRootAsync(true);
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            if (item != null)
            {
                await mainPage.PopToRootAsync();
                await mainPage.PushAsync((Page)Activator.CreateInstance((Type)item.CommandParameter, new [] { default(object) }));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
