using System;

namespace SimpleCMDParser
{
    public class CommandLinePrinter : ICmdPrinter
    {
        /// <summary>
        /// Sets color of message to red, prints message then resets color.
        /// </summary>
        /// <param name="errorMessage">error message</param>
        public void PrintError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
        }

        /// <summary>
        /// Sets color of message to green, prints message then resets color.
        /// </summary>
        /// <param name="message">message</param>
        public void PrintStatement(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Sets color of message to green, prints message on the same line since last print, then resets color.
        /// </summary>
        /// <param name="message">message</param>
        public void PrintStatementWithoutNewLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
