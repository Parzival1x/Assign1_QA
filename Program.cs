using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_QA
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
            SetLength(length);
            SetWidth(width);
        }

        public int GetLength()
        {
            return rect_lth;
        }

        public int GetWidth()
        {
            return rect_wth;
        }


        public int SetLength(int length)
        {
            rect_lth = length;

            return length;
        }

        public int SetWidth(int width)
        {
            rect_wth = width;

            return width;
        }


        public int GetPerimeter(int length, int width)
        {
            rect_perimeter = (2 * (length + width));

            return rect_perimeter;
        }

        public int GetArea(int length, int width)
        {
            rect_area = (length * width);

            return rect_area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lth = 0;
            var wdth = 0;
            Rectangle rect = new Rectangle();

            var user_input = "";

            Console.Write("Enter length for Rectangle: ");
            lth = Convert.ToInt32(Console.ReadLine());
            rect.SetLength(lth);

            Console.Write("Enter width for Rectangle: ");
            wdth = Convert.ToInt32(Console.ReadLine());
            rect.SetWidth(wdth);

            bool Continue = true;

            while (Continue)
            {
                Console.WriteLine(
                    "Choose one of the following option to continue:" + "\n"
                    + "1. Get length of rectangle." + "\n"
                    + "2. Get width of rectangle." + "\n"
                    + "3. Change length of rectangle." + "\n"
                    + "4. Change width of rectangle." + "\n"
                    + "5. Get Perimeter of rectangle." + "\n"
                    + "6. Get Area of rectangle." + "\n"
                    + "7. Quit!");

                Console.Write("Please enter a value from the list: ");

                user_input = Console.ReadLine();

                int num = -1;

                if (!int.TryParse(user_input, out num))
                {
                    Console.WriteLine("Not a valid value. please enter the given integers only.");
                }
                else
                {
                    int choice = Convert.ToInt32(user_input);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("The length of the rectangle is : " + rect.GetLength() + "\n");
                            break;
                        case 2:
                            Console.WriteLine("The width of the rectangle is : " + rect.GetWidth() + "\n");

                            break;
                        case 3:
                            Console.WriteLine("The length is set at " + rect.GetLength() + "\n");
                            break;
                        case 4:
                            Console.WriteLine("The width is set at " + rect.GetWidth() + "\n");
                            break;
                        case 5:
                            Console.WriteLine("The Perimeter of rectangle is: " + rect.GetPerimeter(wdth, lth) + "\n");
                            break;
                        case 6:
                            if (lth > 0 && wdth > 0)
                                Console.WriteLine("The Area of the rectangle is " + rect.GetArea(wdth, lth) + "\n");
                            break;
                        case 7:
                            Continue = false;
                            break;
                    }
                }
            }
        }
    }
}
