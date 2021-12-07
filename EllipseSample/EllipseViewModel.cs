using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GameTestApp.EllipseSample
{
    public class EllipseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int xTransform;

        public int XTransform
        {
            get => xTransform;
            set
            {
                this.xTransform = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("XTransform"));
            }
        }

        private int yTransform;

        public int YTransform
        {
            get => yTransform;
            set
            {
                this.yTransform = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("YTransform"));
            }
        }

        private double left;

        public double Left
        {
            get => left;
            set
            {
                this.left = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Left"));
            }
        }

        private double top;

        public double Top
        {
            get => top;
            set
            {
                this.top = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Top"));
            }
        }

        private double width;

        public double Width
        {
            get => width;
            set
            {
                this.width = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Width"));
            }
        }

        private double height;

        public double Height
        {
            get => height;
            set
            {
                this.height = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Height"));
            }
        }

        private double thickness;

        public double Thickness
        {
            get => thickness;
            set
            {
                this.thickness = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Thickness"));
            }
        }

        private Color color;

        public Color Color
        {
            get => color;
            set
            {
                this.color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Color"));
            }
        }
    }
}
