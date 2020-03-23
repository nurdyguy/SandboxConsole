using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_100 : Problem
    {
        // If a box contains twenty-one coloured discs, composed of fifteen blue discs and six red discs, and two discs were taken at random, 
        // it can be seen that the probability of taking two blue discs, P(BB) = (15/21)×(14/20) = 1/2.
        // 
        // The next such arrangement, for which there is exactly 50% chance of taking two blue discs at random,
        // is a box containing eighty-five blue discs and thirty-five red discs.
        // 
        // By finding the first arrangement to contain over 10^12 = 1,000,000,000,000 discs in total, 
        // determine the number of blue discs that the box would contain.
        public override object RunProblem(double exp, double h = 0, double z = 0)
        {
            var result = 0;
            //var min = BigInteger.Pow(10, (int)exp);
            //var minDenom = 2 * min - 1;
            //var sqrt = Math.Exp(0.5 * BigInteger.Log(minDenom));
            //Console.WriteLine($"min: {min}\n  minDenom: {minDenom}\n  sqrt: {sqrt}");


            var done = false;
            var x = new BigInteger(1414213562371);
            
            while(!done)
            {
                x += 2;
                var test = (x * x + 1) / 2;

                var sqrt = new BigInteger(Math.Exp(0.5 * BigInteger.Log(test)));
                var sqrt_1 = sqrt + 1;

                if (sqrt * sqrt == test || sqrt_1 * sqrt_1 == test)
                {
                    Console.WriteLine(x);
                    Console.WriteLine(test);
                    Console.WriteLine(sqrt);
                    Console.WriteLine("--------------------------------------------------------");
                }

            }


            //var done = false;
            //var n = new BigInteger(500000000000);            
            //while (!done)
            //{
            //    n++;
            //    var sq = 8 * n * n - 8 * n + 1;

            //    //var x = Sqrt(sq);

            //    var sqrt = new BigInteger(Math.Exp(0.5 * BigInteger.Log(sq)));
            //    var sqrt_1 = sqrt + 1;

            //    if (sqrt * sqrt == sq || sqrt_1 * sqrt_1 == sq)
            //    {
            //        Console.WriteLine(n);
            //        Console.WriteLine(sq);
            //        Console.WriteLine(sqrt);
            //        Console.WriteLine("--------------------------------------------------------");
            //    }

            //}
            return new { result };
        }

        private Dictionary<BigInteger, BigInteger> _squares = new Dictionary<BigInteger, BigInteger>();
        private void SeedSquares(BigInteger min, BigInteger max)
        {
            for (var i = min; i <= max; i++)
            {
                var x = i * i;
                _squares.Add(x, x);
            }
        }

        private BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }
    }
}
