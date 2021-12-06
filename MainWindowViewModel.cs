using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace wpf_Generic_ListBox_Canvas
{
    public class MainWindowViewModel
    {
        public ObservableCollection<BaseThing> Items { get; set; }
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<BaseThing>
            {
                new CircleVM {Top=000.0, Left=000.0, EllipseHeight=400, EllipseWidth=400, Thickness = 40, Color = Color.FromArgb(255, 255, 0, 0)},
                new CircleVM {Top=140.0, Left=040.0, EllipseHeight=320, EllipseWidth=320, Thickness = 40, Color = Color.FromArgb(255, 0, 0, 255)},
                new CircleVM {Top=080.0, Left=080.0, EllipseHeight=240, EllipseWidth=240, Thickness = 40, Color = Color.FromArgb(255, 0, 255, 0)}
            };
        }
    }

    public class BaseThing
    {
        public Double Left { get; set; }
        public Double Top { get; set; }
        public Double Height { get; set; }
        public Double Width { get; set; }
    }

    public class CircleVM : BaseThing
    {
        public Double EllipseHeight { get; set; }
        public Double EllipseWidth { get; set; }
        public Color Color { get; set; }
        public Double Thickness { get; set; }
    }

    class TextBoxVM : BaseThing
    {
        public string TbText { get; set; }
    }
}
