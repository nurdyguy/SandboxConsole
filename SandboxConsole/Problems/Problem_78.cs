using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_78 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            max = 100000;
            // vals 1 - n
            var vals = new List<int>();
            for (var i = 1; i <= max; i++)
                vals.Add(i);

            var n = calc(max, vals.ToArray());

            //for (var i = 2100; i <= max; i++)
            //{
                
            //    //Console.WriteLine($"i={i} --- n={n}");
            //    if (n % 1000000 == 0)
            //        Console.WriteLine($"Found: {i}");
                
            //}

            //Console.WriteLine(string.Join(",\n", solution.Select(s => string.Join(", ", s))));

            return new { result = 0 };
        }

        private BigInteger calc(int amount, int[] denominations)
        {
            var combs = new List<List<BigInteger>>(amount);
            for (var i = 0; i <= amount; i++)
                combs.Add(new List<BigInteger>());
            var solution = new List<List<BigInteger>>(denominations.Length);
            for (var i = 0; i <= denominations.Length; i++)
                    solution.Add(new List<BigInteger>(new BigInteger[amount + 1]));

            // need to redo this using currArr and prevArr rather than full matrix

            // if amount=0 then just return empty set to make the change
            for (int i = 0; i <= denominations.Length; i++)
                solution[i][0] = 1;

            // if no coins given, 0 ways to change the amount
            for (int i = 1; i <= amount; i++)            
                solution[0][i] = 0;
            
            for (int i = 1; i <= denominations.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    // check if the coin value is less than the amount needed
                    if (denominations[i - 1] <= j)
                    {
                        // reduce the amount by coin value and
                        // use the subproblem solution (amount-v[i]) and
                        // add the solution from the top to it
                        solution[i][j] = solution[i - 1][j]
                                + solution[i][j - denominations[i - 1]];
                    }
                    else
                    {
                        // just copy the value from the top
                        solution[i][j] = solution[i - 1][j];
                    }                    
                }
                if (solution[i].Last() % 1000000 == 0)
                    Console.WriteLine($"Found: solution_{i}.Last={solution[i].Last()}");
            }            
            return solution[denominations.Length][amount];
        }


    }
}
