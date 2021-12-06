using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GameTestApp
{
    // https://social.msdn.microsoft.com/Forums/sqlserver/en-US/83376231-1d93-47b5-acc3-2fa51f151c1f/how-to-add-children-to-a-canvas-dynamically-in-mvvm?forum=wpf

    public class EllipseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double x;

        public double X
        {
            get => x;
            set
            {
                this.x = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("X"));
            }
        }

        private double y;

        public double Y
        {
            get => y;
            set
            {
                this.y = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Y"));
            }
        }

        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                this.radius = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Radius"));
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
