using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComapreDates
{
    public class Compare
    {
        //this method compare dates only (without time)
        public static int CompareDatesOnly (DateTime d1, DateTime d2)
        {
            int b = 0;
            if (d1.Year > d2.Year)
            {
                b = 1;
            }
            else if (d1.Year < d2.Year)
            {
                b = -1;
            }
            else
            {
                if (d1.Month > d2.Month)
                {
                    b = 1;
                }
                else if(d1.Month < d2.Month)
                {
                    b = -1;
                }
                else
                {
                    if (d1.Day > d2.Day)
                    {
                        b = 1;
                    }
                    else if (d1.Day < d2.Day)
                    {
                        b = -1;
                    }
                }
            }
            return b;
        }

        public static int CompareTimeOnly(DateTime d1, DateTime d2)
        {
            int b = 0;
            if (d1.Hour > d2.Hour)
            {
                b = 1;
            }
            else if(d1.Hour < d2.Hour)
            {
                b = -1;
            }
            else
            {
                if (d1.Minute > d2.Minute)
                {
                    b = 1;
                }
                else if (d1.Minute<d2.Minute)
                {
                    b = -1;
                }
                else
                {
                    if (d1.Second > d2.Second)
                    {
                        b = 1;
                    }
                    else if(d1.Second < d2.Second)
                    {
                        b = -1;
                    }
                    else if(d1.Millisecond > d2.Millisecond)
                    {
                        b = 1;
                    }
                    else if(d1.Millisecond < d2.Millisecond)
                    {
                        b = -1;
                    }

                }
            }
            return b;
        }

        public static int CompareDateTime(DateTime d1, DateTime d2)
        {
            return d1.CompareTo(d2);
        }
    }
}
