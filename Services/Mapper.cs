using System.Collections.Generic;
using SimpleCMDParser.Operations.Implementations;
using SimpleCMDParser.Operations.Interfaces;

namespace SimpleCMDParser.Services
{
    public static class Mapper
    {
        public static readonly Dictionary<string, IOperation> Actions = new Dictionary<string, IOperation>
        {
                { "-a", new Addition() },
                { "-b", new Substitution() },
                { "-c", new Exponentiation() }
        };

        public static IOperation GetOperation (string command)
        {
            return !Actions.ContainsKey(command) ? new NullOperation() : Actions[command];
        }
    }
}
