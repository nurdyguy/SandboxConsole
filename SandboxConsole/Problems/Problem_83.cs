using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_83 : Problem
    {
        
        public override object RunProblem(double max, double h = 0, double z = 0)
        {
            var imax = Math.Pow(max, 0.5);
            var jmax = Math.Pow(max, 0.34);
            var kmax = Math.Pow(max, 0.25);
            var primes = _calc.GetAllPrimes((int)imax);
            var hasComb = new BitArray((int)max + 1, false);
            
            for(var i = 0; i < primes.Count && primes[i] <= imax; i++)
                for (var j = 0; j < primes.Count && primes[j] <= jmax; j++)
                    for (var k = 0; k < primes.Count && primes[k] <= kmax; k++)
                    {
                        var n = primes[i] * primes[i] + primes[j] * primes[j] * primes[j] + primes[k] * primes[k] * primes[k] * primes[k];
                        if (n < max)
                            hasComb[n] = true;
                    }

            var count = 0;
            for (var i = 0; i < hasComb.Count; i++)
                if (hasComb[i])
                    count++;

            return new { result = count };
        }


    }
}
