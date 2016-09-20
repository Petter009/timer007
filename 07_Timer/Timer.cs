using System;

namespace _07_Timer
{
    public class Timer
    {
        private int seconds;

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public override string ToString()
        {
            if (Seconds >= 60)
               return string.Format("{0:00}:{1:00}:{2:00}", Seconds / 3600, (Seconds / 60) % 60, Seconds % 60);
            else
            return Seconds.ToString("00:00:00");
        }

        internal string Padded(int v)
        {
           return v.ToString("00");
        }
    }
}