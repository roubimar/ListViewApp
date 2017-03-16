using ListViewApp.All.Models;
using ListViewApp.All.ViewModels;
using ListViewApp.All.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ListViewApp.All.Pages.ContentPages
{
    public partial class PrescriptionsPage : BaseContentPage
    {
        private List<PrescriptionViewModel> prescriptions;

        public PrescriptionsPage()
		{
			InitializeComponent();

            prescriptions = new List<PrescriptionViewModel>();
            for (int i = 0; i < 100; i++)
            {
                prescriptions.Add(new PrescriptionViewModel(CreatePrescription(i)));
            }

            var listView = new ListView()
            {
                ItemsSource = prescriptions,
                ItemTemplate = new DataTemplate(typeof(ListItemViewCell)),
                SeparatorVisibility = SeparatorVisibility.None,
                HasUnevenRows = true,                   
            };

            listView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                if (e.Item == null)
                    return;
                ((ListView)sender).SelectedItem = null;
                Navigation.PushAsync(new PrescriptionPages.PrescriptionTabbedPage(e.Item as PrescriptionViewModel), true);
            };
            
            listView.Refreshing += ListView_Refreshing;
            listView.IsPullToRefreshEnabled = true;
            
            Content = new StackLayout() { Padding = new Thickness(5), Children = { listView } };
        }
        

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            var listView = sender as ListView;
            listView.ItemsSource = listView.ItemsSource == prescriptions ? new List<PrescriptionViewModel>() { new PrescriptionViewModel(CreatePrescription(1)) } : prescriptions;

            var list = (ListView)sender;
            var items = (IEnumerable<PrescriptionViewModel>)list.ItemsSource;

            //Wait the end of the animation, and then scroll to the first position.
            Device.StartTimer(TimeSpan.FromSeconds(0.1), () =>
            {
                if(items != null && items.Any())
                {
                    list.ScrollTo(items.FirstOrDefault(), ScrollToPosition.Start, true);
                }
                return false;
            });

            list.IsRefreshing = false;
        }

        private Prescription CreatePrescription(int i)
        {
            return new Prescription
            {
                ID = $"0129845562 {i}",
                Items = "Yaz 0,02; Potahované tablety 20mg",
                DateTime = DateTime.Now,
                State = "Vydaný",
                Doctor = "Zdeněk Hřib"
            };
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            TranslationX = 500;
            this.TranslateTo(0, 0);
        }

        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            await this.TranslateTo(500, 0);
        }
    }
}
