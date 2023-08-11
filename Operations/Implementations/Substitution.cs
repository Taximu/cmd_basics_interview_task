using SimpleCMDParser.Operations.Interfaces;

namespace SimpleCMDParser.Operations.Implementations
{
    public class Substitution : IOperation
    {
        private const int One = 1;
        public string Execute(string arg1, string arg2)
        {
            return arg2.Length == One ? arg1.Replace(arg2, string.Empty) : null;
        }

        public string GetOutputMessage(string command, string[] args, string result)
        {
            return $"{args[0]} without {args[1]} results in {result}.";
        }
    }
}
