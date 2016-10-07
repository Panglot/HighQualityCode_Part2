namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;

    /// <summary>
    /// Command that can be executed
    /// </summary>
    public abstract class Command : ICommand
    {
        public abstract string Execute(IList<string> parameters);
    }
}
