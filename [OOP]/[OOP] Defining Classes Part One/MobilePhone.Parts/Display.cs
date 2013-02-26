using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Parts
{
    public class Display
    {
        private double? size = null;
        private int? colorsNumber = null;

        public double? Size
        {
            get { return size; }
            set { size = value; }
        }
        public int? ColorsNumber
        {
            get { return colorsNumber; }
            set { colorsNumber = value; }
        }

        public Display()
        {
        }
        public Display(double size, int colorsNumber)
        {
            this.size = size;
            this.colorsNumber = colorsNumber;
        }

    }
}
