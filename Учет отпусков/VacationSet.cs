using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Учет_отпусков
{
    public class VacationSet
    {
        public int WorkerId
        {
            get;
            set;
        }
        public Worker Worker
        {
            get;
            set;
        }

        public DateOnly Date
        {
            get;
            set;
        }        

        public int Period
        {
            get;
            set;
        }

        public int Val
        {
            get;
            set;
        }

        public OperationType Operation
        {
            get;
            set;
        }
    }
}