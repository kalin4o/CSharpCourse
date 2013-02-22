using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Parts
{
    public class GSMTest
    {

        private GSM[] arrPhones = new GSM[4]
            {
                new GSM("Nokia", "3310", 150.7, "Kalin", new Display(), new Battery("Toshiba")),
                new GSM("Nokia","Nokia"),
                new GSM("HTC","One", 1500, "Ivan"),
                new GSM("Samsung","Galaxy S3", 1000, "Gosho")
            };
        public GSM[] ArrPhones
        {
            get { return arrPhones; }
        }
        public void Test()
        {
            foreach (var item in ArrPhones)
            {
                item.ShowInfo();
            }
            arrPhones[0].IPhone4S.ShowInfo();
            Console.WriteLine(arrPhones[0].IPhone4S.ToString());
            Console.WriteLine();
        }
    }
}
