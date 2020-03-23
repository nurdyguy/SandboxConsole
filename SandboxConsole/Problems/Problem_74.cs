using System;
using System.Collections.Generic;
using System.Text;
using _calc = MathService.Calculators.Calculator;

namespace SandboxConsole.Problems
{
    public class Problem_74 : Problem
    {
        private List<ulong> _smallFacts = new List<ulong> { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var max = (int)x;
            var done = false;
            var result = new List<int>();
            for(var i = 1; i <= max; i++)
            {
                var chain = CalcChain(i);
                //Console.WriteLine($"Chain for {i} with length {chain.Count}: \n    {string.Join(", ", chain)}");
                if (chain.Count == 60)
                    result.Add(i);
            }

            Console.WriteLine("---------------------Result--------------------");
            Console.WriteLine($"{result.Count}");
            return new { result };
        }

        private List<ulong> CalcChain(int num)
        {
            var chain = new List<ulong>() { (ulong)num };
            var done = false;
            while(!done)
            {
                var numStr = chain[chain.Count - 1].ToString();
                var newNum = (ulong)0;
                for (var i = 0; i < numStr.Length; i++)
                    newNum += _smallFacts[int.Parse(numStr[i].ToString())];
                if (chain.Contains(newNum))
                    done = true;
                else
                    chain.Add(newNum);
            }
            return chain;
        }
        


    }
}
