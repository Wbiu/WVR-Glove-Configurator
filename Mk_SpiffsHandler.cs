using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WVR_Glove_Configurator
{
    class Mk_SpiffsHandler
    {
        private Process process = new Process(); 
        public event EventHandlerPassInt eventHandlerPassInt;
        public event EventHandlerPassBool eventHandlerPassBool;
        public Mk_SpiffsHandler(string mkPath)
        {
            Directory.SetCurrentDirectory(mkPath);
        }
        public void makeBin()
        {
            process.StartInfo.FileName = "mkspiffs.exe";
            process.StartInfo.Arguments = "-c data -b 4096 -p 256 -s 0x100000 settings.bin";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            if(eventHandlerPassInt != null && eventHandlerPassBool != null)
            {
                while(!process.HasExited)
                {
                    int i = process.StandardOutput.Read();
                    eventHandlerPassInt(this,null,i);
                }
                eventHandlerPassBool(this,null,true);
                process.WaitForExit();
            }
        }
    }
}
