using SimpleCMDParser.Operations.Interfaces;

namespace SimpleCMDParser.Operations.Implementations
{
    internal class NullOperation : IOperation
    {
        public string Execute(string arg1, string arg2)
        {
            return null;
        }

        public string GetOutputMessage(string command, string[] args, string result)
        {
            return $"The parameter {command} is unknown.";
        }
    }
}
