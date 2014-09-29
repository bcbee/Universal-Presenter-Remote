using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_Presenter_Remote
{
    class SupportedProgram
    {
        public string Name { get; set; }
        public string ControlWindow { get; set; }
        public string StartProcess { get; set; }
        public SupportedProgram(string n, string c,  string p)
        {
            Name = n;
            ControlWindow = c;
            StartProcess = p;
        }
    }
}