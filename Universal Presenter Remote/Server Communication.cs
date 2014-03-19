using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Universal_Presenter_Remote
{
    class Server_Communication
    {
        private static string serverAddress = "http://localhost";
        public static bool enabled = false;

        private static String getResponse()
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serverAddress);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }

        public static void update()
        {
            string response = getResponse();
            int r = 0;
            try
            {
                r = Int32.Parse(response);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            if (r > 0 && Server_Communication.enabled)
            {
                if (r > SlideControl.currentSlide)
                {
                    SlideControl.slideforward();
                    SlideControl.currentSlide = r;
                }
                if (r < SlideControl.currentSlide)
                {
                    SlideControl.slidebackward();
                    SlideControl.currentSlide = r;
                }
            }
        }

    }
}
