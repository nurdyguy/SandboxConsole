using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_75 : Problem
    {
        
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var maxPerim = (int)x;
            var done = false;
            var result = 0;

            var primitiveTrips = GeneratePrimitiveTriples(maxPerim);
            //Console.WriteLine($"{string.Join("\n ", primitiveTrips.Select(t => string.Join(", ", t)))}");
            var foundPerim = new List<bool>(maxPerim + 1);
            var uniquePerim = new List<bool>(maxPerim + 1);
            for(var i = 0; i <= maxPerim + 1; i++)
            {
                foundPerim.Add(false);
                uniquePerim.Add(false);
            }
            foreach (var trip in primitiveTrips)
            {
                var perim = trip[0] + trip[1] + trip[2];
                var factor = (int)maxPerim / perim;
                for(var i = 1; i <= factor; i++)
                    if(foundPerim[perim*i])
                        uniquePerim[perim * i] = false;
                    else
                        foundPerim[perim * i] = uniquePerim[perim * i] = true;
            }

            Console.WriteLine("---------------------Result--------------------");
            Console.WriteLine($"{primitiveTrips.Count}");
            Console.WriteLine($"{uniquePerim.Count(b => b)}");
            return new { result };
        }

        private List<List<int>> GeneratePrimitiveTriples(int maxPerim)
        {
            var trips = new List<List<int>>();
            var loopmax = (int)Math.Sqrt(maxPerim);
            for (var i = 1; i <= loopmax; i++)
                for (var j = i + 1; j <= loopmax; j+=2)
                    if (gcf(i, j) == 1)
                    {
                        var a = j * j - i * i;
                        var b = 2 * i * j;
                        var c = j * j + i * i;
                        if(a + b + c <= maxPerim)
                            trips.Add(new List<int> { Math.Min(a,b), Math.Max(a,b), c });
                    }
                
            return trips;
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
