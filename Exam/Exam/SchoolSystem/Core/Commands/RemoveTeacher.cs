namespace SchoolSystem.Core.Commands
{
    using System.Collections.Generic;
    using Contracts;

    internal class RemoveTeacher : Command, ICommand
    {
        public override string Execute(IList<string> parameters)
        {
            Engine.Teachers.Remove(int.Parse(parameters[0]));
            return string.Format("Teacher with ID {0} was sucessfully removed.", int.Parse(parameters[0]));
        }
    }
}
