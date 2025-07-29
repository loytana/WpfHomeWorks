using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Task4
{
    public class OnOffButton : Button
    {
        public static readonly DependencyProperty OnOffProperty =
            DependencyProperty.Register(
                nameof(ClickOnOff),
                typeof(int),
                typeof(OnOffButton),
                new FrameworkPropertyMetadata(
                    0,
                    OnClickOnOffChanged));
        public int ClickOnOff
        {
            get => (int)GetValue(OnOffProperty);
            set => SetValue(OnOffProperty, value);
        }
        private static void OnClickOnOffChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var button = (OnOffButton)d;
            int newValue = (int)e.NewValue;

            button.Content = newValue % 2 == 0
                ? "OFF"
                : "ON";
            button.Background = newValue % 2 == 0
                ? new SolidColorBrush(Colors.Red)
                : new SolidColorBrush(Colors.Green);
        }
        public OnOffButton()
        {
            Content = "OFF";
            Background = new SolidColorBrush(Colors.Red);

            Click += (sender, e) => ClickOnOff++;
        }
    }
}
