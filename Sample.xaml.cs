using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpf_Generic_ListBox_Canvas
{
    /// <summary>
    /// Interaction logic for Sample.xaml
    /// </summary>
    public partial class Sample : Window
    {
        public Sample()
        {
            InitializeComponent();

            var vm = new MainWindowViewModel();
            this.DataContext = vm;
            //vm.VisibleAreas.Add(new CircleVM { Top = 050.0, Left = 050.0, EllipseHeight = 400, EllipseWidth = 400, Thickness = 40, Color = Color.FromArgb(100, 255, 255, 0) });
            //vm.VisibleAreas.Add(new CircleVM { Top = 050.0, Left = 060.0, EllipseHeight = 400, EllipseWidth = 400, Thickness = 40, Color = Color.FromArgb(100, 255, 255, 0) });
        }
    }

    public class ColorToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is System.Windows.Media.Color)
            {
                return new SolidColorBrush((System.Windows.Media.Color)value);
            }
            return new SolidColorBrush(System.Windows.Media.Colors.Orange);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
