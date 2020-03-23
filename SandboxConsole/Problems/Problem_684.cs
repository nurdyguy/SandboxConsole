using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SandboxConsole.Problems
{
    public class Problem_684 : Problem
    {
        private ulong _mod = 1000000007;
        private List<ulong> _fib = new List<ulong>{ 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55,
                                                    89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765,
                                                    10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040,
                                                    1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155,
                                                    165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903, 2971215073, 4807526976, 7778742049, 12586269025,
                                                    20365011074, 32951280099, 53316291173, 86267571272, 139583862445, 225851433717, 365435296162, 591286729879, 956722026041, 1548008755920,
                                                    2504730781961, 4052739537881, 6557470319842, 10610209857723, 17167680177565, 27777890035288, 44945570212853, 72723460248141, 117669030460994, 190392490709135,
                                                    308061521170129, 498454011879264, 806515533049393, 1304969544928657, 2111485077978050, 3416454622906707, 5527939700884757, 8944394323791464, 14472334024676221, 23416728348467685, 
                                                    37889062373143906, 61305790721611591, 99194853094755497, 160500643816367088, 259695496911122585, 420196140727489673, 679891637638612258, 1100087778366101931, 1779979416004714189, 2880067194370816120, 
                                                    4660046610375530309, 7540113804746346429, 12200160415121876738, 1293530146158671551, 13493690561280548289, 14787220707439219840, 9834167195010216513, 6174643828739884737, 16008811023750101250, 3736710778780434371 };
        private List<BigInteger> _fibS = new List<BigInteger> { BigInteger.Zero };
        /* 
            1 2 3 4 5 6 7 8								= 36																		= 45*10^0 - 9
            9 19 29 39 49 59 69 79 89 					= 10 + 20 + 30 + 40 + 50 + 60 + 70 + 80 + 90 -9 = 450 -9					= 45*10^1 - 9
            99 199 299 399 499 599 699 799 899 			= 100 + 200 + 300 + 400 + 500 + 600 + 700 + 800 + 900 = 4500 -9				= 45*10^2 - 9
            999 1999 2999 3999 4999 5999 6999 7999 8999 = 1000 + 2000 + 3000 + 4000 + 5000 + 6000 + 7000 + 8000 + 9000 = 45000 - 9	= 45*10^3 - 9


            45(1 + 10 + 100 + 1000) - 4*9
            49995 - 4*9
            50000 - 5 - 4*9

            5*10^(n-1) - 5 - n*9 
        */
        public override object RunProblem(double x, double y = 0, double z = 0)
        {
            var result = BigInteger.Zero;
            var max = (int)x;

            //Console.WriteLine($"S(20) = {S2(20)}");
            for (var i = 2; i <= max; i++)
            {
                Console.WriteLine($"-----{i}-----");
                var next = S2(_fib[i]);
                Console.WriteLine($"{next}");
                
                result = (result + next)%_mod;
            }

            
            return new { result };
        }

        private BigInteger s(ulong n)
        {
            var nines = n / 9;
            var leader = n - nines * 9;
            return ((leader + 1) * BigInteger.ModPow(10, nines, _mod) - 1) % _mod;
        }

        private BigInteger S(ulong n)
        {
            var total = BigInteger.Zero;
            for (ulong i = 1; i <= n; i++)
                total = (total + s(i)) % _mod;            
            return total;
        }

        private BigInteger S2(ulong n)
        {
            var total = BigInteger.Zero;
            var nines = new BigInteger(n / 9);
            var leader = n - nines * 9;
            
            total = 5 * BigInteger.ModPow(10, nines, _mod) - 5 - (nines * 9)%_mod;
            if (total < 0)
                total += _mod;
            total += (leader + 1) * (leader + 2) * BigInteger.ModPow(10, nines, _mod) / 2 - (leader + 1);
            
            return total%_mod;
        }

        private BigInteger S_fib(int index)
        {
            var total = _fibS[index - 1];
            for(ulong i = _fib[index - 1] + 1; i <= _fib[index]; i++)
                total = (total + s(i)) % _mod;
            return total;
        }

        private void CalcFib(int max)
        {
            var fibs = new List<ulong>(max + 1) { 0, 1 };

            for (var i = 2; i <= max; i++)
                fibs.Add(fibs[i - 1] + fibs[i - 2]);

            Console.WriteLine(string.Join(", ", fibs));
        }

    }
}
