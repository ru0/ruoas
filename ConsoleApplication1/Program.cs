using System;
using System.Collections.Generic;
using System.Text;
using murrayju.ProcessExtensions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string helpStr = "Creates a proces from LocalSystem,looks like runas,maybe better.\n" +
                                 "hacked by ruo.\n" +
                                 "useage:\n" +
                                 "cp.exe \"d:\\nircmd.exe cmdwait 2000 savescreenshot d:\\11.png\"\n " +
                                 "cp.exe \"c:\\windows\\notepad.exe"
                    
                    ;
                System.Console.WriteLine(helpStr);
            }
            else
            {
                ProcessExtensions.StartProcessAsCurrentUser(null, args[0].ToString());
            }

            
        }
    }
}
