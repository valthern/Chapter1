using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {
        public static void Main()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
               {
                   if (i == 500)
                   {
                       Console.WriteLine("Breaking loop");
                       loopState.Break();
                   }

                   return;
               });

            Console.WriteLine(result);
        }
    }
}
