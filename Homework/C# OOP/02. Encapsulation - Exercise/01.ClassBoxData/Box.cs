using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width; 
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return length; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
           private  set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public string SurfaceArea()
        {
            double result = 2 * (Length * Width) + 2 * (Width * Height) + 2 * (Height * Length);
            return $"Surface Area - {result:f2}";
        }
        public string LateralSurfaceArea()
        {
            double result = 2 * (Height * Length) + 2 * (Width * Height); 
            return $"Lateral Surface Area - {result:f2}";
        }
        public string Volume()  
        {
          double result =   Length * Width * Height;
            return $"Volume - {result:f2}";
        }






    }
}
