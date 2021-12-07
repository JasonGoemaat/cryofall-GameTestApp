using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GameTestApp.EllipseSample
{
    public class EllipseSampleViewModel
    {
        public ObservableCollection<EllipseViewModel> VisibleEllipses { get; set; }
        public ObservableCollection<EllipseViewModel> HiddenEllipses { get; set; }

        public EllipseSampleViewModel()
        {
            VisibleEllipses = new ObservableCollection<EllipseViewModel>();
            HiddenEllipses = new ObservableCollection<EllipseViewModel>();

            //VisibleEllipses.Add(new EllipseViewModel()
            //{
            //    Left = 10050,
            //    Top = 8050,
            //    Width = 100,
            //    Height = 100,
            //    Color = Color.FromArgb(255, 0, 255, 0),
            //    Thickness = 20,
            //    XTransform = -10000,
            //    YTransform = -8000
            //});

            //HiddenEllipses.Add(new EllipseViewModel()
            //{
            //    Left = 10000,
            //    Top = 8000,
            //    Width = 200,
            //    Height = 200,
            //    Color = Color.FromArgb(128, 0, 0, 0),
            //    Thickness = 50,
            //    XTransform = -10000,
            //    YTransform = -8000
            //});


            //HiddenEllipses.Add(new EllipseViewModel()
            //{
            //    Left = 10070,
            //    Top = 8070,
            //    Width = 60,
            //    Height = 60,
            //    Color = Color.FromArgb(128, 0, 0, 0),
            //    Thickness = 30,
            //    XTransform = -10000,
            //    YTransform = -8000
            //});

            Pong(10000, 10000, 1.5);
            Pong(10020, 10000, 1.2);
            Pong(10040, 10000, 0.9);
            Pong(10060, 10000, 0.6);
            Pong(10080, 10000, 0.3);
            //Pong(10020, 10000, 1.2);
            //Pong(10010, 10000, 1.2);
        }

        public void UpdatePosition(double x, double y)
        {
            foreach (var e in VisibleEllipses)
            {
                e.XTransform = (int)(-x + 200);
                e.YTransform = (int)(-y + 200);
            }

            foreach (var e in HiddenEllipses)
            {
                e.XTransform = (int)(-x + 200);
                e.YTransform = (int)( -y + 200);
            }
        }

        public void Pong(double x, double y, double timeSincePing)
        {
            int stage = (int)(Math.Round(timeSincePing / 0.3));
            int outerRadius = stage * 20;
            int innerRadius = outerRadius - 20;
            int superOuterRadius = outerRadius + 60;

            Color color = Color.FromArgb(255, 255, 255, 255);
            Color hiddenColor = Color.FromArgb(255, 0, 0, 0);

            switch(stage)
            {
                case 1:
                    color = Color.FromArgb(128, 0, 255, 0); // green inner
                    break;
                case 2:
                    color = Color.FromArgb(128, 0, 0, 255); // blue inner
                    break;
                case 3:
                    color = Color.FromArgb(128, 255, 0, 0); // red inner
                    break;
                case 4:
                    color = Color.FromArgb(128, 192, 128, 0); // ?? 
                    break;
                case 5:
                    color = Color.FromArgb(128, 0, 192, 128); // ?? 
                    break;
                default:
                    color = Color.FromArgb(255, 255, 255, 0);
                    break;
            }

            VisibleEllipses.Add(new EllipseViewModel()
            {
                Left = x - outerRadius,
                Top = y - outerRadius,
                Width = outerRadius * 2,
                Height = outerRadius * 2,
                Color = color,
                Thickness = 20,
                XTransform = (int)-x,
                YTransform = (int)-y
            });

            HiddenEllipses.Add(new EllipseViewModel()
            {
                Left = x - innerRadius,
                Top = y - innerRadius,
                Width = innerRadius * 2,
                Height = innerRadius * 2,
                Color = hiddenColor,
                Thickness = innerRadius,
                XTransform = (int)-x,
                YTransform = (int)-y
            });


            HiddenEllipses.Add(new EllipseViewModel()
            {
                Left = x - superOuterRadius,
                Top = y - superOuterRadius,
                Width = superOuterRadius * 2,
                Height = superOuterRadius * 2,
                Color = hiddenColor,
                Thickness = 60,
                XTransform = (int)-x,
                YTransform = (int)-y
            });

            UpdatePosition(x, y);
        }
    }
}
