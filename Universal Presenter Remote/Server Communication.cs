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
        private static int uid = 0;

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

        public static void setupUid()
        {
            Random rnd = new Random();
            uid = rnd.Next(9999, 999999999);
        }

        public static bool sendCommand(string command)
        {
            string response = getResponse(command + "?token=" + token + "&holdfor=" + uid);
            int r = 0;
            try
            {
                r = Int32.Parse(response);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            if (r == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool joinSession()
        {
            string response = getResponse("JoinSession?token=" + token);
            int r = 0;
            try
            {
                r = Int32.Parse(response);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            if (r > 0)
            {
                uid = r;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void checkStatus()
        {
            if(getResponse("Alive") == "Ready")
            {
                serverAvailable = true;
                if (temptoken == 0)
                {
                    try
                    {
                        temptoken = Int32.Parse(getResponse("NewSession"));
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                try
                {
                    controlmode = Int32.Parse(getResponse("TempSession?token=" + temptoken + "&holdfor=" + uid));
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                serverAvailable = false;
            }
        }

        public static void update()
        {
            string response = getResponse("ActiveSession?token=" + token + "&holdfor=" + uid);
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
                    if ((r - SlideControl.currentSlide) >= 100)
                    {
                        SlideControl.playMedia();
                    } 
                    else
                    {
                        SlideControl.slideforward();
                    }

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
