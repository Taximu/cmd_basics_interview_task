using System;
using System.Collections.Generic;

namespace SimpleCMDParser.Services
{
    public static class Mapper
    {
        public static readonly Dictionary<string, Func<int, int, int>> Actions 
            = new Dictionary<string, Func<int, int, int>>
        {
                { "-a", (x, y) => x + y },
                { "-s", (x, y) => x - y },
                { "-e", (x, y) => (int)Math.Pow(x, y) }
        };

        public static Func<int, int, int> GetOperation (string command)
        {
            return !Actions.ContainsKey(command) ? null : Actions[command];
        }
    }
}
