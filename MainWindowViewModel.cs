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
        public ObservableCollection<BaseThing> VisibleAreas { get; set; }
        public ObservableCollection<BaseThing> HiddenAreas { get; set; }
        
        public MainWindowViewModel()
        {
            VisibleAreas = new ObservableCollection<BaseThing>
            {
                //new CircleVM {Top=000.0, Left=000.0, EllipseHeight=400, EllipseWidth=400, Thickness = 40, Color = Color.FromArgb(100, 255, 0, 0)},
                //new CircleVM {Top=140.0, Left=040.0, EllipseHeight=320, EllipseWidth=320, Thickness = 40, Color = Color.FromArgb(100, 0, 0, 255)},
                
            };

            // outer ping, thickness is 10, width and height are 100
            VisibleAreas.Add(new CircleVM { Top = 100.0, Left = 100.0, EllipseHeight = 200, EllipseWidth = 200, Thickness = 20, Color = Color.FromArgb(100, 255, 0, 0) });
            
            // we have moved 20 units to the right, since ellipse is smaller, left is +40, and width and height are -40
            // top is also +20 because ellips is smaller
            // Top and Left are actually Location - (outer range)
            // Width and Height are (outer rage * 2)
            VisibleAreas.Add(new CircleVM { Top = 120.0, Left = 140.0, EllipseHeight = 160, EllipseWidth = 160, Thickness = 20, Color = Color.FromArgb(100, 0, 0, 255) });

            HiddenAreas = new ObservableCollection<BaseThing>();
            foreach (CircleVM circle in VisibleAreas)
            {
                //var outer = new CircleVM()
                //{
                //    Top = circle.Top - 40,
                //    Left = circle.Left - 40,
                //    EllipseHeight = circle.EllipseHeight + 80,
                //    EllipseWidth = circle.EllipseWidth + 80,
                //    Thickness = 80,
                //    Color = Color.FromArgb(100, 0, 0, 0)
                //};

                //var inner = new CircleVM()
                //{
                //    Top = circle.Top + 20,
                //    Left = circle.Left + 20,
                //    EllipseHeight = circle.EllipseHeight- 40,
                //    EllipseWidth = circle.EllipseWidth - 40,
                //    Thickness = 20,
                //    Color = Color.FromArgb(100, 0, 0, 0)
                //};

                //HiddenAreas.Add(outer);
                //HiddenAreas.Add(inner);
            }
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
