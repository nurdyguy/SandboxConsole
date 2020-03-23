using System;
using System.Threading.Tasks;
using Unify.Security;
using System.Security;
using System.Security.Cryptography;
using SandboxConsole.Problems;
using System.Diagnostics;
using System.Collections.Generic;

namespace SandboxConsole
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Sandbox!");

            //var enc = await Encryption.Instance.EncryptAsync($"{3345000}:{DateTime.Now:O}");
            //Console.WriteLine($"Encrypted: {enc}");

            //var path = "C:\\devwork\\dataFiles\\Balance_Transfer_Promotional_Disclosure_2020_FIXED2.pdf";
            //var pathResult = "C:\\devwork\\dataFiles\\Balance_Transfer_Promotional_Disclosure_2020_FIXED2_result.pdf";
            //var fbytes = System.IO.File.ReadAllBytes(path);
            //var b64 = Convert.ToBase64String(fbytes);

            //var backtoBytes = Convert.FromBase64String(_f1);
            //System.IO.File.WriteAllBytes(pathResult, backtoBytes);


            Run(91, 2);
            
            Console.ReadKey();
        }

        private static void Run(int num, int x, int y = 0, int z = 0)
        {
            var watch = new Stopwatch();
            var timers = new List<double>();
            watch.Start();
            Console.WriteLine($"Running problem {num}...");

            var epBase = typeof(Problem).AssemblyQualifiedName.Split(',');
            epBase[0] = $"{epBase[0]}_{num}";

            var probType = Type.GetType(string.Join(",", epBase));

            if (probType == null)
                throw new NotImplementedException("Invalid problem number.");

            var prob = (Problem)Activator.CreateInstance(probType);
            var result = prob.RunProblem(x, y, z);

            timers.Add(watch.ElapsedMilliseconds / 1000.0);
            watch.Stop();

            Console.WriteLine($"Finished running problem {num}:");
            Console.WriteLine($"    result: {result}");
            Console.WriteLine($"    timers: {string.Join(", ", timers)}");
        }
    }
}
