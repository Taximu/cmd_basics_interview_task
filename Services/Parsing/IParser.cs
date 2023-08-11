using System.Collections.Generic;

namespace SimpleCMDParser.Services.Parsing
{
    internal interface IParser
    {
        void ParseLine(Queue<string> line);
    }
}
