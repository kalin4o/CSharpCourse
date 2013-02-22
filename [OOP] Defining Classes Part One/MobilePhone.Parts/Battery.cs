using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Parts
{
    public class Battery
    {
        private string model;
        private double? hoursIdle = null;
        private double? hoursTalk = null;
        private BatteryType? type = null;

        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                
            }
        }    
        public double? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }
        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
        public BatteryType? Type
        {
            get { return type; }
            set { type = value; }
        }



        public Battery()
        {
        }
        public Battery(string model)
        {
            this.model = model;
        }
        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }
        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }
    }
}
