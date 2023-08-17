using System;
using SimpleCMDParser.Infra;
using SimpleCMDParser.Services.Printing;

namespace SimpleCMDParser.Services.Parsing
{
    internal class CommandLineParser : IParser
    {
        private const int MaxArgsNumber = 3;
        private const int EmptyNumberOfLines = 0;
        private readonly ICmdPrinter _printer;
        private readonly IStringValidator _validator;

        public CommandLineParser(ICmdPrinter printer, IStringValidator validator)
        {
            _printer = printer;
            _validator = validator;
        }

        public void ParseLine(string cmdline)
        {
            _validator.Validate(cmdline);
            
            var arr = cmdline.ToCharArray();
            while (arr.Length > 0)
            {
                if (line.Count < MaxArgsNumber)
                {
                    _printer.PrintError(PromptConstants.NotEnoughArguments);
                    break;
                }

                string command = line.Dequeue();
                if (!Mapper.Actions.ContainsKey(command))
                {
                    _printer.PrintError(PromptConstants.UnknownParameter);
                    continue;
                }

                string[] args = { line.Dequeue(), line.Dequeue() };

                var operation = Mapper.GetOperation(command);
                int? result = operation(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                _printer.PrintStatement($"The sum of {args[0]} and {args[1]} is {result}.");
            }
        }
    }
}
