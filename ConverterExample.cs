using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.UI.Xaml.Data;

namespace CompiledBindingsDemo
{
    class ConverterExample : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return string.Empty;

            // какие-то преобразования со значением value
            string newtext = value.ToString();
            newtext = newtext.ToUpper();

            return newtext;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            // используется редко
            throw new NotImplementedException();
        }
    }
}
