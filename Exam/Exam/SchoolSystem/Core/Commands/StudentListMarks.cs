namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;

    internal class StudentListMarks : Command, ICommand
    {
        public override string Execute(IList<string> parameters)
        {
            return Engine.Students[int.Parse(parameters[0])].ListMarks();
        }
    }
}
