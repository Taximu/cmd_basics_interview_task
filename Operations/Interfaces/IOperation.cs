namespace SimpleCMDParser.Operations.Interfaces
{
    public interface IOperation
    {
        string Execute(string arg1, string arg2);

        string GetOutputMessage(string command, string[] args, string result);
    }
}
