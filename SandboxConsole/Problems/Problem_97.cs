using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_97 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var result = BigInteger.ModPow(2, 7830457, 10000000000);
            result = result * 28433 + 1;


            return new { result };
        }


    }
}
