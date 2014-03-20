﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Presenter_Remote
{
    class SlideControl
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public static int presentationSoftware {get; set;}
        public static int currentSlide = 5000;

        public static SupportedProgram[] supportedPrograms = new SupportedProgram[] {
                new SupportedProgram("Microsoft PowerPoint", "powerpnt", "pwrpnt.exe"),
                new SupportedProgram("Internet Explorer", "iexplore", "iexplore.exe"),
                new SupportedProgram("Manual Program Entry (Advanced)", "TBD", "TBD")
        };

        public static void slidecontrol(bool direction)
        {
            Process p = Process.GetProcessesByName(supportedPrograms[presentationSoftware].ControlWindow).FirstOrDefault();
            if (p == null)
            {
                p = Process.Start(supportedPrograms[presentationSoftware].StartProcess);
            }
            p.WaitForInputIdle();
            IntPtr h = p.MainWindowHandle;
            SetForegroundWindow(h);
            if (direction == true)
            {
                SendKeys.SendWait("{RIGHT}");
            }
            else 
            { 
                SendKeys.SendWait("{LEFT}");
            }
        }

        public bool connect()
        {
            Process p = Process.GetProcessesByName(supportedPrograms[presentationSoftware].ControlWindow).FirstOrDefault();
            if (p == null)
            {
                try
                {
                    p = Process.Start(supportedPrograms[presentationSoftware].StartProcess);
                }
                catch
                {
                    return false;
                }
                
                p.WaitForInputIdle();
            }
            IntPtr h = p.MainWindowHandle;
            SetForegroundWindow(h);
            return true;
        }

        public static void slideforward()
        {
            slidecontrol(true);
        }

        public static void slidebackward()
        {
            slidecontrol(false);
        }
    }
}