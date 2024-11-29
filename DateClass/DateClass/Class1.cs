using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass
{
    public class Date
    {
       private int _Year {  get; set; }
       private int _Month { get; set; }     
       private int _Day { get; set; }

 
        public Date(int Year, int Month , int Day)
        {
            _Year = Year;
            _Month = Month;
            _Day = Day;
        }

        public bool CheckLeapYear()
        {
            return (_Year % 400 == 0) || (_Year % 4 == 0 && _Year % 100 != 0);
        }


        public bool CheckValidMonth()
        {
            if(_Month>0 &&_Month<=12)
            {
                return true;
            }
            return false;
        }
        public bool CheckValidYear()
        {
           DateTime dateTime = DateTime.Now;
            

            if(_Year ==dateTime.Year || _Year== dateTime.Year+1)
            {
                return true;
            }
            return false;
        }
        public bool CheckValidDay()
        {
           int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            if(_Month>12)
            { return false; }


            if(_Month==2 && CheckLeapYear())
            {
                if(_Day<=29 && _Day>0)
                {
                    return true;
                }
                return false;
            }

            if (daysInMonths[_Month-1] <_Day ||_Day==0)
            {
                return false;
            }
            return true;
        }
       public bool CheckDateIsPasse()
        {
            DateTime dDate =  DateTime.Now;

            if(_Year> dDate.Year)
            {
                return false;
            }

            if (_Month > dDate.Month)
            {
                return false;
            }
            if (_Month == dDate.Month)
            {
                if (_Day >= dDate.Day)
                {
                    return false;
                }
            }
           
            return true;
        }
        public bool CheckValidDate()
        {
            if (!CheckValidDay() || !CheckValidMonth() || !CheckValidYear())
            {
                return false;
            }
            return true;

        }

    }

}
