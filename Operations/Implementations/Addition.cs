using SimpleCMDParser.Operations.Interfaces;

namespace SimpleCMDParser.Operations.Implementations
{
    public class Addition : IOperation
    {
        public string Execute(string arg1, string arg2)
        {
            return (int.Parse(arg1) + int.Parse(arg2)).ToString();
        }

        public string GetOutputMessage(string command, string[] args, string result)
        {
            return $"The sum of {args[0]} and {args[1]} is {result}.";
        }
    }
}
