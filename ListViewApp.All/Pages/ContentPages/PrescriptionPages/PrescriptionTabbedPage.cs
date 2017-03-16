using ListViewApp.All.Models;
using ListViewApp.All.ViewModels;
using System;
using Xamarin.Forms;

namespace ListViewApp.All.Pages.ContentPages.PrescriptionPages
{
    public class PrescriptionTabbedPage : TabbedPage
    {
        public PrescriptionTabbedPage(PrescriptionViewModel model = null)
        {
            var viewModel = model ?? new PrescriptionViewModel(new Prescription
            {
                ID = "0129845562",
                Items = "Yaz 0,02; Potahované tablety 20mg",
                DateTime = DateTime.Now,
                State = "Vydaný",
                Doctor = "Zdeněk Hřib"
            });
            Title = viewModel.ID;
            Children.Add(new PrescriptionDetailPage() { BindingContext = viewModel });
            Children.Add(new CuresPage() { BindingContext = viewModel });
            Children.Add(new NotesPage() { BindingContext = viewModel });
            Children.Add(new PatientPage() { BindingContext = viewModel });
            Children.Add(new DoctorPage() { BindingContext = viewModel });           
                
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TranslationX = -500;
            this.TranslateTo(0, 0);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.TranslateTo(500, 0);
        }
    }
}
