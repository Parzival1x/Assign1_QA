using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_QA
{
    public class Rectangle
    {
        private int rect_lth;
        private int rect_wth;
        private int rect_perimeter = 0;
        private int rect_area = 0;


        public Rectangle()
        {
        }

        public Rectangle(int length, int width)
        {
            setlength(length);
            setwidth(width);
        }

        public int getlength()
        {
            return rect_lth;
        }

        public int getwidth()
        {
            return rect_wth;
        }

        public int getperimeter(int length, int width)
        {
            rect_perimeter = ((length * 2) + (width * 2));

            return rect_perimeter;
        }

        public int getarea(int length, int width)
        {
            rect_area = (length * width);

            return rect_area;
        }

        public int setlength(int length)
        {
            rect_lth = length;

            return length;
        }

        public int setwidth(int width)
        {
            rect_wth = width;

            return width;
        }
    }
}
