using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.Workers
{
    public class Worker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="durationMs"></param>
        /// <param name="tick"></param>
        /// <param name="action"></param>
        /// <param name="requiredsuccesscount">Countinous = 0, Single = 1, Multiple = 2</param>
        /// <returns></returns>
        public static Task Start(int durationMs, int tick, Func<bool> action, bool continous = false)
        {
            DateTime end = DateTime.Now.AddMilliseconds(durationMs);

            return Task.Run(() =>
            {
                while (DateTime.Now < end)
                {
                    Console.WriteLine("worker tick");
                    System.Threading.Thread.Sleep(tick);

                    var result = action();

                    if (!continous && result)
                    {
                        Console.WriteLine("success!");
                        break;
                    }
                }
            });
        }
    }
}
