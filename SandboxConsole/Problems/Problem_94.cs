using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_94 : Problem
    {
        // It is easily proved that no equilateral triangle exists with integral length sides and integral area.However, the almost equilateral triangle 5-5-6 has an area of 12 square units.
        // 
        // We shall define an almost equilateral triangle to be a triangle for which two sides are equal and the third differs by no more than one unit.
        // 
        // Find the sum of the perimeters of all almost equilateral triangles with integral side lengths and area and whose perimeters do not exceed one billion (1,000,000,000).
        public override object RunProblem(double max, double zz = 0, double zzz = 0)
        {
            var result = BigInteger.Zero;
            var diagMax = max / 3 + 100000;

            // skip first couple, know they don't work
            // only check evens
            for(ulong b = 6; b <= diagMax; b+=2)
            {
                var diag = b + 1;
                var h = (ulong)Math.Sqrt(diag * diag - b * b / 4);                
                if(h * h + b * b / 4 == diag * diag)
                {
                    Console.WriteLine($"{diag} x {diag} x {b}");
                    result += diag + diag + b;

                }

                diag = b - 1;
                h = (ulong)Math.Sqrt(diag * diag - b * b / 4);
                if (h * h + b * b / 4 == diag * diag)
                {
                    Console.WriteLine($"{diag} x {diag} x {b}");
                    result += diag + diag + b;

                }

            }

            return new { result };
        }

        private Dictionary<long, long> _squares = new Dictionary<long, long>();
        private void SeedSquares(int max)
        {
            for (var i = 0; i <= max; i++)
                _squares.Add(i * i, i * i);

        }


    }
}
