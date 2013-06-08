using System.Windows;
using System.Windows.Controls;

namespace BackEndAplication.Utilities.AttachedProperties
{
    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password", typeof (string),
                                                typeof (PasswordBoxHelper),
                                                new FrameworkPropertyMetadata(string.Empty, OnPasswordPropertyChanged));

        public static readonly DependencyProperty AttachProperty =
            DependencyProperty.RegisterAttached("Attach",
                                                typeof (bool), typeof (PasswordBoxHelper),
                                                new PropertyMetadata(false, Attach));

        private static readonly DependencyProperty IsUpdatingProperty =
            DependencyProperty.RegisterAttached("IsUpdating", typeof (bool),
                                                typeof (PasswordBoxHelper));


        public static void SetAttach(DependencyObject valuedp, bool value)
        {
            valuedp.SetValue(AttachProperty, value);
        }

        public static bool GetAttach(DependencyObject valuedp)
        {
            return (bool) valuedp.GetValue(AttachProperty);
        }

        public static string GetPassword(DependencyObject valuedp)
        {
            return (string) valuedp.GetValue(PasswordProperty);
        }

        public static void SetPassword(DependencyObject valuedp, string value)
        {
            valuedp.SetValue(PasswordProperty, value);
        }

        private static bool GetIsUpdating(DependencyObject valuedp)
        {
            return (bool) valuedp.GetValue(IsUpdatingProperty);
        }

        private static void SetIsUpdating(DependencyObject valuedp, bool value)
        {
            valuedp.SetValue(IsUpdatingProperty, value);
        }

        private static void OnPasswordPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs value)
        {
            var pbox = sender as PasswordBox;
            if (pbox == null) return;
            pbox.PasswordChanged -= PasswordChanged;

            if (!GetIsUpdating(pbox))
            {
                pbox.Password = (string) value.NewValue;
            }
            pbox.PasswordChanged += PasswordChanged;
        }

        private static void Attach(DependencyObject sender,
                                   DependencyPropertyChangedEventArgs value)
        {
            var pbox = sender as PasswordBox;
            if (pbox == null)
            {
                return;
            }
            if ((bool) value.OldValue)
            {
                pbox.PasswordChanged -= PasswordChanged;
            }
            if ((bool) value.NewValue)
            {
                pbox.PasswordChanged += PasswordChanged;
            }
        }

        private static void PasswordChanged(object sender, RoutedEventArgs value)
        {
            var pbox = sender as PasswordBox;
            SetIsUpdating(pbox, true);
            if (pbox == null) return;
            SetPassword(pbox, pbox.Password);
            SetIsUpdating(pbox, false);
        }
    }
}