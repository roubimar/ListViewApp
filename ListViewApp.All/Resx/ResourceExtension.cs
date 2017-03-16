using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewApp.All.Resx
{
    [ContentProperty("Text")]
    public class ResourceExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;
            return AppResources.ResourceManager.GetString(Text, CultureInfo.CurrentCulture);
        }
    }
}
