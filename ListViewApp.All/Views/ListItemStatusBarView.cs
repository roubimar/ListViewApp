using ListViewApp.All.Helpers;
using ListViewApp.All.ViewModels;
using System;

using Xamarin.Forms;

namespace ListViewApp.All.Views
{
    public class ListItemStatusBarView : ContentView
    {
        private BoxView statusBar;

        public ListItemStatusBarView()
        {
            statusBar = new BoxView() { BackgroundColor = Color.Black };
            Content = statusBar;
            //BindingContextChanged += ListItemStatusBarView_BindingContextChanged;
        }


        private void ListItemStatusBarView_BindingContextChanged(object sender, EventArgs e)
        {
            var model = BindingContext as PrescriptionViewModel;
            if (model == null) return;
            statusBar.BackgroundColor =  PrescriptionHelper.GetPrescriptionStatusBarColor(model.Status);
        }
    }
}
