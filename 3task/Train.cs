using System;

namespace _3task
{
    public struct TRAIN : IComparable<TRAIN>
    {
        public string Destination;
        public int TrainNumber;
        public DateTime DepartureTime;

        public TRAIN(string destination, int trainNumber, DateTime departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public int CompareTo(TRAIN other)
        {
            if(this.TrainNumber != other.TrainNumber)
            {
                int result = this.TrainNumber.CompareTo(other.TrainNumber);
                return result;
            }
            int resultSecond = this.Destination.CompareTo(other.Destination);
            return resultSecond;
        }
    }
}
