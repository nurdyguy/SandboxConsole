﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_72 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = (long)0;
            
            for (var denom = 2; denom <= max; denom++)            
            {
                if (_calc.IsPrime(denom))
                    count += denom - 1;
                else
                {
                    var pfact = _calc.GetPrimeFactorization(denom);
                    var relPrime = new BitArray(denom);
                    foreach (int fact in pfact.Keys)
                        for (var i = 1; i < denom / fact; i++)
                            relPrime[i * fact] = true;
                    for (var i = 1; i < relPrime.Count; i++)
                        if (!relPrime[i])
                            count++;
                }
            }
            

            return new { result = count };
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
