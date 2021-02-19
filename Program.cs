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
            rect.setlength(lth);

            Console.Write("Enter width for Rectangle: ");
            wdth = Convert.ToInt32(Console.ReadLine());
            rect.setwidth(wdth);

            bool PleaseContinue = true;

            while (PleaseContinue)
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

                Console.Write("Please enter a value - ");

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
                            Console.WriteLine("The length of the rectangle is : " + rect.getlength() + "\n");
                            break;
                        case 2:
                            Console.WriteLine("The length is set at " + rect.getlength() + "\n");
                            break;
                        case 3:
                            Console.WriteLine("The width of the rectangle is : " + rect.getwidth() + "\n");
                            break;
                        case 4:
                            Console.WriteLine("The width is set at " + rect.getwidth() + "\n");
                            break;
                        case 5:
                            Console.WriteLine("The Perimeter of rectangle is: " + rect.getperimeter(wdth, lth) + "\n");
                            break;
                        case 6:
                            if (lth > 0 && wdth > 0)
                                Console.WriteLine("The Area of the rectangle is " + rect.getarea(wdth, lth) + "\n");
                            break;
                        case 7:
                            PleaseContinue = false;
                            break;
                    }
                }
            }
        }
    }
}
