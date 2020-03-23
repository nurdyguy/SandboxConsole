using System;
using System.Collections.Generic;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public abstract class Problem
    {
        public Problem()
        {
            _calc.InitializeCalculator();
        }
        public abstract object RunProblem(double x, double y = 0, double z = 0);

    }
}