using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Diagnostics;
using System.Linq;

namespace MathService.Calculators
{
    public static partial class Calculator
    {

        // based on http://www.keithschwarz.com/interesting/code/?dir=factoradic-permutation
        public static BigInteger GetPermutationCode(int[] perm)
        {
            var code = BigInteger.Zero;
            var tempList = new List<int>(perm);

            while (tempList.Count > 0)
            {
                code += tempList.Count(n => n < tempList[0]) * Factorial(tempList.Count - 1);
                tempList.RemoveAt(0);
            }

            return code;
        }

        public static int[] GetPermutationFromCode(BigInteger code, int size)
        {
            if (code >= Factorial(size))
                throw new InvalidOperationException("Invalid code");

            var perm = new int[size];
            var factoraticNum = new List<int>(size);
            
            for(var i = 1; i < size; i++)
            {
                var subs = (int)(code / Factorial(size - i));
                factoraticNum.Add(subs);
                code -= subs * Factorial(size - i);
            }
            factoraticNum.Add((int)code);

            var unused = new List<int>(size);
            for (var i = 0; i < size; i++)
                unused.Add(i);

            for (var i = 0; i < perm.Length; i++)
            {
                perm[i] = unused[factoraticNum[i]];
                unused.RemoveAt(factoraticNum[i]);
            }

            return perm;

        }

        public static List<int[]> GenAllPermutations(int size)
        {
            var allPerms = new List<int[]>((int)Factorial(size));

            var curr = new int[size];
            for (var i = 0; i < (int)Factorial(size); i++)
                allPerms.Add(GetPermutationFromCode(i, size));

            return allPerms;
        }

        
    }

    public class Permutation
    {
        public List<int> Perm { get; set; }
        public int order { get; set; }
    }
}
