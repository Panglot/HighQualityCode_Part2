namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;

    public abstract class Command : ICommand
    {
        public abstract string Execute(IList<string> parameters);
    }
}
