using System.Collections.Generic;

namespace SimpleCMDParser
{
    internal interface IParser
    {
        void ParseLine(Queue<string> line);
    }
}