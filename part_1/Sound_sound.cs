using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace part_1

{
    public class Sound_sound
    {
        //constructor
        public Sound_sound()
        {
            //getting the app full location
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace bin \ Debug\

            string new_path = full_location.Replace("bin\\Debug\\", "say.wav");

            //combine the paths

            string full_path = Path.Combine(new_path, "");

            //try and catch to play the audio
            try
            {
                //making use of using function

                using (SoundPlayer play = new SoundPlayer(full_path))
                {
                    //play the file 
                    play.PlaySync();


                }// end of using 



            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }// end of catch














        }// end of constructor 





    }
}
