using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Учет_отпусков.Models
{
    public class Worker:ICloneable
    {
        public string Name
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public DateOnly DateStart
        {
            get;
            set;
        }

        public DateOnly DateEnd
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public object Clone()
        {
           return new Worker() { Name = this.Name,FirstName=this.FirstName, DateEnd=this.DateEnd, DateStart=this.DateEnd, LastName=this.LastName};
        }

        public override string ToString()
        {
            return $"{FirstName} {Name} - дата начала {DateStart}";
        }
    }
}