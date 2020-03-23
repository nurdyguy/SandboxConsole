using System;
using System.Collections.Generic;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_85 : Problem
    {
        private List<int> _primes;
        public override object RunProblem(double target, double h = 0, double z = 0)
        {
            var closest = new List<int> { 0, 0, (int)target };
            
            var count = 0;
            for (var x = 10; x <= 100; x++)
                for (var y = x+1; y <= 100; y++)
                {
                    count = 0;
                    for (var a = 1; a <= x; a++)
                        for (var b = 1; b <= y; b++)
                            count += (x - a + 1) * (y - b + 1);
                    if(Math.Abs(target - count) < closest[2])
                    {
                        closest[0] = x;
                        closest[1] = y;
                        closest[2] = (int)Math.Abs(target - count);
                    }                        
                    Console.WriteLine($"{x} x {y}: {count}");
                }
                        

            return new { result = string.Join(", ", closest) };
        }


    }
}
