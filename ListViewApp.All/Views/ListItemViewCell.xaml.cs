using ListViewApp.All.Controls;
using System;

using Xamarin.Forms;

namespace ListViewApp.All.Views
{
    public partial class ListItemViewCell : FastCell
    {
        public const int EASING_TIME = 250;
        public const int INIT_POSITION = -300;
        public const int INIT_POSITION_IOS = -299;

        protected override void InitializeCell()
        {
            InitializeComponent();
            Appearing += Device.OnPlatform<EventHandler>(ListItemView_Appearing_iOS, ListItemView_Appearing, ListItemView_Appearing);
            Disappearing += ListItemView_Disappearing;
        }

        protected override void SetupCell(bool isRecycled)
        {
            View.TranslationX = -300;
            View.TranslateTo(0, 0, 250, Easing.SinOut);
        }

        private void ListItemView_Disappearing(object sender, EventArgs e)
        {
            var listItem = sender as ViewCell;
            if (listItem.View.TranslationX == INIT_POSITION_IOS)
            {
                listItem.View.TranslationX = INIT_POSITION_IOS;
            }
            else
            {
                listItem.View.TranslationX = 0;
            }
        }

        private void ListItemView_Appearing(object sender, EventArgs e)
        {
            var listItem = sender as ViewCell;
            if (listItem.View.TranslationX == INIT_POSITION)
            {
                listItem.View.FadeTo(1, EASING_TIME);
                listItem.View.TranslateTo(0, 0, EASING_TIME, Easing.SinOut);                
            }            
        }

        private void ListItemView_Appearing_iOS(object sender, EventArgs e)
        {
            var listItem = sender as ViewCell;
            if (listItem.View.TranslationX == INIT_POSITION)
            {
                listItem.View.TranslationX = INIT_POSITION * 2;
                listItem.View.FadeTo(1, EASING_TIME);
                listItem.View.TranslateTo(INIT_POSITION, 0, EASING_TIME, Easing.SinOut).ContinueWith((s) => listItem.View.TranslationX = INIT_POSITION_IOS);
            }
        }
    }
}
