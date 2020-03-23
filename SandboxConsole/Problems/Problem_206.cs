using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_206 : Problem
    {
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var result = (ulong)0;
            //      1_2_3_4_5_6_7_8_9_0
            var start = (ulong)Math.Sqrt(1020304050607080900);
            var end = (ulong)Math.Sqrt(1929394959697989990);
            
            for(var i = start; i <= end; i++)
            {
                var numStr = (i * i).ToString();
                if (numStr[0] == '1' && numStr[2] == '2' && numStr[4] == '3'
                        && numStr[6] == '4' && numStr[8] == '5' && numStr[10] == '6'
                        && numStr[12] == '7' && numStr[14] == '8' && numStr[16] == '9' && numStr[18] == '0')
                {
                    result = i;
                    i = end;// exit
                }
            }
                

            return new { result };
        }

    }
}
