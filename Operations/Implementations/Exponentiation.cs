using System;
using System.Globalization;
using SimpleCMDParser.Operations.Interfaces;

namespace SimpleCMDParser.Operations.Implementations
{
    public class Exponentiation : IOperation
    {
        public string Execute(string arg1, string arg2)
        {
            if (!ushort.TryParse(arg2, out ushort power)) return null;
            try {
                return Math.Pow(double.Parse(arg1), power).ToString(CultureInfo.InvariantCulture);
            } catch {
                return null;
            }
        }

        public string GetOutputMessage(string command, string[] args, string result)
        {
            return $"{args[0]} raised to the power of {args[1]} is {result}";
        }
    }
}
