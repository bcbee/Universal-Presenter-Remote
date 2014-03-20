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
        private static string serverAddress = "http://localhost/";

        public static bool serverAvailable = false;
        public static bool enabled = false;
        public static int temptoken = 0;
        public static int controlmode = 0;
        public static int token = 0;

        private static String getResponse(String page)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serverAddress+page);
            myRequest.Method = "GET";
            WebResponse myResponse;
            try
            {
                myResponse = myRequest.GetResponse();
            }
            catch
            {
                return "";
            }
            
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }

        public static void checkStatus()
        {
            if(getResponse("Alive") == "Ready")
            {
                serverAvailable = true;
                controlmode = Int32.Parse(getResponse("TempSession"));
                if (temptoken == 0)
                {
                    temptoken = Int32.Parse(getResponse("NewSession"));
                }
            }
            else
            {
                serverAvailable = false;
            }
        }

        public static void update()
        {
            string response = getResponse("ActiveSession");
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
