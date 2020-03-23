using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_686 : Problem
    {
        
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var result = BigInteger.Zero;
            var max = (int)x;

            result = FindExp("123", 678910);

           
            return new { result };
        }

        private int FindExp(string lead, int occurance)
        {
            var val = new BigInteger(128);
            var count = 0;
            var exp = 7;
            while(count < occurance)
            {
                val *= 2;
                exp++;

                var valStr = val.ToString();
                if (lead[0] == valStr[0] && lead[1] == valStr[1] && lead[2] == valStr[2])
                    count++;

                if (valStr.Length > 25)
                    val = BigInteger.Parse(valStr.Substring(0, 25));                
            }

            return exp;
        }

    }
}
