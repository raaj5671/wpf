using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace shopfloorcs.ViewModels.Converters
{
    public class StatusToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) // From model to view
        {
            if (value is bool)
            {
                if ((bool)value == true)
                {
                    return "Enable";
                }
                else
                {
                    return "Disable";
                }
            }
            return "Disable";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) // From view to model
        {
            switch (value.ToString())
            {
                case "Enable":
                    return true;
                case "Disable":
                    return false;
            }
            return false;
            

        }
    }
}
