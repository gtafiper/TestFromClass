using System;
using System.Data;

namespace Test_techniqes
{
    public class Cal : ITeste

    {
        public int ToGrade(int percentage)
        {

            switch (percentage)
            {
                case int grade when (percentage <= 5):
                    return -3;


                case int grade1 when (percentage <= 49):
                    return 0;


                case int grade2 when (percentage <= 59):
                    return 2;


                case int grade3 when (percentage <= 79):
                    return 4;


                case int grade4 when (percentage <= 84):
                    return 7;


                case int grade5 when (percentage <= 94):
                    return 10;


                case int grade6 when (percentage <= 100):
                    return 12;

                case int grade7 when (percentage > 100):
                    throw new DataException("the max percentage is 100");

            }

            return percentage;

        }

        public bool IsTeenager(DateTime bDay)
        {
            int age = 0;
            age = DateTime.Now.Year - bDay.Year;
            if (DateTime.Now.DayOfYear < bDay.DayOfYear)
            {
                age = age - 1;
            }

            if (age > 12 && age < 19)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}