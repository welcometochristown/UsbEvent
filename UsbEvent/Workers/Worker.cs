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
        public static Task Start(int durationMs, int tick, Func<bool> action, int requiredSuccessCount = 1)
        {
            requiredSuccessCount = Math.Max(requiredSuccessCount, 0); //negative becomes continous
            DateTime end = DateTime.Now.AddMilliseconds(durationMs);

            return Task.Run(() =>
            {
                int successCount = 0;
                while (DateTime.Now < end)
                {
                    Console.WriteLine("tick");
                    System.Threading.Thread.Sleep(tick);

                    if (action())
                        successCount++;

                    if (requiredSuccessCount != 0 && successCount == requiredSuccessCount)
                    {
                        Console.WriteLine("success!");
                        break;
                    }
                }
            });
        }
    }
}
