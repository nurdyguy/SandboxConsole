using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Diagnostics;

using _combRepo = MathService.Repositories.Constants.CombinationsRepository;

namespace MathService.Calculators
{
    public static partial class Calculator
    {
        // Encoding/Decoding a combination implies an order:
        //      lexicographic means (0, 1, 2, 3, 4, ..., n) is the very first combination so id = 1
        // 
        // converts Combination into integer
        // max is the largest possible number
        public static BigInteger EncodeCombination(List<int> comb, int max)
        {
            var id = _combRepo.nCr(max + 1, comb.Count);
            for (int i = 0; i < comb.Count; i++)
                id -= _combRepo.nCr(max - comb[i], comb.Count - i);
            return id;            
        }

        /// gets Combination from integer 
        public static List<int> DecodeCombination(BigInteger id, int n, int r)
        {
            List<int> comb = new List<int>(r);
            var tId = _combRepo.nCr(n, r) - id;
            for (int i = r; i > 0; i--)
            {
                var tVal = BigInteger.Zero;
                bool done = false;
                int pos = 0;
                while (!done)
                {
                    var t = _combRepo.nCr(n - pos - 1, i);
                    if (t <= tId)
                    {
                        tVal = t;
                        done = true;
                    }
                    pos++;
                }
                tId -= tVal;
                comb.Add(pos - 1);
            }

            return comb;

        }
        
        public static List<List<int>> GenAllCombinations(int n)
        {
            var combs = new List<List<int>>();
            for (var i = 0; i <= n; i++)
            {
                var num = _combRepo.nCr(n, i);
                for (var id = BigInteger.One; id <= num; id++)
                {
                    var comb = DecodeCombination(id, n, i);
                    combs.Add(comb);
                }
            }

            return combs;
        }

        public static List<List<int>> GenAllCombinations(int n, int r)
        {
            var combs = new List<List<int>>();
            var num = _combRepo.nCr(n, r);
            for (var id = BigInteger.One; id <= num; id++)
            {
                var comb = DecodeCombination(id, n, r);
                combs.Add(comb);
            }
            
            return combs;
        }

        public static BigInteger nCr(BigInteger n, BigInteger r)
        {
            return _combRepo.nCr(n, r);
        }
    }

    public class Combination
    {
        public List<int> comb { get; set; }
        public int order { get; set; }
    }
}
