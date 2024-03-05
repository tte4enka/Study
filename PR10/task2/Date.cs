using System;

namespace _2task
{
    public class Date : Triad
    {

        public Date(int day, int month, int year):base(day, month, year)
        {
            First = year;
            Second = month;
            Third = day;
        }

        public static bool operator ==(Date a, Date b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Date a, Date b)
        {
            return !(a == b);
        }
        public static bool operator >(Date a, Date b)
        {
            DateTime first = new DateTime(a.First, a.Second, a.Third);
            DateTime second = new DateTime(b.First, b.Second, b.Third);

            return first > second;
        }

        public static bool operator <(Date a, Date b)
        {
            DateTime first = new DateTime(a.First, a.Second, a.Third);
            DateTime second = new DateTime(b.First, b.Second, b.Third);

            return first < second;
        }

        public static bool operator >=(Date a, Date b)
        {
            DateTime first = new DateTime(a.First, a.Second, a.Third);
            DateTime second = new DateTime(b.First, b.Second, b.Third);

            return first >= second;
        }

        public static bool operator <=(Date a, Date b)
        {
            DateTime first = new DateTime(a.First, a.Second, a.Third);
            DateTime second = new DateTime(b.First, b.Second, b.Third);

            return first <= second;
        }
    }
}
