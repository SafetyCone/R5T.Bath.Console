using System;

using R5T.Bath.Default;

using R5T.T0064;


namespace R5T.Bath.Console
{
    [ServiceImplementationMarker]
    public class ConsoleHumanOutput : TextWriterHumanOutput, IHumanOutput, IServiceImplementation
    {
        public ConsoleHumanOutput()
            : base(System.Console.Out)
        {
        }
    }
}
