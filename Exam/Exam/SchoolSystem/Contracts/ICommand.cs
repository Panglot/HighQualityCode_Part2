namespace SchoolSystem.Contracts
{
    using System.Collections.Generic;

    internal interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
