using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Diagnostics;

using _factRepo = MathService.Repositories.Constants.FactorialsRepository;

namespace MathService.Calculators
{
    public static partial class Calculator
    {
        public static BigInteger PartialFactorial(int x, int y)
        {
            return _factRepo.PartialFactorial(x, y);
        }

        public static BigInteger Factorial(int x)
        {
            return _factRepo.Factorial(x);
        }


    }

}
