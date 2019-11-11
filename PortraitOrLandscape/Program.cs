using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortraitOrLandscape
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;

            Console.Write("Enter the image height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter the imange width: ");
            width = int.Parse(Console.ReadLine());
            if (height > width)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("Landscape");
            Console.ReadLine();
        }
    }
}
/*
Sample Result:
Enter the image height: 45
Enter the imange width: 22
Portrait
*/

