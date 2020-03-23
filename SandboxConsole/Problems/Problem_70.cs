using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_70 : Problem
    {
        // φ(n) = relative primes of n from 1 to n
        // Find the value of n, 1 < n < 10^7, for which φ(n) is a permutation of n and the ratio n/φ(n) produces a minimum.
        // trying to maximize φ(n) -> fewer prime factors
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = 10000000;            
            long num = 10;
            long denom = 1;
            var result = new List<int>();
            
            for (var i = 2; i <= max; i++)
            {
                var phiI = phi(i);
                
                if (isDigitPermutation(i, phiI) && i*denom < phiI*num )
                {
                    num = i;
                    denom = phiI;
                }
                    
            }

            return new { result = new { num, denom } };
        }

        private int phi(int n)
        {
            var count = n;
            if (!_calc.IsPrime(n))
            {
                var pFacts = _calc.GetPrimeFactorization(n).Keys.Select(k => (int)k).ToList();
                var combs = _calc.GenAllCombinations(pFacts.Count);
                
                for (var i = 1; i < combs.Count; i++)
                {
                    var div = 1;
                    for (var j = 0; j < combs[i].Count; j++)
                        div *= pFacts[combs[i][j]];

                    if (combs[i].Count % 2 == 0)
                        count += n / div;
                    else
                        count -= n / div;
                }
            }
            else
                count = n - 1;
            return count;
        }

        private int phi_siv(int n)
        {
            var count = 0;
            if (!_calc.IsPrime(n))
            {
                var pFacts = _calc.GetPrimeFactorization(n).Keys.Select(k => (int)k).ToList();
                

            }
            else
                count = n - 1;
            return count;
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

        public bool isDigitPermutation(int x, int y)
        {
            if ((x - y) % 9 != 0)
                return false;
            var xStr = x.ToString();
            var yStr = y.ToString();
            if (xStr.Length != yStr.Length)
                return false;
            for (var i = 0; i < xStr.Length; i++)
                if (xStr.Count(x => x == xStr[i]) != yStr.Count(y => y == xStr[i]))
                    return false;
            return true;
        }
    }
}
