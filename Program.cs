using System;
using System.Drawing;

namespace jpegtest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var img = Image.FromFile("test.jpg"))
	    {
                Console.WriteLine(img.HorizontalResolution);
                Console.WriteLine(img.VerticalResolution);
            }
        }
    }
}
