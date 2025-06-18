using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Adapter
{
    public class ClientCode
    {
        public void Main()
        {
            try
            {
                MusicDurationSeconds adaptee = new MusicDurationSeconds();
                Console.Write("Enter duration in seconds:");
                adaptee.Duration = int.Parse(Console.ReadLine() ?? "0");

                IMusicDurationTransformer adapter = new Adapter(adaptee);
                string result = adapter.SecondsToFormattedTime(adaptee.Duration, TimeFormat.Seconds, TimeUnit.S);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}