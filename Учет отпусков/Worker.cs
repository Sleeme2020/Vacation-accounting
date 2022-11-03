using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Учет_отпусков
{
    public class Worker
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
            get => default;
            set
            {
            }
        }
    }
}