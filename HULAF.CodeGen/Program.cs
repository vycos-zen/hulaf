using System;
using System.Threading.Tasks;
using HULAF.CodeGenLib;

namespace HULAF.CodeGen
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var generator = new Generator();
            Console.WriteLine(string.Concat("Generated: ", Environment.NewLine, await generator.Generate()));


        }
    }
}
