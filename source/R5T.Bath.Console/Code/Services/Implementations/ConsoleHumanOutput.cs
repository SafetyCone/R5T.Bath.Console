using System;

using R5T.Bath.Default;


namespace R5T.Bath.Console
{
    public class ConsoleHumanOutput : TextWriterHumanOutput
    {
        public ConsoleHumanOutput()
            : base(System.Console.Out)
        {
        }
    }
}
