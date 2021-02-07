using System.Collections.Generic;

namespace SimpleCMDParser
{
    public static class Mapper
    {
        public static readonly Dictionary<string, IOperation> actions = new Dictionary<string, IOperation>()
        {
                { "-a", new Addition() },
                { "-b", new Substitution() },
                { "-c", new Exponention() }
        };

        public static IOperation GetOperation (string command)
        {
            if (!actions.ContainsKey(command))
            {
                return new NullOperation();
            }
            return actions[command];
        }
    }
}
