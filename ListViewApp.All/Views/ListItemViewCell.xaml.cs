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

        private bool ios = false;

        protected override void InitializeCell()
        {
            InitializeComponent();
            ios = Device.OS == TargetPlatform.iOS;
        }

        protected override void SetupCell(bool isRecycled)
        {
            if (ios)
            {
                View.TranslateTo(INIT_POSITION * 2, 0, 0, Easing.SinOut)
                    .ContinueWith((s) => View.TranslateTo(INIT_POSITION, 0, EASING_TIME, Easing.SinOut));
            }
            else
            {
                View.TranslationX = INIT_POSITION;
                View.TranslateTo(0, 0, 250, Easing.SinOut);
            }
        }
    }
}
