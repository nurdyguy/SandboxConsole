using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_80 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;

            var sqrt = Math.Sqrt(2);

            Console.WriteLine(sqrt);

            return new { result = 0 };
        }

    }
}
