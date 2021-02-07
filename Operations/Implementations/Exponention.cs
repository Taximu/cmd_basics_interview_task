using System;

namespace SimpleCMDParser
{
    public class Exponention : IOperation
    {
        public string Execute(string arg1, string arg2)
        {
            if (ushort.TryParse(arg2, out ushort power)) {
                try {
                    return Math.Pow(double.Parse(arg1), power).ToString();
                } catch {
                    return null;
                }
            }

            return null;
        }

        public string GetOutputMessage(string command, string[] args, string result)
        {
            return string.Format("{0} raised to the power of {1} is {2}", args[0], args[1], result);
        }
    }
}