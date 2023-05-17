using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okolnaSreda
{
    internal class Izsledvane:IPrint
    {
        private string obekt;
        public string Obekt
        {
            get { return obekt; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "value"
                    );
                }
                this.obekt = value;
            }
          
        }
        private string date;
        public string Date
        {
            get { return date; }
          
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Grephka"
                    );
                }
                this.date = value;
            }

        }
        private string veshtestvo;
        public string Veshestvo
        {
            get { return veshtestvo; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "value"
                    );
                }
                this.veshtestvo = value;
            }

        }
        public Izsledvane(string obekt,string date,string veshtestvo)
        {
            this.Obekt = obekt;
            this.Date=date;
            this.Veshestvo = veshtestvo;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{this.obekt} {this.date} {this.veshtestvo}");
        }
    }
  }

