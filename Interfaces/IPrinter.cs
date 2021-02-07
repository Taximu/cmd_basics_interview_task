namespace SimpleCMDParser
{
    internal interface ICmdPrinter
    {
        void PrintError(string message);

        void PrintStatement(string message);

        void PrintStatementWithoutNewLine(string message);
    }
}