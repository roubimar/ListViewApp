using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ListViewApp.All.Views
{
    public partial class GridCellView : StackLayout
    {

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Header. This enables animation, styling, binding, etc...
        public static readonly BindableProperty HeaderProperty =
            BindableProperty.Create(nameof(Header), typeof(string), typeof(GridCellView));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text. This enables animation, styling, binding, etc...
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(GridCellView));

        public GridCellView()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == nameof(Text))
            {
                TextLabel.Text = Text;
            }
            else if (propertyName == nameof(Header))
            {
                HeaderLabel.Text = Header;
            }
        }
    }
}
