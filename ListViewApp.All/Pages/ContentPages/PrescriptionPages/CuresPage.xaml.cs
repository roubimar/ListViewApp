using ListViewApp.All.Models;
using ListViewApp.All.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewApp.All.Pages.ContentPages.PrescriptionPages
{
    public partial class CuresPage : ContentPage
    {
        public CuresPage()
        {
            InitializeComponent();
            var cures = new List<Cure>();
            for (int i = 0; i < 4; i++)
            {
                cures.Add(new Cure() { Code = $"dsadas + {i}" });
            }
            var curesList = new ListView()
            {
                ItemsSource = cures,
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(CureViewCell)),
                SeparatorVisibility = SeparatorVisibility.None
            };

            curesList.ItemTapped += (s, e) => ((ListView)s).SelectedItem = null;           

            Content = curesList;
        }
    }
}
