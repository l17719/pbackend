using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BackEndAplication
{
    public sealed class VisibilityConverter : IValueConverter
    {
        #region Implementation of IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof (Visibility))
                throw new ArgumentOutOfRangeException("targetType", "VisibilityConverter can only convert to Visibility");

            Visibility vis = Visibility.Visible;

            if (value == null)
            {
                vis = Visibility.Hidden;
            }
            if (value is bool)
            {
                vis = (bool) value ? Visibility.Visible : Visibility.Hidden;
            }

            var s = value as string;
            if (s != null)
            {
                vis = string.IsNullOrEmpty(s) ? Visibility.Hidden : Visibility.Visible;
            }
            return vis;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Visibility))
            {
                throw new ArgumentOutOfRangeException("value", "VisibilityConverter can only convert from Visibility");
            }
            if (targetType == typeof (bool))
            {
                return ((Visibility) value == Visibility.Visible) ? true : false;
            }
            throw new ArgumentOutOfRangeException("targetType", "VisibilityConverter can only convert to Boolean");
        }

        #endregion
    }
}