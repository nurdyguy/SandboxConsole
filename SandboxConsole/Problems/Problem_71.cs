using System;
using System.Collections.Generic;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_71 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var done = false;
                        
            var num = 0;
            var denom = max;
            var best = new List<int> { num, denom };
            while (!done)
            {
                num = 3 * denom / 7;
                var diff = 3 * denom - 7 * num;
                if (diff == 1)
                {
                    var g = gcf(num, denom);
                    Console.WriteLine(g);
                    best[0] = num;
                    best[1] = denom;
                    denom = 0;
                }
                if (--denom <= 0)
                    done = true;
            }

            return new { result = string.Join(", ", best) };
        }

        private int gcf(int a, int b)
        {
            while (a != 0 && b != 0)
                if (a > b)
                    a %= b;
                else
                    b %= a;

            return a == 0 ? b : a;
        }

    }
}
