using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_79 : Problem
    {
        // no 4 or 5
        // 73162890
        private List<int> _codes = new List<int> {
            129, 160, 162, 162, 168, 180, 
            289, 290, 
            316, 316, 318, 318, 319, 319, 319, 319, 362, 368, 380, 389, 
            620, 629, 680, 680, 680, 689, 689, 690, 
            710, 710, 710, 716, 716, 718, 719, 720, 728, 729, 729, 729, 729, 729, 731, 736, 760, 762, 762, 769, 790, 
            890
        };
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var count = 0;

            var digits = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach(var code in _codes)
            {
                code.ToString().Select(c => int.Parse(c.ToString())).ToList().ForEach(d => digits[d]++);
                
            }


            return new { result = count };
        }



    }
}
