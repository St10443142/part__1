using System;
using System.Drawing;
using System.IO;

namespace part_1
{
    public class photo1
    {
        public photo1()
        {
            //get full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace bin\\Debug
            string new_location = full_location.Replace("bin\\Debug\\", "");

            //combine the path
            string full_path = Path.Combine(new_location, "images.png");

            //create ASCII image using Bitmap class (use small letter m)
            //after typing, press light bulb
            //select 'using System.Drawing(from System.Drawing)'
            Bitmap image = new Bitmap(full_path);

            //then set the size
            image = new Bitmap(image, new Size(50, 50));

            //outer and inner loop
            for (int height = 0; height < image.Height; height++)
            {
                //inner loop
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char assiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 5 ? '#' : '@';
                //PRINT ASCII CHARACTERS ON THE SAME LINE
                Console.Write(assiChar);
                
                
                
                
                
                }//end of inner loop
                Console.WriteLine();





            }//end of outer loop

        }// end of constructor
    }//end of  class
}//end of name space