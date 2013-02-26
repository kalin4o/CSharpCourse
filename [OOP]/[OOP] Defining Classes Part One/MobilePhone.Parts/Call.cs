using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Parts
{
    public class Call
    {
        private DateTime datetime;
        private string number; 
        private int duration;

        public DateTime Datetime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Call(DateTime datetime, string number, int duration)
        {
            this.datetime = datetime;
            this.number = number;
            this.duration = duration;
        }
    }
}
