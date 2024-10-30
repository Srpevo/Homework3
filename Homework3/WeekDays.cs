using System;

namespace WeekDaysInArmenian
{
        internal class WeekDays
        {

            static public string GetWeekDayBySwitch()
            {

            var DayOfWeek = DateTime.Now.DayOfWeek;

                switch (DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        return "Երկուշաբթի";
                    case DayOfWeek.Tuesday:
                        return "Երեքշաբթի";
                    case DayOfWeek.Wednesday:
                        return "Չորեքշաբթի";
                    case DayOfWeek.Thursday:
                        return "Հինգշաբթի";
                    case DayOfWeek.Friday:
                        return "Ուրբաթ";
                    case DayOfWeek.Saturday:
                        return "Շաբաթ";
                    case DayOfWeek.Sunday:
                        return "Կիրակի";
                    default:
                        return "Unknow Day :(";
                }
            }

        public static string GetWeekDayByIfElse()
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Monday) return "Երկուշաբթի";
            else if (dayOfWeek == DayOfWeek.Tuesday) return "Երեքշաբթի";
            else if (dayOfWeek == DayOfWeek.Wednesday) return "Չորեքշաբթի";
            else if (dayOfWeek == DayOfWeek.Thursday) return "Հինգշաբթի";
            else if (dayOfWeek == DayOfWeek.Friday) return "Ուրբաթ";
            else if (dayOfWeek == DayOfWeek.Saturday) return "Շաբաթ";
            else if (dayOfWeek == DayOfWeek.Sunday) return "Կիրակի";
            else return "Unknown Day :(";
        }

         
        }
}
