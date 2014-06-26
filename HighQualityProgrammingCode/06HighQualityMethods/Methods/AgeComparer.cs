namespace Methods
{
    using System;

    public static class AgeComparer
    {
        public static bool IsEarlierThan(this DateTime firstBirthDate, DateTime secondBirthDate)
        {
            bool isOlder = firstBirthDate < secondBirthDate;

            return isOlder;
        }
    }
}
