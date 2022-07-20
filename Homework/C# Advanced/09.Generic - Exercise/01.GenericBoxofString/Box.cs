using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box
    {
        private List<string> boxes;

        public Box()
        {
            boxes = new List<string>();
        }
        public void Add(string box)
        {
            boxes.Add(box);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 

          foreach (string box in boxes)
            {
                sb.AppendLine($"System.String: { box}");
            }
          return sb.ToString().TrimEnd();
        }
    }
}
