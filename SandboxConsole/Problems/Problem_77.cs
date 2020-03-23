using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_77 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var pmax = 75;
            var p = _calc.GetAllPrimes(100);

            // vals 1 - n
            var vals = p.ToArray();
            
            for(var i = 1; i <= pmax; i++)
            {
                var n = calc(i, vals.ToArray());
                Console.WriteLine($"{n}");
                if (n > 5000)
                    Console.WriteLine($"-----{i}-----");
            }


            //Console.WriteLine(string.Join(",\n", solution.Select(s => string.Join(", ", s))));
            //Console.WriteLine(calc(max, vals.ToArray()));

            return new { result = calc(max, vals.ToArray()) };
        }

        private int calc(int amount, int[] denominations)
        {
            var combs = new List<List<int>>();
            for (var i = 0; i <= amount; i++)
                combs.Add(new List<int>());
            var solution = new List<List<int>>();
            for (var i = 0; i <= denominations.Length; i++)
                    solution.Add(new List<int>(new int[amount + 1]));

            // if amount=0 then just return empty set to make the change
            for (int i = 0; i <= denominations.Length; i++)
            {
                solution[i][0] = 1;
            }

            // if no coins given, 0 ways to change the amount
            for (int i = 1; i <= amount; i++)
            {
                solution[0][i] = 0;
            }

            // now fill rest of the matrix.

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
            }            
            return solution[denominations.Length][amount];
        }


    }
}
