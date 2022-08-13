using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int height { get; set; }
        public int width { get; set; }

        public override double CalculateArea()
        {
            return height * width;  
        }

        public override double CalculatePerimeter()
        {
            return 2 * height + 2 * width;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
