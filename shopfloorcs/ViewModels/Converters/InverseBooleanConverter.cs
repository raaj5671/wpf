using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace shopfloorcs.ViewModels.Converters
{
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                bool testValue = System.Convert.ToBoolean(value);
                return !testValue; // or do whatever you need with this boolean
            }
            catch { return true; } // or false
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                int testValue = System.Convert.ToInt32(!((bool)value));
                return testValue; // or do whatever you need with this boolean
            }
            catch { return 1; }
        }
    }
}
