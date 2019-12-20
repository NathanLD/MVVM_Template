using System;
using System.Globalization;
using System.Windows.Data;

namespace MVVM_Template.Utils.Converter
{
    // Un "Converter" convertit un type de données côté ViewModel, en autre type de données côté View.
    // Exemple : Un booléen dans le code (true/false) va être converti en string pour la vue ("Visible"/"Hidden")
    class ExampleBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "Hidden";

            bool myVal = (Boolean)value;
            if (myVal) return "Visible";
            else return "Hidden";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}
