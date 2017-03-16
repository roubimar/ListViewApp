﻿using System;
using Xamarin.Forms;

namespace ListViewApp.All.Helpers
{
    public class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((DateTime)value).ToString("dd/MM/yyyy");
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return DateTime.Parse(value.ToString());
        }
    }
}
