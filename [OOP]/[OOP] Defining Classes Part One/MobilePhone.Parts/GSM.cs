using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Parts
{
    public class GSM
    {
        private string manufacturer;
        private string model;
        private double? price = null;
        private string owner = null;
        private Display display;
        private Battery battInfo;
        private List<Call> callHistory = new List<Call>();      


        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value != null)
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("The phone must have a model");
                }
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value != null)
                {
                    manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("The phone must have a manufacturer");
                }
            }
        }
        public double? Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }


        public GSM(string manufacturer, string model)
            : this(manufacturer, model, null, null)
        {
        }
        public GSM(string manufacturer, string model, double? price, string owner)
            : this(manufacturer, model, price, owner, null, null)
        {
        }
        public GSM(string manufacturer, string model, double? price, string owner, Display display, Battery battInfo)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.display = display;
            this.battInfo = battInfo;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}\nManufacturer: {1}\nPrice: {2:c2}\nOwner: {3}\n"
                , this.model, this.manufacturer, this.price, this.owner);
        }
        public override string ToString()
        {
            StringBuilder phoneInfo = new StringBuilder();
            phoneInfo.AppendLine("Model: " + this.Model + "\nManufacturer: " + this.Manufacturer + "\nOwner: " + this.Owner + "\nPrice: " + this.Price);
            if (this.battInfo != null)
            {
                phoneInfo.AppendLine("Battery: " + this.battInfo.Model);
            }
            if (this.display != null)
            {
                phoneInfo.AppendLine("Display size: " + this.display.Size + "\nDisplay colors number: " + this.display.ColorsNumber);               
            }
            return phoneInfo.ToString();
        }

        static GSM iPhone4S = new GSM("Apple", "4S", 500, "Pesho", new Display(), new Battery("Varta"));
        public GSM IPhone4S { get { return iPhone4S; } }

        public void AddCall(DateTime date, string phoneNum, int duration)
        {
            callHistory.Add(new Call (date, phoneNum, duration));
        }
        public void RemoveCall(Call call)
        {
            callHistory.Remove(call);
        }
        public void ClearCalls()
        {
            callHistory.Clear();
        }
        public double? CalcPrice(double pricePerMinute)
        {
            int? durationSum = 0;
            foreach (var item in callHistory)
            {
                durationSum += item.Duration;
            }
            return (durationSum / 60) * pricePerMinute;
        }
    }
}
