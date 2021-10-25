using System;
using System.Collections.Generic;
using System.Text;

namespace Aleksandrov
{
    class AleksandrovLog : LogAbstract, LogInterface 
    {
		private static AleksandrovLog instance;
        List<string> List = new List<string>(); 
        public static AleksandrovLog I()
		{
			if (instance == null)
                instance = new AleksandrovLog();
            return instance;
		}

        public LogInterface log(string str)
        {
            List.Add(str); 
            return this; 
        }

        public LogInterface write()
        {
            writeConsole(List.ToArray());
            return this;
        }
    }
}
