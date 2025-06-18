using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    public enum TimeFormat
    {
        Hours,
        Minutes,
        Seconds
    }

    public enum TimeUnit
    {
        H,
        M,
        S
    }

    public interface IMusicDurationTransformer
    {
        string SecondsToFormattedTime(int seconds, TimeFormat timeFormat, TimeUnit timeUnit);
    }

    class MusicDurationSeconds
    {
        public int Duration { get; set; }
    }

    class Adapter : IMusicDurationTransformer
    {
        private readonly MusicDurationSeconds _adaptee;

        public Adapter(MusicDurationSeconds adaptee)
        {
            this._adaptee = adaptee;
        }

        public string SecondsToFormattedTime(int seconds, TimeFormat timeFormat, TimeUnit timeUnit)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;

            string result = "";
            
            switch (timeFormat)
            {
                case TimeFormat.Hours:
                    result = $"{hours} {timeUnit}";
                    break;
                case TimeFormat.Minutes:
                    result = $"{minutes} {timeUnit}";
                    break;
                case TimeFormat.Seconds:
                    result = $"{hours:D2}:{minutes:D2}:{remainingSeconds:D2}";
                    break;
            }

            return result;
        }
    }
}