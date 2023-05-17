using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okolnaSreda
{
    internal class SadarjanieIzsledvane :Izsledvane,IComparable<SadarjanieIzsledvane>
    {
        private int norma;
        public int Norma
        {
            get { return norma; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("Grephka");
                }
                this.norma = value;
            }
        }
        private int sadarjanie;
        public int Sadarjanie
        {
            get { return sadarjanie; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grephka");
                }
                this.sadarjanie = value;
            }
        }
        public SadarjanieIzsledvane(string obekt, string date, string veshtestvo, 
            int norma, int sadarjanie):base(obekt,date,veshtestvo)
        {
            this.Norma = norma;
            this.Sadarjanie = sadarjanie;
        }

        public int CompareTo(SadarjanieIzsledvane obj)
        {
           int result= this.sadarjanie.CompareTo(obj.sadarjanie);
            if (result == 0)
                result = this.Date.CompareTo(obj.Date);
            return result;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{this.norma} {this.sadarjanie}");
        }
    }
}
