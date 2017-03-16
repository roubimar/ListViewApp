using ListViewApp.All.ViewModels;
using System;
using System.Linq;

using Xamarin.Forms;

namespace ListViewApp.All.Pages.ContentPages.PrescriptionPages
{
    public partial class PrescriptionDetailPage : ContentPage
    {
        public PrescriptionDetailPage()
        {
            InitializeComponent();
        }

        private void PrescriptionDetailPage_BindingContextChanged(object sender, EventArgs e)
        {
            var model = BindingContext as PrescriptionViewModel;
            if (model == null || model.Issues == null || !model.Issues.Any()) return;

            foreach( var issue in model.Issues)
            {
                var textCell = new TextCell() { Text = issue.ToString(), TextColor = Color.Gray };
                textCell.IsEnabled = false;
                //IssuesSection.Add(textCell);
            }
        }
    }
}
