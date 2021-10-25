using System;
using System.Collections.Generic;
using System.Text;

namespace Aleksandrov
{
    interface LogInterface
    {
         LogInterface log(string str);
         LogInterface write();
    }
}
