using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Parts
{
    public class GSMCallHistoryTest
    {
        public void CallHistoryTest()
        {
            GSM phone = new GSM("Samsung", "3310", 550.7, "Kalin", new Display(), new Battery("AA"));
            phone.AddCall(new DateTime(2010, 1, 18, 18, 20, 22), "088961444", 44);
            phone.AddCall(new DateTime(2010, 1, 18, 19, 00, 55), "089798046", 152);
            phone.AddCall(new DateTime(2010, 1, 20, 03, 44, 31), "084646546", 509);

            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine("Date: {0}, Number: {1}, Duration: {2} sec", item.Datetime, item.Number, item.Duration);
            }

            Console.WriteLine("Price of the calls: {0}", phone.CalcPrice(0.37));

            int longestCall = 0;
            for (int i = 0; i < phone.CallHistory.Count -1; i++)
            {
                if (phone.CallHistory[i].Duration > phone.CallHistory[i+1].Duration)
                {
                    longestCall = i;
                }
                else
                {
                    longestCall = i + 1;
                }
            }
            phone.RemoveCall(phone.CallHistory[longestCall]);
            Console.WriteLine("Price of the calls: {0}", phone.CalcPrice(0.37));
            phone.ClearCalls();
            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine("Date: {0}, Number: {1}, Duration: {2} sec", item.Datetime, item.Number, item.Duration);
            }

        }
    }
}
