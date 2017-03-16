using ListViewApp.All.Helpers;
using ListViewApp.All.Models;
using ListViewApp.All.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewApp.All.Views
{
    public partial class ListItemStatusView : ContentView
    {
        public ListItemStatusView()
        {
            InitializeComponent();

            BindingContextChanged += ListItemStatusView_BindingContextChanged;
        }

        private void ListItemStatusView_BindingContextChanged(object sender, EventArgs e)
        {
            var model = BindingContext as PrescriptionViewModel;
            if (model == null) return;

            Icons.Children.Clear();

            var statusTextCollection = new List<string>();
            foreach (PrescriptionStatus x in Enum.GetValues(typeof(PrescriptionStatus)))
            {
                if (model.Status.HasFlag(x))
                {
                    Icons.Children.Add(new Image() { HeightRequest = 13, WidthRequest = 13, Source = PrescriptionHelper.GetPrescriptionStatusIcon(x) });
                    statusTextCollection.Add(PrescriptionHelper.GetPrescriptionStatusText(x));
                }
            }
            StatusText.Text = string.Join(", ", statusTextCollection);
            BackgroundColor = PrescriptionHelper.GetPrescriptionStatusBarColor(model.Status);
        }
    }
}
