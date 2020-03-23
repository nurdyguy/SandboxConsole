using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_92 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = 0;
            for (var i = 1; i <= max; i++)
                if (Is89chain(i))
                    count++;
            return new { result = count };
        }

        private bool Is89chain(int x)
        {
            var num = x; 
            while(num != 1 && num != 89)
            {
                var digs = num.ToString().Select(n => int.Parse(n.ToString())).ToList();
                num = 0;
                for (var i = 0; i < digs.Count(); i++)
                    num += digs[i] * digs[i];
            }

            return num == 89;
        }
    }
}
