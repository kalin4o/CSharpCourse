using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Parts;

namespace MobilePhone
{
    class Mobile
    {
        static void Main()
        {
            GSMTest test = new GSMTest();
            test.Test();

            GSMCallHistoryTest test2 = new GSMCallHistoryTest();
            test2.CallHistoryTest();
        }
    }
}
