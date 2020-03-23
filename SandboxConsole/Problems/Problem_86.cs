using System;
using System.Collections.Generic;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_86 : Problem
    {
        public override object RunProblem(double max, double q1 = 0, double q2 = 0)
        {
            var count = 0;


            for (var x = 1; x <= max; x++)
                for (var y = 1; y <= max; y++)
                    for (var z = 1; z <= max; z++)
                    {
                        double shortest = x + y + z;
                        int shortestX1 = x;
                        for (var x1 = 0; x1 <= x; x1++)
                        {
                            var d = dist(x1, y, x - x1, z);
                            if (d < shortest)
                            {
                                shortest = d;
                                shortestX1 = x1;
                            }
                            
                        }
                        if ((int)shortest == shortest)
                        {
                            count++;
                            Console.WriteLine($"{x} {y} {z} {shortestX1}-- d={shortest}");
                        }
                    }

            return new { result = count };
        }

        public double dist(int x1, int y, int x2, int z)
        {
            return Math.Sqrt(x1 * x1 + y * y) + Math.Sqrt(x2 * x2 + z * z);
        }

    }
}
